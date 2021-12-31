
namespace YilbasiCekilisi
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
            this.dgvKisiler = new System.Windows.Forms.DataGridView();
            this.lblKazanan = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCekilisYap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKisiler
            // 
            this.dgvKisiler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKisiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKisiler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKisiler.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvKisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKisiler.Location = new System.Drawing.Point(12, 118);
            this.dgvKisiler.MultiSelect = false;
            this.dgvKisiler.Name = "dgvKisiler";
            this.dgvKisiler.ReadOnly = true;
            this.dgvKisiler.RowHeadersVisible = false;
            this.dgvKisiler.RowHeadersWidth = 51;
            this.dgvKisiler.RowTemplate.Height = 24;
            this.dgvKisiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKisiler.Size = new System.Drawing.Size(1046, 382);
            this.dgvKisiler.TabIndex = 5;
            this.dgvKisiler.SelectionChanged += new System.EventHandler(this.dgvKisiler_SelectionChanged);
            this.dgvKisiler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvKisiler_KeyDown);
            // 
            // lblKazanan
            // 
            this.lblKazanan.AutoSize = true;
            this.lblKazanan.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKazanan.Location = new System.Drawing.Point(492, 78);
            this.lblKazanan.Name = "lblKazanan";
            this.lblKazanan.Size = new System.Drawing.Size(133, 37);
            this.lblKazanan.TabIndex = 6;
            this.lblKazanan.Text = "Kazanan:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(28, 92);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(34, 20);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(186, 91);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(55, 20);
            this.lblSoyad.TabIndex = 3;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(68, 91);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(247, 90);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(364, 89);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(87, 26);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCekilisYap
            // 
            this.btnCekilisYap.BackColor = System.Drawing.Color.Red;
            this.btnCekilisYap.Enabled = false;
            this.btnCekilisYap.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCekilisYap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCekilisYap.Location = new System.Drawing.Point(876, 44);
            this.btnCekilisYap.Name = "btnCekilisYap";
            this.btnCekilisYap.Size = new System.Drawing.Size(158, 71);
            this.btnCekilisYap.TabIndex = 7;
            this.btnCekilisYap.Text = "Çekliliş Yap";
            this.btnCekilisYap.UseVisualStyleBackColor = false;
            this.btnCekilisYap.Click += new System.EventHandler(this.btnCekilisYap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YilbasiCekilisi.Properties.Resources.yeni_yıl_yılbaşı;
            this.pictureBox1.Location = new System.Drawing.Point(736, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1070, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCekilisYap);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblKazanan);
            this.Controls.Add(this.dgvKisiler);
            this.Name = "Form1";
            this.Tag = "01";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKisiler;
        private System.Windows.Forms.Label lblKazanan;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCekilisYap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

