namespace PRN211_Project
{
    partial class frmClientAdd
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
            btnCancel = new Button();
            btnSubmit = new Button();
            lblName = new Label();
            lblMeaning = new Label();
            lblType = new Label();
            txtName = new TextBox();
            txtMeaning = new TextBox();
            cbType = new ComboBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(12, 398);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 40);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(687, 398);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(101, 40);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 31);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblMeaning
            // 
            lblMeaning.AutoSize = true;
            lblMeaning.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblMeaning.Location = new Point(12, 47);
            lblMeaning.Name = "lblMeaning";
            lblMeaning.Size = new Size(105, 31);
            lblMeaning.TabIndex = 3;
            lblMeaning.Text = "Meaning";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(462, 9);
            lblType.Name = "lblType";
            lblType.Size = new Size(64, 31);
            lblType.TabIndex = 4;
            lblType.Text = "Type";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(94, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(362, 38);
            txtName.TabIndex = 5;
            // 
            // txtMeaning
            // 
            txtMeaning.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMeaning.Location = new Point(12, 81);
            txtMeaning.Multiline = true;
            txtMeaning.Name = "txtMeaning";
            txtMeaning.ScrollBars = ScrollBars.Both;
            txtMeaning.Size = new Size(776, 311);
            txtMeaning.TabIndex = 6;
            // 
            // cbType
            // 
            cbType.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(532, 6);
            cbType.Name = "cbType";
            cbType.Size = new Size(256, 39);
            cbType.TabIndex = 7;
            // 
            // frmClientAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbType);
            Controls.Add(txtMeaning);
            Controls.Add(txtName);
            Controls.Add(lblType);
            Controls.Add(lblMeaning);
            Controls.Add(lblName);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Name = "frmClientAdd";
            Text = "Add your own words";
            Load += ClientAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSubmit;
        private Label lblName;
        private Label lblMeaning;
        private Label lblType;
        private TextBox txtName;
        private TextBox txtMeaning;
        private ComboBox cbType;
    }
}