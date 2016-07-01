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
        }
        SqlConnection conn = new SqlConnection("Data Source=REUS;Initial Catalog=QLNT;Integrated Security=True");
        SqlDataReader reader;
        DataTable dt;

        //private SqlConnection Create_Connection()
        //{
            
        //    return conn;
            
        //}
        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //dataGridView1.DataSource = null;
            //    //
            //    SqlCommand cmd = new SqlCommand("BaoCao_An_Ngu_Lst", conn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    conn.Open();
            //    reader = cmd.ExecuteReader();
            //    dt = new DataTable();
            //    dt.Load(reader);
            //    dataGridView1.DataSource = dt;
            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            try
            {
                //dataGridView1.DataSource = null;
                //
                conn.Open();
                SqlCommand sqlcmd = new SqlCommand("BaoCao_An_Ngu_Search", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                // Declare Parameters:
                SqlParameter _ma_BC = sqlcmd.Parameters.Add("@p_MA_BC", SqlDbType.NVarChar, 10);
                SqlParameter _ten_BC = sqlcmd.Parameters.Add("@p_TEN_BC", SqlDbType.NVarChar, 10);
                SqlParameter _ma_Tre = sqlcmd.Parameters.Add("@p_MA_TRE", SqlDbType.NVarChar, 10);
                SqlParameter _ten_Tre = sqlcmd.Parameters.Add("@p_TEN_TRE", SqlDbType.NVarChar, 30);
                SqlParameter _ngay = sqlcmd.Parameters.Add("@p_NGAY", SqlDbType.NVarChar, 30);
                SqlParameter _tinh_Trang_An = sqlcmd.Parameters.Add("@p_TINHTRANG_AN", SqlDbType.NVarChar, 100);
                SqlParameter _tinh_Trang_Ngu = sqlcmd.Parameters.Add("@p_TINHTRANG_NGU", SqlDbType.NVarChar, 100);
                SqlParameter _tinh_Trang_VuiChoi = sqlcmd.Parameters.Add("@p_TINHTRANG_VUICHOI", SqlDbType.NVarChar, 10);
                SqlParameter _ma_NV = sqlcmd.Parameters.Add("@p_MA_NV", SqlDbType.NVarChar, 10);
                SqlParameter _ngay_Tao = sqlcmd.Parameters.Add("@p_NGAY_TAO", SqlDbType.NVarChar, 30);
                // Transmitted vaue to Parameter:
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
                //
                reader = sqlcmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker_NgayTao_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
