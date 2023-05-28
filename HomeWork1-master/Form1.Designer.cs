namespace HW1
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
            btnCreateControls = new Button();
            lblControlType = new Label();
            lblNumOfControls = new Label();
            comControlType = new ComboBox();
            txtNumOfControls = new TextBox();
            pnlDynamicControls = new Panel();
            SuspendLayout();
            // 
            // btnCreateControls
            // 
            btnCreateControls.BackColor = Color.FromArgb(128, 255, 128);
            btnCreateControls.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateControls.ForeColor = Color.DeepSkyBlue;
            btnCreateControls.Location = new Point(304, 130);
            btnCreateControls.Name = "btnCreateControls";
            btnCreateControls.Size = new Size(182, 72);
            btnCreateControls.TabIndex = 0;
            btnCreateControls.Text = "Create Controls";
            btnCreateControls.UseVisualStyleBackColor = false;
            btnCreateControls.Click += btnCreateControls_Click;
            // 
            // lblControlType
            // 
            lblControlType.AutoSize = true;
            lblControlType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblControlType.ForeColor = Color.Navy;
            lblControlType.Location = new Point(554, 46);
            lblControlType.Name = "lblControlType";
            lblControlType.Size = new Size(113, 25);
            lblControlType.TabIndex = 1;
            lblControlType.Text = "Control Type";
            // 
            // lblNumOfControls
            // 
            lblNumOfControls.AutoSize = true;
            lblNumOfControls.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumOfControls.ForeColor = Color.Navy;
            lblNumOfControls.Location = new Point(91, 46);
            lblNumOfControls.Name = "lblNumOfControls";
            lblNumOfControls.Size = new Size(174, 25);
            lblNumOfControls.TabIndex = 2;
            lblNumOfControls.Text = "Number Of Controls";
            // 
            // comControlType
            // 
            comControlType.BackColor = Color.FromArgb(128, 255, 128);
            comControlType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comControlType.ForeColor = Color.Navy;
            comControlType.FormattingEnabled = true;
            comControlType.Items.AddRange(new object[] { "Button", "Label", "TextBox" });
            comControlType.Location = new Point(523, 88);
            comControlType.Name = "comControlType";
            comControlType.Size = new Size(182, 33);
            comControlType.TabIndex = 3;
            // 
            // txtNumOfControls
            // 
            txtNumOfControls.BackColor = Color.FromArgb(128, 255, 128);
            txtNumOfControls.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumOfControls.ForeColor = Color.Navy;
            txtNumOfControls.Location = new Point(83, 100);
            txtNumOfControls.Name = "txtNumOfControls";
            txtNumOfControls.Size = new Size(182, 31);
            txtNumOfControls.TabIndex = 4;
            // 
            // pnlDynamicControls
            // 
            pnlDynamicControls.BorderStyle = BorderStyle.Fixed3D;
            pnlDynamicControls.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            pnlDynamicControls.ForeColor = Color.Navy;
            pnlDynamicControls.Location = new Point(12, 260);
            pnlDynamicControls.Name = "pnlDynamicControls";
            pnlDynamicControls.Size = new Size(776, 263);
            pnlDynamicControls.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(833, 556);
            Controls.Add(pnlDynamicControls);
            Controls.Add(txtNumOfControls);
            Controls.Add(comControlType);
            Controls.Add(lblNumOfControls);
            Controls.Add(lblControlType);
            Controls.Add(btnCreateControls);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateControls;
        private Label lblControlType;
        private Label lblNumOfControls;
        private ComboBox comControlType;
        private TextBox txtNumOfControls;
        private Panel pnlDynamicControls;
    }
}