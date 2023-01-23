
namespace WindowsFormsApp
{
    partial class Form4
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.btnBinaryWriter = new System.Windows.Forms.Button();
            this.btnBinaryReader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter DId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter DName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(283, 64);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(283, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(283, 173);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(100, 22);
            this.txtLoc.TabIndex = 5;
            // 
            // btnBinaryWriter
            // 
            this.btnBinaryWriter.Location = new System.Drawing.Point(143, 303);
            this.btnBinaryWriter.Name = "btnBinaryWriter";
            this.btnBinaryWriter.Size = new System.Drawing.Size(122, 23);
            this.btnBinaryWriter.TabIndex = 6;
            this.btnBinaryWriter.Text = "Binary Writer";
            this.btnBinaryWriter.UseVisualStyleBackColor = true;
            this.btnBinaryWriter.Click += new System.EventHandler(this.btnBinaryWriter_Click);
            // 
            // btnBinaryReader
            // 
            this.btnBinaryReader.Location = new System.Drawing.Point(325, 303);
            this.btnBinaryReader.Name = "btnBinaryReader";
            this.btnBinaryReader.Size = new System.Drawing.Size(110, 23);
            this.btnBinaryReader.TabIndex = 7;
            this.btnBinaryReader.Text = "Binary Reader";
            this.btnBinaryReader.UseVisualStyleBackColor = true;
            this.btnBinaryReader.Click += new System.EventHandler(this.btnBinaryReader_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBinaryReader);
            this.Controls.Add(this.btnBinaryWriter);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Button btnBinaryWriter;
        private System.Windows.Forms.Button btnBinaryReader;
    }
}