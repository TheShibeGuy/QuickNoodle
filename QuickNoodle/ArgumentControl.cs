using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace QuickNoodle
{
    
    public partial class ArgumentControl : UserControl
    {
        public ArgumentControl()
        {
            InitializeComponent();
        }

        private string GetName()
        {
            return name1.Text;
        }

        private DataType GetDataType()
        {
            if(DataType1.SelectedItem == null)
            {
                return DataType.Float;
            }
            switch (DataType1.SelectedItem.ToString())
            {
                case "Float[3]":
                    return DataType.Float3;
                case "Float":
                    return DataType.Float;
                case "Int":
                    return DataType.Int;
                case "Int[3]":
                    return DataType.Int3;
                default:
                    return DataType.Float;
            }
            
        }

        private EffectedObjects GetObjectType()
        {
            switch (ObjectType1.SelectedItem.ToString())
            {
                case "All Lighting Events":
                    return EffectedObjects.AllEvents;
                case "All Notes":
                    return EffectedObjects.AllNotes;
                case "Blue Notes":
                    return EffectedObjects.BlueNotes;
                case "Bombs":
                    return EffectedObjects.Bombs;
                case "Lighting Events":
                    return EffectedObjects.Event;
                case "Red Notes":
                    return EffectedObjects.RedNotes;
                case "Walls":
                    return EffectedObjects.Walls;
                default:
                    return EffectedObjects.AllNotes;
            }

        }
        private int GetEventType()
        {
            int result;
            if(int.TryParse(eventType1.Text, out result))
            {
                return result;
            }
            else
            {
                return -1;
            }
        }
        private int GetEventValue()
        {
            int result;
            if (int.TryParse(eventValue1.Text, out result))
            {
                return result;
            }
            else
            {
                return -1;
            }
        }
        private string GetDataName()
        {
            return dataName1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ObjectType1.SelectedItem.ToString().Equals("Lighting Events"))
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
        private void nameBox1_TextChanged(object sender, EventArgs e)
        {
            name1.Text = name1.Text.Replace(" ", "");
        }
        private void dataName1_TextChanged(object sender, EventArgs e)
        {
            dataName1.Text = dataName1.Text.Replace(" ", "");
        }
        
        public int EventType { get { return GetEventType(); } set { eventType1.Text = value.ToString(); } }
        public int EventValue { get { return GetEventValue(); } set { eventValue1.Text = value.ToString(); } }
        public string ArgName { get { return name1.Text; } set { name1.Text = value; } }
        public string DataName { get { return dataName1.Text; } set { dataName1.Text = value; } }
        public EffectedObjects ObjectType { get { return EffectedObjects.FromString("All Lighting Events"); } set { ObjectType1.SelectedIndex = ObjectType1.FindString(value.Value); } }
        public DataType DataType { get { return GetDataType(); } set { DataType1.SelectedIndex = DataType1.FindString(value.Value); } }


    }
}
