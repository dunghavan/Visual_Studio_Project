using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HienThi_BaoCao_AnUong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox_SapXep.SelectedItem = "--- default ---";
        }
        SqlConnection conn = new SqlConnection("Data Source=REUS;Initial Catalog=QLNT;Integrated Security=True");
        SqlDataReader reader;
        DataTable dt;
        // Declare Parameters:
        static SqlCommand sqlcmd;
        SqlParameter _ma_BC, _ten_BC, _ma_Tre, _ten_Tre, _ngay, _tinh_Trang_An, _tinh_Trang_Ngu, _tinh_Trang_VuiChoi,
                    _ma_NV, _ngay_Tao, _sort_by;

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string maBC, tenBC, maTre, tenTre, ngay, ttAn, ttNgu, ttVuiChoi, maNV, ngayTao, ghiChu;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            maBC = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tenBC = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            maTre = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tenTre = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ngay = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ttAn = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            ttNgu = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            ttVuiChoi = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            maNV = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            ngayTao = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            ghiChu = dataGridView1.CurrentRow.Cells[10].Value.ToString();

        }
        private void button_NhapLaiTatCa_Click(object sender, EventArgs e)
        {
            comboBox_SapXep.SelectedItem = "--- default ---";
            textBox_MaBC.Text = null;
            textBox_TenBC.Text = null;
            textBox_MaTre.Text = null;
            textBox_HoTen.Text = null;
            textBox_BaoCaoNgay.Text = null;
            textBox_TT_An.Text = null;
            textBox_TT_Ngu.Text = null;
            textBox_TT_VuiChoi.Text = null;
            textBox_Ngay_Tao.Text = null;
            textBox_Ma_Nguoi_Tao.Text = null;
        }

        //internal Form2 f;
        private void button_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 f = new Form2(this);
                f.ShowDialog(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        
        private void button_TimKiem_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                dt = new DataTable();
                switch (comboBox_SapXep.SelectedItem.ToString())
                {
                    case "--- default ---":
                        sqlcmd = new SqlCommand("BaoCao_An_Ngu_Search", conn);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        // Construction Parameters:
                        _ma_BC = sqlcmd.Parameters.Add("@p_MA_BC", SqlDbType.NVarChar, 10);
                        _ten_BC = sqlcmd.Parameters.Add("@p_TEN_BC", SqlDbType.NVarChar, 10);
                        _ma_Tre = sqlcmd.Parameters.Add("@p_MA_TRE", SqlDbType.NVarChar, 10);
                        _ten_Tre = sqlcmd.Parameters.Add("@p_TEN_TRE", SqlDbType.NVarChar, 30);
                        _ngay = sqlcmd.Parameters.Add("@p_NGAY", SqlDbType.NVarChar, 30);
                        _tinh_Trang_An = sqlcmd.Parameters.Add("@p_TINHTRANG_AN", SqlDbType.NVarChar, 100);
                        _tinh_Trang_Ngu = sqlcmd.Parameters.Add("@p_TINHTRANG_NGU", SqlDbType.NVarChar, 100);
                        _tinh_Trang_VuiChoi = sqlcmd.Parameters.Add("@p_TINHTRANG_VUICHOI", SqlDbType.NVarChar, 10);
                        _ma_NV = sqlcmd.Parameters.Add("@p_MA_NV", SqlDbType.NVarChar, 10);
                        _ngay_Tao = sqlcmd.Parameters.Add("@p_NGAY_TAO", SqlDbType.NVarChar, 30);
                        // Transmitted value to Parameter:
                        _ma_BC.Value = textBox_MaBC.Text;
                        _ten_BC.Value = textBox_TenBC.Text;
                        _ma_Tre.Value = textBox_MaTre.Text;
                        _ten_Tre.Value = textBox_HoTen.Text;
                        _ngay.Value = textBox_BaoCaoNgay.Text.ToString();
                        _tinh_Trang_An.Value = textBox_TT_An.Text;
                        _tinh_Trang_Ngu.Value = textBox_TT_Ngu.Text;
                        _tinh_Trang_VuiChoi.Value = textBox_TT_VuiChoi.Text;
                        _ma_NV.Value = textBox_Ma_NV.Text;
                        _ngay_Tao.Value = textBox_Ngay_Tao.Text.ToString();
                        reader = sqlcmd.ExecuteReader();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                        break;
                    case "Họ tên       A -> Z":
                        sqlcmd = new SqlCommand("BaoCao_An_Ngu_Sort_by_Name", conn);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        // Construction Parameters:
                        _ma_BC = sqlcmd.Parameters.Add("@p_MA_BC", SqlDbType.NVarChar, 10);
                        _ten_BC = sqlcmd.Parameters.Add("@p_TEN_BC", SqlDbType.NVarChar, 10);
                        _ma_Tre = sqlcmd.Parameters.Add("@p_MA_TRE", SqlDbType.NVarChar, 10);
                        _ten_Tre = sqlcmd.Parameters.Add("@p_TEN_TRE", SqlDbType.NVarChar, 30);
                        _ngay = sqlcmd.Parameters.Add("@p_NGAY", SqlDbType.NVarChar, 30);
                        _tinh_Trang_An = sqlcmd.Parameters.Add("@p_TINHTRANG_AN", SqlDbType.NVarChar, 100);
                        _tinh_Trang_Ngu = sqlcmd.Parameters.Add("@p_TINHTRANG_NGU", SqlDbType.NVarChar, 100);
                        _tinh_Trang_VuiChoi = sqlcmd.Parameters.Add("@p_TINHTRANG_VUICHOI", SqlDbType.NVarChar, 10);
                        _ma_NV = sqlcmd.Parameters.Add("@p_MA_NV", SqlDbType.NVarChar, 10);
                        _ngay_Tao = sqlcmd.Parameters.Add("@p_NGAY_TAO", SqlDbType.NVarChar, 30);
                        _sort_by = sqlcmd.Parameters.Add("@p_SORT_BY", SqlDbType.Int);
                        // Transmitted value to Parameter:
                        _ma_BC.Value = textBox_MaBC.Text;
                        _ten_BC.Value = textBox_TenBC.Text;
                        _ma_Tre.Value = textBox_MaTre.Text;
                        _ten_Tre.Value = textBox_HoTen.Text;
                        _ngay.Value = textBox_BaoCaoNgay.Text.ToString();
                        _tinh_Trang_An.Value = textBox_TT_An.Text;
                        _tinh_Trang_Ngu.Value = textBox_TT_Ngu.Text;
                        _tinh_Trang_VuiChoi.Value = textBox_TT_VuiChoi.Text;
                        _ma_NV.Value = textBox_Ma_NV.Text;
                        _ngay_Tao.Value = textBox_Ngay_Tao.Text.ToString();
                        _sort_by.Value = 0;
                        reader = sqlcmd.ExecuteReader();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                        break;
                    case "Họ tên       Z -> A":
                        sqlcmd = new SqlCommand("BaoCao_An_Ngu_Sort_by_Name", conn);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        // Construction Parameters:
                        _ma_BC = sqlcmd.Parameters.Add("@p_MA_BC", SqlDbType.NVarChar, 10);
                        _ten_BC = sqlcmd.Parameters.Add("@p_TEN_BC", SqlDbType.NVarChar, 10);
                        _ma_Tre = sqlcmd.Parameters.Add("@p_MA_TRE", SqlDbType.NVarChar, 10);
                        _ten_Tre = sqlcmd.Parameters.Add("@p_TEN_TRE", SqlDbType.NVarChar, 30);
                        _ngay = sqlcmd.Parameters.Add("@p_NGAY", SqlDbType.NVarChar, 30);
                        _tinh_Trang_An = sqlcmd.Parameters.Add("@p_TINHTRANG_AN", SqlDbType.NVarChar, 100);
                        _tinh_Trang_Ngu = sqlcmd.Parameters.Add("@p_TINHTRANG_NGU", SqlDbType.NVarChar, 100);
                        _tinh_Trang_VuiChoi = sqlcmd.Parameters.Add("@p_TINHTRANG_VUICHOI", SqlDbType.NVarChar, 10);
                        _ma_NV = sqlcmd.Parameters.Add("@p_MA_NV", SqlDbType.NVarChar, 10);
                        _ngay_Tao = sqlcmd.Parameters.Add("@p_NGAY_TAO", SqlDbType.NVarChar, 30);
                        _sort_by = sqlcmd.Parameters.Add("@p_SORT_BY", SqlDbType.Int);
                        // Transmitted value to Parameter:
                        _ma_BC.Value = textBox_MaBC.Text;
                        _ten_BC.Value = textBox_TenBC.Text;
                        _ma_Tre.Value = textBox_MaTre.Text;
                        _ten_Tre.Value = textBox_HoTen.Text;
                        _ngay.Value = textBox_BaoCaoNgay.Text.ToString();
                        _tinh_Trang_An.Value = textBox_TT_An.Text;
                        _tinh_Trang_Ngu.Value = textBox_TT_Ngu.Text;
                        _tinh_Trang_VuiChoi.Value = textBox_TT_VuiChoi.Text;
                        _ma_NV.Value = textBox_Ma_NV.Text;
                        _ngay_Tao.Value = textBox_Ngay_Tao.Text.ToString();
                        _sort_by.Value = 1;
                        reader = sqlcmd.ExecuteReader();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                        break;

                    case "Ngày tháng tăng dần":
                        sqlcmd = new SqlCommand("BaoCao_An_Ngu_Sort_by_Date", conn);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        // Construction Parameters:
                        _ma_BC = sqlcmd.Parameters.Add("@p_MA_BC", SqlDbType.NVarChar, 10);
                        _ten_BC = sqlcmd.Parameters.Add("@p_TEN_BC", SqlDbType.NVarChar, 10);
                        _ma_Tre = sqlcmd.Parameters.Add("@p_MA_TRE", SqlDbType.NVarChar, 10);
                        _ten_Tre = sqlcmd.Parameters.Add("@p_TEN_TRE", SqlDbType.NVarChar, 30);
                        _ngay = sqlcmd.Parameters.Add("@p_NGAY", SqlDbType.NVarChar, 30);
                        _tinh_Trang_An = sqlcmd.Parameters.Add("@p_TINHTRANG_AN", SqlDbType.NVarChar, 100);
                        _tinh_Trang_Ngu = sqlcmd.Parameters.Add("@p_TINHTRANG_NGU", SqlDbType.NVarChar, 100);
                        _tinh_Trang_VuiChoi = sqlcmd.Parameters.Add("@p_TINHTRANG_VUICHOI", SqlDbType.NVarChar, 10);
                        _ma_NV = sqlcmd.Parameters.Add("@p_MA_NV", SqlDbType.NVarChar, 10);
                        _ngay_Tao = sqlcmd.Parameters.Add("@p_NGAY_TAO", SqlDbType.NVarChar, 30);
                        _sort_by = sqlcmd.Parameters.Add("@p_SORT_BY", SqlDbType.Int);
                        // Transmitted value to Parameter:
                        _ma_BC.Value = textBox_MaBC.Text;
                        _ten_BC.Value = textBox_TenBC.Text;
                        _ma_Tre.Value = textBox_MaTre.Text;
                        _ten_Tre.Value = textBox_HoTen.Text;
                        _ngay.Value = textBox_BaoCaoNgay.Text.ToString();
                        _tinh_Trang_An.Value = textBox_TT_An.Text;
                        _tinh_Trang_Ngu.Value = textBox_TT_Ngu.Text;
                        _tinh_Trang_VuiChoi.Value = textBox_TT_VuiChoi.Text;
                        _ma_NV.Value = textBox_Ma_NV.Text;
                        _ngay_Tao.Value = textBox_Ngay_Tao.Text.ToString();
                        _sort_by.Value = 0;
                        reader = sqlcmd.ExecuteReader();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                        break;
                    case "Ngày tháng giảm dần":
                        sqlcmd = new SqlCommand("BaoCao_An_Ngu_Sort_by_Date", conn);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        // Construction Parameters:
                        _ma_BC = sqlcmd.Parameters.Add("@p_MA_BC", SqlDbType.NVarChar, 10);
                        _ten_BC = sqlcmd.Parameters.Add("@p_TEN_BC", SqlDbType.NVarChar, 10);
                        _ma_Tre = sqlcmd.Parameters.Add("@p_MA_TRE", SqlDbType.NVarChar, 10);
                        _ten_Tre = sqlcmd.Parameters.Add("@p_TEN_TRE", SqlDbType.NVarChar, 30);
                        _ngay = sqlcmd.Parameters.Add("@p_NGAY", SqlDbType.NVarChar, 30);
                        _tinh_Trang_An = sqlcmd.Parameters.Add("@p_TINHTRANG_AN", SqlDbType.NVarChar, 100);
                        _tinh_Trang_Ngu = sqlcmd.Parameters.Add("@p_TINHTRANG_NGU", SqlDbType.NVarChar, 100);
                        _tinh_Trang_VuiChoi = sqlcmd.Parameters.Add("@p_TINHTRANG_VUICHOI", SqlDbType.NVarChar, 10);
                        _ma_NV = sqlcmd.Parameters.Add("@p_MA_NV", SqlDbType.NVarChar, 10);
                        _ngay_Tao = sqlcmd.Parameters.Add("@p_NGAY_TAO", SqlDbType.NVarChar, 30);
                        _sort_by = sqlcmd.Parameters.Add("@p_SORT_BY", SqlDbType.Int);
                        // Transmitted value to Parameter:
                        _ma_BC.Value = textBox_MaBC.Text;
                        _ten_BC.Value = textBox_TenBC.Text;
                        _ma_Tre.Value = textBox_MaTre.Text;
                        _ten_Tre.Value = textBox_HoTen.Text;
                        _ngay.Value = textBox_BaoCaoNgay.Text.ToString();
                        _tinh_Trang_An.Value = textBox_TT_An.Text;
                        _tinh_Trang_Ngu.Value = textBox_TT_Ngu.Text;
                        _tinh_Trang_VuiChoi.Value = textBox_TT_VuiChoi.Text;
                        _ma_NV.Value = textBox_Ma_NV.Text;
                        _ngay_Tao.Value = textBox_Ngay_Tao.Text.ToString();
                        _sort_by.Value = 1;
                        reader = sqlcmd.ExecuteReader();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                        break;
                    default:
                        //reader = sqlcmd.ExecuteReader();
                        //dt = new DataTable();
                        //dt.Load(reader);
                        //dataGridView1.DataSource = dt;
                        break;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
