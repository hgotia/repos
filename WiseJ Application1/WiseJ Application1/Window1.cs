
using System;
using Wisej.Web;

namespace WiseJ_Application1
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // parse the selected alignment and default to TopCenter
            // if the selection in the combo is not a valid ContentAlignment.
            DataGridViewContentAlignment alignment = DataGridViewContentAlignment.TopCenter;
            if (!Enum.TryParse(this.comboBox1.Text, out alignment))
                alignment = DataGridViewContentAlignment.TopCenter;

            // Hello World!            
            AlertBox.Show("Hello World to you!",
                          alignment: (System.Drawing.ContentAlignment)alignment);
        }

        private void Window1_Load(object sender, EventArgs e)
        {
            //load the enumeration in the combobox.
            comboBox1.Items.AddRange(Enum.GetNames(typeof(DataGridViewContentAlignment)));
        }
    }
}
