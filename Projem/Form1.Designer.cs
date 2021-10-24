
namespace Projem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1_kaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_temizle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÜRÜN ADI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ÜRETİM YERİ :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(179, 281);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "STOK :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1_kaydet
            // 
            this.button1_kaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1_kaydet.ImageKey = "save_button.png";
            this.button1_kaydet.ImageList = this.ımageList1;
            this.button1_kaydet.Location = new System.Drawing.Point(37, 362);
            this.button1_kaydet.Name = "button1_kaydet";
            this.button1_kaydet.Size = new System.Drawing.Size(121, 86);
            this.button1_kaydet.TabIndex = 8;
            this.button1_kaydet.Text = "KAYDET";
            this.button1_kaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1_kaydet.UseVisualStyleBackColor = true;
            this.button1_kaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageKey = "list_button.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(323, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(592, 73);
            this.button2.TabIndex = 9;
            this.button2.Text = "LİSTELE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_temizle
            // 
            this.button_temizle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_temizle.ImageKey = "Delete-file-icon.png";
            this.button_temizle.ImageList = this.ımageList1;
            this.button_temizle.Location = new System.Drawing.Point(179, 362);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(121, 86);
            this.button_temizle.TabIndex = 10;
            this.button_temizle.Text = "TEMİZLE";
            this.button_temizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_temizle.UseVisualStyleBackColor = true;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // button_sil
            // 
            this.button_sil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_sil.ImageKey = "delete_button.png";
            this.button_sil.ImageList = this.ımageList1;
            this.button_sil.Location = new System.Drawing.Point(37, 477);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(121, 84);
            this.button_sil.TabIndex = 11;
            this.button_sil.Text = "SİL";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button5
            // 
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.ImageKey = "update_button.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(179, 477);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 84);
            this.button5.TabIndex = 12;
            this.button5.Text = "GÜNCELLE";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(323, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(592, 431);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add_button.png");
            this.ımageList1.Images.SetKeyName(1, "delete_button.png");
            this.ımageList1.Images.SetKeyName(2, "list_button.png");
            this.ımageList1.Images.SetKeyName(3, "save_button.png");
            this.ımageList1.Images.SetKeyName(4, "update_button.png");
            this.ımageList1.Images.SetKeyName(5, "Delete-file-icon.png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(778, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(714, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 15;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(927, 584);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1_kaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ZÜCCACİYE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1_kaydet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}

