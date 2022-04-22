using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        Form opener;

        public Form2(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            loadProductFromFile(file);
        }

        public void loadProductFromFile(string filepath)
        {

            string[] lines = System.IO.File.ReadAllLines(filepath);
            if (lines.Length > 0)
            {

                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');

                DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
                Name.HeaderText = headerLabels[0];
                DataGridViewTextBoxColumn Price = new DataGridViewTextBoxColumn();
                Price.HeaderText = headerLabels[1];
                DataGridViewCheckBoxColumn Select = new DataGridViewCheckBoxColumn();
                Select.HeaderText = headerLabels[2];
                DataGridViewTextBoxColumn Amount = new DataGridViewTextBoxColumn();
                Amount.HeaderText = "Amount";
                dataGridView1.Columns.Add(Name);
                dataGridView1.Columns.Add(Price);
                dataGridView1.Columns.Add(Select);
                dataGridView1.Columns.Add(Amount);


                for (int i = 1; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');
                    dataGridView1.Rows.Add(data[0], data[1], data[2]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalAll = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bool checkedCell = Convert.ToBoolean(dataGridView1.Rows[i].Cells[2].Value);
                if (checkedCell == true)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];
                    double totalS = Convert.ToDouble(row.Cells[1].Value);
                    double amount = Convert.ToDouble(row.Cells[3].Value);
                    totalS *= amount;
                    totalAll += totalS;
                    totalBox.Text = totalAll.ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(moneyBox.Text);
            double total = Convert.ToDouble(totalBox.Text);
            double change = money - total;
            if (change > 0)
            {
                Status.Text = "Sucessful";
                changeStatus.Text = " " + change.ToString();
            }
            else
            {
                Status.Text = "Sucessful";
                changeStatus.Text = "Lack of change = " + change.ToString();
            }
        }
    }
}