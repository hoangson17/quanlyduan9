﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppQuanly
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        Modify modify;
        private void NhanVien_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                guna2DataGridView1.DataSource = modify.getAllNhanvien();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi"+ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }



    }
}
