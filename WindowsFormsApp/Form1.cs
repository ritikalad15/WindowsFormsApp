using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtEmpId.Text+" "+txtEmpName.Text+" "+txtEmpsal.Text+" "+txtTotalsal.Text);
           // MessageBox.Show(txtEmpName.Text);
           // MessageBox.Show(txtEmpsal.Text);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpId.Clear();
            txtEmpName.Clear();
            txtEmpsal.Clear();
            txtHRA.Clear();
            txtTA.Clear();
            txtDA.Clear();
            txtPF.Clear();
            txtTotalsal.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deleted Successfully");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Salary = Convert.ToDouble(txtEmpsal.Text);
            double HRA= Salary*0.15;
            double DA = Salary * 0.12;
            double TA = Salary * 0.17;
            double PF = Salary * 0.1;
            double TotalSalary = (Salary + HRA + DA + TA) - PF;
            txtHRA.Text = HRA.ToString();
            txtDA.Text = DA.ToString();
            txtTA.Text = TA.ToString();
            txtPF.Text = PF.ToString();
            txtTotalsal.Text = TotalSalary.ToString();
        }

        
    }
}
