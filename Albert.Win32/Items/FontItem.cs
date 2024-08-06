using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Albert.Win32.Items
{
    /// <summary>
    /// This class is used to store FontFamily in an itmes type list.
    /// </summary>
    public sealed class FontItem: Item
    {
        public FontItem(string _name)
        {
            Name = _name;
            FontFamily = new FontFamily(_name);
        }

        
        public FontFamily FontFamily {get;init;}

        public override string ToString()
        {
            return Name!;
        }
    }
}
