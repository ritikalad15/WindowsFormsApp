using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text.Json;
using System.Windows.Forms;


namespace WindowsFormsApp
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillMineDoc\Employee.dat", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.EmpId = Convert.ToInt32(txtEmpId.Text);
                emp.EmpName = txtEmpName.Text;
                emp.EmpSalary = Convert.ToInt32(txtEmpSal.Text);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Employee record added to file");
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
                FileStream fs = new FileStream(@"D:\SkillMineDoc\Employee.dat", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                emp = (Employee)binaryFormatter.Deserialize(fs);
                fs.Close();

                txtEmpId.Text = emp.EmpId.ToString();
                txtEmpName.Text = emp.EmpName;
                txtEmpSal.Text = emp.EmpSalary.ToString();
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
                FileStream fs = new FileStream(@"D:\SkillMineDoc\EmployeeSOAP.soap", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.EmpId = Convert.ToInt32(txtEmpId.Text);
                emp.EmpName = txtEmpName.Text;
                emp.EmpSalary = Convert.ToInt32(txtEmpSal.Text);
                SoapFormatter saop = new SoapFormatter();
                saop.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Soap Write Done");
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
                FileStream fs = new FileStream(@"D:\SkillMineDoc\EmployeeSOAP.soap", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                SoapFormatter soap = new SoapFormatter();
                emp = (Employee)soap.Deserialize(fs);
                fs.Close();

                txtEmpId.Text = emp.EmpId.ToString();
                txtEmpName.Text = emp.EmpName;
                txtEmpSal.Text = emp.EmpSalary.ToString();
                MessageBox.Show("Soap Read Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillMineDoc\EmployeeXML.xml", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.EmpId = Convert.ToInt32(txtEmpId.Text);
                emp.EmpName = txtEmpName.Text;
                emp.EmpSalary = Convert.ToInt32(txtEmpSal.Text);
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
               xml.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("XML Write Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillMineDoc\EmployeeXML.xml", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                emp = (Employee)xml.Deserialize(fs);
                fs.Close();

                txtEmpId.Text = emp.EmpId.ToString();
                txtEmpName.Text = emp.EmpName;
                txtEmpSal.Text = emp.EmpSalary.ToString();
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
                FileStream fs = new FileStream(@"D:\SkillMineDoc\EmployeeJSON.json", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.EmpId = Convert.ToInt32(txtEmpId.Text);
                emp.EmpName = txtEmpName.Text;
                emp.EmpSalary = Convert.ToInt32(txtEmpSal.Text);
                JsonSerializer.Serialize<Employee>(fs, emp);
                fs.Close();
                MessageBox.Show("Json Write Done");
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
                FileStream fs = new FileStream(@"D:\SkillMineDoc\EmployeeJSON.json", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                emp = JsonSerializer.Deserialize<Employee>(fs);
                fs.Close();
                txtEmpId.Text = emp.EmpId.ToString();
                txtEmpName.Text = emp.EmpName;
                txtEmpSal.Text = emp.EmpSalary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

