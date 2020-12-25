namespace Salon
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
            this.SalonsControls = new MaterialSkin.Controls.MaterialTabControl();
            this.SalonsTabPage = new System.Windows.Forms.TabPage();
            this.AvrgRatingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RatingBtn = new MaterialSkin.Controls.MaterialButton();
            this.SelectedVehicledChb = new MaterialSkin.Controls.MaterialCheckbox();
            this.ExpXlsBtn = new MaterialSkin.Controls.MaterialButton();
            this.BookBtn = new MaterialSkin.Controls.MaterialButton();
            this.BuyBtn = new MaterialSkin.Controls.MaterialButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.VehicleListData = new System.Windows.Forms.DataGridView();
            this.clMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSalon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentersComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.CentresLabel = new MaterialSkin.Controls.MaterialLabel();
            this.KoszykTabPage = new System.Windows.Forms.TabPage();
            this.KoszykSelectedVehicleChb = new MaterialSkin.Controls.MaterialCheckbox();
            this.RefreshButton = new MaterialSkin.Controls.MaterialButton();
            this.RemoveBtn = new MaterialSkin.Controls.MaterialButton();
            this.KoszykList = new System.Windows.Forms.DataGridView();
            this.MarkCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KoszykVehicleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalonCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservedCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.xlsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SalonsControls.SuspendLayout();
            this.SalonsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleListData)).BeginInit();
            this.KoszykTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KoszykList)).BeginInit();
            this.SuspendLayout();
            // 
            // SalonsControls
            // 
            this.SalonsControls.Controls.Add(this.SalonsTabPage);
            this.SalonsControls.Controls.Add(this.KoszykTabPage);
            this.SalonsControls.Depth = 0;
            this.SalonsControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalonsControls.ImageList = this.imageList1;
            this.SalonsControls.Location = new System.Drawing.Point(0, 0);
            this.SalonsControls.MouseState = MaterialSkin.MouseState.HOVER;
            this.SalonsControls.Multiline = true;
            this.SalonsControls.Name = "SalonsControls";
            this.SalonsControls.SelectedIndex = 0;
            this.SalonsControls.Size = new System.Drawing.Size(1510, 706);
            this.SalonsControls.TabIndex = 0;
            // 
            // SalonsTabPage
            // 
            this.SalonsTabPage.Controls.Add(this.xlsLinkLabel);
            this.SalonsTabPage.Controls.Add(this.AvrgRatingLabel);
            this.SalonsTabPage.Controls.Add(this.RatingBtn);
            this.SalonsTabPage.Controls.Add(this.SelectedVehicledChb);
            this.SalonsTabPage.Controls.Add(this.ExpXlsBtn);
            this.SalonsTabPage.Controls.Add(this.BookBtn);
            this.SalonsTabPage.Controls.Add(this.BuyBtn);
            this.SalonsTabPage.Controls.Add(this.SearchTextBox);
            this.SalonsTabPage.Controls.Add(this.VehicleListData);
            this.SalonsTabPage.Controls.Add(this.CentersComboBox);
            this.SalonsTabPage.Controls.Add(this.CentresLabel);
            this.SalonsTabPage.ImageKey = "icons8-car-48.png";
            this.SalonsTabPage.Location = new System.Drawing.Point(4, 39);
            this.SalonsTabPage.Name = "SalonsTabPage";
            this.SalonsTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.SalonsTabPage.Size = new System.Drawing.Size(1502, 663);
            this.SalonsTabPage.TabIndex = 0;
            this.SalonsTabPage.Text = "Salons";
            this.SalonsTabPage.UseVisualStyleBackColor = true;
            // 
            // AvrgRatingLabel
            // 
            this.AvrgRatingLabel.Depth = 0;
            this.AvrgRatingLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AvrgRatingLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AvrgRatingLabel.Location = new System.Drawing.Point(263, 89);
            this.AvrgRatingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AvrgRatingLabel.Name = "AvrgRatingLabel";
            this.AvrgRatingLabel.Size = new System.Drawing.Size(360, 34);
            this.AvrgRatingLabel.TabIndex = 14;
            this.AvrgRatingLabel.Text = "średnia ocen użytkowników";
            // 
            // RatingBtn
            // 
            this.RatingBtn.AutoSize = false;
            this.RatingBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RatingBtn.Depth = 0;
            this.RatingBtn.DrawShadows = true;
            this.RatingBtn.HighEmphasis = true;
            this.RatingBtn.Icon = null;
            this.RatingBtn.Location = new System.Drawing.Point(1228, 186);
            this.RatingBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RatingBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RatingBtn.Name = "RatingBtn";
            this.RatingBtn.Size = new System.Drawing.Size(133, 36);
            this.RatingBtn.TabIndex = 13;
            this.RatingBtn.Text = "Rate salon";
            this.RatingBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RatingBtn.UseAccentColor = false;
            this.RatingBtn.UseVisualStyleBackColor = true;
            this.RatingBtn.Click += new System.EventHandler(this.RatingBtn_Click);
            // 
            // SelectedVehicledChb
            // 
            this.SelectedVehicledChb.AutoSize = true;
            this.SelectedVehicledChb.Depth = 0;
            this.SelectedVehicledChb.Location = new System.Drawing.Point(862, 494);
            this.SelectedVehicledChb.Margin = new System.Windows.Forms.Padding(0);
            this.SelectedVehicledChb.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SelectedVehicledChb.MouseState = MaterialSkin.MouseState.HOVER;
            this.SelectedVehicledChb.Name = "SelectedVehicledChb";
            this.SelectedVehicledChb.Ripple = true;
            this.SelectedVehicledChb.Size = new System.Drawing.Size(178, 37);
            this.SelectedVehicledChb.TabIndex = 12;
            this.SelectedVehicledChb.Text = "Is Vehicle Selected ?";
            this.SelectedVehicledChb.UseVisualStyleBackColor = true;
            // 
            // ExpXlsBtn
            // 
            this.ExpXlsBtn.AutoSize = false;
            this.ExpXlsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExpXlsBtn.Depth = 0;
            this.ExpXlsBtn.DrawShadows = true;
            this.ExpXlsBtn.HighEmphasis = true;
            this.ExpXlsBtn.Icon = null;
            this.ExpXlsBtn.Location = new System.Drawing.Point(1134, 552);
            this.ExpXlsBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExpXlsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExpXlsBtn.Name = "ExpXlsBtn";
            this.ExpXlsBtn.Size = new System.Drawing.Size(268, 48);
            this.ExpXlsBtn.TabIndex = 11;
            this.ExpXlsBtn.Text = "Export Vehicles to *.xlsx";
            this.ExpXlsBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExpXlsBtn.UseAccentColor = false;
            this.ExpXlsBtn.UseVisualStyleBackColor = true;
            this.ExpXlsBtn.Click += new System.EventHandler(this.ExpXlsBtn_Click);
            // 
            // BookBtn
            // 
            this.BookBtn.AutoSize = false;
            this.BookBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BookBtn.Depth = 0;
            this.BookBtn.DrawShadows = true;
            this.BookBtn.HighEmphasis = true;
            this.BookBtn.Icon = null;
            this.BookBtn.Location = new System.Drawing.Point(1228, 126);
            this.BookBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BookBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(133, 36);
            this.BookBtn.TabIndex = 10;
            this.BookBtn.Text = "Book";
            this.BookBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BookBtn.UseAccentColor = false;
            this.BookBtn.UseVisualStyleBackColor = true;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // BuyBtn
            // 
            this.BuyBtn.AutoSize = false;
            this.BuyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuyBtn.Depth = 0;
            this.BuyBtn.DrawShadows = true;
            this.BuyBtn.HighEmphasis = true;
            this.BuyBtn.Icon = null;
            this.BuyBtn.Location = new System.Drawing.Point(1228, 74);
            this.BuyBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BuyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(133, 31);
            this.BuyBtn.TabIndex = 9;
            this.BuyBtn.Text = "Buy";
            this.BuyBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BuyBtn.UseAccentColor = false;
            this.BuyBtn.UseVisualStyleBackColor = true;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(921, 101);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(201, 22);
            this.SearchTextBox.TabIndex = 8;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // VehicleListData
            // 
            this.VehicleListData.BackgroundColor = System.Drawing.Color.White;
            this.VehicleListData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehicleListData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMark,
            this.VehicleId,
            this.clModel,
            this.clPrice,
            this.clYear,
            this.clSalon,
            this.clReserved});
            this.VehicleListData.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.VehicleListData.Location = new System.Drawing.Point(28, 139);
            this.VehicleListData.Name = "VehicleListData";
            this.VehicleListData.ReadOnly = true;
            this.VehicleListData.RowHeadersWidth = 51;
            this.VehicleListData.RowTemplate.Height = 24;
            this.VehicleListData.Size = new System.Drawing.Size(1094, 340);
            this.VehicleListData.TabIndex = 7;
            this.VehicleListData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VehicleListData_CellContentClickAsync);
            // 
            // clMark
            // 
            this.clMark.FillWeight = 60F;
            this.clMark.HeaderText = "Mark";
            this.clMark.MinimumWidth = 6;
            this.clMark.Name = "clMark";
            this.clMark.ReadOnly = true;
            this.clMark.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clMark.Width = 125;
            // 
            // VehicleId
            // 
            this.VehicleId.HeaderText = "ID";
            this.VehicleId.MinimumWidth = 6;
            this.VehicleId.Name = "VehicleId";
            this.VehicleId.ReadOnly = true;
            this.VehicleId.Visible = false;
            this.VehicleId.Width = 125;
            // 
            // clModel
            // 
            this.clModel.FillWeight = 60F;
            this.clModel.HeaderText = "Model";
            this.clModel.MinimumWidth = 6;
            this.clModel.Name = "clModel";
            this.clModel.ReadOnly = true;
            this.clModel.Width = 125;
            // 
            // clPrice
            // 
            this.clPrice.HeaderText = "Price";
            this.clPrice.MinimumWidth = 6;
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            this.clPrice.Width = 125;
            // 
            // clYear
            // 
            this.clYear.FillWeight = 60F;
            this.clYear.HeaderText = "Year";
            this.clYear.MinimumWidth = 6;
            this.clYear.Name = "clYear";
            this.clYear.ReadOnly = true;
            this.clYear.Width = 125;
            // 
            // clSalon
            // 
            this.clSalon.FillWeight = 60F;
            this.clSalon.HeaderText = "Salon";
            this.clSalon.MinimumWidth = 6;
            this.clSalon.Name = "clSalon";
            this.clSalon.ReadOnly = true;
            this.clSalon.Width = 125;
            // 
            // clReserved
            // 
            this.clReserved.HeaderText = "Reserved";
            this.clReserved.MinimumWidth = 6;
            this.clReserved.Name = "clReserved";
            this.clReserved.ReadOnly = true;
            this.clReserved.Width = 125;
            // 
            // CentersComboBox
            // 
            this.CentersComboBox.AutoResize = true;
            this.CentersComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CentersComboBox.Depth = 0;
            this.CentersComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CentersComboBox.DropDownHeight = 174;
            this.CentersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CentersComboBox.DropDownWidth = 121;
            this.CentersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CentersComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CentersComboBox.FormattingEnabled = true;
            this.CentersComboBox.IntegralHeight = false;
            this.CentersComboBox.ItemHeight = 43;
            this.CentersComboBox.Location = new System.Drawing.Point(28, 74);
            this.CentersComboBox.MaxDropDownItems = 4;
            this.CentersComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CentersComboBox.Name = "CentersComboBox";
            this.CentersComboBox.Size = new System.Drawing.Size(121, 49);
            this.CentersComboBox.TabIndex = 6;
            this.CentersComboBox.SelectedIndexChanged += new System.EventHandler(this.CentersComboBox_SelectedIndexChanged);
            // 
            // CentresLabel
            // 
            this.CentresLabel.AutoSize = true;
            this.CentresLabel.Depth = 0;
            this.CentresLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CentresLabel.Location = new System.Drawing.Point(25, 39);
            this.CentresLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CentresLabel.Name = "CentresLabel";
            this.CentresLabel.Size = new System.Drawing.Size(54, 19);
            this.CentresLabel.TabIndex = 5;
            this.CentresLabel.Text = "Centres";
            // 
            // KoszykTabPage
            // 
            this.KoszykTabPage.Controls.Add(this.KoszykSelectedVehicleChb);
            this.KoszykTabPage.Controls.Add(this.RefreshButton);
            this.KoszykTabPage.Controls.Add(this.RemoveBtn);
            this.KoszykTabPage.Controls.Add(this.KoszykList);
            this.KoszykTabPage.ImageKey = "icons8-list-52.png";
            this.KoszykTabPage.Location = new System.Drawing.Point(4, 39);
            this.KoszykTabPage.Name = "KoszykTabPage";
            this.KoszykTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.KoszykTabPage.Size = new System.Drawing.Size(1502, 663);
            this.KoszykTabPage.TabIndex = 1;
            this.KoszykTabPage.Text = "Booked";
            this.KoszykTabPage.UseVisualStyleBackColor = true;
            // 
            // KoszykSelectedVehicleChb
            // 
            this.KoszykSelectedVehicleChb.AutoSize = true;
            this.KoszykSelectedVehicleChb.Depth = 0;
            this.KoszykSelectedVehicleChb.Location = new System.Drawing.Point(913, 560);
            this.KoszykSelectedVehicleChb.Margin = new System.Windows.Forms.Padding(0);
            this.KoszykSelectedVehicleChb.MouseLocation = new System.Drawing.Point(-1, -1);
            this.KoszykSelectedVehicleChb.MouseState = MaterialSkin.MouseState.HOVER;
            this.KoszykSelectedVehicleChb.Name = "KoszykSelectedVehicleChb";
            this.KoszykSelectedVehicleChb.Ripple = true;
            this.KoszykSelectedVehicleChb.Size = new System.Drawing.Size(176, 37);
            this.KoszykSelectedVehicleChb.TabIndex = 10;
            this.KoszykSelectedVehicleChb.Text = "Is Vehicle selected ?";
            this.KoszykSelectedVehicleChb.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoSize = false;
            this.RefreshButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefreshButton.Depth = 0;
            this.RefreshButton.DrawShadows = true;
            this.RefreshButton.HighEmphasis = true;
            this.RefreshButton.Icon = null;
            this.RefreshButton.Location = new System.Drawing.Point(1236, 33);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RefreshButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(112, 36);
            this.RefreshButton.TabIndex = 9;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RefreshButton.UseAccentColor = false;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.AutoSize = false;
            this.RemoveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveBtn.Depth = 0;
            this.RemoveBtn.DrawShadows = true;
            this.RemoveBtn.HighEmphasis = true;
            this.RemoveBtn.Icon = null;
            this.RemoveBtn.Location = new System.Drawing.Point(1236, 103);
            this.RemoveBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RemoveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(112, 36);
            this.RemoveBtn.TabIndex = 8;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RemoveBtn.UseAccentColor = false;
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // KoszykList
            // 
            this.KoszykList.BackgroundColor = System.Drawing.Color.White;
            this.KoszykList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KoszykList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MarkCL,
            this.KoszykVehicleId,
            this.ModelCL,
            this.PriceCL,
            this.YearCL,
            this.SalonCl,
            this.ReservedCl});
            this.KoszykList.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.KoszykList.Location = new System.Drawing.Point(51, 33);
            this.KoszykList.Name = "KoszykList";
            this.KoszykList.ReadOnly = true;
            this.KoszykList.RowHeadersWidth = 51;
            this.KoszykList.RowTemplate.Height = 24;
            this.KoszykList.Size = new System.Drawing.Size(1078, 514);
            this.KoszykList.TabIndex = 7;
            this.KoszykList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KoszykList_CellContentClickAsync);
            // 
            // MarkCL
            // 
            this.MarkCL.FillWeight = 60F;
            this.MarkCL.HeaderText = "Mark";
            this.MarkCL.MinimumWidth = 6;
            this.MarkCL.Name = "MarkCL";
            this.MarkCL.ReadOnly = true;
            this.MarkCL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MarkCL.Width = 125;
            // 
            // KoszykVehicleId
            // 
            this.KoszykVehicleId.HeaderText = "ID";
            this.KoszykVehicleId.MinimumWidth = 6;
            this.KoszykVehicleId.Name = "KoszykVehicleId";
            this.KoszykVehicleId.ReadOnly = true;
            this.KoszykVehicleId.Visible = false;
            this.KoszykVehicleId.Width = 125;
            // 
            // ModelCL
            // 
            this.ModelCL.FillWeight = 60F;
            this.ModelCL.HeaderText = "Model";
            this.ModelCL.MinimumWidth = 6;
            this.ModelCL.Name = "ModelCL";
            this.ModelCL.ReadOnly = true;
            this.ModelCL.Width = 125;
            // 
            // PriceCL
            // 
            this.PriceCL.HeaderText = "Price";
            this.PriceCL.MinimumWidth = 6;
            this.PriceCL.Name = "PriceCL";
            this.PriceCL.ReadOnly = true;
            this.PriceCL.Width = 125;
            // 
            // YearCL
            // 
            this.YearCL.FillWeight = 60F;
            this.YearCL.HeaderText = "Year";
            this.YearCL.MinimumWidth = 6;
            this.YearCL.Name = "YearCL";
            this.YearCL.ReadOnly = true;
            this.YearCL.Width = 125;
            // 
            // SalonCl
            // 
            this.SalonCl.FillWeight = 60F;
            this.SalonCl.HeaderText = "Salon";
            this.SalonCl.MinimumWidth = 6;
            this.SalonCl.Name = "SalonCl";
            this.SalonCl.ReadOnly = true;
            this.SalonCl.Width = 125;
            // 
            // ReservedCl
            // 
            this.ReservedCl.HeaderText = "Reserved";
            this.ReservedCl.MinimumWidth = 6;
            this.ReservedCl.Name = "ReservedCl";
            this.ReservedCl.ReadOnly = true;
            this.ReservedCl.Width = 125;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-car-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-list-52.png");
            // 
            // xlsLinkLabel
            // 
            this.xlsLinkLabel.AutoSize = true;
            this.xlsLinkLabel.Location = new System.Drawing.Point(1137, 505);
            this.xlsLinkLabel.Name = "xlsLinkLabel";
            this.xlsLinkLabel.Size = new System.Drawing.Size(158, 17);
            this.xlsLinkLabel.TabIndex = 15;
            this.xlsLinkLabel.TabStop = true;
            this.xlsLinkLabel.Text = "download vehicles *.xlsx";
            this.xlsLinkLabel.Click += new System.EventHandler(this.xlsLinkLabel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 706);
            this.Controls.Add(this.SalonsControls);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.SalonsControls;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salon";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SalonsControls.ResumeLayout(false);
            this.SalonsTabPage.ResumeLayout(false);
            this.SalonsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleListData)).EndInit();
            this.KoszykTabPage.ResumeLayout(false);
            this.KoszykTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KoszykList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl SalonsControls;
        private System.Windows.Forms.TabPage SalonsTabPage;
        private System.Windows.Forms.TabPage KoszykTabPage;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialComboBox CentersComboBox;
        private MaterialSkin.Controls.MaterialLabel CentresLabel;
        private System.Windows.Forms.DataGridView VehicleListData;
        private System.Windows.Forms.TextBox SearchTextBox;
        private MaterialSkin.Controls.MaterialButton ExpXlsBtn;
        private MaterialSkin.Controls.MaterialButton BookBtn;
        private MaterialSkin.Controls.MaterialButton BuyBtn;
        private MaterialSkin.Controls.MaterialButton RemoveBtn;
        private System.Windows.Forms.DataGridView KoszykList;
        private MaterialSkin.Controls.MaterialButton RefreshButton;
        private MaterialSkin.Controls.MaterialCheckbox SelectedVehicledChb;
        private MaterialSkin.Controls.MaterialCheckbox KoszykSelectedVehicleChb;
        private MaterialSkin.Controls.MaterialButton RatingBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSalon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn KoszykVehicleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalonCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservedCl;
        private MaterialSkin.Controls.MaterialLabel AvrgRatingLabel;
        private System.Windows.Forms.LinkLabel xlsLinkLabel;
    }
}

