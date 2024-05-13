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
    public partial class Frm_AddUser : Form
    {
        public Frm_AddUser()
        {
            InitializeComponent();
        }

        private void Frm_AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Main objMainFrm = new Frm_Main();
            objMainFrm.Show();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txt_Name.Text.Trim();
                string address = txt_Address.Text;
                string phoneNumber = txt_PhoneNum.Text;
                string line = $"{name}, {phoneNumber}, {address}\n";
                File.AppendAllText("Users.csv", line);

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
