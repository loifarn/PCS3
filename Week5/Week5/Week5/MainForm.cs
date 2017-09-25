﻿using System;
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
    public partial class MainForm : Form
    {
        private TextFileHelper tfh;
        private List<string> text;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            tfh = new TextFileHelper(ofd.FileName.ToString());

            text = tfh.LoadFromFile();
            foreach(string s in text)
            {
                RTB_Display.Text += $"{s}\n";
            }


        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            /*
            foreach(string s in RTB_Display.Lines)
            {
                MessageBox.Show(s);
            }*/
            tfh.SaveToFile(new List<string>(RTB_Display.Lines));

            
        }
    }
}