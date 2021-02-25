using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace QuickNoodle
{
    class BookmarkProperty
    {
        
        private dynamic property;
        private DataType type;

        public dynamic Property { get { return property; } set { property = value; } }
        public DataType propertyType { get { return type; } }

        public BookmarkProperty( dynamic property, DataType type)
        {
            this.property = property;
            this.type = type;
        }

    }
}
