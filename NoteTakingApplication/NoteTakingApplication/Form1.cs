using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApplication
{
    public partial class NoteTaker : Form
    {
        DataTable table;

        public NoteTaker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable(); //instantiate table
            table.Columns.Add("Title", typeof(String)); //adding tables called title
            table.Columns.Add("Messages", typeof(String)); //adding tables called message

            dataGridView1.DataSource = table; //connects the datagridview to table

            dataGridView1.Columns["Messages"].Visible = false; //makes 'messages' column hidden
            dataGridView1.Columns["Title"].Width = 220; //sets the width for aesthetics
        }

        //everything down here adds functions to buttons

        private void bttNew_Click(object sender, EventArgs e)
        {
            textTitle.Clear();
            textMessage.Clear();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textTitle.Text, textMessage.Text); //adds what is in the title and message to 'table'

            textTitle.Clear();
            textMessage.Clear();
        }

        private void bttRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;  // selects the highlighted row on the table

            textTitle.Text = table.Rows[index].ItemArray[0].ToString(); //transfers the data to the specific column in the table
            textMessage.Text = table.Rows[index].ItemArray[1].ToString(); //transfers the data to the specific column in the table
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}
