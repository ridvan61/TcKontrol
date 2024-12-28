namespace TcKimlikKontrol
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_GonderenTCno = new System.Windows.Forms.TextBox();
            this.TCHatasi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TCHatasi)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_GonderenTCno
            // 
            this.txt_GonderenTCno.Location = new System.Drawing.Point(279, 190);
            this.txt_GonderenTCno.Name = "txt_GonderenTCno";
            this.txt_GonderenTCno.Size = new System.Drawing.Size(185, 20);
            this.txt_GonderenTCno.TabIndex = 0;
            this.txt_GonderenTCno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_GonderenTCno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTcKimlik_KeyPress_1);
            this.txt_GonderenTCno.Leave += new System.EventHandler(this.txt_GonderenTCno_Leave);
            // 
            // TCHatasi
            // 
            this.TCHatasi.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_GonderenTCno);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TCHatasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_GonderenTCno;
        private System.Windows.Forms.ErrorProvider TCHatasi;
    }
}

