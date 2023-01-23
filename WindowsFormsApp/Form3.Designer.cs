
namespace WindowsFormsApp
{
    partial class Form3
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
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpSal = new System.Windows.Forms.TextBox();
            this.btnDInfoCF = new System.Windows.Forms.Button();
            this.btnFInfoCFI = new System.Windows.Forms.Button();
            this.btnDeleteFInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(525, 64);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(111, 23);
            this.btnCreateFolder.TabIndex = 0;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(642, 64);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(105, 23);
            this.btnCreateFile.TabIndex = 1;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(162, 285);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(104, 23);
            this.btnBinaryWrite.TabIndex = 2;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(312, 285);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(128, 23);
            this.btnBinaryRead.TabIndex = 3;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter EmpId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter EmpName";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(287, 51);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(100, 22);
            this.txtEmpId.TabIndex = 6;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(287, 103);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 22);
            this.txtEmpName.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(572, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter EmpSalary";
            // 
            // txtEmpSal
            // 
            this.txtEmpSal.Location = new System.Drawing.Point(287, 154);
            this.txtEmpSal.Name = "txtEmpSal";
            this.txtEmpSal.Size = new System.Drawing.Size(100, 22);
            this.txtEmpSal.TabIndex = 10;
            // 
            // btnDInfoCF
            // 
            this.btnDInfoCF.Location = new System.Drawing.Point(521, 190);
            this.btnDInfoCF.Name = "btnDInfoCF";
            this.btnDInfoCF.Size = new System.Drawing.Size(75, 23);
            this.btnDInfoCF.TabIndex = 11;
            this.btnDInfoCF.Text = "DInfo";
            this.btnDInfoCF.UseVisualStyleBackColor = true;
            this.btnDInfoCF.Click += new System.EventHandler(this.btnDInfoCF_Click);
            // 
            // btnFInfoCFI
            // 
            this.btnFInfoCFI.Location = new System.Drawing.Point(625, 190);
            this.btnFInfoCFI.Name = "btnFInfoCFI";
            this.btnFInfoCFI.Size = new System.Drawing.Size(75, 23);
            this.btnFInfoCFI.TabIndex = 12;
            this.btnFInfoCFI.Text = "FInfo";
            this.btnFInfoCFI.UseVisualStyleBackColor = true;
            this.btnFInfoCFI.Click += new System.EventHandler(this.btnFInfoCFI_Click);
            // 
            // btnDeleteFInfo
            // 
            this.btnDeleteFInfo.Location = new System.Drawing.Point(581, 257);
            this.btnDeleteFInfo.Name = "btnDeleteFInfo";
            this.btnDeleteFInfo.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFInfo.TabIndex = 13;
            this.btnDeleteFInfo.Text = "Delete File";
            this.btnDeleteFInfo.UseVisualStyleBackColor = true;
            this.btnDeleteFInfo.Click += new System.EventHandler(this.btnDeleteFInfo_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteFInfo);
            this.Controls.Add(this.btnFInfoCFI);
            this.Controls.Add(this.btnDInfoCF);
            this.Controls.Add(this.txtEmpSal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateFolder);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpSal;
        private System.Windows.Forms.Button btnDInfoCF;
        private System.Windows.Forms.Button btnFInfoCFI;
        private System.Windows.Forms.Button btnDeleteFInfo;
    }
}