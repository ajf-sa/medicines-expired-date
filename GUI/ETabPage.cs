using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Expire.GUI
{
    class ETabPage
    {
        private TabPage tabpage;
        private string name;
        public string Name {get{ return name; }set{ name = value; } }
        private string text;
        public string Text { get { return text; } set { text = value; } }
        public ETabPage() {
            tabpage = new TabPage();
        }
        
        public TabPage GetTabPage() {
            tabpage.Name = this.Name;
            tabpage.Text = this.Text;
            tabpage.SuspendLayout();
            tabpage.AutoScroll = true;
            tabpage.UseVisualStyleBackColor = true;
            
          //  AddToTabPage(new TestButton().GetButton("b_" + this.Name, "click"));
      

            return tabpage;
        }

        public void AddToTabPage(System.Windows.Forms.Control control) {

            tabpage.Controls.Add(control);
        }

    }
}
