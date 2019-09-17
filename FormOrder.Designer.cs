namespace kiwoom_sample {
    partial class FormOrder {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.stockSearchButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.label3 = new System.Windows.Forms.Label();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.balanceCheckButton = new System.Windows.Forms.Button();
            this.outstandingDataGridView = new System.Windows.Forms.DataGridView();
            this.balanceListBox = new System.Windows.Forms.ListBox();
            this.alertListBox = new System.Windows.Forms.ListBox();
            this.sellFixButton = new System.Windows.Forms.Button();
            this.buyFixButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.balanceDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outstandingDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stockTextBox
            // 
            this.stockTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.stockTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.stockTextBox.Location = new System.Drawing.Point(103, 38);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(73, 21);
            this.stockTextBox.TabIndex = 66;
            // 
            // stockSearchButton
            // 
            this.stockSearchButton.Location = new System.Drawing.Point(182, 38);
            this.stockSearchButton.Name = "stockSearchButton";
            this.stockSearchButton.Size = new System.Drawing.Size(64, 20);
            this.stockSearchButton.TabIndex = 65;
            this.stockSearchButton.Text = "종목검색";
            this.stockSearchButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 60;
            this.label6.Text = "수량";
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(5, 449);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(62, 13);
            this.axKHOpenAPI1.TabIndex = 58;
            this.axKHOpenAPI1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 56;
            this.label3.Text = "종목명";
            // 
            // accountComboBox
            // 
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Location = new System.Drawing.Point(103, 12);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(143, 20);
            this.accountComboBox.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 69;
            this.label2.Text = "계좌번호";
            // 
            // numberNumericUpDown
            // 
            this.numberNumericUpDown.Location = new System.Drawing.Point(103, 66);
            this.numberNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberNumericUpDown.Name = "numberNumericUpDown";
            this.numberNumericUpDown.Size = new System.Drawing.Size(143, 21);
            this.numberNumericUpDown.TabIndex = 71;
            this.numberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.Location = new System.Drawing.Point(103, 93);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.priceNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(143, 21);
            this.priceNumericUpDown.TabIndex = 73;
            this.priceNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 72;
            this.label7.Text = "가격";
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Location = new System.Drawing.Point(103, 120);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(143, 20);
            this.orderComboBox.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 74;
            this.label8.Text = "거래구분";
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(278, 12);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(91, 41);
            this.buyButton.TabIndex = 76;
            this.buyButton.Text = "신규매수";
            this.buyButton.UseVisualStyleBackColor = true;
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(375, 12);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(91, 41);
            this.sellButton.TabIndex = 78;
            this.sellButton.Text = "신규매도";
            this.sellButton.UseVisualStyleBackColor = true;
            // 
            // balanceCheckButton
            // 
            this.balanceCheckButton.Location = new System.Drawing.Point(375, 100);
            this.balanceCheckButton.Name = "balanceCheckButton";
            this.balanceCheckButton.Size = new System.Drawing.Size(91, 38);
            this.balanceCheckButton.TabIndex = 80;
            this.balanceCheckButton.Text = "잔고조회";
            this.balanceCheckButton.UseVisualStyleBackColor = true;
            // 
            // outstandingDataGridView
            // 
            this.outstandingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outstandingDataGridView.Location = new System.Drawing.Point(4, 7);
            this.outstandingDataGridView.Name = "outstandingDataGridView";
            this.outstandingDataGridView.RowHeadersVisible = false;
            this.outstandingDataGridView.RowTemplate.Height = 23;
            this.outstandingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.outstandingDataGridView.Size = new System.Drawing.Size(447, 180);
            this.outstandingDataGridView.TabIndex = 81;
            // 
            // balanceListBox
            // 
            this.balanceListBox.FormattingEnabled = true;
            this.balanceListBox.ItemHeight = 12;
            this.balanceListBox.Location = new System.Drawing.Point(484, 13);
            this.balanceListBox.Name = "balanceListBox";
            this.balanceListBox.Size = new System.Drawing.Size(396, 160);
            this.balanceListBox.TabIndex = 82;
            // 
            // alertListBox
            // 
            this.alertListBox.FormattingEnabled = true;
            this.alertListBox.ItemHeight = 12;
            this.alertListBox.Location = new System.Drawing.Point(484, 206);
            this.alertListBox.Name = "alertListBox";
            this.alertListBox.Size = new System.Drawing.Size(396, 160);
            this.alertListBox.TabIndex = 83;
            // 
            // sellFixButton
            // 
            this.sellFixButton.Location = new System.Drawing.Point(375, 55);
            this.sellFixButton.Name = "sellFixButton";
            this.sellFixButton.Size = new System.Drawing.Size(91, 41);
            this.sellFixButton.TabIndex = 85;
            this.sellFixButton.Text = "매도정정";
            this.sellFixButton.UseVisualStyleBackColor = true;
            // 
            // buyFixButton
            // 
            this.buyFixButton.Location = new System.Drawing.Point(278, 55);
            this.buyFixButton.Name = "buyFixButton";
            this.buyFixButton.Size = new System.Drawing.Size(91, 41);
            this.buyFixButton.TabIndex = 84;
            this.buyFixButton.Text = "매수정정";
            this.buyFixButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 157);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 218);
            this.tabControl1.TabIndex = 86;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.balanceDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(454, 192);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "잔고";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.outstandingDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(454, 192);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "미체결";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // balanceDataGridView
            // 
            this.balanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balanceDataGridView.Location = new System.Drawing.Point(4, 6);
            this.balanceDataGridView.Name = "balanceDataGridView";
            this.balanceDataGridView.RowHeadersVisible = false;
            this.balanceDataGridView.RowTemplate.Height = 23;
            this.balanceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.balanceDataGridView.Size = new System.Drawing.Size(447, 180);
            this.balanceDataGridView.TabIndex = 82;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 388);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.sellFixButton);
            this.Controls.Add(this.buyFixButton);
            this.Controls.Add(this.alertListBox);
            this.Controls.Add(this.balanceListBox);
            this.Controls.Add(this.balanceCheckButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.orderComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numberNumericUpDown);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.stockSearchButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Controls.Add(this.label3);
            this.Name = "FormOrder";
            this.Text = "매수/매도/잔고조회";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outstandingDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.Button stockSearchButton;
        private System.Windows.Forms.Label label6;
        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberNumericUpDown;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button balanceCheckButton;
        private System.Windows.Forms.DataGridView outstandingDataGridView;
        private System.Windows.Forms.ListBox balanceListBox;
        private System.Windows.Forms.ListBox alertListBox;
        private System.Windows.Forms.Button sellFixButton;
        private System.Windows.Forms.Button buyFixButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView balanceDataGridView;
    }
}