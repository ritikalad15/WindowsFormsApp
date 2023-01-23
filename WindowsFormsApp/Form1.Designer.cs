
namespace WindowsFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtEmpsal = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalsal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHRA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter EmpId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter EmpName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter EmpSalary";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(203, 140);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 22);
            this.txtEmpName.TabIndex = 3;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(203, 92);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(100, 22);
            this.txtEmpId.TabIndex = 4;
           
            // 
            // txtEmpsal
            // 
            this.txtEmpsal.Location = new System.Drawing.Point(203, 186);
            this.txtEmpsal.Name = "txtEmpsal";
            this.txtEmpsal.Size = new System.Drawing.Size(102, 22);
            this.txtEmpsal.TabIndex = 5;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(535, 86);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(649, 86);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(649, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(649, 211);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(127, 282);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(27, 17);
            this.label.TabIndex = 11;
            this.label.Text = "DA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "TA";
            // 
            // txtTA
            // 
            this.txtTA.Enabled = false;
            this.txtTA.Location = new System.Drawing.Point(205, 327);
            this.txtTA.Name = "txtTA";
            this.txtTA.Size = new System.Drawing.Size(100, 22);
            this.txtTA.TabIndex = 14;
            // 
            // txtDA
            // 
            this.txtDA.Enabled = false;
            this.txtDA.Location = new System.Drawing.Point(205, 282);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(100, 22);
            this.txtDA.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Total Salary";
            // 
            // txtTotalsal
            // 
            this.txtTotalsal.Enabled = false;
            this.txtTotalsal.Location = new System.Drawing.Point(203, 418);
            this.txtTotalsal.Name = "txtTotalsal";
            this.txtTotalsal.Size = new System.Drawing.Size(100, 22);
            this.txtTotalsal.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "HRA";
            // 
            // txtHRA
            // 
            this.txtHRA.Enabled = false;
            this.txtHRA.Location = new System.Drawing.Point(203, 239);
            this.txtHRA.Name = "txtHRA";
            this.txtHRA.Size = new System.Drawing.Size(100, 22);
            this.txtHRA.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "PF";
            // 
            // txtPF
            // 
            this.txtPF.Enabled = false;
            this.txtPF.Location = new System.Drawing.Point(203, 377);
            this.txtPF.Name = "txtPF";
            this.txtPF.Size = new System.Drawing.Size(100, 22);
            this.txtPF.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 501);
            this.Controls.Add(this.txtPF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHRA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalsal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.txtTA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtEmpsal);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtEmpsal;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTA;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalsal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHRA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPF;
    }
}