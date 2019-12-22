using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_LHP_dotNetEF
{
    public partial class Form2 : Form
    {

        SinhVien DBsinhvien = new SinhVien();
        QSLV_LHPEntities sqlv = new QSLV_LHPEntities();
        public Form2()
        {
            InitializeComponent();

        }
        public String MaSinhVien;
        public String HoDem;
        public String Ten;
        public String NgaySinh;
        public String QueQuan;

        public String MaLopHocPhan;
        void LoadDB()
        {
            txtMaSinhVien.Text = MaSinhVien;
            txtHoDem.Text = HoDem;
            txtTen.Text = Ten;
            txtNgaySinh.Text = NgaySinh;
            txtQueQuan.Text = QueQuan;
            txtMaLopHocPhan.Text = MaLopHocPhan;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DBsinhvien.MaSinhVien = txtMaSinhVien.Text.Trim();
            DBsinhvien.HoDem = txtHoDem.Text.Trim();
            DBsinhvien.Ten = txtTen.Text.Trim();
            DBsinhvien.NgaySinh = Convert.ToDateTime(txtNgaySinh.Text.Trim());
            DBsinhvien.QueQuan = txtQueQuan.Text.Trim();
            DBsinhvien.MaLopHocPhan = txtMaLopHocPhan.Text.Trim();

            using (QSLV_LHPEntities sqlv = new QSLV_LHPEntities())
            {
                //tự động lưu tất cả các thây đổi
                sqlv.Entry(DBsinhvien).State = EntityState.Modified;
                sqlv.SaveChanges();
            }
            MessageBox.Show("update thành công");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBsinhvien.MaSinhVien = txtMaSinhVien.Text.Trim();
            DBsinhvien.NgaySinh =Convert.ToDateTime(txtNgaySinh.Text.Trim());
            DBsinhvien.HoDem = txtHoDem.Text.Trim();
            DBsinhvien.Ten = txtTen.Text.Trim();
            DBsinhvien.QueQuan = txtTen.Text.Trim();
            using (QSLV_LHPEntities sqlv = new QSLV_LHPEntities())
            {
                sqlv.SinhViens.Add(DBsinhvien);
                sqlv.SaveChanges();
            }
          
            MessageBox.Show("Thêm thành công");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHoDem.Text = txtMaLopHocPhan.Text = txtMaSinhVien.Text = txtNgaySinh.Text = txtQueQuan.Text = txtTen.Text = "";
        }
    }
}
