namespace PRN211_Project
{
    partial class frmWordDetail
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
            lblName = new Label();
            lblType = new Label();
            txtMeaning = new TextBox();
            btnExit = new Button();
            btnLike = new Button();
            btnDislike = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dgSynonym = new DataGridView();
            lblSynonym = new Label();
            ((System.ComponentModel.ISupportInitialize)dgSynonym).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(138, 46);
            lblName.TabIndex = 0;
            lblName.Text = "Default";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblType.Location = new Point(12, 55);
            lblType.Name = "lblType";
            lblType.Size = new Size(88, 31);
            lblType.TabIndex = 1;
            lblType.Text = "Default";
            // 
            // txtMeaning
            // 
            txtMeaning.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMeaning.Location = new Point(12, 89);
            txtMeaning.Multiline = true;
            txtMeaning.Name = "txtMeaning";
            txtMeaning.ReadOnly = true;
            txtMeaning.ScrollBars = ScrollBars.Both;
            txtMeaning.Size = new Size(458, 304);
            txtMeaning.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(12, 399);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 39);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLike
            // 
            btnLike.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLike.Location = new Point(158, 44);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(100, 39);
            btnLike.TabIndex = 4;
            btnLike.Text = "Like";
            btnLike.UseVisualStyleBackColor = true;
            btnLike.Click += btnLike_Click;
            // 
            // btnDislike
            // 
            btnDislike.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDislike.Location = new Point(158, 44);
            btnDislike.Name = "btnDislike";
            btnDislike.Size = new Size(100, 39);
            btnDislike.TabIndex = 5;
            btnDislike.Text = "Dislike";
            btnDislike.UseVisualStyleBackColor = true;
            btnDislike.Click += btnDislike_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(370, 44);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 39);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(264, 44);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 39);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgSynonym
            // 
            dgSynonym.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSynonym.Location = new Point(476, 89);
            dgSynonym.Name = "dgSynonym";
            dgSynonym.RowHeadersWidth = 51;
            dgSynonym.RowTemplate.Height = 29;
            dgSynonym.Size = new Size(312, 304);
            dgSynonym.TabIndex = 8;
            dgSynonym.CellClick += dgSynonym_CellClick;
            // 
            // lblSynonym
            // 
            lblSynonym.AutoSize = true;
            lblSynonym.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSynonym.Location = new Point(668, 48);
            lblSynonym.Name = "lblSynonym";
            lblSynonym.Size = new Size(120, 31);
            lblSynonym.TabIndex = 9;
            lblSynonym.Text = "Synonyms";
            // 
            // frmWordDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSynonym);
            Controls.Add(dgSynonym);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnDislike);
            Controls.Add(btnLike);
            Controls.Add(btnExit);
            Controls.Add(txtMeaning);
            Controls.Add(lblType);
            Controls.Add(lblName);
            Name = "frmWordDetail";
            Text = "Default";
            ((System.ComponentModel.ISupportInitialize)dgSynonym).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblType;
        private TextBox txtMeaning;
        private Button btnExit;
        private Button btnLike;
        private Button btnDislike;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dgSynonym;
        private Label lblSynonym;
    }
}