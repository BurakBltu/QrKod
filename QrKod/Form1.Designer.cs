namespace QrKod
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_byte = new System.Windows.Forms.RadioButton();
            this.rdo_Alpha = new System.Windows.Forms.RadioButton();
            this.rdo_Num = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_qrcode = new System.Windows.Forms.PictureBox();
            this.txt_character = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_qrcode1 = new System.Windows.Forms.Button();
            this.btn_qrcode = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_Num);
            this.groupBox1.Controls.Add(this.rdo_Alpha);
            this.groupBox1.Controls.Add(this.rdo_byte);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENCODE_MODE";
            // 
            // rdo_byte
            // 
            this.rdo_byte.AutoSize = true;
            this.rdo_byte.Location = new System.Drawing.Point(6, 19);
            this.rdo_byte.Name = "rdo_byte";
            this.rdo_byte.Size = new System.Drawing.Size(186, 17);
            this.rdo_byte.TabIndex = 0;
            this.rdo_byte.TabStop = true;
            this.rdo_byte.Text = "Byte (Tüm karakterler desteklenir.)";
            this.rdo_byte.UseVisualStyleBackColor = true;
            // 
            // rdo_Alpha
            // 
            this.rdo_Alpha.AutoSize = true;
            this.rdo_Alpha.Location = new System.Drawing.Point(6, 51);
            this.rdo_Alpha.Name = "rdo_Alpha";
            this.rdo_Alpha.Size = new System.Drawing.Size(622, 17);
            this.rdo_Alpha.TabIndex = 1;
            this.rdo_Alpha.TabStop = true;
            this.rdo_Alpha.Text = "ALPHA_NUMERIC (Alfa numerik olarak şifrelenir. Byte olarak şifrelenir. Metin şifr" +
    "eleme yapılırsa geri okumada sadece 0 geliyor.)";
            this.rdo_Alpha.UseVisualStyleBackColor = true;
            // 
            // rdo_Num
            // 
            this.rdo_Num.AutoSize = true;
            this.rdo_Num.Location = new System.Drawing.Point(6, 84);
            this.rdo_Num.Name = "rdo_Num";
            this.rdo_Num.Size = new System.Drawing.Size(326, 17);
            this.rdo_Num.TabIndex = 2;
            this.rdo_Num.TabStop = true;
            this.rdo_Num.Text = "NUMERIC (Sayısal olarak şifrelenir. Sadece sayı kullanmalısınız.)";
            this.rdo_Num.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Not: Boyut sınırlamaları, yukarıdaki modlara göre değişiyor.";
            // 
            // pic_qrcode
            // 
            this.pic_qrcode.Location = new System.Drawing.Point(628, 189);
            this.pic_qrcode.Name = "pic_qrcode";
            this.pic_qrcode.Size = new System.Drawing.Size(160, 164);
            this.pic_qrcode.TabIndex = 2;
            this.pic_qrcode.TabStop = false;
            // 
            // txt_character
            // 
            this.txt_character.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_character.Location = new System.Drawing.Point(27, 189);
            this.txt_character.Multiline = true;
            this.txt_character.Name = "txt_character";
            this.txt_character.Size = new System.Drawing.Size(595, 164);
            this.txt_character.TabIndex = 3;
            this.txt_character.TextChanged += new System.EventHandler(this.txt_character_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Karakter Sayısı: 0";
            // 
            // btn_qrcode1
            // 
            this.btn_qrcode1.Location = new System.Drawing.Point(218, 360);
            this.btn_qrcode1.Name = "btn_qrcode1";
            this.btn_qrcode1.Size = new System.Drawing.Size(404, 23);
            this.btn_qrcode1.TabIndex = 5;
            this.btn_qrcode1.Text = "KareKod Üret";
            this.btn_qrcode1.UseVisualStyleBackColor = true;
            this.btn_qrcode1.Click += new System.EventHandler(this.btn_qrcode1_Click);
            // 
            // btn_qrcode
            // 
            this.btn_qrcode.Location = new System.Drawing.Point(628, 360);
            this.btn_qrcode.Name = "btn_qrcode";
            this.btn_qrcode.Size = new System.Drawing.Size(160, 23);
            this.btn_qrcode.TabIndex = 6;
            this.btn_qrcode.Text = "KareKod Çöz";
            this.btn_qrcode.UseVisualStyleBackColor = true;
            this.btn_qrcode.Click += new System.EventHandler(this.btn_qrcode_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "KareKod Yazdır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_qrcode);
            this.Controls.Add(this.btn_qrcode1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_character);
            this.Controls.Add(this.pic_qrcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_byte;
        private System.Windows.Forms.RadioButton rdo_Num;
        private System.Windows.Forms.RadioButton rdo_Alpha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_qrcode;
        private System.Windows.Forms.TextBox txt_character;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_qrcode1;
        private System.Windows.Forms.Button btn_qrcode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
    }
}

