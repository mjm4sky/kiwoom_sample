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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            btnLogin.Click          += ButtonClicked;
            btnSearchStock.Click    += ButtonClicked;
            btnSearchStockRT.Click  += ButtonClicked;
            btnBuy.Click            += ButtonClicked;
        }

        private void ButtonClicked(object sender, EventArgs e) {
            if(sender.Equals(btnLogin)) {
                FormLogin popup = new FormLogin();
                popup.ShowDialog();

            } else if(sender.Equals(btnSearchStock)) {
                FormStock popup = new FormStock();
                popup.ShowDialog();

            } else if (sender.Equals(btnSearchStockRT)) {
                FormStockRT popup = new FormStockRT();
                popup.ShowDialog();

            } else if (sender.Equals(btnBuy)) {
                FormOrder popup = new FormOrder();
                popup.ShowDialog();

            }

        }
    }
}
