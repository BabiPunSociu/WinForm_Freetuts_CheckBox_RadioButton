namespace CoBan_CheckBox_RadioButton
{
    partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.rdoHong = new System.Windows.Forms.RadioButton();
			this.rdoDen = new System.Windows.Forms.RadioButton();
			this.rdoTrang = new System.Windows.Forms.RadioButton();
			this.rdoVang = new System.Windows.Forms.RadioButton();
			this.rdoXanh = new System.Windows.Forms.RadioButton();
			this.rdoDo = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.ckbMuaSam = new System.Windows.Forms.CheckBox();
			this.ckbDuLich = new System.Windows.Forms.CheckBox();
			this.ckbGame = new System.Windows.Forms.CheckBox();
			this.ckbTheThao = new System.Windows.Forms.CheckBox();
			this.ckbXemPhim = new System.Windows.Forms.CheckBox();
			this.ckbNgheNhac = new System.Windows.Forms.CheckBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnMauSac = new System.Windows.Forms.Button();
			this.btnSoThich = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(800, 317);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.rdoHong);
			this.groupBox4.Controls.Add(this.rdoDen);
			this.groupBox4.Controls.Add(this.rdoTrang);
			this.groupBox4.Controls.Add(this.rdoVang);
			this.groupBox4.Controls.Add(this.rdoXanh);
			this.groupBox4.Controls.Add(this.rdoDo);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBox4.Location = new System.Drawing.Point(386, 18);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(411, 296);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Màu sắc";
			// 
			// rdoHong
			// 
			this.rdoHong.AutoSize = true;
			this.rdoHong.Location = new System.Drawing.Point(26, 259);
			this.rdoHong.Name = "rdoHong";
			this.rdoHong.Size = new System.Drawing.Size(61, 20);
			this.rdoHong.TabIndex = 5;
			this.rdoHong.TabStop = true;
			this.rdoHong.Text = "Hồng";
			this.rdoHong.UseVisualStyleBackColor = true;
			// 
			// rdoDen
			// 
			this.rdoDen.AutoSize = true;
			this.rdoDen.Location = new System.Drawing.Point(26, 219);
			this.rdoDen.Name = "rdoDen";
			this.rdoDen.Size = new System.Drawing.Size(52, 20);
			this.rdoDen.TabIndex = 4;
			this.rdoDen.TabStop = true;
			this.rdoDen.Text = "Đen";
			this.rdoDen.UseVisualStyleBackColor = true;
			// 
			// rdoTrang
			// 
			this.rdoTrang.AutoSize = true;
			this.rdoTrang.Location = new System.Drawing.Point(26, 178);
			this.rdoTrang.Name = "rdoTrang";
			this.rdoTrang.Size = new System.Drawing.Size(64, 20);
			this.rdoTrang.TabIndex = 3;
			this.rdoTrang.TabStop = true;
			this.rdoTrang.Text = "Trắng";
			this.rdoTrang.UseVisualStyleBackColor = true;
			// 
			// rdoVang
			// 
			this.rdoVang.AutoSize = true;
			this.rdoVang.Location = new System.Drawing.Point(26, 132);
			this.rdoVang.Name = "rdoVang";
			this.rdoVang.Size = new System.Drawing.Size(60, 20);
			this.rdoVang.TabIndex = 2;
			this.rdoVang.TabStop = true;
			this.rdoVang.Text = "Vàng";
			this.rdoVang.UseVisualStyleBackColor = true;
			// 
			// rdoXanh
			// 
			this.rdoXanh.AutoSize = true;
			this.rdoXanh.Location = new System.Drawing.Point(26, 83);
			this.rdoXanh.Name = "rdoXanh";
			this.rdoXanh.Size = new System.Drawing.Size(58, 20);
			this.rdoXanh.TabIndex = 1;
			this.rdoXanh.TabStop = true;
			this.rdoXanh.Text = "Xanh";
			this.rdoXanh.UseVisualStyleBackColor = true;
			// 
			// rdoDo
			// 
			this.rdoDo.AutoSize = true;
			this.rdoDo.Location = new System.Drawing.Point(26, 42);
			this.rdoDo.Name = "rdoDo";
			this.rdoDo.Size = new System.Drawing.Size(45, 20);
			this.rdoDo.TabIndex = 0;
			this.rdoDo.TabStop = true;
			this.rdoDo.Text = "Đỏ";
			this.rdoDo.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.ckbMuaSam);
			this.groupBox3.Controls.Add(this.ckbDuLich);
			this.groupBox3.Controls.Add(this.ckbGame);
			this.groupBox3.Controls.Add(this.ckbTheThao);
			this.groupBox3.Controls.Add(this.ckbXemPhim);
			this.groupBox3.Controls.Add(this.ckbNgheNhac);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox3.Location = new System.Drawing.Point(3, 18);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(378, 296);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Sở thích";
			// 
			// ckbMuaSam
			// 
			this.ckbMuaSam.AutoSize = true;
			this.ckbMuaSam.Location = new System.Drawing.Point(17, 260);
			this.ckbMuaSam.Name = "ckbMuaSam";
			this.ckbMuaSam.Size = new System.Drawing.Size(84, 20);
			this.ckbMuaSam.TabIndex = 5;
			this.ckbMuaSam.Text = "Mua sắm";
			this.ckbMuaSam.UseVisualStyleBackColor = true;
			// 
			// ckbDuLich
			// 
			this.ckbDuLich.AutoSize = true;
			this.ckbDuLich.Location = new System.Drawing.Point(17, 220);
			this.ckbDuLich.Name = "ckbDuLich";
			this.ckbDuLich.Size = new System.Drawing.Size(69, 20);
			this.ckbDuLich.TabIndex = 4;
			this.ckbDuLich.Text = "Du lịch";
			this.ckbDuLich.UseVisualStyleBackColor = true;
			// 
			// ckbGame
			// 
			this.ckbGame.AutoSize = true;
			this.ckbGame.Location = new System.Drawing.Point(17, 178);
			this.ckbGame.Name = "ckbGame";
			this.ckbGame.Size = new System.Drawing.Size(66, 20);
			this.ckbGame.TabIndex = 3;
			this.ckbGame.Text = "Game";
			this.ckbGame.UseVisualStyleBackColor = true;
			// 
			// ckbTheThao
			// 
			this.ckbTheThao.AutoSize = true;
			this.ckbTheThao.Location = new System.Drawing.Point(17, 132);
			this.ckbTheThao.Name = "ckbTheThao";
			this.ckbTheThao.Size = new System.Drawing.Size(82, 20);
			this.ckbTheThao.TabIndex = 2;
			this.ckbTheThao.Text = "Thể thao";
			this.ckbTheThao.UseVisualStyleBackColor = true;
			// 
			// ckbXemPhim
			// 
			this.ckbXemPhim.AutoSize = true;
			this.ckbXemPhim.Location = new System.Drawing.Point(17, 83);
			this.ckbXemPhim.Name = "ckbXemPhim";
			this.ckbXemPhim.Size = new System.Drawing.Size(88, 20);
			this.ckbXemPhim.TabIndex = 1;
			this.ckbXemPhim.Text = "Xem phim";
			this.ckbXemPhim.UseVisualStyleBackColor = true;
			// 
			// ckbNgheNhac
			// 
			this.ckbNgheNhac.AutoSize = true;
			this.ckbNgheNhac.Location = new System.Drawing.Point(17, 43);
			this.ckbNgheNhac.Name = "ckbNgheNhac";
			this.ckbNgheNhac.Size = new System.Drawing.Size(94, 20);
			this.ckbNgheNhac.TabIndex = 0;
			this.ckbNgheNhac.Text = "Nghe nhạc";
			this.ckbNgheNhac.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnMauSac);
			this.groupBox2.Controls.Add(this.btnSoThich);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 317);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(800, 133);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// btnMauSac
			// 
			this.btnMauSac.Location = new System.Drawing.Point(412, 50);
			this.btnMauSac.Name = "btnMauSac";
			this.btnMauSac.Size = new System.Drawing.Size(314, 47);
			this.btnMauSac.TabIndex = 1;
			this.btnMauSac.Text = "Màu bạn thích";
			this.btnMauSac.UseVisualStyleBackColor = true;
			this.btnMauSac.Click += new System.EventHandler(this.btnMauSac_Click);
			// 
			// btnSoThich
			// 
			this.btnSoThich.Location = new System.Drawing.Point(20, 50);
			this.btnSoThich.Name = "btnSoThich";
			this.btnSoThich.Size = new System.Drawing.Size(314, 47);
			this.btnSoThich.TabIndex = 0;
			this.btnSoThich.Text = "Sở thích của bạn";
			this.btnSoThich.UseVisualStyleBackColor = true;
			this.btnSoThich.Click += new System.EventHandler(this.btnSoThich_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CheckBox RadioButton";
			this.groupBox1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoHong;
        private System.Windows.Forms.RadioButton rdoDen;
        private System.Windows.Forms.RadioButton rdoTrang;
        private System.Windows.Forms.RadioButton rdoVang;
        private System.Windows.Forms.RadioButton rdoXanh;
        private System.Windows.Forms.RadioButton rdoDo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckbMuaSam;
        private System.Windows.Forms.CheckBox ckbDuLich;
        private System.Windows.Forms.CheckBox ckbGame;
        private System.Windows.Forms.CheckBox ckbTheThao;
        private System.Windows.Forms.CheckBox ckbXemPhim;
        private System.Windows.Forms.CheckBox ckbNgheNhac;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMauSac;
        private System.Windows.Forms.Button btnSoThich;
    }
}

