using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QuickNoodle
{
    public struct Bookmark
    {
        Dictionary<string, BookmarkProperty> tags;

        
        public Bookmark(object obj)
        {

            tags = new Dictionary<string, BookmarkProperty>();
        }
        

        


    }
}
