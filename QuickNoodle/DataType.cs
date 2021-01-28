using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickNoodle
{
    public class DataType
    {
        private DataType(string value) { Value = value; }

        public string Value { get; set; }

        public static DataType Float { get { return new DataType("Float"); } }
        public static DataType Float3 { get { return new DataType("Float[3]"); } }

        public static DataType Int { get { return new DataType("Int"); } }
        public static DataType Int3 { get { return new DataType("Int[3]"); } }

        public static DataType FromString(string input)
        {
            return new DataType(input);
        }

       
    }
    public class EffectedObjects
    {
        private EffectedObjects(string value) { Value = value; }
        public string Value { get; set; }

        public static EffectedObjects AllEvents { get { return new EffectedObjects("All Lighting Events"); } }
        public static EffectedObjects Event { get { return new EffectedObjects("Lighting Events"); } }

        public static EffectedObjects AllNotes { get { return new EffectedObjects("All Notes"); } }
        public static EffectedObjects RedNotes { get { return new EffectedObjects("Red Notes"); } }
        public static EffectedObjects BlueNotes { get { return new EffectedObjects("Blue Notes"); } }

        public static EffectedObjects Walls { get { return new EffectedObjects("Walls"); } }

        public static EffectedObjects AllNoteObjects { get { return new EffectedObjects("All Note Objects"); } }
        public static EffectedObjects AllObjects { get { return new EffectedObjects("All Objects"); } }

        public static EffectedObjects Bombs { get { return new EffectedObjects("All Lighting Events"); } }


        public static EffectedObjects FromString(string input)
        {
            return new EffectedObjects(input);
        }
    }
}
