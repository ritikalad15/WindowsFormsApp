using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text.Json;

namespace WindowsFormsApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtStudId.Text+" "+txtStudName.Text+" "+txtStudFee.Text+" "+DeptList.Text);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudId.Clear();
            txtStudName.Clear();
            txtStudFee.Clear();
           // DeptList.Items.Clear();
            DeptList.ResetText();
           
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string path = @"D:\StudentForm";
            try
            {
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder Already Exsits");

                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder Created");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"D:\StudentForm\stud1.txt";
            try
            {
                if (File.Exists(path))
                {
                    MessageBox.Show("File Already Exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            string path = @"D:\StudentFor\stud1.txt";
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    MessageBox.Show("File Deleted Successfully");
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

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\StudentForm\stud1.text", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtStudId.Text));
                bw.Write(txtStudName.Text);
                bw.Write(txtStudFee.Text);
                bw.Write(DeptList.Text);
                bw.Close();
                fs.Close();
                MessageBox.Show("Data Saved Successfully");
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
                FileStream fs = new FileStream(@"D:\StudentForm\stud1.text", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtStudId.Text = br.ReadInt32().ToString();
                txtStudName.Text = br.ReadString();
                txtStudFee.Text = br.ReadString();
                DeptList.Text = br.ReadString();
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\StudentForm\stud1SOAP.Soap", FileMode.Create, FileAccess.Write);
                Student stu = new Student();
                stu.StudID = Convert.ToInt32(txtStudId.Text);
                stu.StudName = txtStudName.Text;
                stu.StudFee = Convert.ToInt32(txtStudFee.Text);
                stu.SDepartment = DeptList.Text;
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, stu);
                fs.Close();
                MessageBox.Show("SOAPWrite Data Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\StudentForm\stud1SOAP.Soap", FileMode.Open, FileAccess.Read);
                Student stu = new Student();
                SoapFormatter soap = new SoapFormatter();
                stu = (Student)soap.Deserialize(fs);
                fs.Close();
                txtStudId.Text = stu.StudID.ToString();
                txtStudName.Text = stu.StudName;
                txtStudFee.Text = stu.StudFee.ToString();
                DeptList.Text = stu.SDepartment;
                MessageBox.Show("SOAP Read Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\StudentForm\stud1XML.xml", FileMode.Create, FileAccess.Write);
                Student stu = new Student();
                stu.StudID = Convert.ToInt32(txtStudId.Text);
                stu.StudName = txtStudName.Text;
                stu.StudFee = Convert.ToInt32(txtStudFee.Text);
                stu.SDepartment = DeptList.Text;
                XmlSerializer xml = new XmlSerializer(typeof(Student));
                xml.Serialize(fs, stu);
                fs.Close();
                MessageBox.Show("XMLWrite Data Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\StudentForm\stud1XML.xml", FileMode.Open, FileAccess.Read);
                Student stu = new Student();
                XmlSerializer xml = new XmlSerializer(typeof(Student));
                stu = (Student)xml.Deserialize(fs);
                fs.Close();
                txtStudId.Text = stu.StudID.ToString();
                txtStudName.Text = stu.StudName;
                txtStudFee.Text = stu.StudFee.ToString();
                DeptList.Text = stu.SDepartment;
                MessageBox.Show("XML Read Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\StudentForm\stud1Json.json", FileMode.Create, FileAccess.Write);
                Student stu = new Student();
                stu.StudID = Convert.ToInt32(txtStudId.Text);
                stu.StudName = txtStudName.Text;
                stu.StudFee = Convert.ToInt32(txtStudFee.Text);
                stu.SDepartment = DeptList.Text;
                JsonSerializer.Serialize<Student>(fs, stu);
                fs.Close();
                MessageBox.Show("JsonWrite Data Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\StudentForm\stud1Json.json", FileMode.Open, FileAccess.Read);
                Student stu = new Student();
                
                stu = JsonSerializer.Deserialize<Student>(fs);
                fs.Close();
                txtStudId.Text = stu.StudID.ToString();
                txtStudName.Text = stu.StudName;
                txtStudFee.Text = stu.StudFee.ToString();
                DeptList.Text = stu.SDepartment;
                MessageBox.Show("Json Read Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
