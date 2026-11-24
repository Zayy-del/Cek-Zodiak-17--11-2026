namespace WinFormsApp6
{
    partial class aplikasizodiak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aplikasizodiak));
            btnHasil = new Button();
            txtTanggal = new TextBox();
            txtBulan = new TextBox();
            txtHasil = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnHasil
            // 
            btnHasil.BackColor = Color.PaleVioletRed;
            btnHasil.Location = new Point(39, 233);
            btnHasil.Name = "btnHasil";
            btnHasil.Size = new Size(150, 56);
            btnHasil.TabIndex = 0;
            btnHasil.Text = "Tekan";
            btnHasil.UseVisualStyleBackColor = false;
            btnHasil.Click += btnHasil_Click;
            // 
            // txtTanggal
            // 
            txtTanggal.Location = new Point(39, 95);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.Size = new Size(150, 31);
            txtTanggal.TabIndex = 1;
            // 
            // txtBulan
            // 
            txtBulan.Location = new Point(39, 176);
            txtBulan.Name = "txtBulan";
            txtBulan.Size = new Size(150, 31);
            txtBulan.TabIndex = 2;
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(263, 135);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(150, 31);
            txtHasil.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 62);
            label1.Name = "label1";
            label1.Size = new Size(88, 30);
            label1.TabIndex = 4;
            label1.Text = "Tanggal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 143);
            label2.Name = "label2";
            label2.Size = new Size(66, 30);
            label2.TabIndex = 5;
            label2.Text = "Bulan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(263, 102);
            label3.Name = "label3";
            label3.Size = new Size(132, 30);
            label3.TabIndex = 6;
            label3.Text = "Zodiak anda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(202, 119);
            label4.Name = "label4";
            label4.Size = new Size(55, 60);
            label4.TabIndex = 7;
            label4.Text = "=";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(221, 9);
            label5.Name = "label5";
            label5.Size = new Size(377, 60);
            label5.TabIndex = 8;
            label5.Text = "Cek Zodiak Kamu!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 295);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(478, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(324, 391);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // aplikasizodiak
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHasil);
            Controls.Add(txtBulan);
            Controls.Add(txtTanggal);
            Controls.Add(btnHasil);
            ForeColor = Color.Black;
            Name = "aplikasizodiak";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplikasi Zodiak";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHasil;
        private TextBox txtTanggal;
        private TextBox txtBulan;
        private TextBox txtHasil;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
