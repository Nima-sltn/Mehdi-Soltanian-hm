using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            Frm_AddProduct objAddPrdFrm = new Frm_AddProduct();
            this.Hide();
            objAddPrdFrm.Show();
        }

        private void btn_ShowProduct_Click(object sender, EventArgs e)
        {
            Frm_ShowProduct objShowPrdFrm = new Frm_ShowProduct();
            this.Hide();
            objShowPrdFrm.Show();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            Frm_AddUser objAddUserFrm =new Frm_AddUser();
            this.Hide();
            objAddUserFrm.Show();
        }

        private void btn_ShowUser_Click(object sender, EventArgs e)
        {
            Frm_ShowUser objShowUserFrm = new Frm_ShowUser();
            this.Hide();
            objShowUserFrm.Show();
        }

        private void Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
