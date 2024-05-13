using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class Frm_ShowProduct : Form
    {
        public Frm_ShowProduct()
        {
            InitializeComponent();
        }

        private void Frm_ShowProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Main objMainFrm = new Frm_Main();
            objMainFrm.Show();
        }

        private void Frm_ShowProduct_Load(object sender, EventArgs e)
        {
            try
            {

                string[] lines = File.ReadAllLines("Products.csv");
                DataTable dataTable = new DataTable();

                string[] headers = { "Name", "Price", "Count" };
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');
                    dataTable.Rows.Add(data);
                }

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
