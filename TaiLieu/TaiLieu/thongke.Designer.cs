namespace TaiLieu
{
    partial class thongke
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
            this.dgvbaocao = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtngay2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txttk = new System.Windows.Forms.TextBox();
            this.datengay = new System.Windows.Forms.DateTimePicker();
            this.txtlt = new System.Windows.Forms.NumericUpDown();
            this.txtsl = new System.Windows.Forms.NumericUpDown();
            this.butdelete = new System.Windows.Forms.Button();
            this.butedit = new System.Windows.Forms.Button();
            this.txtma = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.butadd = new System.Windows.Forms.Button();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.ComboBox();
            this.txttenbcao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbaocao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.dtngay2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbaocao
            // 
            this.dgvbaocao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbaocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbaocao.Location = new System.Drawing.Point(14, 31);
            this.dgvbaocao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvbaocao.Name = "dgvbaocao";
            this.dgvbaocao.RowHeadersWidth = 51;
            this.dgvbaocao.Size = new System.Drawing.Size(822, 228);
            this.dgvbaocao.TabIndex = 0;
            this.dgvbaocao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbaocao_CellClick);
            this.dgvbaocao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbaocao_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvbaocao);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 263);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(845, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtngay2
            // 
            this.dtngay2.Controls.Add(this.button2);
            this.dtngay2.Controls.Add(this.txttk);
            this.dtngay2.Controls.Add(this.datengay);
            this.dtngay2.Controls.Add(this.txtlt);
            this.dtngay2.Controls.Add(this.txtsl);
            this.dtngay2.Controls.Add(this.butdelete);
            this.dtngay2.Controls.Add(this.butedit);
            this.dtngay2.Controls.Add(this.txtma);
            this.dtngay2.Controls.Add(this.label9);
            this.dtngay2.Controls.Add(this.butadd);
            this.dtngay2.Controls.Add(this.txttennv);
            this.dtngay2.Controls.Add(this.txtmanv);
            this.dtngay2.Controls.Add(this.txttenbcao);
            this.dtngay2.Controls.Add(this.label5);
            this.dtngay2.Controls.Add(this.label3);
            this.dtngay2.Controls.Add(this.label6);
            this.dtngay2.Controls.Add(this.label4);
            this.dtngay2.Controls.Add(this.label7);
            this.dtngay2.Controls.Add(this.label8);
            this.dtngay2.Controls.Add(this.label2);
            this.dtngay2.Controls.Add(this.button1);
            this.dtngay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtngay2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtngay2.Location = new System.Drawing.Point(0, 0);
            this.dtngay2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtngay2.Name = "dtngay2";
            this.dtngay2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtngay2.Size = new System.Drawing.Size(845, 263);
            this.dtngay2.TabIndex = 2;
            this.dtngay2.TabStop = false;
            this.dtngay2.Text = "Thao tác";
            this.dtngay2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(716, 162);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 28);
            this.button2.TabIndex = 39;
            this.button2.Text = "Nhập mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(178, 233);
            this.txttk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(188, 27);
            this.txttk.TabIndex = 38;
            // 
            // datengay
            // 
            this.datengay.CustomFormat = "dd/MM/yyyy";
            this.datengay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datengay.Location = new System.Drawing.Point(156, 87);
            this.datengay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datengay.Name = "datengay";
            this.datengay.Size = new System.Drawing.Size(163, 27);
            this.datengay.TabIndex = 37;
            // 
            // txtlt
            // 
            this.txtlt.Location = new System.Drawing.Point(492, 142);
            this.txtlt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtlt.Name = "txtlt";
            this.txtlt.Size = new System.Drawing.Size(55, 27);
            this.txtlt.TabIndex = 36;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(178, 181);
            this.txtsl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsl.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(49, 27);
            this.txtsl.TabIndex = 35;
            // 
            // butdelete
            // 
            this.butdelete.Location = new System.Drawing.Point(716, 94);
            this.butdelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butdelete.Name = "butdelete";
            this.butdelete.Size = new System.Drawing.Size(120, 31);
            this.butdelete.TabIndex = 34;
            this.butdelete.Text = "Xóa báo cáo";
            this.butdelete.UseVisualStyleBackColor = true;
            this.butdelete.Click += new System.EventHandler(this.butdelete_Click);
            // 
            // butedit
            // 
            this.butedit.Location = new System.Drawing.Point(716, 48);
            this.butedit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butedit.Name = "butedit";
            this.butedit.Size = new System.Drawing.Size(120, 31);
            this.butedit.TabIndex = 33;
            this.butedit.Text = "Sửa báo cáo";
            this.butedit.UseVisualStyleBackColor = true;
            this.butedit.Click += new System.EventHandler(this.butedit_Click);
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(156, 48);
            this.txtma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtma.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(49, 27);
            this.txtma.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 21);
            this.label9.TabIndex = 31;
            this.label9.Text = "Ngày tạo";
            // 
            // butadd
            // 
            this.butadd.Location = new System.Drawing.Point(716, 223);
            this.butadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(120, 31);
            this.butadd.TabIndex = 29;
            this.butadd.Text = "Thêm mới";
            this.butadd.UseVisualStyleBackColor = true;
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // txttennv
            // 
            this.txttennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennv.Location = new System.Drawing.Point(468, 90);
            this.txttennv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(184, 26);
            this.txttennv.TabIndex = 28;
            // 
            // txtmanv
            // 
            this.txtmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.FormattingEnabled = true;
            this.txtmanv.Location = new System.Drawing.Point(468, 38);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(184, 28);
            this.txtmanv.TabIndex = 27;
            this.txtmanv.SelectedIndexChanged += new System.EventHandler(this.txtmanv_SelectedIndexChanged);
            // 
            // txttenbcao
            // 
            this.txttenbcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenbcao.Location = new System.Drawing.Point(156, 138);
            this.txttenbcao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttenbcao.Name = "txttenbcao";
            this.txttenbcao.Size = new System.Drawing.Size(240, 26);
            this.txttenbcao.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tài liệu đang có";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Lượt tải";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tên báo cáo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mã nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mã báo cáo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập tên báo cáo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 529);
            this.Controls.Add(this.dtngay2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "thongke";
            this.Text = "Báo cáo thống kê";
            this.Load += new System.EventHandler(this.thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbaocao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.dtngay2.ResumeLayout(false);
            this.dtngay2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbaocao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox dtngay2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butadd;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.ComboBox txtmanv;
        private System.Windows.Forms.TextBox txttenbcao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button butdelete;
        private System.Windows.Forms.Button butedit;
        private System.Windows.Forms.NumericUpDown txtma;
        private System.Windows.Forms.NumericUpDown txtsl;
        private System.Windows.Forms.NumericUpDown txtlt;
        private System.Windows.Forms.DateTimePicker datengay;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Button button2;
    }
}