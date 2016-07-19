using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creating_User
{
    public partial class Form_User_Management : DevExpress.XtraEditors.XtraForm
    {
        public Form_User_Management()
        {
            InitializeComponent();
        }

        Form_Edit_User f = new Form_Edit_User();
        private void button_Edit_Click(object sender, EventArgs e)
        {
            f.Show();
        }
    }
}
