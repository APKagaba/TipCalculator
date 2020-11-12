namespace Lab_2
{
    partial class Lab2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pricelbl = new System.Windows.Forms.Label();
            this.num1Txt = new System.Windows.Forms.TextBox();
            this.TipRateLowlbl = new System.Windows.Forms.Label();
            this.TipRateMedlbl = new System.Windows.Forms.Label();
            this.TipRateHilbl = new System.Windows.Forms.Label();
            this.output1lbl = new System.Windows.Forms.Label();
            this.output2lbl = new System.Windows.Forms.Label();
            this.output3lbl = new System.Windows.Forms.Label();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Location = new System.Drawing.Point(12, 9);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(131, 17);
            this.Pricelbl.TabIndex = 0;
            this.Pricelbl.Text = "Enter price of meal:";
            // 
            // num1Txt
            // 
            this.num1Txt.Location = new System.Drawing.Point(149, 6);
            this.num1Txt.Name = "num1Txt";
            this.num1Txt.Size = new System.Drawing.Size(100, 22);
            this.num1Txt.TabIndex = 1;
            // 
            // TipRateLowlbl
            // 
            this.TipRateLowlbl.AutoSize = true;
            this.TipRateLowlbl.Location = new System.Drawing.Point(88, 42);
            this.TipRateLowlbl.Name = "TipRateLowlbl";
            this.TipRateLowlbl.Size = new System.Drawing.Size(46, 17);
            this.TipRateLowlbl.TabIndex = 2;
            this.TipRateLowlbl.Text = "label2";
            // 
            // TipRateMedlbl
            // 
            this.TipRateMedlbl.AutoSize = true;
            this.TipRateMedlbl.Location = new System.Drawing.Point(88, 82);
            this.TipRateMedlbl.Name = "TipRateMedlbl";
            this.TipRateMedlbl.Size = new System.Drawing.Size(46, 17);
            this.TipRateMedlbl.TabIndex = 3;
            this.TipRateMedlbl.Text = "label3";
            // 
            // TipRateHilbl
            // 
            this.TipRateHilbl.AutoSize = true;
            this.TipRateHilbl.Location = new System.Drawing.Point(88, 128);
            this.TipRateHilbl.Name = "TipRateHilbl";
            this.TipRateHilbl.Size = new System.Drawing.Size(46, 17);
            this.TipRateHilbl.TabIndex = 4;
            this.TipRateHilbl.Text = "label4";
            // 
            // output1lbl
            // 
            this.output1lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output1lbl.Location = new System.Drawing.Point(149, 41);
            this.output1lbl.Name = "output1lbl";
            this.output1lbl.Size = new System.Drawing.Size(100, 25);
            this.output1lbl.TabIndex = 5;
            // 
            // output2lbl
            // 
            this.output2lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output2lbl.Location = new System.Drawing.Point(149, 81);
            this.output2lbl.Name = "output2lbl";
            this.output2lbl.Size = new System.Drawing.Size(100, 25);
            this.output2lbl.TabIndex = 6;
            // 
            // output3lbl
            // 
            this.output3lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output3lbl.Location = new System.Drawing.Point(149, 120);
            this.output3lbl.Name = "output3lbl";
            this.output3lbl.Size = new System.Drawing.Size(100, 25);
            this.output3lbl.TabIndex = 7;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(91, 191);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(136, 29);
            this.CalcBtn.TabIndex = 8;
            this.CalcBtn.Text = "Calculate Tip";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // Lab2
            // 
            this.AcceptButton = this.CalcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.output3lbl);
            this.Controls.Add(this.output2lbl);
            this.Controls.Add(this.output1lbl);
            this.Controls.Add(this.TipRateHilbl);
            this.Controls.Add(this.TipRateMedlbl);
            this.Controls.Add(this.TipRateLowlbl);
            this.Controls.Add(this.num1Txt);
            this.Controls.Add(this.Pricelbl);
            this.Name = "Lab2";
            this.Text = "Lab 2";
            this.Load += new System.EventHandler(this.Lab2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pricelbl;
        private System.Windows.Forms.TextBox num1Txt;
        private System.Windows.Forms.Label TipRateLowlbl;
        private System.Windows.Forms.Label TipRateMedlbl;
        private System.Windows.Forms.Label TipRateHilbl;
        private System.Windows.Forms.Label output1lbl;
        private System.Windows.Forms.Label output2lbl;
        private System.Windows.Forms.Label output3lbl;
        private System.Windows.Forms.Button CalcBtn;
    }
}

