namespace SİNEMA
{
    partial class FrmAcilis
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
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            label3 = new Label();
            txtSifre = new TextBox();
            btnGirisYap = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 110, 122);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 46);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(418, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 46);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 1;
            label1.Text = "Sinema.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.FromArgb(84, 110, 112);
            label2.Location = new Point(67, 90);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 1;
            label2.Text = "YETKİLİ";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtKullaniciAdi.Location = new Point(160, 93);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(194, 25);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(84, 110, 122);
            label3.Location = new Point(83, 131);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 3;
            label3.Text = "ŞİFRE";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(160, 134);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(194, 25);
            txtSifre.TabIndex = 4;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Cursor = Cursors.Hand;
            btnGirisYap.Location = new Point(160, 165);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(194, 33);
            btnGirisYap.TabIndex = 5;
            btnGirisYap.Text = "GİRİŞ YAPIN";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // FrmAcilis
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(458, 285);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(label3);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmAcilis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private Label label3;
        private TextBox txtSifre;
        private Button btnGirisYap;
    }
}
