namespace CafeSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelLeft = new Panel();
            btnClear = new Button();
            btnCalculate = new Button();
            txtBalance = new TextBox();
            lblBalance = new Label();
            txtAmount = new MaskedTextBox();
            lblAmount = new Label();
            txtDuration = new TextBox();
            lblDuration = new Label();
            pictureCafe = new PictureBox();
            panelRight = new Panel();
            txtTotal = new TextBox();
            lblTotal = new Label();
            btnTotal = new Button();
            btnRefresh = new Button();
            btnRemove = new Button();
            lstBasket = new CheckedListBox();
            lblBasket = new Label();
            panelMenu = new Panel();
            picCookies = new PictureBox();
            picHotDog = new PictureBox();
            picMuffin = new PictureBox();
            picPizza = new PictureBox();
            picSandwich = new PictureBox();
            picBurger = new PictureBox();
            picJuice = new PictureBox();
            picKetchup = new PictureBox();
            picCake = new PictureBox();
            lblMenu = new Label();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCafe).BeginInit();
            panelRight.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCookies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHotDog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMuffin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPizza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSandwich).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picJuice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picKetchup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCake).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(24, 60, 54);
            panelLeft.Controls.Add(btnClear);
            panelLeft.Controls.Add(btnCalculate);
            panelLeft.Controls.Add(txtBalance);
            panelLeft.Controls.Add(lblBalance);
            panelLeft.Controls.Add(txtAmount);
            panelLeft.Controls.Add(lblAmount);
            panelLeft.Controls.Add(txtDuration);
            panelLeft.Controls.Add(lblDuration);
            panelLeft.Controls.Add(pictureCafe);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.RightToLeft = RightToLeft.No;
            panelLeft.Size = new Size(280, 644);
            panelLeft.TabIndex = 0;
            panelLeft.Paint += panel1_Paint;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(201, 76, 76);
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(30, 532);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(215, 45);
            btnClear.TabIndex = 8;
            btnClear.Text = "Təmizlə";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(46, 125, 91);
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(30, 477);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(215, 45);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Hesabla";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBalance.Location = new Point(30, 393);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(215, 37);
            txtBalance.TabIndex = 6;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = Color.White;
            lblBalance.Location = new Point(30, 360);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(68, 30);
            lblBalance.TabIndex = 5;
            lblBalance.Text = "Qalıq";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(30, 313);
            txtAmount.Mask = "00000";
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(215, 37);
            txtAmount.TabIndex = 4;
            txtAmount.ValidatingType = typeof(int);
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmount.ForeColor = Color.White;
            lblAmount.Location = new Point(30, 280);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(92, 30);
            lblAmount.TabIndex = 3;
            lblAmount.Text = "Məbləğ";
            // 
            // txtDuration
            // 
            txtDuration.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDuration.Location = new Point(30, 233);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(215, 37);
            txtDuration.TabIndex = 2;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDuration.ForeColor = Color.White;
            lblDuration.Location = new Point(30, 200);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(96, 30);
            lblDuration.TabIndex = 1;
            lblDuration.Text = "Müddət";
            // 
            // pictureCafe
            // 
            pictureCafe.BackColor = Color.Transparent;
            pictureCafe.Image = (Image)resources.GetObject("pictureCafe.Image");
            pictureCafe.Location = new Point(65, 35);
            pictureCafe.Name = "pictureCafe";
            pictureCafe.Size = new Size(150, 120);
            pictureCafe.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCafe.TabIndex = 0;
            pictureCafe.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(232, 222, 208);
            panelRight.Controls.Add(txtTotal);
            panelRight.Controls.Add(lblTotal);
            panelRight.Controls.Add(btnTotal);
            panelRight.Controls.Add(btnRefresh);
            panelRight.Controls.Add(btnRemove);
            panelRight.Controls.Add(lstBasket);
            panelRight.Controls.Add(lblBasket);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(878, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(300, 644);
            panelRight.TabIndex = 1;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(122, 575);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(150, 39);
            txtTotal.TabIndex = 6;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(25, 578);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(91, 32);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Hesab:";
            // 
            // btnTotal
            // 
            btnTotal.BackColor = Color.FromArgb(46, 125, 91);
            btnTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotal.ForeColor = Color.White;
            btnTotal.Location = new Point(25, 511);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(250, 45);
            btnTotal.TabIndex = 4;
            btnTotal.Text = "Yekun hesab";
            btnTotal.UseVisualStyleBackColor = false;
            btnTotal.Click += btnTotal_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(217, 154, 43);
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(25, 460);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(250, 45);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Yenilə";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(201, 76, 76);
            btnRemove.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(25, 416);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(250, 45);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Səbətdən sil";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // lstBasket
            // 
            lstBasket.BackColor = Color.White;
            lstBasket.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBasket.FormattingEnabled = true;
            lstBasket.Location = new Point(25, 100);
            lstBasket.Name = "lstBasket";
            lstBasket.Size = new Size(250, 310);
            lstBasket.TabIndex = 1;
            lstBasket.SelectedIndexChanged += lstBasket_SelectedIndexChanged;
            // 
            // lblBasket
            // 
            lblBasket.AutoSize = true;
            lblBasket.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBasket.ForeColor = Color.FromArgb(24, 60, 54);
            lblBasket.Location = new Point(72, 30);
            lblBasket.Name = "lblBasket";
            lblBasket.Size = new Size(156, 65);
            lblBasket.TabIndex = 0;
            lblBasket.Text = "Səbət";
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(picCookies);
            panelMenu.Controls.Add(picHotDog);
            panelMenu.Controls.Add(picMuffin);
            panelMenu.Controls.Add(picPizza);
            panelMenu.Controls.Add(picSandwich);
            panelMenu.Controls.Add(picBurger);
            panelMenu.Controls.Add(picJuice);
            panelMenu.Controls.Add(picKetchup);
            panelMenu.Controls.Add(picCake);
            panelMenu.Controls.Add(lblMenu);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(280, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(598, 644);
            panelMenu.TabIndex = 2;
            // 
            // picCookies
            // 
            picCookies.BackColor = Color.Transparent;
            picCookies.Image = (Image)resources.GetObject("picCookies.Image");
            picCookies.Location = new Point(382, 402);
            picCookies.Name = "picCookies";
            picCookies.Size = new Size(150, 120);
            picCookies.SizeMode = PictureBoxSizeMode.Zoom;
            picCookies.TabIndex = 9;
            picCookies.TabStop = false;
            picCookies.Click += picCookies_Click;
            // 
            // picHotDog
            // 
            picHotDog.BackColor = Color.Transparent;
            picHotDog.Image = (Image)resources.GetObject("picHotDog.Image");
            picHotDog.Location = new Point(226, 402);
            picHotDog.Name = "picHotDog";
            picHotDog.Size = new Size(150, 120);
            picHotDog.SizeMode = PictureBoxSizeMode.Zoom;
            picHotDog.TabIndex = 8;
            picHotDog.TabStop = false;
            picHotDog.Click += picHotDog_Click;
            // 
            // picMuffin
            // 
            picMuffin.BackColor = Color.Transparent;
            picMuffin.Image = (Image)resources.GetObject("picMuffin.Image");
            picMuffin.Location = new Point(70, 402);
            picMuffin.Name = "picMuffin";
            picMuffin.Size = new Size(150, 120);
            picMuffin.SizeMode = PictureBoxSizeMode.Zoom;
            picMuffin.TabIndex = 7;
            picMuffin.TabStop = false;
            picMuffin.Click += picMuffin_Click;
            // 
            // picPizza
            // 
            picPizza.BackColor = Color.Transparent;
            picPizza.Image = (Image)resources.GetObject("picPizza.Image");
            picPizza.Location = new Point(382, 276);
            picPizza.Name = "picPizza";
            picPizza.Size = new Size(150, 120);
            picPizza.SizeMode = PictureBoxSizeMode.Zoom;
            picPizza.TabIndex = 6;
            picPizza.TabStop = false;
            picPizza.Click += picPizza_Click;
            // 
            // picSandwich
            // 
            picSandwich.BackColor = Color.Transparent;
            picSandwich.Image = (Image)resources.GetObject("picSandwich.Image");
            picSandwich.Location = new Point(226, 276);
            picSandwich.Name = "picSandwich";
            picSandwich.Size = new Size(150, 120);
            picSandwich.SizeMode = PictureBoxSizeMode.Zoom;
            picSandwich.TabIndex = 5;
            picSandwich.TabStop = false;
            picSandwich.Click += picSandwich_Click;
            // 
            // picBurger
            // 
            picBurger.BackColor = Color.Transparent;
            picBurger.Image = (Image)resources.GetObject("picBurger.Image");
            picBurger.Location = new Point(70, 276);
            picBurger.Name = "picBurger";
            picBurger.Size = new Size(150, 120);
            picBurger.SizeMode = PictureBoxSizeMode.Zoom;
            picBurger.TabIndex = 4;
            picBurger.TabStop = false;
            picBurger.Click += picBurger_Click;
            // 
            // picJuice
            // 
            picJuice.BackColor = Color.Transparent;
            picJuice.Image = (Image)resources.GetObject("picJuice.Image");
            picJuice.Location = new Point(382, 150);
            picJuice.Name = "picJuice";
            picJuice.Size = new Size(150, 120);
            picJuice.SizeMode = PictureBoxSizeMode.Zoom;
            picJuice.TabIndex = 3;
            picJuice.TabStop = false;
            picJuice.Click += picJuice_Click;
            // 
            // picKetchup
            // 
            picKetchup.BackColor = Color.Transparent;
            picKetchup.Image = (Image)resources.GetObject("picKetchup.Image");
            picKetchup.Location = new Point(226, 150);
            picKetchup.Name = "picKetchup";
            picKetchup.Size = new Size(150, 120);
            picKetchup.SizeMode = PictureBoxSizeMode.Zoom;
            picKetchup.TabIndex = 2;
            picKetchup.TabStop = false;
            picKetchup.Click += picKetchup_Click;
            // 
            // picCake
            // 
            picCake.BackColor = Color.Transparent;
            picCake.Image = (Image)resources.GetObject("picCake.Image");
            picCake.Location = new Point(70, 150);
            picCake.Name = "picCake";
            picCake.Size = new Size(150, 120);
            picCake.SizeMode = PictureBoxSizeMode.Zoom;
            picCake.TabIndex = 1;
            picCake.TabStop = false;
            picCake.Click += picCake_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.ForeColor = Color.FromArgb(24, 60, 54);
            lblMenu.Location = new Point(205, 35);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(187, 70);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "MENU";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 237);
            ClientSize = new Size(1178, 644);
            Controls.Add(panelMenu);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            MaximumSize = new Size(1200, 700);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cafe System";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCafe).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCookies).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHotDog).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMuffin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPizza).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSandwich).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picJuice).EndInit();
            ((System.ComponentModel.ISupportInitialize)picKetchup).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCake).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelRight;
        private Panel panelMenu;
        private PictureBox pictureCafe;
        private Label lblDuration;
        private MaskedTextBox txtAmount;
        private Label lblAmount;
        private TextBox txtDuration;
        private Button btnCalculate;
        private TextBox txtBalance;
        private Label lblBalance;
        private Button btnClear;
        private Label lblMenu;
        private PictureBox picCookies;
        private PictureBox picHotDog;
        private PictureBox picMuffin;
        private PictureBox picPizza;
        private PictureBox picSandwich;
        private PictureBox picBurger;
        private PictureBox picJuice;
        private PictureBox picKetchup;
        private PictureBox picCake;
        private Label lblBasket;
        private Button btnTotal;
        private Button btnRefresh;
        private Button btnRemove;
        private CheckedListBox lstBasket;
        private TextBox txtTotal;
        private Label lblTotal;
    }
}
