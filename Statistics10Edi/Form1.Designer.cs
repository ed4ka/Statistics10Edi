namespace Statistics10Edi
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnAvr = new System.Windows.Forms.Button();
            this.lblAvr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(281, 34);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(403, 22);
            this.txtNum.TabIndex = 0;
            // 
            // btnAvr
            // 
            this.btnAvr.Location = new System.Drawing.Point(75, 118);
            this.btnAvr.Name = "btnAvr";
            this.btnAvr.Size = new System.Drawing.Size(104, 53);
            this.btnAvr.TabIndex = 1;
            this.btnAvr.Text = "button1";
            this.btnAvr.UseVisualStyleBackColor = true;
            this.btnAvr.Click += new System.EventHandler(this.btnAvr_Click);
            // 
            // lblAvr
            // 
            this.lblAvr.AutoSize = true;
            this.lblAvr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAvr.Location = new System.Drawing.Point(70, 185);
            this.lblAvr.Name = "lblAvr";
            this.lblAvr.Size = new System.Drawing.Size(0, 39);
            this.lblAvr.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAvr);
            this.Controls.Add(this.btnAvr);
            this.Controls.Add(this.txtNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnAvr;
        private System.Windows.Forms.Label lblAvr;
    }
}

