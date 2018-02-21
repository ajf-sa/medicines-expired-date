using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Expire.Control
{
    class TabPagesTest
    {
        public TabPagesTest() { }
        public TabPage GetTab(string name) {

            var tabpage = new TabPage();
            tabpage.SuspendLayout();
            tabpage.Name = name;
            tabpage.Location = new System.Drawing.Point(4, 23);
            tabpage.Size = new System.Drawing.Size(376, 255);
            tabpage.Text = name + 1;
           
            tabpage.UseVisualStyleBackColor = true;
            return tabpage;
        }
      
    }
}
