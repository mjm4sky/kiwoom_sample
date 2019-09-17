using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiwoom_sample {
    public partial class FormOrder : Form {
        List<stockInfo> stockList;
        List<stockBalance> stockBalanceList;
        List<outstanding> outstandingList;
        public string accountNumber = "";

        public FormOrder() {
            InitializeComponent();

            axKHOpenAPI1.CommConnect();

            axKHOpenAPI1.OnEventConnect         += onEventConnect;
            axKHOpenAPI1.OnReceiveChejanData    += onReceiveChejanData;
            axKHOpenAPI1.OnReceiveTrData        += onReceiveTrData;

            buyButton.Click             += orderButtonClicked;
            stockSearchButton.Click     += stockSearch;
            balanceCheckButton.Click    += balanceCheck;
        }

        public void bindingByBalanceDataGridView(object sender, EventArgs e) {
            if (outstandingDataGridView.SelectedCells.Count > 0) {
                int rowIndex = outstandingDataGridView.SelectedCells[0].RowIndex;
                string[] stockPriceArray = outstandingDataGridView["현재가", rowIndex].Value.ToString().Split(',');
                string stockPrice = "";
                for (int i = 0; i < stockPriceArray.Length; i++) {
                    stockPrice = stockPrice + stockPriceArray[i];
                }
                long stockCurrentPrice = long.Parse(stockPrice);
                priceNumericUpDown.Value = stockCurrentPrice;
            }
        }
        public void balanceCheck(object sender, EventArgs e) {
            accountNumber = accountComboBox.Text;
            string password = "2351";

            axKHOpenAPI1.SetInputValue("계좌번호", accountNumber);
            axKHOpenAPI1.SetInputValue("비밀번호", password);
            axKHOpenAPI1.SetInputValue("상장폐지조회구분", "0");
            axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
            axKHOpenAPI1.CommRqData("계좌평가현황요청", "opw00004", 0, "0004");

            axKHOpenAPI1.SetInputValue("계좌번호", accountNumber);
            axKHOpenAPI1.SetInputValue("체결구분", "1");//1:미체결조회
            axKHOpenAPI1.SetInputValue("매매구분", "2");//2:매수
            axKHOpenAPI1.CommRqData("실시간미체결요청", "opt10075", 0, "0075");
        }

        public void onReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e) {
            if (e.sRQName == "종목정보요청") {
                string stockPrice = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가");
                priceNumericUpDown.Value = long.Parse(stockPrice.Replace("-", ""));
            } else if (e.sRQName == "계좌평가현황요청") {
                int count = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                stockBalanceList = new List<stockBalance>();
                for (int i = 0; i < count; i++) {
                    string stockCode = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").TrimStart('0');
                    string stockName = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                    long number = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "보유수량"));
                    long buyingMoney = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "매입금액"));
                    long currentPrice = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Replace("-", ""));
                    long estimatedProfit = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "손익금액"));
                    double estimatedProfitRate = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "손익율"));

                    stockBalanceList.Add(new stockBalance(stockCode, stockName, number, String.Format("{0:#,###}", buyingMoney), String.Format("{0:#,###}", currentPrice), estimatedProfit, String.Format("{0:f2}", estimatedProfitRate)));
                }
                outstandingDataGridView.DataSource = stockBalanceList;

            } else if (e.sRQName == "실시간미체결요청") {
                int count = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                outstandingList = new List<outstanding>();

                for (int i = 0; i < count; i++) {
                    string orderCode = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문번호")).ToString();
                    string stockCode = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim();
                    string stockName = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                    int orderNumber = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문수량"));
                    int orderPrice = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문가격"));
                    int outstandingNumber = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "미체결수량"));
                    int currentPrice = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Replace("-", ""));
                    string orderGubun = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문구분").Trim();
                    string orderTime = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "시간").Trim();

                    outstandingList.Add(new outstanding(orderCode, stockCode, stockName, orderNumber, String.Format("{0:#,###}", orderPrice), String.Format("{0:#,###}", currentPrice), outstandingNumber, orderGubun, orderTime));
                }
                outstandingDataGridView.DataSource = outstandingList;
            }
        }
        public void stockSearch(object sender, EventArgs e) {
            string stockText = stockTextBox.Text;
            int index = stockList.FindIndex(o => o.stockName == stockText);
            string stockCode = stockList[index].stockCode;
            axKHOpenAPI1.SetInputValue("종목코드", stockCode);
            axKHOpenAPI1.CommRqData("종목정보요청", "opt10001", 0, "5000");
        }

        public void onReceiveChejanData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveChejanDataEvent e) {
            //주문 접수 , 체결시
            if (e.sGubun == "0") {
                alertListBox.Items.Add("계좌번호 : " + axKHOpenAPI1.GetChejanData(9201) + " | " + " 주문번호 : " + axKHOpenAPI1.GetChejanData(9203));
                alertListBox.Items.Add("주문상태 : " + axKHOpenAPI1.GetChejanData(913) + " | " + " 종목명 : " + axKHOpenAPI1.GetChejanData(302));
                alertListBox.Items.Add("매매구분" + axKHOpenAPI1.GetChejanData(906) + " | " + " 주문수량 : " + axKHOpenAPI1.GetChejanData(900));

                string orderTime = axKHOpenAPI1.GetChejanData(908);
                string orderHour = orderTime[0] + "" + orderTime[1];
                string orderMinute = orderTime[2] + "" + orderTime[3];
                string orderSecond = orderTime[4] + "" + orderTime[5];
                long orderPrice = long.Parse(axKHOpenAPI1.GetChejanData(901));

                alertListBox.Items.Add("주문/체결시간 : " + orderHour + "시 " + orderMinute + "분 " + orderSecond + "초");
                alertListBox.Items.Add("주문구분 : " + axKHOpenAPI1.GetChejanData(905));
                alertListBox.Items.Add("주문가격 : " + String.Format("{0:#,###}", orderPrice));
                alertListBox.Items.Add("----------------------------------------------------------");

            } else if (e.sGubun == "1") {
                string stockName = axKHOpenAPI1.GetChejanData(302);
                long currentPrice = long.Parse(axKHOpenAPI1.GetChejanData(10).Replace("-", ""));

                string profitRate = axKHOpenAPI1.GetChejanData(8019);
                long totalBuyingPrice = long.Parse(axKHOpenAPI1.GetChejanData(932));
                long profitMoney = long.Parse(axKHOpenAPI1.GetChejanData(950));

                balanceListBox.Items.Add("종목명 : " + stockName + " | 현재 종가 : " + String.Format("{0:#,###}", currentPrice));
                balanceListBox.Items.Add("매입주문금액 : " + String.Format("{0:#,###}", totalBuyingPrice) + " | 금일 실현손익 : " + String.Format("{0:#,###}", profitMoney));
                balanceListBox.Items.Add("금일 실현 손익율 : " + profitRate);
                balanceListBox.Items.Add("----------------------------------------------------------");
            }
        }

        public void orderButtonClicked(object sender, EventArgs e) {
            if (sender.Equals(buyButton)) {
                if (stockTextBox.Text.Length > 0 && accountComboBox.Text.Length > 0) {
                    string stockText = stockTextBox.Text;
                    int index = stockList.FindIndex(o => o.stockName == stockText);

                    string orderCode = stockList[index].stockCode;
                    string accountCode = accountComboBox.Text;
                    int stockQty = int.Parse(numberNumericUpDown.Value.ToString());
                    int stockPrice = int.Parse(priceNumericUpDown.Value.ToString());
                    string[] orderCombo = orderComboBox.Text.Split(':');

                    axKHOpenAPI1.SendOrder("종목신규매수", "8249", accountCode, 1, orderCode, stockQty, stockPrice, orderCombo[0], "");
                }
            } else if (sender.Equals(sellButton)) {
                if (outstandingDataGridView.SelectedCells[0] != null) {
                    int rowIndex = outstandingDataGridView.SelectedCells[0].RowIndex;
                    Console.WriteLine(rowIndex);

                    Console.WriteLine(stockBalanceList[rowIndex].종목코드);

                }

                //Console.WriteLine(balanceDataGridView["종목코드", rowIndex].Value);
            }
        }
        public void onEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e) {
            if (e.nErrCode == 0) {
                orderComboBox.Items.Add("00:지정가".ToString());
                orderComboBox.Items.Add("03:시장가".ToString());
                orderComboBox.SelectedIndex = 0;

                stockList = new List<stockInfo>();
                string accountList = axKHOpenAPI1.GetLoginInfo("ACCLIST");
                string[] accountArray = accountList.Split(';');
                for (int i = 0; i < accountArray.Length; i++) {
                    accountComboBox.Items.Add(accountArray[i]);
                }
                accountComboBox.SelectedIndex = 0;

                string stocklist = axKHOpenAPI1.GetCodeListByMarket(null);
                string[] stockArray = stocklist.Split(';');
                AutoCompleteStringCollection stockCollection = new AutoCompleteStringCollection();

                for (int i = 0; i < stockArray.Length; i++) {
                    stockList.Add(new stockInfo(stockArray[i], axKHOpenAPI1.GetMasterCodeName(stockArray[i])));
                    stockCollection.Add(axKHOpenAPI1.GetMasterCodeName(stockArray[i]));
                }
                stockTextBox.AutoCompleteCustomSource = stockCollection;
            }
        }

        class stockBalance {
            public string 종목코드 { get; set; }
            public string 종목명 { get; set; }
            public long 수량 { get; set; }
            public string 매수금 { get; set; }
            public string 현재가 { get; set; }
            public long 평가손익 { get; set; }
            public string 수익률 { get; set; }

            public stockBalance() { }

            public stockBalance(string 종목번호, string 종목명, long 수량, string 매수금, string 현재가, long 평가손익, string 수익률) {
                this.종목코드 = 종목번호;
                this.종목명 = 종목명;
                this.수량 = 수량;
                this.매수금 = 매수금;
                this.현재가 = 현재가;
                this.평가손익 = 평가손익;
                this.수익률 = 수익률;
            }
        }

        class outstanding {
            public string 주문번호 { get; set; }
            public string 종목코드 { get; set; }
            public string 종목명 { get; set; }
            public int 주문수량 { get; set; }
            public string 주문가격 { get; set; }
            public int 미체결수량 { get; set; }
            public string 주문구분 { get; set; }
            public string 현재가 { get; set; }
            public string 시간 { get; set; }

            public outstanding() {}
            public outstanding(string 주문번호, string 종목코드, string 종목명, int 주문수량, string 주문가격, string 현재가, int 미체결수량, string 주문구분, string 시간) {
                this.주문번호 = 주문번호;
                this.종목코드 = 종목코드;
                this.종목명 = 종목명;
                this.주문수량 = 주문수량;
                this.주문가격 = 주문가격;
                this.미체결수량 = 미체결수량;
                this.주문구분 = 주문구분;
                this.현재가 = 현재가;
                this.시간 = 시간;
            }
        }
    }

}
