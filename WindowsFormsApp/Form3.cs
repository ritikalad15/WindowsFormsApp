using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }



        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string path = @"D:\SkillMineDoc";
            try
            {
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Directory is already exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory created..");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"D:\SkillMineDoc\Test1.txt";
            try
            {
                if (File.Exists(path))
                {
                    MessageBox.Show("File is already exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File created");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string path = @"D:\SkillMineDoc\Test1.txt";
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    MessageBox.Show("File has been removed");
                }
                else
                {
                    MessageBox.Show("File not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillMineDoc\emp.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtEmpId.Text));
                bw.Write(txtEmpName.Text);
                bw.Write(Convert.ToDouble(txtEmpSal.Text));
                bw.Close();
                fs.Close();
                MessageBox.Show("Data saved to file..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillMineDoc\emp.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtEmpId.Text = br.ReadInt32().ToString();
                txtEmpName.Text = br.ReadString();
                txtEmpSal.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDInfoCF_Click(object sender, EventArgs e)
        {
            DirectoryInfo df = new DirectoryInfo(@"D:\SkillMineDoc2");
            try
            {
                if (df.Exists)
                {
                    MessageBox.Show("DirectoryInfo File Already Exists");
                }
                else
                {
                    df.Create();
                    MessageBox.Show("Directory Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnFInfoCFI_Click(object sender, EventArgs e)
        {
            FileInfo fI = new FileInfo(@"D:\SkillMineDoc2\Test1.Text");
            try
            {
                if (fI.Exists)
                {
                    MessageBox.Show("File Alreay Exists");
                }
                else
                {
                    fI.Create();
                    MessageBox.Show("File Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteFInfo_Click(object sender, EventArgs e)
        {
            FileInfo fI = new FileInfo(@"D:\SkillMineDoc2\Test1.Text");
            try
            {
                if (fI.Exists)
                {
                    fI.Delete();
                    MessageBox.Show("File Removed Successfully");
                }
                else
                {
                    MessageBox.Show("File not Found");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

