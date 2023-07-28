namespace PRN211_Project
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgWords = new DataGridView();
            btnLogout = new Button();
            btnLogin = new Button();
            btnCollection = new Button();
            lblIntro = new Label();
            pictureBox1 = new PictureBox();
            btnAdd = new Button();
            btnExit = new Button();
            btnHistory = new Button();
            lblNote = new Label();
            ((System.ComponentModel.ISupportInitialize)dgWords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(453, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter a word";
            txtSearch.Size = new Size(335, 38);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(363, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(84, 31);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search";
            // 
            // dgWords
            // 
            dgWords.BorderStyle = BorderStyle.Fixed3D;
            dgWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgWords.Location = new Point(363, 56);
            dgWords.Name = "dgWords";
            dgWords.RowHeadersWidth = 51;
            dgWords.RowTemplate.Height = 29;
            dgWords.Size = new Size(425, 410);
            dgWords.TabIndex = 2;
            dgWords.CellClick += dgWords_CellClick;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(12, 174);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(125, 40);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(12, 174);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 40);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCollection
            // 
            btnCollection.Enabled = false;
            btnCollection.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCollection.Location = new Point(232, 350);
            btnCollection.Name = "btnCollection";
            btnCollection.Size = new Size(125, 40);
            btnCollection.TabIndex = 6;
            btnCollection.Text = "My words";
            btnCollection.UseVisualStyleBackColor = true;
            btnCollection.Click += btnCollection_Click;
            // 
            // lblIntro
            // 
            lblIntro.AutoSize = true;
            lblIntro.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblIntro.Location = new Point(12, 9);
            lblIntro.Name = "lblIntro";
            lblIntro.Size = new Size(156, 31);
            lblIntro.TabIndex = 7;
            lblIntro.Text = "Not logged in";
            lblIntro.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(232, 128);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 40);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(12, 426);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(125, 40);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnHistory
            // 
            btnHistory.Enabled = false;
            btnHistory.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistory.Location = new Point(232, 239);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(125, 40);
            btnHistory.TabIndex = 11;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.ForeColor = Color.Red;
            lblNote.Location = new Point(93, 393);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(264, 20);
            lblNote.TabIndex = 14;
            lblNote.Text = "*Login or register to use these features";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 478);
            Controls.Add(lblNote);
            Controls.Add(btnHistory);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(pictureBox1);
            Controls.Add(lblIntro);
            Controls.Add(btnCollection);
            Controls.Add(btnLogin);
            Controls.Add(btnLogout);
            Controls.Add(dgWords);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Name = "frmHome";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)dgWords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dataGridView1;
        private Button btnLogout;
        private Button btnLogin;
        private Button btnCollection;
        private Label lblIntro;
        private PictureBox pictureBox1;
        private Button btnAdd;
        private Button btnExit;
        private DataGridView dgWords;
        private Button btnHistory;
        private Label lblNote;
    }
}