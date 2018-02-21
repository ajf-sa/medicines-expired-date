using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Expire.GUI
{
   public class EListView
    {
        private ListView lsv;
        private System.Windows.Forms.ColumnHeader batch_num;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader note;
        private System.Windows.Forms.ColumnHeader me_expire;
        private System.Windows.Forms.ColumnHeader me_type;
        private System.Windows.Forms.ColumnHeader me_name;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader where;
        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public EListView(string name) {
            lsv = new ListView();
           
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.batch_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.me_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.me_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.me_expire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.where = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

            id.Text = "id";
            num.Text = "#";
            batch_num.Text = "Batch #";
            me_name.Text = "Name";
            me_type.Text = "Type";
            me_expire.Text = "Expired";
            where.Text = "Place";
            amount.Text = "Amount";
            note.Text = "Note";

            id.Width = 0;
            num.Width = 66;
            batch_num.Width = 66;
            me_name.Width = 175;
            me_type.Width = 95;
            me_expire.Width = 83;
            where.Width = 69;
            amount.Width = 72;
             note.Width =188;
            this.lsv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.num,
            this.batch_num,
            this.me_name,
            this.me_type,
            this.me_expire,
            this.where,
            this.amount,
            this.note});
            this.lsv.FullRowSelect = true;
            this.lsv.GridLines = true;
            this.lsv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsv.HideSelection = false;
            this.lsv.Name ="lsv_"+name;
            this.lsv.ShowGroups = false;
          
            this.lsv.ShowItemToolTips = true;
            this.lsv.TabStop = false;

            this.lsv.Dock = DockStyle.None;
            this.lsv.LabelWrap = false;
            this.lsv.Size = new System.Drawing.Size(1877, 789);
           
            this.lsv.Font = new System.Drawing.Font("Times New Roman", 12.0f);
           
            this.lsv.UseCompatibleStateImageBehavior = false;
            this.lsv.View = System.Windows.Forms.View.Details;
            this.lsv.Click += Lsv_Click;
            listitem();
        }

        private void Lsv_Click(object sender, EventArgs e)
        {
            ListView d = (ListView)sender;
            MessageBox.Show(d.Name);
        }
        public void listitem() {
            ListViewItem l = new ListViewItem("x");
            l.SubItems.Add("x");
            lsv.Items.Add(l);
        }
        public ListView GetListView { get { return lsv; } }
        public ListView GetList() {

            return lsv;
        }

    }
}
