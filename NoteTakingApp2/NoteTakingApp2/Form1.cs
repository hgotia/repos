using System;
using System.Data;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace NoteTakingApp2
{
    public partial class Form1 : Form
    {
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("Title");
            table.Columns.Add("Message");

            dataGridView.DataSource = table;

            dataGridView.Columns["Message"].Visible = false;
            dataGridView.Columns["Title"].Width = 210;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.TextLength != 0 || txtMessage.TextLength != 0)
            {
                table.Rows.Add(txtTitle.Text, txtMessage.Text);
            }

            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0)
            {
                int index = dataGridView.CurrentCell.RowIndex;

                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0)
            {
                int index = dataGridView.CurrentCell.RowIndex;

                if (index > -1)
                    table.Rows[index].Delete();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0)
            {
                int index = dataGridView.CurrentCell.RowIndex;

                string folderName = @"C:\Users\TIM ASUS\Desktop\C#_practice\";
                string fileName = table.Rows[index].ItemArray[0].ToString();
                string pathString = Path.Combine(folderName, fileName + ".txt");

                StreamWriter sw = new StreamWriter(pathString);

                sw.WriteLine(table.Rows[index].ItemArray[0].ToString());
                sw.WriteLine("");
                sw.WriteLine(table.Rows[index].ItemArray[1].ToString());

                sw.Close();
                MessageBox.Show("File Exported.");


            }
        }
    }
}
