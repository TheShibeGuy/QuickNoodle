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
    public partial class PresetCreator : Form
    {
        public PresetCreator()
        {
            InitializeComponent();
        }

        private void presentName_GotFocus(object sender, EventArgs e)
        {
            if (presetName.Text == "Name")
                presetName.Text = "";
        }
        private void presentName_LostFocus(object sender, EventArgs e)
        {
            if (presetName.Text == "")
                presetName.Text = "Name";
        }

        private void presetList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PresetCreator_Load(object sender, EventArgs e)
        {

        }
    }
}
