namespace chapter3_cash
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.banksCashLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.joesCashLabel.Location = new System.Drawing.Point(12, 9);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(82, 16);
            this.joesCashLabel.TabIndex = 2;
            this.joesCashLabel.Text = "Joe has $50";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.bobsCashLabel.Location = new System.Drawing.Point(12, 44);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(95, 16);
            this.bobsCashLabel.TabIndex = 3;
            this.bobsCashLabel.Text = "Bob has $100";
            // 
            // banksCashLabel
            // 
            this.banksCashLabel.AutoSize = true;
            this.banksCashLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.banksCashLabel.Location = new System.Drawing.Point(12, 82);
            this.banksCashLabel.Name = "banksCashLabel";
            this.banksCashLabel.Size = new System.Drawing.Size(102, 16);
            this.banksCashLabel.TabIndex = 4;
            this.banksCashLabel.Text = "Bank has $100";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 69);
            this.button3.TabIndex = 5;
            this.button3.Text = "Give $10 to Bob";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(76, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 69);
            this.button4.TabIndex = 6;
            this.button4.Text = "Receive $5 from Joe";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 278);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.banksCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label banksCashLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

