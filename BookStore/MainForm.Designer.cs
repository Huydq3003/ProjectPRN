namespace BookStore
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            btnLogo = new Button();
            menuContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            btnMenu = new Button();
            panel5 = new Panel();
            button1 = new Button();
            btnLogin = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            lblWelcome = new Label();
            menuTransition = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            panel_Body = new Panel();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            menuContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.LemonChiffon;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(menuContainer);
            sidebar.Controls.Add(btnLogin);
            sidebar.Controls.Add(btnExit);
            sidebar.Location = new Point(-4, -11);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(581, 1683);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(btnLogo);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 264);
            panel1.TabIndex = 0;
            // 
            // btnLogo
            // 
            btnLogo.BackColor = Color.LemonChiffon;
            btnLogo.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogo.Image = Properties.Resources.book;
            btnLogo.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogo.Location = new Point(3, 3);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(573, 250);
            btnLogo.TabIndex = 0;
            btnLogo.Text = "       Book System";
            btnLogo.TextAlign = ContentAlignment.MiddleLeft;
            btnLogo.UseVisualStyleBackColor = false;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.LemonChiffon;
            menuContainer.Controls.Add(panel3);
            menuContainer.Controls.Add(panel5);
            menuContainer.Location = new Point(3, 273);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(581, 119);
            menuContainer.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LemonChiffon;
            panel3.Controls.Add(btnMenu);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(575, 115);
            panel3.TabIndex = 3;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.LemonChiffon;
            btnMenu.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(-1, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(573, 106);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "         Menu";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Aqua;
            panel5.Controls.Add(button1);
            panel5.Location = new Point(3, 124);
            panel5.Name = "panel5";
            panel5.Size = new Size(575, 124);
            panel5.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Aqua;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(573, 106);
            button1.TabIndex = 3;
            button1.Text = "         Book";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LemonChiffon;
            btnLogin.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(3, 398);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(573, 106);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "         Login";
            btnLogin.TextAlign = ContentAlignment.MiddleLeft;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LemonChiffon;
            btnExit.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(3, 510);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(573, 106);
            btnExit.TabIndex = 5;
            btnExit.Text = "         Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tan;
            panel2.Controls.Add(lblWelcome);
            panel2.Location = new Point(571, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(2641, 264);
            panel2.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(89, 80);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(442, 89);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Book System";
            // 
            // menuTransition
            // 
            menuTransition.Interval = 5;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // panel_Body
            // 
            panel_Body.BackColor = Color.Ivory;
            panel_Body.Location = new Point(571, 251);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(2638, 1433);
            panel_Body.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3207, 1665);
            Controls.Add(panel_Body);
            Controls.Add(panel2);
            Controls.Add(sidebar);
            Name = "MainForm";
            Text = "MainForm";
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private FlowLayoutPanel menuContainer;
        private Panel panel1;
        private Button btnLogo;
        private Panel panel3;
        private Panel panel2;
        private Button btnMenu;
        private Panel panel5;
        private Button button1;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer timer1;
        private Panel panel_Body;
        private Label lblWelcome;
        private Button btnLogin;
        private Button btnExit;
    }
}