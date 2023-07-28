namespace PRN211_Project
{
    partial class frmAdminHome
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
            dgWords = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            btnLoad = new Button();
            lblSelected = new Label();
            txtSelected = new TextBox();
            lblGreeting = new Label();
            ((System.ComponentModel.ISupportInitialize)dgWords).BeginInit();
            SuspendLayout();
            // 
            // dgWords
            // 
            dgWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgWords.Location = new Point(12, 85);
            dgWords.Name = "dgWords";
            dgWords.RowHeadersWidth = 51;
            dgWords.RowTemplate.Height = 29;
            dgWords.Size = new Size(581, 353);
            dgWords.TabIndex = 0;
            dgWords.CellClick += dgWords_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(662, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 41);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(662, 85);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 41);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(662, 165);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 41);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(662, 397);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(126, 41);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(662, 249);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(126, 41);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelected.Location = new Point(330, 17);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(132, 31);
            lblSelected.TabIndex = 6;
            lblSelected.Text = "Selected ID";
            // 
            // txtSelected
            // 
            txtSelected.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSelected.Location = new Point(468, 14);
            txtSelected.Name = "txtSelected";
            txtSelected.Size = new Size(125, 38);
            txtSelected.TabIndex = 7;
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblGreeting.Location = new Point(12, 17);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(69, 31);
            lblGreeting.TabIndex = 8;
            lblGreeting.Text = "Hello";
            // 
            // frmAdminHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGreeting);
            Controls.Add(txtSelected);
            Controls.Add(lblSelected);
            Controls.Add(btnLoad);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgWords);
            Name = "frmAdminHome";
            Text = "AdminHome";
            Load += AdminHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgWords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgWords;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private Button btnLoad;
        private Label lblSelected;
        private TextBox txtSelected;
        private Label lblGreeting;
    }
}