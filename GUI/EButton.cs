using System;
using System.Collections.Generic;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Expire.GUI
{
   
  public  class EButton
    {
        Button b;
        private string name;
        private string text;
        public EButton() {
            b = new Button();
        }
        public Button Get() {
          
            return b;
        }
        public string Name { set { b.Name = value; } get { return name; } }
        public string Text { set { b.Text = value; }get { return text; } }
        public Point SetLocation(int x, int y) {

            return new Point(x, y);
        }

        public Size SetSize(int width, int height) {

            return new Size(width, height);
        }

        public void SetVSize(int width,int height) {

            b.Size = SetSize(width,height);

        }
        public void SetVLocation(int x, int y) {
            b.Location = SetLocation(x,y);
        }

        public void UseStyle()
        {

            b.UseVisualStyleBackColor = true;
        }

    }
}
