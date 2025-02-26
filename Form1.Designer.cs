
namespace part2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.amountQ_bt = new System.Windows.Forms.Button();
            this.title_bt = new System.Windows.Forms.Button();
            this.country_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1392, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // amountQ_bt
            // 
            this.amountQ_bt.Location = new System.Drawing.Point(89, 406);
            this.amountQ_bt.Name = "amountQ_bt";
            this.amountQ_bt.Size = new System.Drawing.Size(75, 23);
            this.amountQ_bt.TabIndex = 1;
            this.amountQ_bt.Text = "totalAmount";
            this.amountQ_bt.UseVisualStyleBackColor = true;
            this.amountQ_bt.Click += new System.EventHandler(this.amountQ_bt_Click);
            // 
            // title_bt
            // 
            this.title_bt.Location = new System.Drawing.Point(382, 405);
            this.title_bt.Name = "title_bt";
            this.title_bt.Size = new System.Drawing.Size(75, 23);
            this.title_bt.TabIndex = 2;
            this.title_bt.Text = "title";
            this.title_bt.UseVisualStyleBackColor = true;
            this.title_bt.Click += new System.EventHandler(this.title_bt_Click);
            // 
            // country_bt
            // 
            this.country_bt.Location = new System.Drawing.Point(644, 405);
            this.country_bt.Name = "country_bt";
            this.country_bt.Size = new System.Drawing.Size(75, 23);
            this.country_bt.TabIndex = 3;
            this.country_bt.Text = "country";
            this.country_bt.UseVisualStyleBackColor = true;
            this.country_bt.Click += new System.EventHandler(this.country_bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 503);
            this.Controls.Add(this.country_bt);
            this.Controls.Add(this.title_bt);
            this.Controls.Add(this.amountQ_bt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button amountQ_bt;
        private System.Windows.Forms.Button title_bt;
        private System.Windows.Forms.Button country_bt;
    }
}

