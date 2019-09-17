namespace kiwoom_sample {
    partial class Form1 {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSearchStock = new System.Windows.Forms.Button();
            this.btnSearchStockRT = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(62, 25);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(151, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "로그인 사용자 확인";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnSearchStock
            // 
            this.btnSearchStock.Location = new System.Drawing.Point(61, 54);
            this.btnSearchStock.Name = "btnSearchStock";
            this.btnSearchStock.Size = new System.Drawing.Size(152, 23);
            this.btnSearchStock.TabIndex = 1;
            this.btnSearchStock.Text = "종목 조회";
            this.btnSearchStock.UseVisualStyleBackColor = true;
            // 
            // btnSearchStockRT
            // 
            this.btnSearchStockRT.Location = new System.Drawing.Point(62, 83);
            this.btnSearchStockRT.Name = "btnSearchStockRT";
            this.btnSearchStockRT.Size = new System.Drawing.Size(151, 23);
            this.btnSearchStockRT.TabIndex = 2;
            this.btnSearchStockRT.Text = "실시간 종목조회";
            this.btnSearchStockRT.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(62, 112);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(151, 23);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "매수/매도/잔고";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 178);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnSearchStockRT);
            this.Controls.Add(this.btnSearchStock);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSearchStock;
        private System.Windows.Forms.Button btnSearchStockRT;
        private System.Windows.Forms.Button btnBuy;
    }
}

