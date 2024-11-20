namespace PresentationLayer.UI.UserControl
{
    partial class SanPhamUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPhamUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THCombox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.ReloadButton = new Guna.UI.WinForms.GunaButton();
            this.SLSP = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.PKbtn = new Guna.UI2.WinForms.Guna2Button();
            this.GDBBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BADBBtn = new Guna.UI2.WinForms.Guna2Button();
            this.GCLBtn = new Guna.UI2.WinForms.Guna2Button();
            this.VCLBtn = new Guna.UI2.WinForms.Guna2Button();
            this.QCLBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ACLBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new Guna.UI.WinForms.GunaButton();
            this.ReadButton = new Guna.UI.WinForms.GunaButton();
            this.UpdateButton = new Guna.UI.WinForms.GunaButton();
            this.dgvSanPham = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(260, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 112;
            this.label1.Text = "Thương hiệu";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "Quantity";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "UnitPrice";
            this.Gia.HeaderText = "Giá bán";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "ProductName";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "Product_ID";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // THCombox
            // 
            this.THCombox.BackColor = System.Drawing.Color.Transparent;
            this.THCombox.BorderColor = System.Drawing.Color.Black;
            this.THCombox.BorderRadius = 10;
            this.THCombox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.THCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.THCombox.FocusedColor = System.Drawing.Color.Empty;
            this.THCombox.FocusedState.Parent = this.THCombox;
            this.THCombox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.THCombox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.THCombox.FormattingEnabled = true;
            this.THCombox.HoverState.Parent = this.THCombox;
            this.THCombox.ItemHeight = 35;
            this.THCombox.Items.AddRange(new object[] {
            ""});
            this.THCombox.ItemsAppearance.Parent = this.THCombox;
            this.THCombox.Location = new System.Drawing.Point(242, 297);
            this.THCombox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.THCombox.Name = "THCombox";
            this.THCombox.ShadowDecoration.Parent = this.THCombox;
            this.THCombox.Size = new System.Drawing.Size(415, 41);
            this.THCombox.TabIndex = 131;
            this.THCombox.SelectedIndexChanged += new System.EventHandler(this.FindButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(684, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 130;
            this.label3.Text = "Tên sản phẩm";
            // 
            // NameText
            // 
            this.NameText.AccessibleName = "";
            this.NameText.BackColor = System.Drawing.Color.Transparent;
            this.NameText.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameText.BorderRadius = 8;
            this.NameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameText.DefaultText = "";
            this.NameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameText.DisabledState.Parent = this.NameText;
            this.NameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameText.FocusedState.Parent = this.NameText;
            this.NameText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameText.HoverState.Parent = this.NameText;
            this.NameText.IconLeftSize = new System.Drawing.Size(30, 30);
            this.NameText.IconRight = ((System.Drawing.Image)(resources.GetObject("NameText.IconRight")));
            this.NameText.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.NameText.IconRightSize = new System.Drawing.Size(30, 30);
            this.NameText.Location = new System.Drawing.Point(668, 297);
            this.NameText.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.NameText.Name = "NameText";
            this.NameText.PasswordChar = '\0';
            this.NameText.PlaceholderText = "";
            this.NameText.SelectedText = "";
            this.NameText.ShadowDecoration.Parent = this.NameText;
            this.NameText.Size = new System.Drawing.Size(412, 44);
            this.NameText.TabIndex = 129;
            this.NameText.TextChanged += new System.EventHandler(this.FindButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.AnimationHoverSpeed = 0.07F;
            this.ReloadButton.AnimationSpeed = 0.03F;
            this.ReloadButton.BackColor = System.Drawing.Color.Transparent;
            this.ReloadButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ReloadButton.BorderColor = System.Drawing.Color.Black;
            this.ReloadButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ReloadButton.FocusedColor = System.Drawing.Color.Empty;
            this.ReloadButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadButton.ForeColor = System.Drawing.Color.Black;
            this.ReloadButton.Image = ((System.Drawing.Image)(resources.GetObject("ReloadButton.Image")));
            this.ReloadButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReloadButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ReloadButton.Location = new System.Drawing.Point(12, 788);
            this.ReloadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.ReloadButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ReloadButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.ReloadButton.OnHoverImage = null;
            this.ReloadButton.OnPressedColor = System.Drawing.Color.Black;
            this.ReloadButton.Radius = 15;
            this.ReloadButton.Size = new System.Drawing.Size(107, 49);
            this.ReloadButton.TabIndex = 128;
            this.ReloadButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // SLSP
            // 
            this.SLSP.AutoSize = true;
            this.SLSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.SLSP.CausesValidation = false;
            this.SLSP.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SLSP.ForeColor = System.Drawing.Color.Black;
            this.SLSP.Location = new System.Drawing.Point(74, 288);
            this.SLSP.Name = "SLSP";
            this.SLSP.Size = new System.Drawing.Size(40, 44);
            this.SLSP.TabIndex = 119;
            this.SLSP.Text = "0";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(52, 332);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(123, 27);
            this.gunaLabel1.TabIndex = 118;
            this.gunaLabel1.Text = "Sản Phẩm";
            // 
            // guna2Button7
            // 
            this.guna2Button7.BorderRadius = 10;
            this.guna2Button7.CheckedState.Parent = this.guna2Button7;
            this.guna2Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button7.CustomImages.Parent = this.guna2Button7;
            this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.guna2Button7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2Button7.ForeColor = System.Drawing.Color.Black;
            this.guna2Button7.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.guna2Button7.HoverState.Parent = this.guna2Button7;
            this.guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.ImageOffset = new System.Drawing.Point(0, -5);
            this.guna2Button7.ImageSize = new System.Drawing.Size(60, 60);
            this.guna2Button7.Location = new System.Drawing.Point(12, 258);
            this.guna2Button7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(208, 110);
            this.guna2Button7.TabIndex = 113;
            this.guna2Button7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // PKbtn
            // 
            this.PKbtn.BorderRadius = 10;
            this.PKbtn.CheckedState.Parent = this.PKbtn;
            this.PKbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PKbtn.CustomImages.Parent = this.PKbtn;
            this.PKbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.PKbtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PKbtn.ForeColor = System.Drawing.Color.Black;
            this.PKbtn.HoverState.FillColor = System.Drawing.Color.LemonChiffon;
            this.PKbtn.HoverState.Parent = this.PKbtn;
            this.PKbtn.Image = ((System.Drawing.Image)(resources.GetObject("PKbtn.Image")));
            this.PKbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PKbtn.ImageOffset = new System.Drawing.Point(0, -5);
            this.PKbtn.ImageSize = new System.Drawing.Size(60, 60);
            this.PKbtn.Location = new System.Drawing.Point(712, 142);
            this.PKbtn.Margin = new System.Windows.Forms.Padding(4);
            this.PKbtn.Name = "PKbtn";
            this.PKbtn.ShadowDecoration.Parent = this.PKbtn;
            this.PKbtn.Size = new System.Drawing.Size(225, 92);
            this.PKbtn.TabIndex = 127;
            this.PKbtn.Text = "Phụ kiện";
            this.PKbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PKbtn.TextOffset = new System.Drawing.Point(5, 0);
            this.PKbtn.Click += new System.EventHandler(this.ButtonDM_Click);
            // 
            // GDBBtn
            // 
            this.GDBBtn.BorderRadius = 10;
            this.GDBBtn.CheckedState.Parent = this.GDBBtn;
            this.GDBBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GDBBtn.CustomImages.Parent = this.GDBBtn;
            this.GDBBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.GDBBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GDBBtn.ForeColor = System.Drawing.Color.Black;
            this.GDBBtn.HoverState.FillColor = System.Drawing.Color.LemonChiffon;
            this.GDBBtn.HoverState.Parent = this.GDBBtn;
            this.GDBBtn.Image = ((System.Drawing.Image)(resources.GetObject("GDBBtn.Image")));
            this.GDBBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GDBBtn.ImageOffset = new System.Drawing.Point(0, -5);
            this.GDBBtn.ImageSize = new System.Drawing.Size(60, 60);
            this.GDBBtn.Location = new System.Drawing.Point(447, 142);
            this.GDBBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GDBBtn.Name = "GDBBtn";
            this.GDBBtn.ShadowDecoration.Parent = this.GDBBtn;
            this.GDBBtn.Size = new System.Drawing.Size(225, 92);
            this.GDBBtn.TabIndex = 126;
            this.GDBBtn.Text = "Giày bóng đá";
            this.GDBBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GDBBtn.TextOffset = new System.Drawing.Point(5, 0);
            this.GDBBtn.Click += new System.EventHandler(this.ButtonDM_Click);
            // 
            // BADBBtn
            // 
            this.BADBBtn.BorderRadius = 10;
            this.BADBBtn.CheckedState.Parent = this.BADBBtn;
            this.BADBBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BADBBtn.CustomImages.Parent = this.BADBBtn;
            this.BADBBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.BADBBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BADBBtn.ForeColor = System.Drawing.Color.Black;
            this.BADBBtn.HoverState.FillColor = System.Drawing.Color.LemonChiffon;
            this.BADBBtn.HoverState.Parent = this.BADBBtn;
            this.BADBBtn.Image = ((System.Drawing.Image)(resources.GetObject("BADBBtn.Image")));
            this.BADBBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BADBBtn.ImageOffset = new System.Drawing.Point(0, -5);
            this.BADBBtn.ImageSize = new System.Drawing.Size(60, 60);
            this.BADBBtn.Location = new System.Drawing.Point(179, 142);
            this.BADBBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BADBBtn.Name = "BADBBtn";
            this.BADBBtn.ShadowDecoration.Parent = this.BADBBtn;
            this.BADBBtn.Size = new System.Drawing.Size(225, 92);
            this.BADBBtn.TabIndex = 125;
            this.BADBBtn.Text = "Bộ đồ bóng đá";
            this.BADBBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BADBBtn.TextOffset = new System.Drawing.Point(5, 0);
            this.BADBBtn.Click += new System.EventHandler(this.ButtonDM_Click);
            // 
            // GCLBtn
            // 
            this.GCLBtn.BorderRadius = 10;
            this.GCLBtn.CheckedState.Parent = this.GCLBtn;
            this.GCLBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GCLBtn.CustomImages.Parent = this.GCLBtn;
            this.GCLBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.GCLBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GCLBtn.ForeColor = System.Drawing.Color.Black;
            this.GCLBtn.HoverState.FillColor = System.Drawing.Color.LemonChiffon;
            this.GCLBtn.HoverState.Parent = this.GCLBtn;
            this.GCLBtn.Image = ((System.Drawing.Image)(resources.GetObject("GCLBtn.Image")));
            this.GCLBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GCLBtn.ImageOffset = new System.Drawing.Point(0, -5);
            this.GCLBtn.ImageSize = new System.Drawing.Size(60, 60);
            this.GCLBtn.Location = new System.Drawing.Point(836, 41);
            this.GCLBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GCLBtn.Name = "GCLBtn";
            this.GCLBtn.ShadowDecoration.Parent = this.GCLBtn;
            this.GCLBtn.Size = new System.Drawing.Size(225, 92);
            this.GCLBtn.TabIndex = 124;
            this.GCLBtn.Text = "Giày cầu lông";
            this.GCLBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GCLBtn.TextOffset = new System.Drawing.Point(5, 0);
            this.GCLBtn.Click += new System.EventHandler(this.ButtonDM_Click);
            // 
            // VCLBtn
            // 
            this.VCLBtn.BorderRadius = 10;
            this.VCLBtn.CheckedState.Parent = this.VCLBtn;
            this.VCLBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VCLBtn.CustomImages.Parent = this.VCLBtn;
            this.VCLBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.VCLBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.VCLBtn.ForeColor = System.Drawing.Color.Black;
            this.VCLBtn.HoverState.FillColor = System.Drawing.Color.LemonChiffon;
            this.VCLBtn.HoverState.Parent = this.VCLBtn;
            this.VCLBtn.Image = ((System.Drawing.Image)(resources.GetObject("VCLBtn.Image")));
            this.VCLBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.VCLBtn.ImageOffset = new System.Drawing.Point(0, -5);
            this.VCLBtn.ImageSize = new System.Drawing.Size(60, 60);
            this.VCLBtn.Location = new System.Drawing.Point(570, 41);
            this.VCLBtn.Margin = new System.Windows.Forms.Padding(4);
            this.VCLBtn.Name = "VCLBtn";
            this.VCLBtn.ShadowDecoration.Parent = this.VCLBtn;
            this.VCLBtn.Size = new System.Drawing.Size(225, 92);
            this.VCLBtn.TabIndex = 123;
            this.VCLBtn.Text = "Vợt cầu lông";
            this.VCLBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.VCLBtn.TextOffset = new System.Drawing.Point(5, 0);
            this.VCLBtn.Click += new System.EventHandler(this.ButtonDM_Click);
            // 
            // QCLBtn
            // 
            this.QCLBtn.BorderRadius = 10;
            this.QCLBtn.CheckedState.Parent = this.QCLBtn;
            this.QCLBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QCLBtn.CustomImages.Parent = this.QCLBtn;
            this.QCLBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.QCLBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.QCLBtn.ForeColor = System.Drawing.Color.Black;
            this.QCLBtn.HoverState.FillColor = System.Drawing.Color.LemonChiffon;
            this.QCLBtn.HoverState.Parent = this.QCLBtn;
            this.QCLBtn.Image = ((System.Drawing.Image)(resources.GetObject("QCLBtn.Image")));
            this.QCLBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.QCLBtn.ImageOffset = new System.Drawing.Point(0, -5);
            this.QCLBtn.ImageSize = new System.Drawing.Size(60, 60);
            this.QCLBtn.Location = new System.Drawing.Point(298, 41);
            this.QCLBtn.Margin = new System.Windows.Forms.Padding(4);
            this.QCLBtn.Name = "QCLBtn";
            this.QCLBtn.ShadowDecoration.Parent = this.QCLBtn;
            this.QCLBtn.Size = new System.Drawing.Size(225, 92);
            this.QCLBtn.TabIndex = 122;
            this.QCLBtn.Text = "Quần cầu lông";
            this.QCLBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.QCLBtn.TextOffset = new System.Drawing.Point(5, 0);
            this.QCLBtn.Click += new System.EventHandler(this.ButtonDM_Click);
            // 
            // ACLBtn
            // 
            this.ACLBtn.BorderRadius = 10;
            this.ACLBtn.CheckedState.Parent = this.ACLBtn;
            this.ACLBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ACLBtn.CustomImages.Parent = this.ACLBtn;
            this.ACLBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ACLBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ACLBtn.ForeColor = System.Drawing.Color.Black;
            this.ACLBtn.HoverState.FillColor = System.Drawing.Color.LemonChiffon;
            this.ACLBtn.HoverState.Parent = this.ACLBtn;
            this.ACLBtn.Image = ((System.Drawing.Image)(resources.GetObject("ACLBtn.Image")));
            this.ACLBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ACLBtn.ImageOffset = new System.Drawing.Point(0, -5);
            this.ACLBtn.ImageSize = new System.Drawing.Size(60, 60);
            this.ACLBtn.Location = new System.Drawing.Point(30, 41);
            this.ACLBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ACLBtn.Name = "ACLBtn";
            this.ACLBtn.ShadowDecoration.Parent = this.ACLBtn;
            this.ACLBtn.Size = new System.Drawing.Size(225, 92);
            this.ACLBtn.TabIndex = 121;
            this.ACLBtn.Text = "Áo cầu lông";
            this.ACLBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ACLBtn.TextOffset = new System.Drawing.Point(5, 0);
            this.ACLBtn.Click += new System.EventHandler(this.ButtonDM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(478, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 27);
            this.label2.TabIndex = 120;
            this.label2.Text = "Danh Mục";
            // 
            // AddButton
            // 
            this.AddButton.AnimationHoverSpeed = 0.07F;
            this.AddButton.AnimationSpeed = 0.03F;
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.AddButton.BorderColor = System.Drawing.Color.White;
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddButton.FocusedColor = System.Drawing.Color.Empty;
            this.AddButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddButton.Location = new System.Drawing.Point(974, 788);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.AddButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.AddButton.OnHoverImage = null;
            this.AddButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddButton.Radius = 15;
            this.AddButton.Size = new System.Drawing.Size(107, 49);
            this.AddButton.TabIndex = 114;
            this.AddButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.AnimationHoverSpeed = 0.07F;
            this.ReadButton.AnimationSpeed = 0.03F;
            this.ReadButton.BackColor = System.Drawing.Color.Transparent;
            this.ReadButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ReadButton.BorderColor = System.Drawing.Color.Black;
            this.ReadButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ReadButton.FocusedColor = System.Drawing.Color.Empty;
            this.ReadButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadButton.ForeColor = System.Drawing.Color.Black;
            this.ReadButton.Image = ((System.Drawing.Image)(resources.GetObject("ReadButton.Image")));
            this.ReadButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReadButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ReadButton.Location = new System.Drawing.Point(748, 788);
            this.ReadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.ReadButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ReadButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.ReadButton.OnHoverImage = null;
            this.ReadButton.OnPressedColor = System.Drawing.Color.Black;
            this.ReadButton.Radius = 15;
            this.ReadButton.Size = new System.Drawing.Size(107, 49);
            this.ReadButton.TabIndex = 117;
            this.ReadButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.AnimationHoverSpeed = 0.07F;
            this.UpdateButton.AnimationSpeed = 0.03F;
            this.UpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.UpdateButton.BorderColor = System.Drawing.Color.Black;
            this.UpdateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdateButton.FocusedColor = System.Drawing.Color.Empty;
            this.UpdateButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateButton.ImageSize = new System.Drawing.Size(20, 20);
            this.UpdateButton.Location = new System.Drawing.Point(860, 788);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.UpdateButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.UpdateButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.UpdateButton.OnHoverImage = null;
            this.UpdateButton.OnPressedColor = System.Drawing.Color.Black;
            this.UpdateButton.Radius = 15;
            this.UpdateButton.Size = new System.Drawing.Size(107, 49);
            this.UpdateButton.TabIndex = 115;
            this.UpdateButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvSanPham.ColumnHeadersHeight = 29;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.Gia,
            this.SoLuong});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvSanPham.Location = new System.Drawing.Point(11, 375);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 51;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvSanPham.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(1069, 399);
            this.dgvSanPham.TabIndex = 116;
            this.dgvSanPham.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Light;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSanPham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSanPham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvSanPham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.dgvSanPham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvSanPham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvSanPham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSanPham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSanPham.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvSanPham.ThemeStyle.ReadOnly = true;
            this.dgvSanPham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSanPham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSanPham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSanPham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSanPham.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSanPham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvSanPham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // SanPhamUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 848);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.THCombox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.SLSP);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.guna2Button7);
            this.Controls.Add(this.PKbtn);
            this.Controls.Add(this.GDBBtn);
            this.Controls.Add(this.BADBBtn);
            this.Controls.Add(this.GCLBtn);
            this.Controls.Add(this.VCLBtn);
            this.Controls.Add(this.QCLBtn);
            this.Controls.Add(this.ACLBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.dgvSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SanPhamUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SanPhamUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SanPhamUI_FormClosing);
            this.Load += new System.EventHandler(this.SanPhamUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private Guna.UI2.WinForms.Guna2ComboBox THCombox;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox NameText;
        private Guna.UI.WinForms.GunaButton ReloadButton;
        private Guna.UI.WinForms.GunaLabel SLSP;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button PKbtn;
        private Guna.UI2.WinForms.Guna2Button GDBBtn;
        private Guna.UI2.WinForms.Guna2Button BADBBtn;
        private Guna.UI2.WinForms.Guna2Button GCLBtn;
        private Guna.UI2.WinForms.Guna2Button VCLBtn;
        private Guna.UI2.WinForms.Guna2Button QCLBtn;
        private Guna.UI2.WinForms.Guna2Button ACLBtn;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton AddButton;
        private Guna.UI.WinForms.GunaButton ReadButton;
        private Guna.UI.WinForms.GunaButton UpdateButton;
        private Guna.UI.WinForms.GunaDataGridView dgvSanPham;
    }
}