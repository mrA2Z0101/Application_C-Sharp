
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.translateAutem = new System.Windows.Forms.Button();
            this.translateDescendit = new System.Windows.Forms.Button();
            this.TranslateMedium = new System.Windows.Forms.Button();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // translateAutem
            // 
            this.translateAutem.Location = new System.Drawing.Point(56, 188);
            this.translateAutem.Name = "translateAutem";
            this.translateAutem.Size = new System.Drawing.Size(112, 34);
            this.translateAutem.TabIndex = 0;
            this.translateAutem.Text = "Autem";
            this.translateAutem.UseVisualStyleBackColor = true;
            this.translateAutem.Click += new System.EventHandler(this.translateAutem_Click);
            // 
            // translateDescendit
            // 
            this.translateDescendit.Location = new System.Drawing.Point(174, 188);
            this.translateDescendit.Name = "translateDescendit";
            this.translateDescendit.Size = new System.Drawing.Size(112, 34);
            this.translateDescendit.TabIndex = 1;
            this.translateDescendit.Text = "Descendit";
            this.translateDescendit.UseVisualStyleBackColor = true;
            this.translateDescendit.Click += new System.EventHandler(this.translateDescendit_Click);
            // 
            // TranslateMedium
            // 
            this.TranslateMedium.Location = new System.Drawing.Point(292, 188);
            this.TranslateMedium.Name = "TranslateMedium";
            this.TranslateMedium.Size = new System.Drawing.Size(112, 34);
            this.TranslateMedium.TabIndex = 2;
            this.TranslateMedium.Text = "Medium";
            this.TranslateMedium.UseVisualStyleBackColor = true;
            this.TranslateMedium.Click += new System.EventHandler(this.TranslateMedium_Click);
            // 
            // lblTranslation
            // 
            this.lblTranslation.AutoSize = true;
            this.lblTranslation.Location = new System.Drawing.Point(126, 109);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Size = new System.Drawing.Size(203, 25);
            this.lblTranslation.TabIndex = 3;
            this.lblTranslation.Text = "Translation appears here";
            this.lblTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.TranslateMedium);
            this.Controls.Add(this.translateDescendit);
            this.Controls.Add(this.translateAutem);
            this.Name = "Form1";
            this.Text = "Latin Words Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button translateAutem;
        private System.Windows.Forms.Button translateDescendit;
        private System.Windows.Forms.Button TranslateMedium;
        private System.Windows.Forms.Label lblTranslation;
    }
}

