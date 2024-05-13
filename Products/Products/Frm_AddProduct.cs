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
    public partial class Frm_AddProduct : Form
    {
        
        public Frm_AddProduct()
        {
            InitializeComponent();
        }

        private void Frm_AddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Main objMainFrm=new Frm_Main();
            objMainFrm.Show();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!File.Exists("Products.csv"))
                {
                    var fl=File.Create("Products.csv");
                    fl.Close();
                }
                
                string name = txt_Name.Text.Trim();
                string price = txt_Price.Text;
                string count = txt_Count.Text;
                string line = $"{name}, {price}, {count}\n";
                File.AppendAllText("Products.csv", line);

                MessageBox.Show("Successfully Added");

                foreach (var item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
