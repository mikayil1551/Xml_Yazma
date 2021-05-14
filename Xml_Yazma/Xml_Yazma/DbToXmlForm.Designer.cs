namespace Xml_Yazma
{
    partial class DbToXmlForm
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
            this.btnUrunlerXml = new System.Windows.Forms.Button();
            this.btnTedarikciler = new System.Windows.Forms.Button();
            this.btnTedarikcilerListele = new System.Windows.Forms.Button();
            this.btnUrunlerListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrunlerXml
            // 
            this.btnUrunlerXml.Location = new System.Drawing.Point(12, 12);
            this.btnUrunlerXml.Name = "btnUrunlerXml";
            this.btnUrunlerXml.Size = new System.Drawing.Size(127, 23);
            this.btnUrunlerXml.TabIndex = 0;
            this.btnUrunlerXml.Text = "Urunler Icin Xml Olustur";
            this.btnUrunlerXml.UseVisualStyleBackColor = true;
            this.btnUrunlerXml.Click += new System.EventHandler(this.btnUrunlerXml_Click);
            // 
            // btnTedarikciler
            // 
            this.btnTedarikciler.Location = new System.Drawing.Point(177, 12);
            this.btnTedarikciler.Name = "btnTedarikciler";
            this.btnTedarikciler.Size = new System.Drawing.Size(163, 23);
            this.btnTedarikciler.TabIndex = 1;
            this.btnTedarikciler.Text = "Tedarikciler Icin Xml Olustur";
            this.btnTedarikciler.UseVisualStyleBackColor = true;
            this.btnTedarikciler.Click += new System.EventHandler(this.btnTedarikciler_Click);
            // 
            // btnTedarikcilerListele
            // 
            this.btnTedarikcilerListele.Location = new System.Drawing.Point(177, 41);
            this.btnTedarikcilerListele.Name = "btnTedarikcilerListele";
            this.btnTedarikcilerListele.Size = new System.Drawing.Size(163, 23);
            this.btnTedarikcilerListele.TabIndex = 2;
            this.btnTedarikcilerListele.Text = "Tedarikciler Xml dosyasi Listele";
            this.btnTedarikcilerListele.UseVisualStyleBackColor = true;
            this.btnTedarikcilerListele.Click += new System.EventHandler(this.btnTedarikcilerListele_Click);
            // 
            // btnUrunlerListele
            // 
            this.btnUrunlerListele.Location = new System.Drawing.Point(12, 41);
            this.btnUrunlerListele.Name = "btnUrunlerListele";
            this.btnUrunlerListele.Size = new System.Drawing.Size(146, 23);
            this.btnUrunlerListele.TabIndex = 2;
            this.btnUrunlerListele.Text = "Urunler Xml dosyasi Listele";
            this.btnUrunlerListele.UseVisualStyleBackColor = true;
            this.btnUrunlerListele.Click += new System.EventHandler(this.btnUrunlerListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(328, 219);
            this.dataGridView1.TabIndex = 3;
            // 
            // DbToXmlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUrunlerListele);
            this.Controls.Add(this.btnTedarikcilerListele);
            this.Controls.Add(this.btnTedarikciler);
            this.Controls.Add(this.btnUrunlerXml);
            this.Name = "DbToXmlForm";
            this.Text = "DbToXmlForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunlerXml;
        private System.Windows.Forms.Button btnTedarikciler;
        private System.Windows.Forms.Button btnTedarikcilerListele;
        private System.Windows.Forms.Button btnUrunlerListele;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}