namespace QuanLyThiNghe.Forms
{
    partial class frmTaoPhongThi
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Huyện Cai Lậy", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Huyện Châu Thành", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Trường THPT Đốc Binh Kiều", "Truong.png");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Trường THPT Phan Việt Thống", 0);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Trường THPT Võ Việt Tân", 0);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Trường THPT Trừ Văn Thố", 0);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Trường THPT Nguyễn Đình Chiểu", "Truong.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoPhongThi));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Trường THPT Đốc Binh Kiều", "Truong.png");
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Huyện Cai Lậy", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Trường THPT Phan Việt Thống", 0);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Trường THPT Võ Việt Tân", 0);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Trường THPT Trừ Văn Thố", 0);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Huyện Châu Thành", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Trường THPT Nguyễn Đình Chiểu", "Truong.png");
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDistricts = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbHDT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lvSchools = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.lblSchoolName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblDistrictName = new DevExpress.XtraEditors.LabelControl();
            this.lblRooms = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lvSchools2 = new System.Windows.Forms.ListView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDistricts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbDistricts);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(634, 40);
            this.panel1.TabIndex = 0;
            // 
            // cbDistricts
            // 
            this.cbDistricts.Location = new System.Drawing.Point(105, 11);
            this.cbDistricts.Name = "cbDistricts";
            this.cbDistricts.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbDistricts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.cbDistricts.Properties.DropDownRows = 10;
            this.cbDistricts.Size = new System.Drawing.Size(180, 20);
            this.cbDistricts.TabIndex = 28;
            this.cbDistricts.SelectedIndexChanged += new System.EventHandler(this.cbDistricts_SelectedIndexChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl8.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseImage = true;
            this.labelControl8.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl8.Location = new System.Drawing.Point(8, 11);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(91, 20);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Chọn huyện:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::QuanLyThiNghe.Properties.Resources.save_16;
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(308, 5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(30, 30);
            this.simpleButton2.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.Location = new System.Drawing.Point(301, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 40);
            this.panel4.TabIndex = 3;
            // 
            // cbHDT
            // 
            this.cbHDT.Location = new System.Drawing.Point(391, 46);
            this.cbHDT.Name = "cbHDT";
            this.cbHDT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.cbHDT.Size = new System.Drawing.Size(181, 20);
            this.cbHDT.TabIndex = 26;
            this.cbHDT.SelectedIndexChanged += new System.EventHandler(this.cbHDT_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.icon20;
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseImage = true;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(309, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 20);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Chọn HĐT:";
            // 
            // lvSchools
            // 
            this.lvSchools.AllowColumnReorder = true;
            this.lvSchools.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSchools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvSchools.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvSchools.Font = new System.Drawing.Font("Segoe UI", 9F);
            listViewGroup1.Header = "Huyện Cai Lậy";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "Huyện Châu Thành";
            listViewGroup2.Name = "listViewGroup2";
            this.lvSchools.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listViewItem4.Group = listViewGroup2;
            listViewItem5.Group = listViewGroup2;
            this.lvSchools.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.lvSchools.LargeImageList = this.imageList1;
            this.lvSchools.Location = new System.Drawing.Point(5, 45);
            this.lvSchools.Name = "lvSchools";
            this.lvSchools.Size = new System.Drawing.Size(300, 372);
            this.lvSchools.SmallImageList = this.imageList1;
            this.lvSchools.TabIndex = 1;
            this.lvSchools.TileSize = new System.Drawing.Size(280, 50);
            this.lvSchools.UseCompatibleStateImageBehavior = false;
            this.lvSchools.View = System.Windows.Forms.View.Tile;
            this.lvSchools.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSchools_MouseDoubleClick);
            this.lvSchools.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvSchool_MouseUp);
            this.lvSchools.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvSchool_MouseMove);
            this.lvSchools.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvSchool_MouseDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Truong.png");
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Location = new System.Drawing.Point(306, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 370);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyThiNghe.Properties.Resources.HDT;
            this.pictureBox1.Location = new System.Drawing.Point(308, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl15
            // 
            this.labelControl15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelControl15.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.pin;
            this.labelControl15.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseForeColor = true;
            this.labelControl15.Appearance.Options.UseImage = true;
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl15.LineColor = System.Drawing.Color.Silver;
            this.labelControl15.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl15.LineVisible = true;
            this.labelControl15.Location = new System.Drawing.Point(313, 77);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(314, 23);
            this.labelControl15.TabIndex = 24;
            this.labelControl15.Text = "Thông tin về HĐT:";
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolName.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSchoolName.Appearance.Options.UseFont = true;
            this.lblSchoolName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblSchoolName.Location = new System.Drawing.Point(449, 109);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(84, 14);
            this.lblSchoolName.TabIndex = 21;
            this.lblSchoolName.Text = "Đốc Binh Kiều";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.tag_blue;
            this.labelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseImage = true;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl3.Location = new System.Drawing.Point(383, 132);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 20);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Huyện:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.tag_blue;
            this.labelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseImage = true;
            this.labelControl4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl4.Location = new System.Drawing.Point(383, 158);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 20);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Số phòng thi:";
            // 
            // lblDistrictName
            // 
            this.lblDistrictName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrictName.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDistrictName.Appearance.Options.UseFont = true;
            this.lblDistrictName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblDistrictName.Location = new System.Drawing.Point(449, 135);
            this.lblDistrictName.Name = "lblDistrictName";
            this.lblDistrictName.Size = new System.Drawing.Size(33, 14);
            this.lblDistrictName.TabIndex = 21;
            this.lblDistrictName.Text = "Cai lậy";
            // 
            // lblRooms
            // 
            this.lblRooms.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRooms.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblRooms.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRooms.Appearance.Options.UseFont = true;
            this.lblRooms.Appearance.Options.UseForeColor = true;
            this.lblRooms.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblRooms.Location = new System.Drawing.Point(485, 161);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(16, 14);
            this.lblRooms.TabIndex = 21;
            this.lblRooms.Text = "12";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelControl7.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.pin;
            this.labelControl7.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Appearance.Options.UseImage = true;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl7.LineColor = System.Drawing.Color.Silver;
            this.labelControl7.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl7.LineVisible = true;
            this.labelControl7.Location = new System.Drawing.Point(313, 184);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(314, 23);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Các trường tham gia HĐT này:";
            // 
            // lvSchools2
            // 
            this.lvSchools2.AllowDrop = true;
            this.lvSchools2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSchools2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSchools2.Font = new System.Drawing.Font("Segoe UI", 9F);
            listViewGroup3.Header = "Huyện Cai Lậy";
            listViewGroup3.Name = "listViewGroup1";
            listViewItem6.Group = listViewGroup3;
            listViewItem7.Group = listViewGroup3;
            listViewItem8.Group = listViewGroup3;
            listViewGroup4.Header = "Huyện Châu Thành";
            listViewGroup4.Name = "listViewGroup2";
            listViewItem9.Group = listViewGroup4;
            listViewItem10.Group = listViewGroup4;
            this.lvSchools2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.lvSchools2.LargeImageList = this.imageList1;
            this.lvSchools2.Location = new System.Drawing.Point(313, 213);
            this.lvSchools2.Name = "lvSchools2";
            this.lvSchools2.Size = new System.Drawing.Size(314, 200);
            this.lvSchools2.SmallImageList = this.imageList1;
            this.lvSchools2.TabIndex = 25;
            this.lvSchools2.TileSize = new System.Drawing.Size(250, 50);
            this.lvSchools2.UseCompatibleStateImageBehavior = false;
            this.lvSchools2.View = System.Windows.Forms.View.Tile;
            this.lvSchools2.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvSchool_DragDrop);
            this.lvSchools2.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvSchools2_DragEnter);
            this.lvSchools2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvSchools2_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Image = global::QuanLyThiNghe.Properties.Resources.tag_blue;
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseImage = true;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.Location = new System.Drawing.Point(383, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 20);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Huyện:";
            // 
            // frmTaoPhongThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 422);
            this.Controls.Add(this.cbHDT);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lvSchools2);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lblRooms);
            this.Controls.Add(this.lblDistrictName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblSchoolName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lvSchools);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaoPhongThi";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sắp xếp Hội Đồng thi";
            this.Load += new System.EventHandler(this.frmTaoPhongThi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDistricts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvSchools;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.ComboBoxEdit cbHDT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl lblSchoolName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblDistrictName;
        private DevExpress.XtraEditors.LabelControl lblRooms;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ListView lvSchools2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.ComboBoxEdit cbDistricts;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}