using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5
{
    public partial class STE_Form : Form
    {
        private TextFileHelper tfh;
        private List<string> text;
        public STE_Form()
        {
            InitializeComponent();
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = ofd.ShowDialog();
            tfh = new TextFileHelper(ofd.FileName.ToString());
            Lbl_File.Text = $"File: {ofd.FileName}"; 

            text = tfh.LoadFromFile();
            foreach(string s in text)
            {
                RTB_Display.Text += $"{s}\n";
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            tfh.SaveToFile(new List<string>(RTB_Display.Lines));   
        }
    }
}
