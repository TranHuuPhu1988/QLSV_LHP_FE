using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ComboBox = System.Windows.Controls.ComboBox;

namespace QLSV_LHP_dotNetEF
{
    public partial class Form1 : Form
    {
        SinhVien DBsinhvien = new SinhVien();
        LopHocPhan DBlophocphan = new LopHocPhan();
        DanhSachMonHoc DBdsMonHoc = new DanhSachMonHoc();
        QSLV_LHPEntities sqlv = new QSLV_LHPEntities();
        public ComboBox Sender { get; private set; }

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGV_LopHocPhan();
            LoadDataDV_SinhVien();
        }

        void LoadDataGV_LopHocPhan()
        {
            dtgvLopHocPhan.AutoGenerateColumns = false;
            using(QSLV_LHPEntities sqlv = new QSLV_LHPEntities())
            {
                dtgvLopHocPhan.DataSource = sqlv.LopHocPhans.ToList<LopHocPhan>();
            }
          

        }

        void LoadDataDV_SinhVien()
        {
            dtgvSanhSachSV.AutoGenerateColumns = false;
            using (QSLV_LHPEntities sqlv = new QSLV_LHPEntities())
            {
                dtgvSanhSachSV.DataSource = sqlv.SinhViens.ToList<SinhVien>();
            }
        }
        private void dtgvSanhSachSV_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvSanhSachSV.CurrentRow.Index != -1)
            {
                DBsinhvien.MaSinhVien = Convert.ToString(dtgvSanhSachSV.CurrentRow.Cells["MaSinhVien"].Value);
                
                using (QSLV_LHPEntities sqlv = new QSLV_LHPEntities())
                {
                    DBsinhvien = sqlv.SinhViens.Where(x => x.MaSinhVien == DBsinhvien.MaSinhVien).FirstOrDefault();                }

            }
        }

        private void dtgvLopHocPhan_DoubleClick(object sender, EventArgs e)
        {
            if(dtgvLopHocPhan.CurrentRow.Index != -1)
            {
                DBlophocphan.MaLopHocPhan = Convert.ToString(dtgvLopHocPhan.CurrentRow.Cells["MaLopHocPhan"].Value);
                using (QSLV_LHPEntities sqlv = new QSLV_LHPEntities())
                {
                    DBlophocphan = sqlv.LopHocPhans.Where(x => x.MaLopHocPhan == DBlophocphan.MaLopHocPhan).FirstOrDefault();

                    txtDinhMucSinhVien.Text = Convert.ToString(DBlophocphan.DinhMucSinhVien);
                    txtGiaoVienPhuTrach.Text = DBlophocphan.GiaoVienPhuTrach;
                    txtMaLopHocPhan.Text = DBlophocphan.MaLopHocPhan;
                    txtSoLuongSinhVienDk.Text = Convert.ToString(DBlophocphan.SoLuongSinhVienDangKy);
                    txtTenLHP.Text = DBlophocphan.TenLopHocPhan;
                }
                string mhp = DBlophocphan.MaLopHocPhan;
                using (QSLV_LHPEntities sqlv = new QSLV_LHPEntities())
                {
                    var tbl = from c in sqlv.SinhViens
                              where c.MaLopHocPhan == mhp
                              select c;

                    dtgvSanhSachSV.DataSource = tbl.ToList();

                }

            }
        }


        private void tsXoaLopHocPhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa không ?", "XÓA", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (QSLV_LHPEntities sqlv = new QSLV_LHPEntities())
                {
                    var entry = sqlv.Entry(DBlophocphan);

                    if (entry.State == EntityState.Detached)
                    {
                        sqlv.LopHocPhans.Attach(DBlophocphan);
                    }
                    sqlv.LopHocPhans.Remove(DBlophocphan);
                    sqlv.SaveChanges();
                    LoadDataGV_LopHocPhan();
                    MessageBox.Show("xóa thành công");
                }

            }

        }

        private void tsSuaLopHocPhan_Click(object sender, EventArgs e)
        {
            DBlophocphan.MaLopHocPhan = txtMaLopHocPhan.Text.Trim();
            DBlophocphan.SoLuongSinhVienDangKy = Convert.ToInt32(txtSoLuongSinhVienDk.Text.Trim());
            DBlophocphan.GiaoVienPhuTrach = txtGiaoVienPhuTrach.Text.Trim();
            DBlophocphan.DinhMucSinhVien = Convert.ToInt32(txtDinhMucSinhVien.Text.Trim());
            DBlophocphan.TenLopHocPhan = txtTenLHP.Text.Trim();
            using (QSLV_LHPEntities sqlv = new QSLV_LHPEntities())
            {
                //tự động lưu tất cả các thây đổi
                sqlv.Entry(DBlophocphan).State = EntityState.Modified;
                sqlv.SaveChanges();
            }

            LoadDataGV_LopHocPhan();
            MessageBox.Show("update thành công");

        }

        private void tsThemHocPhan_Click(object sender, EventArgs e)
        {
            DBlophocphan.TenLopHocPhan = txtTenLHP.Text.Trim();
            DBlophocphan.DinhMucSinhVien = Convert.ToInt32(txtDinhMucSinhVien.Text.Trim());
            DBlophocphan.GiaoVienPhuTrach = txtGiaoVienPhuTrach.Text.Trim();
            DBlophocphan.MaLopHocPhan = txtMaLopHocPhan.Text.Trim();
            DBlophocphan.SoLuongSinhVienDangKy = Convert.ToInt32(txtSoLuongSinhVienDk.Text.Trim());

        

            using (QSLV_LHPEntities sqlv = new QSLV_LHPEntities())
            {
                foreach (LopHocPhan l in sqlv.LopHocPhans)
                {
                    if(l.MaLopHocPhan == txtMaLopHocPhan.Text.Trim())
                    {
                        MessageBox.Show("Không được thêm trùng mã");
                        return;
                    }

                }
                sqlv.LopHocPhans.Add(DBlophocphan);
                sqlv.SaveChanges();

            }
            LoadDataGV_LopHocPhan();
            MessageBox.Show("Thêm thành công");

        }

        private void tsXoaSinhVien_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa không ?", "XÓA", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (QSLV_LHPEntities sqlv = new QSLV_LHPEntities())
                {
                    var entry = sqlv.Entry(DBsinhvien);

                    if (entry.State == EntityState.Detached)
                    {
                        sqlv.SinhViens.Attach(DBsinhvien);
                    }
                    sqlv.SinhViens.Remove(DBsinhvien);
                    sqlv.SaveChanges();
                    LoadDataDV_SinhVien();
                    MessageBox.Show("xóa thành công");
                }

            }

        }

        private void tsRefrest_Click(object sender, EventArgs e)
        {
            LoadDataDV_SinhVien();
        }

        private void tsSua_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            if (dtgvSanhSachSV.CurrentRow.Index != -1)
            {
                DBsinhvien.MaSinhVien = Convert.ToString(dtgvSanhSachSV.CurrentRow.Cells["MaSinhVien"].Value);
                using (QSLV_LHPEntities sqlv = new QSLV_LHPEntities())
                {
                    DBsinhvien = sqlv.SinhViens.Where(x => x.MaSinhVien == DBsinhvien.MaSinhVien).FirstOrDefault();

                    f.MaSinhVien = DBsinhvien.MaSinhVien;
                    f.HoDem = DBsinhvien.HoDem;
                    f.Ten = DBsinhvien.Ten;
                    f.NgaySinh = Convert.ToString(DBsinhvien.NgaySinh);
                    f.QueQuan = DBsinhvien.QueQuan;
                    f.MaLopHocPhan = DBsinhvien.MaLopHocPhan;
                }

            }

            f.Show();
            LoadDataDV_SinhVien();
            sqlv.SaveChanges();
        }
        private void cbxMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = cbxMonHoc.Text;
            Console.WriteLine("ssssss", s);

        }

        private void cbxMonHoc_Click_1(object sender, EventArgs e)
        {
            using (QSLV_LHPEntities sqlv = new QSLV_LHPEntities())
            {
                cbxMonHoc.DataSource = sqlv.DanhSachMonHocs.ToList();
                cbxMonHoc.ValueMember = "TenMonHoc";
                cbxMonHoc.DisplayMember = "MaMonHoc";
            }
        }

        private void cbxMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            string s = cbxMonHoc.Text;
            using (QSLV_LHPEntities sqlv = new QSLV_LHPEntities())
            {
                var tbl = from c in sqlv.LopHocPhans
                          where c.MaMonHoc == s
                          select c;

                dtgvLopHocPhan.DataSource = tbl.ToList();

            }

        }
    }
}
