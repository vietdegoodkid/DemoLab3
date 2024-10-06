using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_1
{
    public partial class Form2 : Form
    {
        public string MSNV { get; set; }
        public string Ten { get; set; }
        public string Luong { get; set; }
        public Form2(string msnv, string ten, string luong)
        {
            InitializeComponent();
            MSNV = msnv;
            Ten = ten;
            Luong = luong;
            txbMSNV.Text = MSNV;
            txbTen.Text = Ten;
            txbLuong.Text = Luong;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MSNV = txbMSNV.Text;
            Ten = txbTen.Text;
            Luong = txbLuong.Text;
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
