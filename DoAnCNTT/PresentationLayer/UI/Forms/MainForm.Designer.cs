namespace PresentationLayer.UI.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonKH = new Guna.UI.WinForms.GunaButton();
            this.ButtonSP = new Guna.UI.WinForms.GunaButton();
            this.lblTen = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.ButtonTK = new Guna.UI.WinForms.GunaButton();
            this.ButtonHDNH = new Guna.UI.WinForms.GunaButton();
            this.ButtonNCC = new Guna.UI.WinForms.GunaButton();
            this.ButtonNV = new Guna.UI.WinForms.GunaButton();
            this.ButtonHDBH = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.lblChucVu = new System.Windows.Forms.TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonKH
            // 
            this.ButtonKH.AnimationHoverSpeed = 0.07F;
            this.ButtonKH.AnimationSpeed = 0.03F;
            this.ButtonKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ButtonKH.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ButtonKH.BorderColor = System.Drawing.Color.Black;
            this.ButtonKH.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonKH.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonKH.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonKH.ForeColor = System.Drawing.Color.Black;
            this.ButtonKH.Image = ((System.Drawing.Image)(resources.GetObject("ButtonKH.Image")));
            this.ButtonKH.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonKH.Location = new System.Drawing.Point(1, 317);
            this.ButtonKH.Name = "ButtonKH";
            this.ButtonKH.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.ButtonKH.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonKH.OnHoverForeColor = System.Drawing.Color.Black;
            this.ButtonKH.OnHoverImage = null;
            this.ButtonKH.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonKH.Size = new System.Drawing.Size(306, 42);
            this.ButtonKH.TabIndex = 15;
            this.ButtonKH.Text = "Khách Hàng";
            this.ButtonKH.Click += new System.EventHandler(this.ButtonKH_Click);
            // 
            // ButtonSP
            // 
            this.ButtonSP.AnimationHoverSpeed = 0.07F;
            this.ButtonSP.AnimationSpeed = 0.03F;
            this.ButtonSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ButtonSP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ButtonSP.BorderColor = System.Drawing.Color.Black;
            this.ButtonSP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonSP.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonSP.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonSP.ForeColor = System.Drawing.Color.Black;
            this.ButtonSP.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSP.Image")));
            this.ButtonSP.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonSP.Location = new System.Drawing.Point(1, 269);
            this.ButtonSP.Name = "ButtonSP";
            this.ButtonSP.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.ButtonSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonSP.OnHoverForeColor = System.Drawing.Color.Black;
            this.ButtonSP.OnHoverImage = null;
            this.ButtonSP.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonSP.Size = new System.Drawing.Size(306, 42);
            this.ButtonSP.TabIndex = 9;
            this.ButtonSP.Text = "Sản Phẩm";
            this.ButtonSP.Click += new System.EventHandler(this.ButtonSP_Click);
            // 
            // lblTen
            // 
            this.lblTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.lblTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTen.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTen.Location = new System.Drawing.Point(45, 189);
            this.lblTen.Multiline = true;
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(207, 30);
            this.lblTen.TabIndex = 10;
            this.lblTen.Text = "Nguyễn Hoài Bảo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Location = new System.Drawing.Point(307, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 848);
            this.panel1.TabIndex = 12;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(24, 778);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(38, 43);
            this.dgv.TabIndex = 0;
            this.dgv.Visible = false;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(73, 3);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(143, 144);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 13;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // ButtonTK
            // 
            this.ButtonTK.AnimationHoverSpeed = 0.07F;
            this.ButtonTK.AnimationSpeed = 0.03F;
            this.ButtonTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ButtonTK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ButtonTK.BorderColor = System.Drawing.Color.Black;
            this.ButtonTK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonTK.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonTK.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonTK.ForeColor = System.Drawing.Color.Black;
            this.ButtonTK.Image = ((System.Drawing.Image)(resources.GetObject("ButtonTK.Image")));
            this.ButtonTK.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonTK.Location = new System.Drawing.Point(1, 557);
            this.ButtonTK.Name = "ButtonTK";
            this.ButtonTK.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.ButtonTK.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonTK.OnHoverForeColor = System.Drawing.Color.Black;
            this.ButtonTK.OnHoverImage = null;
            this.ButtonTK.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonTK.Size = new System.Drawing.Size(306, 42);
            this.ButtonTK.TabIndex = 20;
            this.ButtonTK.Text = "Thống Kê";
            this.ButtonTK.Click += new System.EventHandler(this.ButtonTK_Click);
            // 
            // ButtonHDNH
            // 
            this.ButtonHDNH.AnimationHoverSpeed = 0.07F;
            this.ButtonHDNH.AnimationSpeed = 0.03F;
            this.ButtonHDNH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ButtonHDNH.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ButtonHDNH.BorderColor = System.Drawing.Color.Black;
            this.ButtonHDNH.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonHDNH.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonHDNH.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonHDNH.ForeColor = System.Drawing.Color.Black;
            this.ButtonHDNH.Image = ((System.Drawing.Image)(resources.GetObject("ButtonHDNH.Image")));
            this.ButtonHDNH.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonHDNH.Location = new System.Drawing.Point(1, 509);
            this.ButtonHDNH.Name = "ButtonHDNH";
            this.ButtonHDNH.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.ButtonHDNH.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonHDNH.OnHoverForeColor = System.Drawing.Color.Black;
            this.ButtonHDNH.OnHoverImage = null;
            this.ButtonHDNH.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonHDNH.Size = new System.Drawing.Size(306, 42);
            this.ButtonHDNH.TabIndex = 19;
            this.ButtonHDNH.Text = "Hóa Đơn Nhập Hàng";
            this.ButtonHDNH.Click += new System.EventHandler(this.ButtonHDNH_Click);
            // 
            // ButtonNCC
            // 
            this.ButtonNCC.AnimationHoverSpeed = 0.07F;
            this.ButtonNCC.AnimationSpeed = 0.03F;
            this.ButtonNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ButtonNCC.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ButtonNCC.BorderColor = System.Drawing.Color.Black;
            this.ButtonNCC.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonNCC.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonNCC.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonNCC.ForeColor = System.Drawing.Color.Black;
            this.ButtonNCC.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNCC.Image")));
            this.ButtonNCC.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonNCC.Location = new System.Drawing.Point(1, 461);
            this.ButtonNCC.Name = "ButtonNCC";
            this.ButtonNCC.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.ButtonNCC.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonNCC.OnHoverForeColor = System.Drawing.Color.Black;
            this.ButtonNCC.OnHoverImage = null;
            this.ButtonNCC.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonNCC.Size = new System.Drawing.Size(306, 42);
            this.ButtonNCC.TabIndex = 14;
            this.ButtonNCC.Text = "Nhà Cung Cấp";
            this.ButtonNCC.Click += new System.EventHandler(this.ButtonNCC_Click);
            // 
            // ButtonNV
            // 
            this.ButtonNV.AnimationHoverSpeed = 0.07F;
            this.ButtonNV.AnimationSpeed = 0.03F;
            this.ButtonNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ButtonNV.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ButtonNV.BorderColor = System.Drawing.Color.Black;
            this.ButtonNV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonNV.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonNV.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonNV.ForeColor = System.Drawing.Color.Black;
            this.ButtonNV.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNV.Image")));
            this.ButtonNV.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonNV.Location = new System.Drawing.Point(1, 413);
            this.ButtonNV.Name = "ButtonNV";
            this.ButtonNV.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.ButtonNV.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonNV.OnHoverForeColor = System.Drawing.Color.Black;
            this.ButtonNV.OnHoverImage = null;
            this.ButtonNV.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonNV.Size = new System.Drawing.Size(306, 42);
            this.ButtonNV.TabIndex = 18;
            this.ButtonNV.Text = "Nhân Viên";
            this.ButtonNV.Click += new System.EventHandler(this.ButtonNV_Click);
            // 
            // ButtonHDBH
            // 
            this.ButtonHDBH.AnimationHoverSpeed = 0.07F;
            this.ButtonHDBH.AnimationSpeed = 0.03F;
            this.ButtonHDBH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ButtonHDBH.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ButtonHDBH.BorderColor = System.Drawing.Color.Black;
            this.ButtonHDBH.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonHDBH.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonHDBH.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonHDBH.ForeColor = System.Drawing.Color.Black;
            this.ButtonHDBH.Image = ((System.Drawing.Image)(resources.GetObject("ButtonHDBH.Image")));
            this.ButtonHDBH.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonHDBH.Location = new System.Drawing.Point(1, 365);
            this.ButtonHDBH.Name = "ButtonHDBH";
            this.ButtonHDBH.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.ButtonHDBH.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonHDBH.OnHoverForeColor = System.Drawing.Color.Black;
            this.ButtonHDBH.OnHoverImage = null;
            this.ButtonHDBH.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonHDBH.Size = new System.Drawing.Size(306, 42);
            this.ButtonHDBH.TabIndex = 17;
            this.ButtonHDBH.Text = "Hóa Đơn Bán Hàng";
            this.ButtonHDBH.Click += new System.EventHandler(this.ButtonHDBH_Click);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaButton3.BaseColor = System.Drawing.Color.Empty;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaButton3.ForeColor = System.Drawing.Color.Black;
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton3.Location = new System.Drawing.Point(1, 796);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(306, 52);
            this.gunaButton3.TabIndex = 16;
            this.gunaButton3.Text = "Đăng xuất";
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 8;
            this.gunaElipse1.TargetControl = this;
            // 
            // lblChucVu
            // 
            this.lblChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.lblChucVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblChucVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblChucVu.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChucVu.Location = new System.Drawing.Point(89, 153);
            this.lblChucVu.Multiline = true;
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(143, 30);
            this.lblChucVu.TabIndex = 21;
            this.lblChucVu.Text = "Quản lý";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(-18, -10);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(325, 876);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 850);
            this.Controls.Add(this.ButtonKH);
            this.Controls.Add(this.ButtonSP);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.ButtonTK);
            this.Controls.Add(this.ButtonHDNH);
            this.Controls.Add(this.ButtonNCC);
            this.Controls.Add(this.ButtonNV);
            this.Controls.Add(this.ButtonHDBH);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brother Sport Club Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton ButtonKH;
        private Guna.UI.WinForms.GunaButton ButtonSP;
        private System.Windows.Forms.TextBox lblTen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaButton ButtonTK;
        private Guna.UI.WinForms.GunaButton ButtonHDNH;
        private Guna.UI.WinForms.GunaButton ButtonNCC;
        private Guna.UI.WinForms.GunaButton ButtonNV;
        private Guna.UI.WinForms.GunaButton ButtonHDBH;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.TextBox lblChucVu;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}