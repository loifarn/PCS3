using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5
{
    class TextFileHelper
    {

        private string FileName;

        public TextFileHelper(string fileName)
        {
            this.FileName = fileName;
        }

        public TextFileHelper()
        {

        }

        public void SaveToFile(List<string> lines)
        {

            using (StreamWriter sw = new StreamWriter(FileName))
            {
                foreach(string s in lines)
                {
                    sw.WriteLine(s);
                }
            }

        }

        public List<string> LoadFromFile()
        {
            MessageBox.Show($"Current file{FileName}");
            FileStream fs = null;
            StreamReader sr = null;
            List<string> list = new List<string>();
            try
            {
                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string s = "";
                while(s != null)
                {
                    s = sr.ReadLine();
                    list.Add(s);
                }
            }
            catch(IOException e)
            {
                MessageBox.Show("Error Reading file");
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
            return list;
        }
    }
}
