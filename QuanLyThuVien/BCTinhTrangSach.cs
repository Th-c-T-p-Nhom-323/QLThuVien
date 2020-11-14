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
    public partial class BCTinhTrangSach : Form
    {
        public BCTinhTrangSach()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        private void BCTinhTrangSach_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton3.Checked)
            {
                cls.LoadData2DataGridView(dataGridView2, "select a.MASACH,TENSACH, COUNT(*) as SoLanMuon from tblMuon a inner join tblSach b on a.MASACH=b.MASACH group by a.MASACH,TENSACH ");
            }
            if (radioButton4.Checked)
            {
                cls.LoadData2DataGridView(dataGridView2, "select * from tblSach where MASACH not in (select MASACH from tblMuon)");
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
