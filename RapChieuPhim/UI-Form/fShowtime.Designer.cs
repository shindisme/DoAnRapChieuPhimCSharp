namespace RapChieuPhim.UI_Form
{
    partial class fShowtime
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
            this.label4 = new System.Windows.Forms.Label();
            this.cboRoomName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbShowtimeId = new System.Windows.Forms.TextBox();
            this.cboMovieName = new System.Windows.Forms.ComboBox();
            this.dgvShowtime = new System.Windows.Forms.DataGridView();
            this.ShowtimeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbFind = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.txbFindRoomName = new System.Windows.Forms.TextBox();
            this.txbFindMovieName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbFindID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbShown = new System.Windows.Forms.RadioButton();
            this.rdbShowing = new System.Windows.Forms.RadioButton();
            this.rdbNotShown = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtime)).BeginInit();
            this.grbFind.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Phòng:";
            // 
            // cboRoomName
            // 
            this.cboRoomName.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomName.FormattingEnabled = true;
            this.cboRoomName.Location = new System.Drawing.Point(152, 132);
            this.cboRoomName.Margin = new System.Windows.Forms.Padding(2);
            this.cboRoomName.Name = "cboRoomName";
            this.cboRoomName.Size = new System.Drawing.Size(198, 26);
            this.cboRoomName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên phim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ngày chiếu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã suất chiếu:";
            // 
            // txbShowtimeId
            // 
            this.txbShowtimeId.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbShowtimeId.Location = new System.Drawing.Point(152, 36);
            this.txbShowtimeId.Margin = new System.Windows.Forms.Padding(2);
            this.txbShowtimeId.Name = "txbShowtimeId";
            this.txbShowtimeId.Size = new System.Drawing.Size(113, 25);
            this.txbShowtimeId.TabIndex = 1;
            // 
            // cboMovieName
            // 
            this.cboMovieName.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMovieName.FormattingEnabled = true;
            this.cboMovieName.Location = new System.Drawing.Point(152, 84);
            this.cboMovieName.Margin = new System.Windows.Forms.Padding(2);
            this.cboMovieName.Name = "cboMovieName";
            this.cboMovieName.Size = new System.Drawing.Size(198, 26);
            this.cboMovieName.TabIndex = 2;
            // 
            // dgvShowtime
            // 
            this.dgvShowtime.AllowUserToAddRows = false;
            this.dgvShowtime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowtime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShowtimeID,
            this.S_MovieName,
            this.S_RoomName,
            this.Date,
            this.Time,
            this.Movie,
            this.Room});
            this.dgvShowtime.Location = new System.Drawing.Point(38, 288);
            this.dgvShowtime.Margin = new System.Windows.Forms.Padding(2);
            this.dgvShowtime.Name = "dgvShowtime";
            this.dgvShowtime.RowHeadersWidth = 51;
            this.dgvShowtime.RowTemplate.Height = 24;
            this.dgvShowtime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowtime.Size = new System.Drawing.Size(1054, 299);
            this.dgvShowtime.TabIndex = 19;
            this.dgvShowtime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowtime_CellClick);
            // 
            // ShowtimeID
            // 
            this.ShowtimeID.DataPropertyName = "StID";
            this.ShowtimeID.HeaderText = "Mã suất chiếu";
            this.ShowtimeID.MinimumWidth = 6;
            this.ShowtimeID.Name = "ShowtimeID";
            // 
            // S_MovieName
            // 
            this.S_MovieName.DataPropertyName = "MovieName";
            this.S_MovieName.HeaderText = "Tên phim";
            this.S_MovieName.MinimumWidth = 6;
            this.S_MovieName.Name = "S_MovieName";
            // 
            // S_RoomName
            // 
            this.S_RoomName.DataPropertyName = "RoomName";
            this.S_RoomName.HeaderText = "Phòng";
            this.S_RoomName.MinimumWidth = 6;
            this.S_RoomName.Name = "S_RoomName";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Ngày chiếu";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Giờ";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            // 
            // Movie
            // 
            this.Movie.DataPropertyName = "Movie";
            this.Movie.HeaderText = "Movie";
            this.Movie.MinimumWidth = 6;
            this.Movie.Name = "Movie";
            this.Movie.Visible = false;
            // 
            // Room
            // 
            this.Room.DataPropertyName = "Room";
            this.Room.HeaderText = "Room";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            this.Room.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1118, 288);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 52);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbFind
            // 
            this.grbFind.Controls.Add(this.cboStatus);
            this.grbFind.Controls.Add(this.label6);
            this.grbFind.Controls.Add(this.dtpTo);
            this.grbFind.Controls.Add(this.dtpFrom);
            this.grbFind.Controls.Add(this.txbFindRoomName);
            this.grbFind.Controls.Add(this.txbFindMovieName);
            this.grbFind.Controls.Add(this.label7);
            this.grbFind.Controls.Add(this.label12);
            this.grbFind.Controls.Add(this.label10);
            this.grbFind.Controls.Add(this.label11);
            this.grbFind.Controls.Add(this.txbFindID);
            this.grbFind.Controls.Add(this.label9);
            this.grbFind.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFind.Location = new System.Drawing.Point(622, 34);
            this.grbFind.Margin = new System.Windows.Forms.Padding(2);
            this.grbFind.Name = "grbFind";
            this.grbFind.Padding = new System.Windows.Forms.Padding(2);
            this.grbFind.Size = new System.Drawing.Size(470, 238);
            this.grbFind.TabIndex = 28;
            this.grbFind.TabStop = false;
            this.grbFind.Text = "Tìm Kiếm:";
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(112, 163);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(136, 26);
            this.cboStatus.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Đến:";
            // 
            // dtpTo
            // 
            this.dtpTo.CalendarFont = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(302, 125);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTo.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(136, 27);
            this.dtpTo.TabIndex = 15;
            this.dtpTo.Value = new System.DateTime(2024, 12, 13, 0, 0, 0, 0);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarFont = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(112, 124);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFrom.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(136, 27);
            this.dtpFrom.TabIndex = 15;
            this.dtpFrom.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // txbFindRoomName
            // 
            this.txbFindRoomName.Font = new System.Drawing.Font("Rockwell", 9F);
            this.txbFindRoomName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbFindRoomName.Location = new System.Drawing.Point(112, 95);
            this.txbFindRoomName.Margin = new System.Windows.Forms.Padding(2);
            this.txbFindRoomName.Name = "txbFindRoomName";
            this.txbFindRoomName.Size = new System.Drawing.Size(205, 25);
            this.txbFindRoomName.TabIndex = 14;
            // 
            // txbFindMovieName
            // 
            this.txbFindMovieName.Font = new System.Drawing.Font("Rockwell", 9F);
            this.txbFindMovieName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbFindMovieName.Location = new System.Drawing.Point(112, 62);
            this.txbFindMovieName.Margin = new System.Windows.Forms.Padding(2);
            this.txbFindMovieName.Name = "txbFindMovieName";
            this.txbFindMovieName.Size = new System.Drawing.Size(205, 25);
            this.txbFindMovieName.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Trạng thái";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 128);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 24);
            this.label12.TabIndex = 26;
            this.label12.Text = "Ngày:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Phòng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tên Phim:";
            // 
            // txbFindID
            // 
            this.txbFindID.Font = new System.Drawing.Font("Rockwell", 9F);
            this.txbFindID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbFindID.Location = new System.Drawing.Point(112, 28);
            this.txbFindID.Margin = new System.Windows.Forms.Padding(2);
            this.txbFindID.Name = "txbFindID";
            this.txbFindID.Size = new System.Drawing.Size(84, 25);
            this.txbFindID.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Mã:";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(1118, 535);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 52);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Quay Về";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(1118, 452);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(91, 52);
            this.btnModify.TabIndex = 8;
            this.btnModify.Text = "Sửa";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1118, 364);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 52);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(1118, 81);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(91, 52);
            this.btnFind.TabIndex = 18;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1118, 158);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 52);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giờ chiếu:";
            // 
            // dtpTime
            // 
            this.dtpTime.CalendarFont = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(152, 213);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(136, 27);
            this.dtpTime.TabIndex = 4;
            this.dtpTime.Value = new System.DateTime(2024, 12, 19, 0, 0, 0, 0);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(152, 174);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(136, 27);
            this.dtpDate.TabIndex = 15;
            this.dtpDate.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbShown);
            this.groupBox1.Controls.Add(this.rdbShowing);
            this.groupBox1.Controls.Add(this.rdbNotShown);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(405, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 158);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trạng Thái:";
            // 
            // rdbShown
            // 
            this.rdbShown.AutoSize = true;
            this.rdbShown.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbShown.Location = new System.Drawing.Point(16, 112);
            this.rdbShown.Name = "rdbShown";
            this.rdbShown.Size = new System.Drawing.Size(86, 28);
            this.rdbShown.TabIndex = 0;
            this.rdbShown.TabStop = true;
            this.rdbShown.Text = "Đã chiếu";
            this.rdbShown.UseVisualStyleBackColor = true;
            // 
            // rdbShowing
            // 
            this.rdbShowing.AutoSize = true;
            this.rdbShowing.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbShowing.Location = new System.Drawing.Point(16, 78);
            this.rdbShowing.Name = "rdbShowing";
            this.rdbShowing.Size = new System.Drawing.Size(103, 28);
            this.rdbShowing.TabIndex = 0;
            this.rdbShowing.TabStop = true;
            this.rdbShowing.Text = "Đang chiếu";
            this.rdbShowing.UseVisualStyleBackColor = true;
            // 
            // rdbNotShown
            // 
            this.rdbNotShown.AutoSize = true;
            this.rdbNotShown.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNotShown.Location = new System.Drawing.Point(16, 44);
            this.rdbNotShown.Name = "rdbNotShown";
            this.rdbNotShown.Size = new System.Drawing.Size(104, 28);
            this.rdbNotShown.TabIndex = 0;
            this.rdbNotShown.TabStop = true;
            this.rdbNotShown.Text = "Chưa chiếu";
            this.rdbNotShown.UseVisualStyleBackColor = true;
            // 
            // fShowtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1238, 607);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.grbFind);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboRoomName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbShowtimeId);
            this.Controls.Add(this.cboMovieName);
            this.Controls.Add(this.dgvShowtime);
            this.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fShowtime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Suất chiếu";
            this.Load += new System.EventHandler(this.fShowtime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtime)).EndInit();
            this.grbFind.ResumeLayout(false);
            this.grbFind.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboRoomName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbShowtimeId;
        private System.Windows.Forms.ComboBox cboMovieName;
        private System.Windows.Forms.DataGridView dgvShowtime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbFind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbFindID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.TextBox txbFindRoomName;
        private System.Windows.Forms.TextBox txbFindMovieName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowtimeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbShown;
        private System.Windows.Forms.RadioButton rdbShowing;
        private System.Windows.Forms.RadioButton rdbNotShown;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label7;
    }
}