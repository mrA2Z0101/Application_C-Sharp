
namespace Distanced_Traveled
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
            this.calculateDistance5Hours = new System.Windows.Forms.Button();
            this.insertSpeed = new System.Windows.Forms.TextBox();
            this.distanceHere = new System.Windows.Forms.Label();
            this.calculateDistance8Hours = new System.Windows.Forms.Button();
            this.calculateDistance12Hours = new System.Windows.Forms.Button();
            this.exitApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateDistance5Hours
            // 
            this.calculateDistance5Hours.Location = new System.Drawing.Point(85, 115);
            this.calculateDistance5Hours.Name = "calculateDistance5Hours";
            this.calculateDistance5Hours.Size = new System.Drawing.Size(236, 62);
            this.calculateDistance5Hours.TabIndex = 0;
            this.calculateDistance5Hours.Text = "The distance the car will travel in 5 hours";
            this.calculateDistance5Hours.UseVisualStyleBackColor = true;
            this.calculateDistance5Hours.Click += new System.EventHandler(this.calculateDistance5Hours_Click);
            // 
            // insertSpeed
            // 
            this.insertSpeed.Location = new System.Drawing.Point(85, 56);
            this.insertSpeed.Name = "insertSpeed";
            this.insertSpeed.Size = new System.Drawing.Size(236, 31);
            this.insertSpeed.TabIndex = 1;
            // 
            // distanceHere
            // 
            this.distanceHere.AutoSize = true;
            this.distanceHere.Location = new System.Drawing.Point(62, 332);
            this.distanceHere.Name = "distanceHere";
            this.distanceHere.Size = new System.Drawing.Size(79, 25);
            this.distanceHere.TabIndex = 5;
            this.distanceHere.Text = "Distance";
            this.distanceHere.Click += new System.EventHandler(this.label3_Click);
            // 
            // calculateDistance8Hours
            // 
            this.calculateDistance8Hours.Location = new System.Drawing.Point(85, 183);
            this.calculateDistance8Hours.Name = "calculateDistance8Hours";
            this.calculateDistance8Hours.Size = new System.Drawing.Size(236, 62);
            this.calculateDistance8Hours.TabIndex = 6;
            this.calculateDistance8Hours.Text = "The distance the car will travel in 8 hours";
            this.calculateDistance8Hours.UseVisualStyleBackColor = true;
            this.calculateDistance8Hours.Click += new System.EventHandler(this.calculateDistance8Hours_Click);
            // 
            // calculateDistance12Hours
            // 
            this.calculateDistance12Hours.Location = new System.Drawing.Point(85, 251);
            this.calculateDistance12Hours.Name = "calculateDistance12Hours";
            this.calculateDistance12Hours.Size = new System.Drawing.Size(236, 62);
            this.calculateDistance12Hours.TabIndex = 7;
            this.calculateDistance12Hours.Text = "The distance the car will travel in 12 hours";
            this.calculateDistance12Hours.UseVisualStyleBackColor = true;
            this.calculateDistance12Hours.Click += new System.EventHandler(this.calculateDistance12Hours_Click);
            // 
            // exitApp
            // 
            this.exitApp.Location = new System.Drawing.Point(85, 387);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(236, 34);
            this.exitApp.TabIndex = 8;
            this.exitApp.Text = "Exit";
            this.exitApp.UseVisualStyleBackColor = true;
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Insert Speed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitApp);
            this.Controls.Add(this.calculateDistance12Hours);
            this.Controls.Add(this.calculateDistance8Hours);
            this.Controls.Add(this.distanceHere);
            this.Controls.Add(this.insertSpeed);
            this.Controls.Add(this.calculateDistance5Hours);
            this.Name = "Form1";
            this.Text = "Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateDistance5Hours;
        private System.Windows.Forms.TextBox insertSpeed;
        private System.Windows.Forms.Label distanceHere;
        private System.Windows.Forms.Button calculateDistance8Hours;
        private System.Windows.Forms.Button calculateDistance12Hours;
        private System.Windows.Forms.Button exitApp;
        private System.Windows.Forms.Label label1;
    }
}

