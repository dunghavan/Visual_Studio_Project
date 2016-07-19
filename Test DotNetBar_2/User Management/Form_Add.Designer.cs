namespace Creating_User
{
    partial class Form_User_Management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_User_Management));
            this.label_Header = new DevComponents.DotNetBar.LabelX();
            this.label_User_name = new DevComponents.DotNetBar.LabelX();
            this.label_Password = new DevComponents.DotNetBar.LabelX();
            this.label_Verify_password = new DevComponents.DotNetBar.LabelX();
            this.label_Email_address = new DevComponents.DotNetBar.LabelX();
            this.textBox_First_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_User_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_Password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_Verify_password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_Email_address = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.button_Add = new DevComponents.DotNetBar.ButtonX();
            this.button_Back_to_homepage = new DevComponents.DotNetBar.ButtonX();
            this.label_Mandatory = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.label_Condition = new DevComponents.DotNetBar.LabelX();
            this.label_Error = new DevComponents.DotNetBar.LabelX();
            this.label_Password_Strenght = new DevComponents.DotNetBar.LabelX();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.groupPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.label_Full_name = new DevComponents.DotNetBar.LabelX();
            this.dataGridView_User = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Edit = new DevComponents.DotNetBar.ButtonX();
            this.button_Delete = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_User)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Header
            // 
            // 
            // 
            // 
            this.label_Header.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_Header.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_Header.Location = new System.Drawing.Point(23, 12);
            this.label_Header.Name = "label_Header";
            this.label_Header.Size = new System.Drawing.Size(386, 23);
            this.label_Header.TabIndex = 0;
            this.label_Header.Text = "Please fill all informations to add User:";
            // 
            // label_User_name
            // 
            // 
            // 
            // 
            this.label_User_name.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_User_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_User_name.ForeColor = System.Drawing.Color.Black;
            this.label_User_name.Location = new System.Drawing.Point(65, 78);
            this.label_User_name.Name = "label_User_name";
            this.label_User_name.Size = new System.Drawing.Size(97, 23);
            this.label_User_name.TabIndex = 1;
            this.label_User_name.Text = "Username:";
            // 
            // label_Password
            // 
            // 
            // 
            // 
            this.label_Password.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_Password.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.Color.Black;
            this.label_Password.Location = new System.Drawing.Point(65, 107);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(97, 23);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password:";
            // 
            // label_Verify_password
            // 
            // 
            // 
            // 
            this.label_Verify_password.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_Verify_password.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Verify_password.ForeColor = System.Drawing.Color.Black;
            this.label_Verify_password.Location = new System.Drawing.Point(65, 136);
            this.label_Verify_password.Name = "label_Verify_password";
            this.label_Verify_password.Size = new System.Drawing.Size(97, 23);
            this.label_Verify_password.TabIndex = 3;
            this.label_Verify_password.Text = "Verify password:";
            // 
            // label_Email_address
            // 
            // 
            // 
            // 
            this.label_Email_address.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_Email_address.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email_address.ForeColor = System.Drawing.Color.Black;
            this.label_Email_address.Location = new System.Drawing.Point(65, 165);
            this.label_Email_address.Name = "label_Email_address";
            this.label_Email_address.Size = new System.Drawing.Size(97, 23);
            this.label_Email_address.TabIndex = 6;
            this.label_Email_address.Text = "Email address:";
            // 
            // textBox_First_name
            // 
            // 
            // 
            // 
            this.textBox_First_name.Border.Class = "TextBoxBorder";
            this.textBox_First_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_First_name.Location = new System.Drawing.Point(179, 51);
            this.textBox_First_name.Name = "textBox_First_name";
            this.textBox_First_name.Size = new System.Drawing.Size(150, 21);
            this.textBox_First_name.TabIndex = 7;
            // 
            // textBox_User_name
            // 
            // 
            // 
            // 
            this.textBox_User_name.Border.Class = "TextBoxBorder";
            this.textBox_User_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_User_name.Location = new System.Drawing.Point(179, 81);
            this.textBox_User_name.Name = "textBox_User_name";
            this.textBox_User_name.Size = new System.Drawing.Size(150, 21);
            this.textBox_User_name.TabIndex = 8;
            // 
            // textBox_Password
            // 
            // 
            // 
            // 
            this.textBox_Password.Border.Class = "TextBoxBorder";
            this.textBox_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_Password.Location = new System.Drawing.Point(179, 110);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(150, 21);
            this.textBox_Password.TabIndex = 10;
            // 
            // textBox_Verify_password
            // 
            // 
            // 
            // 
            this.textBox_Verify_password.Border.Class = "TextBoxBorder";
            this.textBox_Verify_password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_Verify_password.Location = new System.Drawing.Point(179, 139);
            this.textBox_Verify_password.Name = "textBox_Verify_password";
            this.textBox_Verify_password.Size = new System.Drawing.Size(150, 21);
            this.textBox_Verify_password.TabIndex = 11;
            // 
            // textBox_Email_address
            // 
            // 
            // 
            // 
            this.textBox_Email_address.Border.Class = "TextBoxBorder";
            this.textBox_Email_address.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_Email_address.Location = new System.Drawing.Point(179, 168);
            this.textBox_Email_address.Name = "textBox_Email_address";
            this.textBox_Email_address.Size = new System.Drawing.Size(150, 21);
            this.textBox_Email_address.TabIndex = 12;
            // 
            // button_Add
            // 
            this.button_Add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_Add.Location = new System.Drawing.Point(254, 254);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_Add.TabIndex = 17;
            this.button_Add.Text = "Add";
            // 
            // button_Back_to_homepage
            // 
            this.button_Back_to_homepage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Back_to_homepage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_Back_to_homepage.Location = new System.Drawing.Point(374, 254);
            this.button_Back_to_homepage.Name = "button_Back_to_homepage";
            this.button_Back_to_homepage.Size = new System.Drawing.Size(123, 23);
            this.button_Back_to_homepage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_Back_to_homepage.TabIndex = 18;
            this.button_Back_to_homepage.Text = "Back To Homepage";
            // 
            // label_Mandatory
            // 
            // 
            // 
            // 
            this.label_Mandatory.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_Mandatory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Mandatory.ForeColor = System.Drawing.Color.Red;
            this.label_Mandatory.Location = new System.Drawing.Point(335, 49);
            this.label_Mandatory.Name = "label_Mandatory";
            this.label_Mandatory.Size = new System.Drawing.Size(33, 23);
            this.label_Mandatory.TabIndex = 19;
            this.label_Mandatory.Text = "(*)";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.ForeColor = System.Drawing.Color.Red;
            this.labelX10.Location = new System.Drawing.Point(335, 79);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(33, 23);
            this.labelX10.TabIndex = 20;
            this.labelX10.Text = "(*)";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.ForeColor = System.Drawing.Color.Red;
            this.labelX11.Location = new System.Drawing.Point(335, 108);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(33, 23);
            this.labelX11.TabIndex = 21;
            this.labelX11.Text = "(*)";
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.ForeColor = System.Drawing.Color.Red;
            this.labelX12.Location = new System.Drawing.Point(335, 139);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(33, 23);
            this.labelX12.TabIndex = 22;
            this.labelX12.Text = "(*)";
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX13.ForeColor = System.Drawing.Color.Red;
            this.labelX13.Location = new System.Drawing.Point(335, 166);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(33, 23);
            this.labelX13.TabIndex = 23;
            this.labelX13.Text = "(*)";
            // 
            // label_Condition
            // 
            // 
            // 
            // 
            this.label_Condition.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_Condition.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Condition.ForeColor = System.Drawing.Color.Blue;
            this.label_Condition.Location = new System.Drawing.Point(374, 79);
            this.label_Condition.Name = "label_Condition";
            this.label_Condition.Size = new System.Drawing.Size(156, 23);
            this.label_Condition.TabIndex = 25;
            this.label_Condition.Text = "(at least 6 characters long)";
            // 
            // label_Error
            // 
            // 
            // 
            // 
            this.label_Error.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_Error.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(189, 223);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(253, 23);
            this.label_Error.TabIndex = 32;
            this.label_Error.Text = "Error! Invalid information, please fill again.";
            // 
            // label_Password_Strenght
            // 
            // 
            // 
            // 
            this.label_Password_Strenght.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_Password_Strenght.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password_Strenght.ForeColor = System.Drawing.Color.Blue;
            this.label_Password_Strenght.Location = new System.Drawing.Point(374, 107);
            this.label_Password_Strenght.Name = "label_Password_Strenght";
            this.label_Password_Strenght.Size = new System.Drawing.Size(123, 23);
            this.label_Password_Strenght.TabIndex = 26;
            this.label_Password_Strenght.Text = "Password strenght:";
            // 
            // progressBarX1
            // 
            this.progressBarX1.BackColor = System.Drawing.Color.Fuchsia;
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.progressBarX1.BackgroundStyle.BackColor2 = System.Drawing.SystemColors.MenuText;
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.ChunkColor = System.Drawing.Color.Magenta;
            this.progressBarX1.ChunkColor2 = System.Drawing.Color.Red;
            this.progressBarX1.ForeColor = System.Drawing.Color.Red;
            this.progressBarX1.Location = new System.Drawing.Point(494, 108);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(125, 23);
            this.progressBarX1.TabIndex = 33;
            this.progressBarX1.Text = "progressBarX1";
            this.progressBarX1.Value = 80;
            // 
            // groupPanel
            // 
            this.groupPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel.Controls.Add(this.labelX3);
            this.groupPanel.Controls.Add(this.labelX2);
            this.groupPanel.Location = new System.Drawing.Point(374, 137);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.Size = new System.Drawing.Size(245, 80);
            // 
            // 
            // 
            this.groupPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel.Style.BackColorGradientAngle = 90;
            this.groupPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel.Style.BorderBottomWidth = 1;
            this.groupPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel.Style.BorderLeftWidth = 1;
            this.groupPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel.Style.BorderRightWidth = 1;
            this.groupPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel.Style.BorderTopWidth = 1;
            this.groupPanel.Style.CornerDiameter = 4;
            this.groupPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel.TabIndex = 36;
            this.groupPanel.Text = "To make  your password more secure:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(21, 29);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(193, 23);
            this.labelX3.TabIndex = 38;
            this.labelX3.Text = "-  Add numbers and punctuation";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(21, 7);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(193, 23);
            this.labelX2.TabIndex = 37;
            this.labelX2.Text = "-  Use both upper and lowercase letter";
            // 
            // label_Full_name
            // 
            // 
            // 
            // 
            this.label_Full_name.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_Full_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Full_name.ForeColor = System.Drawing.Color.Black;
            this.label_Full_name.Location = new System.Drawing.Point(65, 48);
            this.label_Full_name.Name = "label_Full_name";
            this.label_Full_name.Size = new System.Drawing.Size(97, 23);
            this.label_Full_name.TabIndex = 4;
            this.label_Full_name.Text = "Full name:";
            // 
            // dataGridView_User
            // 
            this.dataGridView_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_User.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.column5});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_User.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_User.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView_User.Location = new System.Drawing.Point(0, 301);
            this.dataGridView_User.Name = "dataGridView_User";
            this.dataGridView_User.Size = new System.Drawing.Size(641, 150);
            this.dataGridView_User.TabIndex = 37;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "#";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Username";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Full name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 165;
            // 
            // column5
            // 
            this.column5.HeaderText = "Email address";
            this.column5.Name = "column5";
            this.column5.ReadOnly = true;
            this.column5.Width = 250;
            // 
            // button_Edit
            // 
            this.button_Edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Edit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_Edit.Location = new System.Drawing.Point(659, 341);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_Edit.TabIndex = 38;
            this.button_Edit.Text = "Edit";
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_Delete.Location = new System.Drawing.Point(659, 386);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_Delete.TabIndex = 39;
            this.button_Delete.Text = "Delete";
            // 
            // Form_User_Management
            // 
            this.ActiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Appearance.BackColor = System.Drawing.Color.YellowGreen;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 455);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.dataGridView_User);
            this.Controls.Add(this.groupPanel);
            this.Controls.Add(this.progressBarX1);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.label_Password_Strenght);
            this.Controls.Add(this.label_Condition);
            this.Controls.Add(this.labelX13);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.label_Mandatory);
            this.Controls.Add(this.button_Back_to_homepage);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_Email_address);
            this.Controls.Add(this.textBox_Verify_password);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_User_name);
            this.Controls.Add(this.textBox_First_name);
            this.Controls.Add(this.label_Email_address);
            this.Controls.Add(this.label_Full_name);
            this.Controls.Add(this.label_Verify_password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_User_name);
            this.Controls.Add(this.label_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_User_Management";
            this.Text = "User Management";
            this.groupPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX label_Header;
        private DevComponents.DotNetBar.LabelX label_User_name;
        private DevComponents.DotNetBar.LabelX label_Password;
        private DevComponents.DotNetBar.LabelX label_Verify_password;
        private DevComponents.DotNetBar.LabelX label_Email_address;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_First_name;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_User_name;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_Password;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_Verify_password;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_Email_address;
        private DevComponents.DotNetBar.ButtonX button_Add;
        private DevComponents.DotNetBar.ButtonX button_Back_to_homepage;
        private DevComponents.DotNetBar.LabelX label_Mandatory;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX label_Condition;
        private DevComponents.DotNetBar.LabelX label_Error;
        private DevComponents.DotNetBar.LabelX label_Password_Strenght;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX label_Full_name;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column5;
        private DevComponents.DotNetBar.ButtonX button_Edit;
        private DevComponents.DotNetBar.ButtonX button_Delete;
    }
}

