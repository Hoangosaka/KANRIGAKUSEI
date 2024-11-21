namespace KANRIGAKUSEI
{
    partial class fログイン
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txbメールアドレス = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbパスワード = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnログイン = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "メールアドレス";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbメールアドレス
            // 
            this.txbメールアドレス.Location = new System.Drawing.Point(79, 74);
            this.txbメールアドレス.MaxLength = 255;
            this.txbメールアドレス.Name = "txbメールアドレス";
            this.txbメールアドレス.Size = new System.Drawing.Size(230, 40);
            this.txbメールアドレス.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "パスワード";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbパスワード
            // 
            this.txbパスワード.Location = new System.Drawing.Point(79, 180);
            this.txbパスワード.Name = "txbパスワード";
            this.txbパスワード.Size = new System.Drawing.Size(230, 40);
            this.txbパスワード.TabIndex = 1;
            this.txbパスワード.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Mincho", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(189, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "パスワード忘れ方";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnログイン
            // 
            this.btnログイン.AccessibleName = "btnログイン";
            this.btnログイン.Font = new System.Drawing.Font("Yu Mincho Demibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnログイン.Location = new System.Drawing.Point(127, 286);
            this.btnログイン.Name = "btnログイン";
            this.btnログイン.Size = new System.Drawing.Size(134, 55);
            this.btnログイン.TabIndex = 2;
            this.btnログイン.TabStop = false;
            this.btnログイン.Text = "ログイン";
            this.btnログイン.UseVisualStyleBackColor = true;
            this.btnログイン.Click += new System.EventHandler(this.btnログイン_Click);
            // 
            // fログイン
            // 
            this.AcceptButton = this.btnログイン;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 407);
            this.Controls.Add(this.btnログイン);
            this.Controls.Add(this.txbパスワード);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbメールアドレス);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Yu Mincho", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fログイン";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ログイン";
            this.Load += new System.EventHandler(this.fログイン_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbメールアドレス;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbパスワード;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnログイン;
    }
}

