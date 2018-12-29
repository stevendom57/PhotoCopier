namespace PhotoCopier
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
            this.lblSource = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.lblDest = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.btnChooseSoure = new System.Windows.Forms.Button();
            this.btnChooseDest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(28, 39);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(60, 20);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(96, 37);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(617, 26);
            this.txtSource.TabIndex = 1;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(96, 90);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(617, 26);
            this.txtDest.TabIndex = 3;
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Location = new System.Drawing.Point(28, 92);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(43, 20);
            this.lblDest.TabIndex = 2;
            this.lblDest.Text = "Dest";
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 20;
            this.lbOutput.Location = new System.Drawing.Point(35, 161);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(862, 224);
            this.lbOutput.TabIndex = 4;
            // 
            // btnChooseSoure
            // 
            this.btnChooseSoure.Location = new System.Drawing.Point(744, 37);
            this.btnChooseSoure.Name = "btnChooseSoure";
            this.btnChooseSoure.Size = new System.Drawing.Size(143, 34);
            this.btnChooseSoure.TabIndex = 5;
            this.btnChooseSoure.Text = "...";
            this.btnChooseSoure.UseVisualStyleBackColor = true;
            // 
            // btnChooseDest
            // 
            this.btnChooseDest.Location = new System.Drawing.Point(744, 86);
            this.btnChooseDest.Name = "btnChooseDest";
            this.btnChooseDest.Size = new System.Drawing.Size(143, 34);
            this.btnChooseDest.TabIndex = 6;
            this.btnChooseDest.Text = "...";
            this.btnChooseDest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 433);
            this.Controls.Add(this.btnChooseDest);
            this.Controls.Add(this.btnChooseSoure);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblSource);
            this.Name = "Form1";
            this.Text = "PhotoCopier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Button btnChooseSoure;
        private System.Windows.Forms.Button btnChooseDest;
    }
}

