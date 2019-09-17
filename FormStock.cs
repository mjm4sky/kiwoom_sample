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
    public partial class FormStock : Form {
        List<stockInfo> stockList;

        public FormStock() {
            InitializeComponent();
            axKHOpenAPI1.CommConnect();
            axKHOpenAPI1.OnEventConnect += onEventConnect;
            axKHOpenAPI1.OnReceiveTrData += onReceiveTrData;
            stockSearchButton.Click += stockSearch;
        }

        public void onReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e) {
            if (e.sRQName == "종목정보요청") {
                long stockPrice = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가").Trim().Replace("-", ""));
                string stockName = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목명").Trim();
                long upDown = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "전일대비").Trim());
                long volume = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래량").Trim());
                string upDownRate = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율").Trim();

                stockPriceTxt.Text = String.Format("{0:#,###}", stockPrice);
                stockNameTxt.Text = stockName;
                stockUpDownTxt.Text = String.Format("{0:#,###}", upDown);
                stockVolumeTxt.Text = String.Format("{0:#,###}", volume);
                if (upDown == 0) {
                    stockUpDownTxt.Text = "0";
                }
                if (volume == 0) {
                    stockVolumeTxt.Text = "0";
                }
                stockUpDownRateTxt.Text = upDownRate + "%";
            }
        }
        public void stockSearch(object sender, EventArgs e) {
            string stockName = stockTextBox.Text;
            int index = stockList.FindIndex(o => o.stockName == stockName);
            string stockCode = stockList[index].stockCode;

            axKHOpenAPI1.SetInputValue("종목코드", stockCode);
            axKHOpenAPI1.CommRqData("종목정보요청", "opt10001", 0, "5000");
        }
        public void onReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e) {
            Console.WriteLine(e.sRealType);

        }
        public void onEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e) {
            stockList = new List<stockInfo>();

            if (e.nErrCode == 0) {
                AutoCompleteStringCollection stockcollection = new AutoCompleteStringCollection();

                string stockCode = axKHOpenAPI1.GetCodeListByMarket(null);
                string[] stockCodeArray = stockCode.Split(';');
                for (int i = 0; i < stockCodeArray.Length; i++) {
                    stockList.Add(new stockInfo(stockCodeArray[i], axKHOpenAPI1.GetMasterCodeName(stockCodeArray[i])));
                }
                for (int i = 0; i < stockList.Count; i++) {
                    stockcollection.Add(stockList[i].stockName);
                }
                stockTextBox.AutoCompleteCustomSource = stockcollection;

            }
        }
    }

    class stockInfo {
        public string stockCode;
        public string stockName;
        public stockInfo(string code, string name) {
            this.stockCode = code;
            this.stockName = name;
        }
    }
}
