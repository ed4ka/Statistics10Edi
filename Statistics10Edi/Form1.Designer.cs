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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnAvr = new System.Windows.Forms.Button();
            this.lblAvr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMed = new System.Windows.Forms.Button();
            this.lblMed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNum.Location = new System.Drawing.Point(269, 26);
            this.txtNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(371, 38);
            this.txtNum.TabIndex = 0;
            // 
            // btnAvr
            // 
            this.btnAvr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAvr.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAvr.Location = new System.Drawing.Point(56, 96);
            this.btnAvr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAvr.Name = "btnAvr";
            this.btnAvr.Size = new System.Drawing.Size(90, 43);
            this.btnAvr.TabIndex = 1;
            this.btnAvr.Text = "Averge";
            this.btnAvr.UseVisualStyleBackColor = false;
            this.btnAvr.Click += new System.EventHandler(this.btnAvr_Click);
            // 
            // lblAvr
            // 
            this.lblAvr.AutoSize = true;
            this.lblAvr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAvr.Location = new System.Drawing.Point(52, 150);
            this.lblAvr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvr.Name = "lblAvr";
            this.lblAvr.Size = new System.Drawing.Size(0, 31);
            this.lblAvr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter numbers:";
            // 
            // btnMed
            // 
            this.btnMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMed.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMed.Location = new System.Drawing.Point(58, 215);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(88, 45);
            this.btnMed.TabIndex = 4;
            this.btnMed.Text = "Median";
            this.btnMed.UseVisualStyleBackColor = false;
            this.btnMed.Click += new System.EventHandler(this.btnMed_Click);
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMed.Location = new System.Drawing.Point(60, 272);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(0, 38);
            this.lblMed.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(694, 366);
            this.Controls.Add(this.lblMed);
            this.Controls.Add(this.btnMed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAvr);
            this.Controls.Add(this.btnAvr);
            this.Controls.Add(this.txtNum);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMed;
        private System.Windows.Forms.Label lblMed;
    }
}

