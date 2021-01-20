using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickNoodle
{
    public partial class ArguimentEditor : Form
    {
        public ArguimentEditor()
        {
            InitializeComponent();
        }

        private void nameBox1_TextChanged(object sender, EventArgs e)
        {
            name1.Text = name1.Text.Replace(" ", "");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(ObjectType1.SelectedItem.ToString().Equals("Lighting Events"))
            {
                eventTypeLabel1.Visible = true;
                EventValueLabel1.Visible = true;
                eventType1.Visible = true;
                eventValue1.Visible = true;
            }
            else
            {
                eventTypeLabel1.Visible = false;
                EventValueLabel1.Visible = false;
                eventType1.Visible = false;
                eventValue1.Visible = false;
            }
        }
    }
}
