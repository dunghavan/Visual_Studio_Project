namespace HienThi_BaoCao_AnUong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_MaBC = new System.Windows.Forms.Label();
            this.label_TenBC = new System.Windows.Forms.Label();
            this.label_TenTre = new System.Windows.Forms.Label();
            this.label_MaTre = new System.Windows.Forms.Label();
            this.label_BaoCaoNgay = new System.Windows.Forms.Label();
            this.label_NgayTao = new System.Windows.Forms.Label();
            this.label_TinhTrangVuiChoi = new System.Windows.Forms.Label();
            this.label_TinhTrangNgu = new System.Windows.Forms.Label();
            this.label_TinhTrangAn = new System.Windows.Forms.Label();
            this.textBox_MaBC = new System.Windows.Forms.TextBox();
            this.textBox_TenBC = new System.Windows.Forms.TextBox();
            this.textBox_TT_An = new System.Windows.Forms.TextBox();
            this.textBox_MaTre = new System.Windows.Forms.TextBox();
            this.textBox_TT_Ngu = new System.Windows.Forms.TextBox();
            this.textBox_HoTen = new System.Windows.Forms.TextBox();
            this.textBox_TT_VuiChoi = new System.Windows.Forms.TextBox();
            this.label_Ma_NV = new System.Windows.Forms.Label();
            this.textBox_Ma_NV = new System.Windows.Forms.TextBox();
            this.textBox_BaoCaoNgay = new System.Windows.Forms.TextBox();
            this.textBox_Ma_Nguoi_Tao = new System.Windows.Forms.TextBox();
            this.textBox_Ngay_Tao = new System.Windows.Forms.TextBox();
            this.label_dd_MM_yyyy_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Location = new System.Drawing.Point(375, 91);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(127, 45);
            this.button_TimKiem.TabIndex = 0;
            this.button_TimKiem.Text = "Tìm Kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = true;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1190, 239);
            this.dataGridView1.TabIndex = 1;
            // 
            // label_MaBC
            // 
            this.label_MaBC.AutoSize = true;
            this.label_MaBC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaBC.Location = new System.Drawing.Point(38, 19);
            this.label_MaBC.Name = "label_MaBC";
            this.label_MaBC.Size = new System.Drawing.Size(76, 15);
            this.label_MaBC.TabIndex = 2;
            this.label_MaBC.Text = "Mã Báo Cáo:";
            // 
            // label_TenBC
            // 
            this.label_TenBC.AutoSize = true;
            this.label_TenBC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenBC.Location = new System.Drawing.Point(38, 56);
            this.label_TenBC.Name = "label_TenBC";
            this.label_TenBC.Size = new System.Drawing.Size(79, 15);
            this.label_TenBC.TabIndex = 3;
            this.label_TenBC.Text = "Tên Báo Cáo:";
            // 
            // label_TenTre
            // 
            this.label_TenTre.AutoSize = true;
            this.label_TenTre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenTre.Location = new System.Drawing.Point(250, 56);
            this.label_TenTre.Name = "label_TenTre";
            this.label_TenTre.Size = new System.Drawing.Size(71, 15);
            this.label_TenTre.TabIndex = 5;
            this.label_TenTre.Text = "Họ Tên Trẻ:";
            // 
            // label_MaTre
            // 
            this.label_MaTre.AutoSize = true;
            this.label_MaTre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaTre.Location = new System.Drawing.Point(283, 19);
            this.label_MaTre.Name = "label_MaTre";
            this.label_MaTre.Size = new System.Drawing.Size(49, 15);
            this.label_MaTre.TabIndex = 4;
            this.label_MaTre.Text = "Mã Trẻ:";
            // 
            // label_BaoCaoNgay
            // 
            this.label_BaoCaoNgay.AutoSize = true;
            this.label_BaoCaoNgay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BaoCaoNgay.Location = new System.Drawing.Point(38, 91);
            this.label_BaoCaoNgay.Name = "label_BaoCaoNgay";
            this.label_BaoCaoNgay.Size = new System.Drawing.Size(87, 15);
            this.label_BaoCaoNgay.TabIndex = 6;
            this.label_BaoCaoNgay.Text = "Báo Cáo Ngày:";
            // 
            // label_NgayTao
            // 
            this.label_NgayTao.AutoSize = true;
            this.label_NgayTao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgayTao.Location = new System.Drawing.Point(873, 22);
            this.label_NgayTao.Name = "label_NgayTao";
            this.label_NgayTao.Size = new System.Drawing.Size(63, 15);
            this.label_NgayTao.TabIndex = 7;
            this.label_NgayTao.Text = "Ngày Tạo:";
            // 
            // label_TinhTrangVuiChoi
            // 
            this.label_TinhTrangVuiChoi.AutoSize = true;
            this.label_TinhTrangVuiChoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TinhTrangVuiChoi.Location = new System.Drawing.Point(548, 56);
            this.label_TinhTrangVuiChoi.Name = "label_TinhTrangVuiChoi";
            this.label_TinhTrangVuiChoi.Size = new System.Drawing.Size(118, 15);
            this.label_TinhTrangVuiChoi.TabIndex = 10;
            this.label_TinhTrangVuiChoi.Text = "Tình Trạng Vui Chơi:";
            // 
            // label_TinhTrangNgu
            // 
            this.label_TinhTrangNgu.AutoSize = true;
            this.label_TinhTrangNgu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TinhTrangNgu.Location = new System.Drawing.Point(548, 21);
            this.label_TinhTrangNgu.Name = "label_TinhTrangNgu";
            this.label_TinhTrangNgu.Size = new System.Drawing.Size(96, 15);
            this.label_TinhTrangNgu.TabIndex = 9;
            this.label_TinhTrangNgu.Text = "Tình Trạng Ngủ:";
            // 
            // label_TinhTrangAn
            // 
            this.label_TinhTrangAn.AutoSize = true;
            this.label_TinhTrangAn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TinhTrangAn.Location = new System.Drawing.Point(548, 86);
            this.label_TinhTrangAn.Name = "label_TinhTrangAn";
            this.label_TinhTrangAn.Size = new System.Drawing.Size(90, 15);
            this.label_TinhTrangAn.TabIndex = 8;
            this.label_TinhTrangAn.Text = "Tình Trạng Ăn:";
            // 
            // textBox_MaBC
            // 
            this.textBox_MaBC.Location = new System.Drawing.Point(131, 17);
            this.textBox_MaBC.Name = "textBox_MaBC";
            this.textBox_MaBC.Size = new System.Drawing.Size(106, 20);
            this.textBox_MaBC.TabIndex = 11;
            // 
            // textBox_TenBC
            // 
            this.textBox_TenBC.Location = new System.Drawing.Point(131, 54);
            this.textBox_TenBC.Name = "textBox_TenBC";
            this.textBox_TenBC.Size = new System.Drawing.Size(106, 20);
            this.textBox_TenBC.TabIndex = 12;
            // 
            // textBox_TT_An
            // 
            this.textBox_TT_An.Location = new System.Drawing.Point(672, 84);
            this.textBox_TT_An.Name = "textBox_TT_An";
            this.textBox_TT_An.Size = new System.Drawing.Size(161, 20);
            this.textBox_TT_An.TabIndex = 14;
            // 
            // textBox_MaTre
            // 
            this.textBox_MaTre.Location = new System.Drawing.Point(341, 17);
            this.textBox_MaTre.Name = "textBox_MaTre";
            this.textBox_MaTre.Size = new System.Drawing.Size(161, 20);
            this.textBox_MaTre.TabIndex = 13;
            // 
            // textBox_TT_Ngu
            // 
            this.textBox_TT_Ngu.Location = new System.Drawing.Point(672, 19);
            this.textBox_TT_Ngu.Name = "textBox_TT_Ngu";
            this.textBox_TT_Ngu.Size = new System.Drawing.Size(161, 20);
            this.textBox_TT_Ngu.TabIndex = 16;
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.Location = new System.Drawing.Point(341, 56);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.Size = new System.Drawing.Size(161, 20);
            this.textBox_HoTen.TabIndex = 15;
            // 
            // textBox_TT_VuiChoi
            // 
            this.textBox_TT_VuiChoi.Location = new System.Drawing.Point(672, 54);
            this.textBox_TT_VuiChoi.Name = "textBox_TT_VuiChoi";
            this.textBox_TT_VuiChoi.Size = new System.Drawing.Size(161, 20);
            this.textBox_TT_VuiChoi.TabIndex = 17;
            // 
            // label_Ma_NV
            // 
            this.label_Ma_NV.AutoSize = true;
            this.label_Ma_NV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ma_NV.Location = new System.Drawing.Point(873, 56);
            this.label_Ma_NV.Name = "label_Ma_NV";
            this.label_Ma_NV.Size = new System.Drawing.Size(88, 15);
            this.label_Ma_NV.TabIndex = 20;
            this.label_Ma_NV.Text = "Mã Người Tạo:";
            // 
            // textBox_Ma_NV
            // 
            this.textBox_Ma_NV.Location = new System.Drawing.Point(1303, 128);
            this.textBox_Ma_NV.Name = "textBox_Ma_NV";
            this.textBox_Ma_NV.Size = new System.Drawing.Size(113, 20);
            this.textBox_Ma_NV.TabIndex = 21;
            // 
            // textBox_BaoCaoNgay
            // 
            this.textBox_BaoCaoNgay.Location = new System.Drawing.Point(131, 89);
            this.textBox_BaoCaoNgay.Name = "textBox_BaoCaoNgay";
            this.textBox_BaoCaoNgay.Size = new System.Drawing.Size(106, 20);
            this.textBox_BaoCaoNgay.TabIndex = 22;
            // 
            // textBox_Ma_Nguoi_Tao
            // 
            this.textBox_Ma_Nguoi_Tao.Location = new System.Drawing.Point(967, 54);
            this.textBox_Ma_Nguoi_Tao.Name = "textBox_Ma_Nguoi_Tao";
            this.textBox_Ma_Nguoi_Tao.Size = new System.Drawing.Size(113, 20);
            this.textBox_Ma_Nguoi_Tao.TabIndex = 23;
            // 
            // textBox_Ngay_Tao
            // 
            this.textBox_Ngay_Tao.Location = new System.Drawing.Point(967, 20);
            this.textBox_Ngay_Tao.Name = "textBox_Ngay_Tao";
            this.textBox_Ngay_Tao.Size = new System.Drawing.Size(113, 20);
            this.textBox_Ngay_Tao.TabIndex = 24;
            // 
            // label_dd_MM_yyyy_1
            // 
            this.label_dd_MM_yyyy_1.AutoSize = true;
            this.label_dd_MM_yyyy_1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dd_MM_yyyy_1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_dd_MM_yyyy_1.Location = new System.Drawing.Point(128, 112);
            this.label_dd_MM_yyyy_1.Name = "label_dd_MM_yyyy_1";
            this.label_dd_MM_yyyy_1.Size = new System.Drawing.Size(75, 15);
            this.label_dd_MM_yyyy_1.TabIndex = 25;
            this.label_dd_MM_yyyy_1.Text = "dd-MM-yyyy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(1086, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "dd-MM-yyyy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_dd_MM_yyyy_1);
            this.Controls.Add(this.textBox_Ngay_Tao);
            this.Controls.Add(this.textBox_Ma_Nguoi_Tao);
            this.Controls.Add(this.textBox_BaoCaoNgay);
            this.Controls.Add(this.textBox_Ma_NV);
            this.Controls.Add(this.label_Ma_NV);
            this.Controls.Add(this.textBox_TT_VuiChoi);
            this.Controls.Add(this.textBox_TT_Ngu);
            this.Controls.Add(this.textBox_HoTen);
            this.Controls.Add(this.textBox_TT_An);
            this.Controls.Add(this.textBox_MaTre);
            this.Controls.Add(this.textBox_TenBC);
            this.Controls.Add(this.textBox_MaBC);
            this.Controls.Add(this.label_TinhTrangVuiChoi);
            this.Controls.Add(this.label_TinhTrangNgu);
            this.Controls.Add(this.label_TinhTrangAn);
            this.Controls.Add(this.label_NgayTao);
            this.Controls.Add(this.label_BaoCaoNgay);
            this.Controls.Add(this.label_TenTre);
            this.Controls.Add(this.label_MaTre);
            this.Controls.Add(this.label_TenBC);
            this.Controls.Add(this.label_MaBC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_TimKiem);
            this.Name = "Form1";
            this.Text = "HienThi_BaoCao_AnUong";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_MaBC;
        private System.Windows.Forms.Label label_TenBC;
        private System.Windows.Forms.Label label_TenTre;
        private System.Windows.Forms.Label label_MaTre;
        private System.Windows.Forms.Label label_BaoCaoNgay;
        private System.Windows.Forms.Label label_NgayTao;
        private System.Windows.Forms.Label label_TinhTrangVuiChoi;
        private System.Windows.Forms.Label label_TinhTrangNgu;
        private System.Windows.Forms.Label label_TinhTrangAn;
        private System.Windows.Forms.TextBox textBox_MaBC;
        private System.Windows.Forms.TextBox textBox_TenBC;
        private System.Windows.Forms.TextBox textBox_TT_An;
        private System.Windows.Forms.TextBox textBox_MaTre;
        private System.Windows.Forms.TextBox textBox_TT_Ngu;
        private System.Windows.Forms.TextBox textBox_HoTen;
        private System.Windows.Forms.TextBox textBox_TT_VuiChoi;
        private System.Windows.Forms.Label label_Ma_NV;
        private System.Windows.Forms.TextBox textBox_Ma_NV;
        private System.Windows.Forms.TextBox textBox_BaoCaoNgay;
        private System.Windows.Forms.TextBox textBox_Ma_Nguoi_Tao;
        private System.Windows.Forms.TextBox textBox_Ngay_Tao;
        private System.Windows.Forms.Label label_dd_MM_yyyy_1;
        private System.Windows.Forms.Label label1;
    }
}

