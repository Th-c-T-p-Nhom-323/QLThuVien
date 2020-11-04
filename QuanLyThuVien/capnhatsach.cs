using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class capnhatsach : Form
    {
        public capnhatsach()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        private void capnhatsach_Load(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dataGridView1, "select *from tblSach");
            cls.LoadData2Combobox(cboMATG, "select MATG from tblTacGia");
            cls.LoadData2Combobox(cboMANXB, "select MANXB from tblNXB");
            cls.LoadData2Combobox(cboMALv, "select MaLv from tblLinhVuc");
            cls.LoadData2Combobox(cbotenLV, "select TenLv from tblLinhVuc");
            cls.LoadData2Combobox(cbotenTG,"Select TENTG from tblTacGia");
            cls.LoadData2Combobox(cbotenNXB,"Select TENNXB from tblNXB");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "Insert Into tblSach(MASACH,TENSACH,MATG,MANXB,MALv,NAMXB,SOTRANG,SOLUONG,NGAYNHAP,GHICHU,SOSACHHONG) values ('" + txtMASACH.Text + "','" + txtTENSACH.Text + "','" + cboMATG.Text + "','" + cboMANXB.Text + "','" + cboMALv.Text + "','" + txtNAMXB.Text + "','" + txtSOTRANG.Text + "','" + txtSOLUONG.Text + "','" + maskedTextBox1.Text + "','" + richTextBox1.Text + "','" + txtsachhong.Text + "')";
                cls.ThucThiSQLTheoPKN(strInsert);
                cls.LoadData2DataGridView(dataGridView1, "select *from tblSach");
            }
            catch { MessageBox.Show("Trùng mã"); };
        }

        int dem = 0;
        string masach;
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMASACH.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTENSACH.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboMATG.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboMANXB.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cboMALv.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtNAMXB.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSOTRANG.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtSOLUONG.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtsachhong.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                maskedTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
            catch { };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtsachhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cbotenLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboMALv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbotenTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboMATG_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbotenNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboMANXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
