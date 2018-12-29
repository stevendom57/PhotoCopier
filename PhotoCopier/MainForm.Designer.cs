namespace PhotoCopier
{
    partial class MainForm
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
            this.btnGo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(28, 38);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(60, 20);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(96, 37);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(618, 26);
            this.txtSource.TabIndex = 1;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(96, 89);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(618, 26);
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
            this.lbOutput.Location = new System.Drawing.Point(33, 163);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(862, 224);
            this.lbOutput.TabIndex = 4;
            // 
            // btnChooseSoure
            // 
            this.btnChooseSoure.Location = new System.Drawing.Point(744, 37);
            this.btnChooseSoure.Name = "btnChooseSoure";
            this.btnChooseSoure.Size = new System.Drawing.Size(142, 34);
            this.btnChooseSoure.TabIndex = 5;
            this.btnChooseSoure.Text = "...";
            this.btnChooseSoure.UseVisualStyleBackColor = true;
            // 
            // btnChooseDest
            // 
            this.btnChooseDest.Location = new System.Drawing.Point(744, 86);
            this.btnChooseDest.Name = "btnChooseDest";
            this.btnChooseDest.Size = new System.Drawing.Size(142, 34);
            this.btnChooseDest.TabIndex = 6;
            this.btnChooseDest.Text = "...";
            this.btnChooseDest.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(194, 432);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(112, 35);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(603, 432);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 511);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnChooseDest);
            this.Controls.Add(this.btnChooseSoure);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblSource);
            this.Name = "MainForm";
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
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnCancel;
    }
}

