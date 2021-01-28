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
    public partial class ArgumentEditor : Form
    {
        LinkedList<ArgumentControl> args = new LinkedList<ArgumentControl>();
        public ArgumentEditor()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ArgumentControl arg = new ArgumentControl();
            arg.ArgName = "defaultArgName";
            arg.BorderStyle = BorderStyle.FixedSingle;
            arg.DataName = "_defaultCustomData";
            arg.DataType = DataType.Float;
            arg.ObjectType = EffectedObjects.AllNotes;
            arg.EventType = -1;
            arg.EventValue = -1;
            arg.Location = new Point(12, args.Last.Value.Location.Y + 123);
            arg.Size = new Size(284, 116);

            this.Controls.Add(arg);
            add.Location = new Point(add.Location.X, add.Location.Y + 123);
            args.AddLast(arg);
        }

        public LinkedList<ArgumentControl> Arguments { get { return args;} }

         
    }
}
