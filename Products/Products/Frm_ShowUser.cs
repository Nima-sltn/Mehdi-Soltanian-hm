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
    public partial class Frm_ShowUser : Form
    {
        public Frm_ShowUser()
        {
            InitializeComponent();
        }

        private void Frm_ShowUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Main objMainFrm = new Frm_Main();
            objMainFrm.Show();
        }

        private void Frm_ShowUser_Load(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines("Users.csv");
            DataTable dataTable = new DataTable();

            string[] headers = {"Name","PhoneNumber","Address"};
            foreach (string header in headers) 
            { 
            dataTable.Columns.Add(header);
            }

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                dataTable.Rows.Add(data);
            }

            dataGridView1.DataSource=dataTable;
        }
    }
}
