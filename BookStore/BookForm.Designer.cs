﻿namespace BookStore_HoangNT
{
    partial class BookForm
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
            lblFormTitle = new Label();
            gbBookInfo = new GroupBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            cboCategory = new ComboBox();
            dtpReleasedDate = new DateTimePicker();
            txtAuthor = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblReleasedDate = new Label();
            lblDesc = new Label();
            lblName = new Label();
            lblId = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            gbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.Yellow;
            lblFormTitle.Location = new Point(113, 37);
            lblFormTitle.Margin = new Padding(6, 0, 6, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(401, 89);
            lblFormTitle.TabIndex = 21;
            lblFormTitle.Text = "Add a Book";
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
            gbBookInfo.Location = new Point(113, 207);
            gbBookInfo.Margin = new Padding(6, 6, 6, 6);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Padding = new Padding(6, 6, 6, 6);
            gbBookInfo.Size = new Size(1092, 912);
            gbBookInfo.TabIndex = 22;
            gbBookInfo.TabStop = false;
            gbBookInfo.Text = " Book Info ";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(763, 613);
            txtPrice.Margin = new Padding(6, 6, 6, 6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(261, 47);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(278, 613);
            txtQuantity.Margin = new Padding(6, 6, 6, 6);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(261, 47);
            txtQuantity.TabIndex = 4;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(278, 806);
            cboCategory.Margin = new Padding(6, 6, 6, 6);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(746, 49);
            cboCategory.TabIndex = 7;
            // 
            // dtpReleasedDate
            // 
            dtpReleasedDate.CustomFormat = "dd/MM/yyyy";
            dtpReleasedDate.Format = DateTimePickerFormat.Custom;
            dtpReleasedDate.Location = new Point(278, 515);
            dtpReleasedDate.Margin = new Padding(6, 6, 6, 6);
            dtpReleasedDate.Name = "dtpReleasedDate";
            dtpReleasedDate.Size = new Size(318, 47);
            dtpReleasedDate.TabIndex = 3;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(278, 703);
            txtAuthor.Margin = new Padding(6, 6, 6, 6);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(746, 47);
            txtAuthor.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(278, 262);
            txtDescription.Margin = new Padding(6, 6, 6, 6);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(746, 205);
            txtDescription.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(278, 176);
            txtName.Margin = new Padding(6, 6, 6, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(746, 47);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(278, 88);
            txtId.Margin = new Padding(6, 6, 6, 6);
            txtId.Name = "txtId";
            txtId.Size = new Size(263, 47);
            txtId.TabIndex = 0;
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
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(612, 611);
            lblPrice.Margin = new Padding(6, 0, 6, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(82, 41);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
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
            // btnCancel
            // 
            btnCancel.BackColor = Color.RoyalBlue;
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(1005, 1158);
            btnCancel.Margin = new Padding(6, 6, 6, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 59);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.ForeColor = Color.Yellow;
            btnSave.Location = new Point(769, 1158);
            btnSave.Margin = new Padding(6, 6, 6, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 59);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1345, 1267);
            Controls.Add(lblFormTitle);
            Controls.Add(gbBookInfo);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 6, 6, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add | Update Book";
            Load += BookForm_Load;
            gbBookInfo.ResumeLayout(false);
            gbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private GroupBox gbBookInfo;
        private ComboBox cboCategory;
        private DateTimePicker dtpReleasedDate;
        private TextBox txtAuthor;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblReleasedDate;
        private Label lblDesc;
        private Label lblName;
        private Label lblId;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtPrice;
        private TextBox txtQuantity;
    }
}