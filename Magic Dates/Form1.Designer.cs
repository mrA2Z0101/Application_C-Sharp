
namespace Magic_Dates
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
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(48, 76);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(150, 31);
            this.txtMonth.TabIndex = 0;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(278, 76);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(150, 31);
            this.txtDay.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(519, 76);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(150, 31);
            this.txtYear.TabIndex = 2;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(48, 48);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(65, 25);
            this.txt.TabIndex = 3;
            this.txt.Text = "Month";
            this.txt.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtD
            // 
            this.txtD.AutoSize = true;
            this.txtD.Location = new System.Drawing.Point(278, 48);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(43, 25);
            this.txtD.TabIndex = 4;
            this.txtD.Text = "Day";
            // 
            // txtY
            // 
            this.txtY.AutoSize = true;
            this.txtY.Location = new System.Drawing.Point(519, 48);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(44, 25);
            this.txtY.TabIndex = 5;
            this.txtY.Text = "Year";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(48, 131);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(112, 34);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Checking";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(48, 199);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(70, 25);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtMonth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label txtD;
        private System.Windows.Forms.Label txtY;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;
    }
}

