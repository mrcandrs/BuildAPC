namespace WindowsFormsApp1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.button_Maximize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Home = new System.Windows.Forms.Button();
            this.button_Order = new System.Windows.Forms.Button();
            this.button_AboutUs = new System.Windows.Forms.Button();
            this.button_Products = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_forID = new System.Windows.Forms.Label();
            this.label_CustomerID = new System.Windows.Forms.Label();
            this.webBrowser_News = new System.Windows.Forms.WebBrowser();
            this.label_News = new System.Windows.Forms.Label();
            this.button_Logout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.button_Minimize);
            this.panel1.Controls.Add(this.button_Maximize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 37);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button_Minimize
            // 
            this.button_Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Minimize.BackgroundImage")));
            this.button_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Location = new System.Drawing.Point(1045, 0);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(42, 37);
            this.button_Minimize.TabIndex = 3;
            this.button_Minimize.UseVisualStyleBackColor = true;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
            // 
            // button_Maximize
            // 
            this.button_Maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Maximize.BackgroundImage")));
            this.button_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Maximize.FlatAppearance.BorderSize = 0;
            this.button_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Maximize.Location = new System.Drawing.Point(1087, 0);
            this.button_Maximize.Name = "button_Maximize";
            this.button_Maximize.Size = new System.Drawing.Size(42, 37);
            this.button_Maximize.TabIndex = 2;
            this.button_Maximize.UseVisualStyleBackColor = true;
            this.button_Maximize.Click += new System.EventHandler(this.button_Maximize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard | Build-A-PC";
            // 
            // button_Close
            // 
            this.button_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Close.BackgroundImage")));
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Location = new System.Drawing.Point(1129, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(42, 37);
            this.button_Close.TabIndex = 0;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Home
            // 
            this.button_Home.BackColor = System.Drawing.Color.Transparent;
            this.button_Home.FlatAppearance.BorderSize = 0;
            this.button_Home.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Home.ForeColor = System.Drawing.Color.White;
            this.button_Home.Location = new System.Drawing.Point(12, 54);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(111, 35);
            this.button_Home.TabIndex = 2;
            this.button_Home.Text = "Home";
            this.button_Home.UseVisualStyleBackColor = false;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            this.button_Home.Paint += new System.Windows.Forms.PaintEventHandler(this.button_Home_Paint);
            // 
            // button_Order
            // 
            this.button_Order.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Order.BackColor = System.Drawing.Color.Transparent;
            this.button_Order.FlatAppearance.BorderSize = 0;
            this.button_Order.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Order.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Order.ForeColor = System.Drawing.Color.White;
            this.button_Order.Location = new System.Drawing.Point(325, 54);
            this.button_Order.Name = "button_Order";
            this.button_Order.Size = new System.Drawing.Size(126, 35);
            this.button_Order.TabIndex = 3;
            this.button_Order.Text = "Place Order";
            this.button_Order.UseVisualStyleBackColor = false;
            this.button_Order.Click += new System.EventHandler(this.button_Order_Click);
            this.button_Order.Paint += new System.Windows.Forms.PaintEventHandler(this.button_Order_Paint);
            // 
            // button_AboutUs
            // 
            this.button_AboutUs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_AboutUs.BackColor = System.Drawing.Color.Transparent;
            this.button_AboutUs.FlatAppearance.BorderSize = 0;
            this.button_AboutUs.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_AboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AboutUs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AboutUs.ForeColor = System.Drawing.Color.White;
            this.button_AboutUs.Location = new System.Drawing.Point(691, 54);
            this.button_AboutUs.Name = "button_AboutUs";
            this.button_AboutUs.Size = new System.Drawing.Size(108, 35);
            this.button_AboutUs.TabIndex = 4;
            this.button_AboutUs.Text = "About Us";
            this.button_AboutUs.UseVisualStyleBackColor = false;
            this.button_AboutUs.Click += new System.EventHandler(this.button_AboutUs_Click);
            this.button_AboutUs.Paint += new System.Windows.Forms.PaintEventHandler(this.button_AboutUs_Paint);
            // 
            // button_Products
            // 
            this.button_Products.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Products.BackColor = System.Drawing.Color.Transparent;
            this.button_Products.FlatAppearance.BorderSize = 0;
            this.button_Products.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Products.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Products.ForeColor = System.Drawing.Color.White;
            this.button_Products.Location = new System.Drawing.Point(948, 54);
            this.button_Products.Name = "button_Products";
            this.button_Products.Size = new System.Drawing.Size(198, 35);
            this.button_Products.TabIndex = 5;
            this.button_Products.Text = "Product Information";
            this.button_Products.UseVisualStyleBackColor = false;
            this.button_Products.Click += new System.EventHandler(this.button_Products_Click);
            this.button_Products.Paint += new System.Windows.Forms.PaintEventHandler(this.button_Products_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1171, 723);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.label_Welcome.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.ForeColor = System.Drawing.Color.White;
            this.label_Welcome.Location = new System.Drawing.Point(41, 132);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(117, 30);
            this.label_Welcome.TabIndex = 6;
            this.label_Welcome.Text = "WELCOME,";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.BackColor = System.Drawing.Color.Transparent;
            this.label_Username.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.ForeColor = System.Drawing.Color.White;
            this.label_Username.Location = new System.Drawing.Point(196, 132);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(40, 30);
            this.label_Username.TabIndex = 7;
            this.label_Username.Text = "```";
            // 
            // label_forID
            // 
            this.label_forID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_forID.AutoSize = true;
            this.label_forID.BackColor = System.Drawing.Color.Transparent;
            this.label_forID.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forID.ForeColor = System.Drawing.Color.White;
            this.label_forID.Location = new System.Drawing.Point(737, 132);
            this.label_forID.Name = "label_forID";
            this.label_forID.Size = new System.Drawing.Size(136, 30);
            this.label_forID.TabIndex = 8;
            this.label_forID.Text = "Customer ID:";
            // 
            // label_CustomerID
            // 
            this.label_CustomerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CustomerID.AutoSize = true;
            this.label_CustomerID.BackColor = System.Drawing.Color.Transparent;
            this.label_CustomerID.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerID.ForeColor = System.Drawing.Color.White;
            this.label_CustomerID.Location = new System.Drawing.Point(890, 132);
            this.label_CustomerID.Name = "label_CustomerID";
            this.label_CustomerID.Size = new System.Drawing.Size(40, 30);
            this.label_CustomerID.TabIndex = 9;
            this.label_CustomerID.Text = "```";
            // 
            // webBrowser_News
            // 
            this.webBrowser_News.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser_News.Location = new System.Drawing.Point(46, 256);
            this.webBrowser_News.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_News.Name = "webBrowser_News";
            this.webBrowser_News.ScriptErrorsSuppressed = true;
            this.webBrowser_News.Size = new System.Drawing.Size(1066, 400);
            this.webBrowser_News.TabIndex = 10;
            this.webBrowser_News.Url = new System.Uri("https://www.tomshardware.com/news", System.UriKind.Absolute);
            // 
            // label_News
            // 
            this.label_News.AutoSize = true;
            this.label_News.BackColor = System.Drawing.Color.Transparent;
            this.label_News.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_News.ForeColor = System.Drawing.Color.White;
            this.label_News.Location = new System.Drawing.Point(42, 220);
            this.label_News.Name = "label_News";
            this.label_News.Size = new System.Drawing.Size(215, 21);
            this.label_News.TabIndex = 11;
            this.label_News.Text = "The Latest News on PC Parts";
            // 
            // button_Logout
            // 
            this.button_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Logout.BackColor = System.Drawing.Color.Transparent;
            this.button_Logout.FlatAppearance.BorderSize = 0;
            this.button_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.ForeColor = System.Drawing.Color.White;
            this.button_Logout.Location = new System.Drawing.Point(1010, 213);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(136, 35);
            this.button_Logout.TabIndex = 12;
            this.button_Logout.Text = "Log Out";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            this.button_Logout.Paint += new System.Windows.Forms.PaintEventHandler(this.button_Logout_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1171, 723);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.label_News);
            this.Controls.Add(this.webBrowser_News);
            this.Controls.Add(this.label_CustomerID);
            this.Controls.Add(this.label_forID);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_Welcome);
            this.Controls.Add(this.button_Home);
            this.Controls.Add(this.button_Order);
            this.Controls.Add(this.button_AboutUs);
            this.Controls.Add(this.button_Products);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard | Build-A-PC";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Button button_Order;
        private System.Windows.Forms.Button button_AboutUs;
        private System.Windows.Forms.Button button_Products;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Maximize;
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_forID;
        private System.Windows.Forms.Label label_CustomerID;
        private System.Windows.Forms.WebBrowser webBrowser_News;
        private System.Windows.Forms.Label label_News;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}