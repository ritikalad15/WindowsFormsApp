using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnBinaryWriter_Click(object sender, EventArgs e)
        {
            try 
            {
                FileStream fs = new FileStream(@"D:\SkillMineDoc\Dept.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtId.Text));
                bw.Write(txtName.Text);
                bw.Write(txtLoc.Text);
                bw.Close();
                fs.Close();
                MessageBox.Show("Data saved Sucessfully..");
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnBinaryReader_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillMineDoc\Dept.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtId.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtLoc.Text = br.ReadString();
                br.Close();
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
