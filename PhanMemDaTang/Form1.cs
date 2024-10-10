using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace PhanMemDaTang
{
    public partial class Form1 : Form
    {
        MonHocBLL monHocBLL = new MonHocBLL();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.btnCreate.Click += BtnCreate_Click;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text) || string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                return;
            }

            MonHoc monHoc = new MonHoc();
            monHoc.MaMonHoc = txtMaMon.Text;
            monHoc.TenMonHoc = txtTenMon.Text;

            if (monHocBLL.Create(monHoc))
            {
                MessageBox.Show("Successfully created");
                LoadMonHocs();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void LoadMonHocs()
        {
            dgvMonHoc.DataSource = monHocBLL.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMonHocs();
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
