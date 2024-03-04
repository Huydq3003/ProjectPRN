namespace BookStore_HoangNT
{
    partial class BookManagerForm
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
            lblId = new Label();
            lblName = new Label();
            lblDesc = new Label();
            lblReleasedDate = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblAuthor = new Label();
            lblCategory = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtAuthor = new TextBox();
            dtpReleasedDate = new DateTimePicker();
            cboCategory = new ComboBox();
            gbBookInfo = new GroupBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtKeyword = new TextBox();
            lblKeyword = new Label();
            gbTask = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            gbSearch = new GroupBox();
            btnSearch = new Button();
            dgvBookList = new DataGridView();
            lblBookList = new Label();
            gbBookInfo.SuspendLayout();
            gbTask.SuspendLayout();
            gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.Yellow;
            lblId.Location = new Point(36, 92);
            lblId.Margin = new Padding(6, 0, 6, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(47, 41);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(36, 182);
            lblName.Margin = new Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(97, 41);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(36, 269);
            lblDesc.Margin = new Padding(6, 0, 6, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(169, 41);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Description";
            // 
            // lblReleasedDate
            // 
            lblReleasedDate.AutoSize = true;
            lblReleasedDate.Location = new Point(36, 525);
            lblReleasedDate.Margin = new Padding(6, 0, 6, 0);
            lblReleasedDate.Name = "lblReleasedDate";
            lblReleasedDate.Size = new Size(206, 41);
            lblReleasedDate.TabIndex = 3;
            lblReleasedDate.Text = "Released Date";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(36, 619);
            lblQuantity.Margin = new Padding(6, 0, 6, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(132, 41);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(616, 619);
            lblPrice.Margin = new Padding(6, 0, 6, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(82, 41);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(36, 709);
            lblAuthor.Margin = new Padding(6, 0, 6, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(109, 41);
            lblAuthor.TabIndex = 6;
            lblAuthor.Text = "Author";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(36, 812);
            lblCategory.Margin = new Padding(6, 0, 6, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(139, 41);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(278, 88);
            txtId.Margin = new Padding(6);
            txtId.Name = "txtId";
            txtId.Size = new Size(263, 47);
            txtId.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(278, 176);
            txtName.Margin = new Padding(6);
            txtName.Name = "txtName";
            txtName.Size = new Size(746, 47);
            txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(278, 262);
            txtDescription.Margin = new Padding(6);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(746, 205);
            txtDescription.TabIndex = 2;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(278, 703);
            txtAuthor.Margin = new Padding(6);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(746, 47);
            txtAuthor.TabIndex = 6;
            // 
            // dtpReleasedDate
            // 
            dtpReleasedDate.CustomFormat = "dd/MM/yyyy";
            dtpReleasedDate.Format = DateTimePickerFormat.Custom;
            dtpReleasedDate.Location = new Point(278, 515);
            dtpReleasedDate.Margin = new Padding(6);
            dtpReleasedDate.Name = "dtpReleasedDate";
            dtpReleasedDate.Size = new Size(318, 47);
            dtpReleasedDate.TabIndex = 3;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(278, 806);
            cboCategory.Margin = new Padding(6);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(746, 49);
            cboCategory.TabIndex = 7;
            // 
            // gbBookInfo
            // 
            gbBookInfo.Controls.Add(txtPrice);
            gbBookInfo.Controls.Add(txtQuantity);
            gbBookInfo.Controls.Add(cboCategory);
            gbBookInfo.Controls.Add(dtpReleasedDate);
            gbBookInfo.Controls.Add(txtAuthor);
            gbBookInfo.Controls.Add(txtDescription);
            gbBookInfo.Controls.Add(txtName);
            gbBookInfo.Controls.Add(txtId);
            gbBookInfo.Controls.Add(lblCategory);
            gbBookInfo.Controls.Add(lblAuthor);
            gbBookInfo.Controls.Add(lblPrice);
            gbBookInfo.Controls.Add(lblQuantity);
            gbBookInfo.Controls.Add(lblReleasedDate);
            gbBookInfo.Controls.Add(lblDesc);
            gbBookInfo.Controls.Add(lblName);
            gbBookInfo.Controls.Add(lblId);
            gbBookInfo.ForeColor = Color.Yellow;
            gbBookInfo.Location = new Point(49, 185);
            gbBookInfo.Margin = new Padding(6);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Padding = new Padding(6);
            gbBookInfo.Size = new Size(1062, 912);
            gbBookInfo.TabIndex = 18;
            gbBookInfo.TabStop = false;
            gbBookInfo.Text = " Book Info ";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(763, 613);
            txtPrice.Margin = new Padding(6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(261, 47);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(278, 613);
            txtQuantity.Margin = new Padding(6);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(261, 47);
            txtQuantity.TabIndex = 4;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(193, 70);
            txtKeyword.Margin = new Padding(6);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(465, 47);
            txtKeyword.TabIndex = 0;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(38, 76);
            lblKeyword.Margin = new Padding(6, 0, 6, 0);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(134, 41);
            lblKeyword.TabIndex = 18;
            lblKeyword.Text = "Keyword";
            // 
            // gbTask
            // 
            gbTask.Controls.Add(btnExit);
            gbTask.Controls.Add(btnDelete);
            gbTask.Controls.Add(btnUpdate);
            gbTask.Controls.Add(btnAdd);
            gbTask.ForeColor = Color.Yellow;
            gbTask.Location = new Point(49, 1121);
            gbTask.Margin = new Padding(6);
            gbTask.Name = "gbTask";
            gbTask.Padding = new Padding(6);
            gbTask.Size = new Size(1062, 164);
            gbTask.TabIndex = 20;
            gbTask.TabStop = false;
            gbTask.Text = " Task ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.RoyalBlue;
            btnExit.Location = new Point(824, 72);
            btnExit.Margin = new Padding(6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 59);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.RoyalBlue;
            btnDelete.Location = new Point(561, 72);
            btnDelete.Margin = new Padding(6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 59);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.RoyalBlue;
            btnUpdate.Location = new Point(300, 72);
            btnUpdate.Margin = new Padding(6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(200, 59);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RoyalBlue;
            btnAdd.Location = new Point(36, 72);
            btnAdd.Margin = new Padding(6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 59);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(lblKeyword);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.ForeColor = Color.Yellow;
            gbSearch.Location = new Point(1194, 185);
            gbSearch.Margin = new Padding(6);
            gbSearch.Name = "gbSearch";
            gbSearch.Padding = new Padding(6);
            gbSearch.Size = new Size(958, 164);
            gbSearch.TabIndex = 21;
            gbSearch.TabStop = false;
            gbSearch.Text = " Search ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.RoyalBlue;
            btnSearch.Location = new Point(703, 68);
            btnSearch.Margin = new Padding(6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(200, 59);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.BackgroundColor = Color.White;
            dgvBookList.BorderStyle = BorderStyle.Fixed3D;
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(1194, 494);
            dgvBookList.Margin = new Padding(6);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(1111, 758);
            dgvBookList.TabIndex = 0;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.ForeColor = Color.Yellow;
            lblBookList.Location = new Point(1194, 428);
            lblBookList.Margin = new Padding(6, 0, 6, 0);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(138, 41);
            lblBookList.TabIndex = 23;
            lblBookList.Text = "Book List";
            // 
            // BookManagerForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(2367, 1322);
            Controls.Add(lblBookList);
            Controls.Add(dgvBookList);
            Controls.Add(gbSearch);
            Controls.Add(gbTask);
            Controls.Add(gbBookInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Manager";
            FormClosed += BookManagerForm_FormClosed;
            Load += BookManagerForm_Load;
            gbBookInfo.ResumeLayout(false);
            gbBookInfo.PerformLayout();
            gbTask.ResumeLayout(false);
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblDesc;
        private Label lblReleasedDate;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblAuthor;
        private Label lblCategory;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtAuthor;
        private DateTimePicker dtpReleasedDate;
        private ComboBox cboCategory;
        private GroupBox gbBookInfo;
        private TextBox txtKeyword;
        private Label lblKeyword;
        private GroupBox gbTask;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox gbSearch;
        private Button btnSearch;
        private DataGridView dgvBookList;
        private Label lblBookList;
        private TextBox txtPrice;
        private TextBox txtQuantity;
    }
}