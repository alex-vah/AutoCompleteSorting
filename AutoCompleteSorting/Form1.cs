using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCompleteSorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label l = new Label();
            l.Location = new Point(122, 80);
            l.Text = "Enter the text";

            this.Controls.Add(l);

            ComboBox mybox = new ComboBox();
            mybox.Location = new Point(327, 77);
            mybox.Size = new Size(216, 26);
            mybox.Items.Add("ABCD");
            mybox.Items.Add("BCDEF");
            mybox.Items.Add("GHIJK");
            mybox.Items.Add("LMNOP");
            mybox.Items.Add("QRST");            
            this.Controls.Add(mybox);

            mybox.AutoCompleteMode = AutoCompleteMode.Suggest;
            mybox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}
