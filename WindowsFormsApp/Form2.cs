using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.DefaultExt = ".txt";
                saveFileDialog.Filter = "Text Documents(.txt) |.txt";
                saveFileDialog.FileName = "*.txt";
                DialogResult result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    streamWriter.Write(richTextBox1.Text);
                    streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog O1 = new OpenFileDialog();
                O1.DefaultExt = "txt";
                O1.Filter = "Text(*.txt) |*.txt |WordFile(*.docx) |*.docx |All File(*.*) |*.*";
                DialogResult result = O1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    StreamReader Sr = new StreamReader(O1.FileName);
                    richTextBox1.Text = Sr.ReadToEnd();
                    Sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }
    }
}
