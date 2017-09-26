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
    public partial class Editor : Form
    {
        private Person _person;
        private ListBox _lb;
        private int _position;
        public Editor(Person person, ListBox lb, int position)
        {
            InitializeComponent();
            this._person = person;
            this._lb = lb;
            this._position = position;
            Field_EditName.Text = _person.Name;
            Field_EditPCN.Text = _person.PCN.ToString();
            Field_EditAge.Text = _person.Age.ToString();
        }

        private void Btn_EditSave_Click(object sender, EventArgs e)
        {
            _person.Name = Field_EditName.Text;
            _person.PCN = Convert.ToInt32(Field_EditPCN.Text);
            _person.Age = Convert.ToInt32(Field_EditAge.Text);

            _lb.Items.RemoveAt(_position);
            _lb.Items.Insert(_position, $"{Field_EditName.Text} | {Field_EditPCN.Text} | {Field_EditAge.Text}");
            this.Dispose();
        }

        private void Btn_EditCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
