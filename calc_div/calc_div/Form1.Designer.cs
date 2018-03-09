namespace calc_div
{
    partial class Form1
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
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtDiv = new System.Windows.Forms.TextBox();
            this.CalcDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(13, 15);
            this.num1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(77, 18);
            this.num1.TabIndex = 0;
            this.num1.Text = "First Number";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(13, 63);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(92, 18);
            this.num2.TabIndex = 1;
            this.num2.Text = "Second Number";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(155, 15);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(155, 63);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 22);
            this.txtNum2.TabIndex = 3;
            // 
            // txtDiv
            // 
            this.txtDiv.Location = new System.Drawing.Point(155, 118);
            this.txtDiv.Name = "txtDiv";
            this.txtDiv.ReadOnly = true;
            this.txtDiv.Size = new System.Drawing.Size(100, 22);
            this.txtDiv.TabIndex = 4;
            // 
            // CalcDiv
            // 
            this.CalcDiv.Location = new System.Drawing.Point(16, 116);
            this.CalcDiv.Name = "CalcDiv";
            this.CalcDiv.Size = new System.Drawing.Size(75, 23);
            this.CalcDiv.TabIndex = 5;
            this.CalcDiv.Text = "CalcDiv";
            this.CalcDiv.UseVisualStyleBackColor = true;
            this.CalcDiv.Click += new System.EventHandler(this.CalcDiv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 302);
            this.Controls.Add(this.CalcDiv);
            this.Controls.Add(this.txtDiv);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F);
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtDiv;
        private System.Windows.Forms.Button CalcDiv;
    }
}

