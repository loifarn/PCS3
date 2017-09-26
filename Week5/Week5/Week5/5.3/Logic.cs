using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5
{
    class Logic
    {
        private List<Person> peopleList;
        private ListBox Display;
        public Logic(ListBox display)
        {
            this.peopleList = new List<Person>();
            this.Display = display;
        }

        public void AddPerson(string name, int pcn, int age)
        {
            peopleList.Add(new Person(name, pcn, age));
            Display.Items.Add($"{name} | {pcn} | {age}");

            if (Display.Items.Count <= 1)
            {
                Display.SetSelected(0, true);
            }
            else
            {
                Display.SetSelected(Display.Items.Count - 1, true);
            }
        }

        public void EditPerson()
        {
            (new Editor(peopleList[Display.SelectedIndex], Display, Display.SelectedIndex)).Show();
        }

        public void DeletePerson()
        {
            if (Display.Items.Count > 0)
            {
                peopleList.RemoveAt(Display.SelectedIndex);
                Display.Items.Remove(Display.SelectedItem);
                Display.SetSelected(Display.Items.Count - 1, true);
            }
        }

        public void LoadFile(string filename)
        {
            Display.Items.Clear();
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs);
                string s = "";

                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    Display.Items.Add(s);
                    string[] personDetails = s.Split('|');
                    peopleList.Add(new Person(personDetails[0], Convert.ToInt32(personDetails[1]), Convert.ToInt32(personDetails[2])));
                }
            }
        }

        public void SaveFile(string filename)
        {
            if(filename != null)
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (var s in Display.Items)
                    {
                        sw.WriteLine(s.ToString());
                    }
                }
            } else
            {
                MessageBox.Show("No open files!");
            }
        }
    }
}
