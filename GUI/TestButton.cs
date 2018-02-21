using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Expire.GUI
{
  public  class TestButton
    {
        public System.Windows.Forms.Button button1;
        public TestButton() { }

        public Button GetButton(string name , string text) {

            this.button1 = new System.Windows.Forms.Button();
            // 
            // button1
            // 
           
            this.button1.Name =name+1;
            this.button1.Text = text;

            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += Button1_Click;


            return button1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            System.Windows.Forms.MessageBox.Show(b.Name);
        }
    }
}
