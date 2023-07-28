namespace PRN211_Project
{
    partial class frmAdminAdd
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
            lblTitle = new Label();
            cbType = new ComboBox();
            btnAdd = new Button();
            lblName = new Label();
            txtName = new TextBox();
            lblType = new Label();
            lblMeaning = new Label();
            txtMeaning = new TextBox();
            btnCancel = new Button();
            dgSynonym = new DataGridView();
            lblSynonym = new Label();
            ((System.ComponentModel.ISupportInitialize)dgSynonym).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(209, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(387, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add words to database";
            // 
            // cbType
            // 
            cbType.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(569, 60);
            cbType.Name = "cbType";
            cbType.Size = new Size(219, 39);
            cbType.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(684, 400);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Submit";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(12, 63);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 31);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(94, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(399, 38);
            txtName.TabIndex = 4;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(499, 63);
            lblType.Name = "lblType";
            lblType.Size = new Size(64, 31);
            lblType.TabIndex = 5;
            lblType.Text = "Type";
            // 
            // lblMeaning
            // 
            lblMeaning.AutoSize = true;
            lblMeaning.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblMeaning.Location = new Point(12, 120);
            lblMeaning.Name = "lblMeaning";
            lblMeaning.Size = new Size(105, 31);
            lblMeaning.TabIndex = 6;
            lblMeaning.Text = "Meaning";
            // 
            // txtMeaning
            // 
            txtMeaning.Location = new Point(12, 154);
            txtMeaning.Multiline = true;
            txtMeaning.Name = "txtMeaning";
            txtMeaning.ScrollBars = ScrollBars.Both;
            txtMeaning.Size = new Size(551, 240);
            txtMeaning.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(12, 400);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 38);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dgSynonym
            // 
            dgSynonym.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSynonym.Location = new Point(569, 154);
            dgSynonym.Name = "dgSynonym";
            dgSynonym.RowHeadersWidth = 51;
            dgSynonym.RowTemplate.Height = 29;
            dgSynonym.Size = new Size(219, 240);
            dgSynonym.TabIndex = 9;
            // 
            // lblSynonym
            // 
            lblSynonym.AutoSize = true;
            lblSynonym.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSynonym.Location = new Point(569, 120);
            lblSynonym.Name = "lblSynonym";
            lblSynonym.Size = new Size(120, 31);
            lblSynonym.TabIndex = 10;
            lblSynonym.Text = "Synonyms";
            // 
            // frmAdminAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSynonym);
            Controls.Add(dgSynonym);
            Controls.Add(btnCancel);
            Controls.Add(txtMeaning);
            Controls.Add(lblMeaning);
            Controls.Add(lblType);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnAdd);
            Controls.Add(cbType);
            Controls.Add(lblTitle);
            Name = "frmAdminAdd";
            Text = "Admin Add Words";
            ((System.ComponentModel.ISupportInitialize)dgSynonym).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ComboBox cbType;
        private Button btnAdd;
        private Label lblName;
        private TextBox txtName;
        private Label lblType;
        private Label lblMeaning;
        private TextBox txtMeaning;
        private Button btnCancel;
        private DataGridView dgSynonym;
        private Label lblSynonym;
    }
}