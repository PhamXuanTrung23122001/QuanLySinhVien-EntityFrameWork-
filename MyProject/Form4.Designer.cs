namespace MyProject
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboID = new System.Windows.Forms.ComboBox();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.CboSubID = new System.Windows.Forms.ComboBox();
            this.cboSubName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.btnViewMark = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnXóa = new System.Windows.Forms.Button();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Số Sinh Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Môn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Môn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm:";
            // 
            // cboID
            // 
            this.cboID.FormattingEnabled = true;
            this.cboID.Location = new System.Drawing.Point(176, 72);
            this.cboID.Name = "cboID";
            this.cboID.Size = new System.Drawing.Size(214, 23);
            this.cboID.TabIndex = 5;
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(176, 128);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(214, 23);
            this.cboName.TabIndex = 6;
            // 
            // CboSubID
            // 
            this.CboSubID.FormattingEnabled = true;
            this.CboSubID.Location = new System.Drawing.Point(176, 176);
            this.CboSubID.Name = "CboSubID";
            this.CboSubID.Size = new System.Drawing.Size(214, 23);
            this.CboSubID.TabIndex = 7;
            // 
            // cboSubName
            // 
            this.cboSubName.FormattingEnabled = true;
            this.cboSubName.Location = new System.Drawing.Point(176, 224);
            this.cboSubName.Name = "cboSubName";
            this.cboSubName.Size = new System.Drawing.Size(214, 23);
            this.cboSubName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Họ Tên:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 354);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Nhập Điểm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(176, 275);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(214, 23);
            this.txtMark.TabIndex = 12;
            // 
            // btnViewMark
            // 
            this.btnViewMark.Location = new System.Drawing.Point(553, 354);
            this.btnViewMark.Name = "btnViewMark";
            this.btnViewMark.Size = new System.Drawing.Size(75, 23);
            this.btnViewMark.TabIndex = 13;
            this.btnViewMark.Text = "Xem điểm";
            this.btnViewMark.UseVisualStyleBackColor = true;
            this.btnViewMark.Click += new System.EventHandler(this.btnViewMark_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(252, 354);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Cập nhật điểm mới";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnXóa
            // 
            this.btnXóa.Location = new System.Drawing.Point(416, 354);
            this.btnXóa.Name = "btnXóa";
            this.btnXóa.Size = new System.Drawing.Size(86, 23);
            this.btnXóa.TabIndex = 15;
            this.btnXóa.Text = "Xóa Điểm";
            this.btnXóa.UseVisualStyleBackColor = true;
            this.btnXóa.Click += new System.EventHandler(this.btnXóa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 401);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(575, 303);
            this.dataGridView1.TabIndex = 17;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 716);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXóa);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnViewMark);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboSubName);
            this.Controls.Add(this.CboSubID);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.cboID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Nhập Điểm";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboID;
        private ComboBox cboName;
        private ComboBox CboSubID;
        private ComboBox cboSubName;
        private Label label6;
        private Button btnAdd;
        private TextBox txtMark;
        private Button btnViewMark;
        private Button btnUpdate;
        private Button btnXóa;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private DataGridView dataGridView1;
    }
}