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
    public partial class Form2 : Form
    {
        public Form2(Form callingForm)
        {
            f1 = callingForm as Form1;
            InitializeComponent();
        }
        private Form1 f1 = new Form1();
        SqlConnection conn = new SqlConnection("Data Source=REUS;Initial Catalog=QLNT;Integrated Security=True");
        SqlDataReader reader;
        DataTable dt;
        // Declare Parameters:
        SqlCommand sqlcmd;
        //SqlParameter _ma_BC, _ten_BC, _ma_Tre, _ten_Tre, _ngay, _tinh_Trang_An, _tinh_Trang_Ngu, _tinh_Trang_VuiChoi, _ma_NV, _ngay_Tao, _sort_by;
        
        private void Form2_Activated(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sqlcmd = new SqlCommand("Tre_Lst_MaTre", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                reader = sqlcmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                foreach(DataRow dr in dt.Rows)
                {
                    comboBox_MaTre.Items.Add(dr[0]);
                }
                //
                sqlcmd = new SqlCommand("Nhan_Vien_Lst_MaNV", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                reader = sqlcmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox_MaNV.Items.Add(dr[0]);
                }
                conn.Close();
                textBox_MaBC.Text = f1.maBC;
                textBox_TenBC.Text = f1.tenBC;
                comboBox_MaTre.Text = f1.maTre;
                textBox_HoTen.Text = f1.tenTre;
                dateTimePicker_Ngay.Text = f1.ngay;
                textBox_TT_An.Text = f1.ttAn;
                textBox_TT_Ngu.Text = f1.ttNgu;
                textBox_TT_VuiChoi.Text = f1.ttVuiChoi;
                comboBox_MaNV.Text = f1.maNV;
                dateTimePicker_NgayTao.Text = f1.ngayTao;
                textBox_GhiChu.Text = f1.ghiChu;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                conn.Close();
            }
        }

        private void Form2_Deactivated(object sender, EventArgs e)
        {
        }
    }
}
