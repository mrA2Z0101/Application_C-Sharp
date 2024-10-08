
namespace Joes_Automative
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOilChange = new System.Windows.Forms.CheckBox();
            this.chkLubeJob = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTransmissionFlush = new System.Windows.Forms.CheckBox();
            this.chkRadiatorFlush = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkTireRotation = new System.Windows.Forms.CheckBox();
            this.chkMufflerReplacement = new System.Windows.Forms.CheckBox();
            this.chkInspection = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblLaborTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.lblTaxTotal = new System.Windows.Forms.TextBox();
            this.lblPartsTotal = new System.Windows.Forms.TextBox();
            this.lblServiceTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkOilChange);
            this.groupBox1.Controls.Add(this.chkLubeJob);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // chkOilChange
            // 
            this.chkOilChange.AutoSize = true;
            this.chkOilChange.Location = new System.Drawing.Point(6, 30);
            this.chkOilChange.Name = "chkOilChange";
            this.chkOilChange.Size = new System.Drawing.Size(170, 29);
            this.chkOilChange.TabIndex = 7;
            this.chkOilChange.Text = "Oil Change ($50)";
            this.chkOilChange.UseVisualStyleBackColor = true;
            // 
            // chkLubeJob
            // 
            this.chkLubeJob.AutoSize = true;
            this.chkLubeJob.Location = new System.Drawing.Point(6, 65);
            this.chkLubeJob.Name = "chkLubeJob";
            this.chkLubeJob.Size = new System.Drawing.Size(154, 29);
            this.chkLubeJob.TabIndex = 8;
            this.chkLubeJob.Text = "Lube Job ($40)";
            this.chkLubeJob.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTransmissionFlush);
            this.groupBox2.Controls.Add(this.chkRadiatorFlush);
            this.groupBox2.Location = new System.Drawing.Point(359, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 124);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // chkTransmissionFlush
            // 
            this.chkTransmissionFlush.AutoSize = true;
            this.chkTransmissionFlush.Location = new System.Drawing.Point(6, 65);
            this.chkTransmissionFlush.Name = "chkTransmissionFlush";
            this.chkTransmissionFlush.Size = new System.Drawing.Size(240, 29);
            this.chkTransmissionFlush.TabIndex = 1;
            this.chkTransmissionFlush.Text = "Transmission Flush ($120)";
            this.chkTransmissionFlush.UseVisualStyleBackColor = true;
            // 
            // chkRadiatorFlush
            // 
            this.chkRadiatorFlush.AutoSize = true;
            this.chkRadiatorFlush.Location = new System.Drawing.Point(6, 30);
            this.chkRadiatorFlush.Name = "chkRadiatorFlush";
            this.chkRadiatorFlush.Size = new System.Drawing.Size(206, 29);
            this.chkRadiatorFlush.TabIndex = 0;
            this.chkRadiatorFlush.Text = "Radiator Flush ($100)";
            this.chkRadiatorFlush.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkTireRotation);
            this.groupBox3.Controls.Add(this.chkMufflerReplacement);
            this.groupBox3.Controls.Add(this.chkInspection);
            this.groupBox3.Location = new System.Drawing.Point(12, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 180);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MISC";
            // 
            // chkTireRotation
            // 
            this.chkTireRotation.AutoSize = true;
            this.chkTireRotation.Location = new System.Drawing.Point(6, 100);
            this.chkTireRotation.Name = "chkTireRotation";
            this.chkTireRotation.Size = new System.Drawing.Size(183, 29);
            this.chkTireRotation.TabIndex = 2;
            this.chkTireRotation.Text = "Tire Rotation ($25)";
            this.chkTireRotation.UseVisualStyleBackColor = true;
            // 
            // chkMufflerReplacement
            // 
            this.chkMufflerReplacement.AutoSize = true;
            this.chkMufflerReplacement.Location = new System.Drawing.Point(6, 65);
            this.chkMufflerReplacement.Name = "chkMufflerReplacement";
            this.chkMufflerReplacement.Size = new System.Drawing.Size(215, 29);
            this.chkMufflerReplacement.TabIndex = 1;
            this.chkMufflerReplacement.Text = "Replace Muffler ($150)";
            this.chkMufflerReplacement.UseVisualStyleBackColor = true;
            // 
            // chkInspection
            // 
            this.chkInspection.AutoSize = true;
            this.chkInspection.Location = new System.Drawing.Point(6, 30);
            this.chkInspection.Name = "chkInspection";
            this.chkInspection.Size = new System.Drawing.Size(165, 29);
            this.chkInspection.TabIndex = 0;
            this.chkInspection.Text = "Inspection ($35)";
            this.chkInspection.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtParts);
            this.groupBox4.Controls.Add(this.txtLabor);
            this.groupBox4.Location = new System.Drawing.Point(359, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 180);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Labor (hours):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parts:";
            // 
            // txtParts
            // 
            this.txtParts.Location = new System.Drawing.Point(144, 28);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(150, 31);
            this.txtParts.TabIndex = 7;
            // 
            // txtLabor
            // 
            this.txtLabor.Location = new System.Drawing.Point(144, 65);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(150, 31);
            this.txtLabor.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblLaborTotal);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.lblTotal);
            this.groupBox5.Controls.Add(this.lblTaxTotal);
            this.groupBox5.Controls.Add(this.lblPartsTotal);
            this.groupBox5.Controls.Add(this.lblServiceTotal);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(12, 328);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(647, 222);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // lblLaborTotal
            // 
            this.lblLaborTotal.Location = new System.Drawing.Point(347, 21);
            this.lblLaborTotal.Name = "lblLaborTotal";
            this.lblLaborTotal.Size = new System.Drawing.Size(150, 31);
            this.lblLaborTotal.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Labor:";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(347, 169);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(150, 31);
            this.lblTotal.TabIndex = 14;
            // 
            // lblTaxTotal
            // 
            this.lblTaxTotal.Location = new System.Drawing.Point(347, 132);
            this.lblTaxTotal.Name = "lblTaxTotal";
            this.lblTaxTotal.Size = new System.Drawing.Size(150, 31);
            this.lblTaxTotal.TabIndex = 13;
            // 
            // lblPartsTotal
            // 
            this.lblPartsTotal.Location = new System.Drawing.Point(347, 95);
            this.lblPartsTotal.Name = "lblPartsTotal";
            this.lblPartsTotal.Size = new System.Drawing.Size(150, 31);
            this.lblPartsTotal.TabIndex = 12;
            // 
            // lblServiceTotal
            // 
            this.lblServiceTotal.Location = new System.Drawing.Point(347, 58);
            this.lblServiceTotal.Name = "lblServiceTotal";
            this.lblServiceTotal.Size = new System.Drawing.Size(150, 31);
            this.lblServiceTotal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Fees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tax (on Parts):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parts:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Service:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(137, 556);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 34);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(272, 556);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 34);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(417, 556);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 602);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Joe\'s Automotive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkOilChange;
        private System.Windows.Forms.CheckBox chkLubeJob;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkTransmissionFlush;
        private System.Windows.Forms.CheckBox chkRadiatorFlush;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkTireRotation;
        private System.Windows.Forms.CheckBox chkMufflerReplacement;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.TextBox txtLabor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox lblLaborTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.TextBox lblTaxTotal;
        private System.Windows.Forms.TextBox lblPartsTotal;
        private System.Windows.Forms.TextBox lblServiceTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

