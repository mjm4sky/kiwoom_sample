namespace kiwoom_sample {
    partial class FormStock {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStock));
            this.stockSearchButton = new System.Windows.Forms.Button();
            this.stockVolumeTxt = new System.Windows.Forms.TextBox();
            this.stockUpDownTxt = new System.Windows.Forms.TextBox();
            this.stockPriceTxt = new System.Windows.Forms.TextBox();
            this.stockNameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.stockUpDownRateTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.SuspendLayout();
            // 
            // stockSearchButton
            // 
            this.stockSearchButton.Location = new System.Drawing.Point(133, 12);
            this.stockSearchButton.Name = "stockSearchButton";
            this.stockSearchButton.Size = new System.Drawing.Size(64, 20);
            this.stockSearchButton.TabIndex = 39;
            this.stockSearchButton.Text = "잔고조회";
            this.stockSearchButton.UseVisualStyleBackColor = true;
            // 
            // stockVolumeTxt
            // 
            this.stockVolumeTxt.Location = new System.Drawing.Point(103, 138);
            this.stockVolumeTxt.Name = "stockVolumeTxt";
            this.stockVolumeTxt.ReadOnly = true;
            this.stockVolumeTxt.Size = new System.Drawing.Size(104, 21);
            this.stockVolumeTxt.TabIndex = 38;
            // 
            // stockUpDownTxt
            // 
            this.stockUpDownTxt.Location = new System.Drawing.Point(103, 111);
            this.stockUpDownTxt.Name = "stockUpDownTxt";
            this.stockUpDownTxt.ReadOnly = true;
            this.stockUpDownTxt.Size = new System.Drawing.Size(104, 21);
            this.stockUpDownTxt.TabIndex = 37;
            // 
            // stockPriceTxt
            // 
            this.stockPriceTxt.Location = new System.Drawing.Point(103, 85);
            this.stockPriceTxt.Name = "stockPriceTxt";
            this.stockPriceTxt.ReadOnly = true;
            this.stockPriceTxt.Size = new System.Drawing.Size(104, 21);
            this.stockPriceTxt.TabIndex = 36;
            // 
            // stockNameTxt
            // 
            this.stockNameTxt.Location = new System.Drawing.Point(103, 58);
            this.stockNameTxt.Name = "stockNameTxt";
            this.stockNameTxt.ReadOnly = true;
            this.stockNameTxt.Size = new System.Drawing.Size(104, 21);
            this.stockNameTxt.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 34;
            this.label6.Text = "현재가";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "거래량";
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(266, 236);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(62, 13);
            this.axKHOpenAPI1.TabIndex = 32;
            this.axKHOpenAPI1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "전일대비";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "종목명";
            // 
            // stockTextBox
            // 
            this.stockTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.stockTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.stockTextBox.Location = new System.Drawing.Point(23, 12);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(104, 21);
            this.stockTextBox.TabIndex = 40;
            // 
            // stockUpDownRateTxt
            // 
            this.stockUpDownRateTxt.Location = new System.Drawing.Point(103, 165);
            this.stockUpDownRateTxt.Name = "stockUpDownRateTxt";
            this.stockUpDownRateTxt.ReadOnly = true;
            this.stockUpDownRateTxt.Size = new System.Drawing.Size(104, 21);
            this.stockUpDownRateTxt.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "등락률";
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 225);
            this.Controls.Add(this.stockUpDownRateTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.stockSearchButton);
            this.Controls.Add(this.stockVolumeTxt);
            this.Controls.Add(this.stockUpDownTxt);
            this.Controls.Add(this.stockPriceTxt);
            this.Controls.Add(this.stockNameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormStock";
            this.Text = "FormStock";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stockSearchButton;
        private System.Windows.Forms.TextBox stockVolumeTxt;
        private System.Windows.Forms.TextBox stockUpDownTxt;
        private System.Windows.Forms.TextBox stockPriceTxt;
        private System.Windows.Forms.TextBox stockNameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox stockUpDownRateTxt;
        private System.Windows.Forms.Label label1;
    }
}