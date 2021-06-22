
namespace Yarışma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.a = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.soruno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dogru = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yanlis = new System.Windows.Forms.Label();
            this.sonraki = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(619, 330);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // a
            // 
            this.a.Enabled = false;
            this.a.Location = new System.Drawing.Point(12, 348);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(305, 70);
            this.a.TabIndex = 1;
            this.a.Text = "A)";
            this.a.UseVisualStyleBackColor = true;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // b
            // 
            this.b.Enabled = false;
            this.b.Location = new System.Drawing.Point(326, 348);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(305, 70);
            this.b.TabIndex = 2;
            this.b.Text = "B)";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // d
            // 
            this.d.Enabled = false;
            this.d.Location = new System.Drawing.Point(326, 424);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(305, 70);
            this.d.TabIndex = 4;
            this.d.Text = "D)";
            this.d.UseVisualStyleBackColor = true;
            this.d.Click += new System.EventHandler(this.d_Click);
            // 
            // c
            // 
            this.c.Enabled = false;
            this.c.Location = new System.Drawing.Point(12, 424);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(305, 70);
            this.c.TabIndex = 3;
            this.c.Text = "C)";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(684, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Question:";
            // 
            // soruno
            // 
            this.soruno.AutoSize = true;
            this.soruno.Location = new System.Drawing.Point(845, 15);
            this.soruno.Name = "soruno";
            this.soruno.Size = new System.Drawing.Size(20, 23);
            this.soruno.TabIndex = 6;
            this.soruno.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(684, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "True:";
            // 
            // dogru
            // 
            this.dogru.AutoSize = true;
            this.dogru.Location = new System.Drawing.Point(845, 95);
            this.dogru.Name = "dogru";
            this.dogru.Size = new System.Drawing.Size(20, 23);
            this.dogru.TabIndex = 8;
            this.dogru.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(684, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "False:";
            // 
            // yanlis
            // 
            this.yanlis.AutoSize = true;
            this.yanlis.Location = new System.Drawing.Point(845, 176);
            this.yanlis.Name = "yanlis";
            this.yanlis.Size = new System.Drawing.Size(20, 23);
            this.yanlis.TabIndex = 10;
            this.yanlis.Text = "0";
            // 
            // sonraki
            // 
            this.sonraki.Location = new System.Drawing.Point(688, 224);
            this.sonraki.Name = "sonraki";
            this.sonraki.Size = new System.Drawing.Size(213, 49);
            this.sonraki.TabIndex = 11;
            this.sonraki.Text = "Start";
            this.sonraki.UseVisualStyleBackColor = true;
            this.sonraki.Click += new System.EventHandler(this.sonraki_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(654, 383);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(818, 383);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 609);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sonraki);
            this.Controls.Add(this.yanlis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dogru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soruno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Competition";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button d;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label soruno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dogru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label yanlis;
        private System.Windows.Forms.Button sonraki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

