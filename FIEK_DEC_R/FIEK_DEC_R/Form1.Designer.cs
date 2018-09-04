namespace FIEK_DEC_R
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wb_1 = new System.Windows.Forms.WebBrowser();
            this.btn_get_key = new System.Windows.Forms.Button();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.txt_iv = new System.Windows.Forms.TextBox();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtb_1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtb_2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // wb_1
            // 
            this.wb_1.Location = new System.Drawing.Point(293, 371);
            this.wb_1.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_1.Name = "wb_1";
            this.wb_1.ScrollBarsEnabled = false;
            this.wb_1.Size = new System.Drawing.Size(645, 186);
            this.wb_1.TabIndex = 0;
            // 
            // btn_get_key
            // 
            this.btn_get_key.BackColor = System.Drawing.Color.Coral;
            this.btn_get_key.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_get_key.FlatAppearance.BorderSize = 0;
            this.btn_get_key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get_key.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get_key.ForeColor = System.Drawing.Color.White;
            this.btn_get_key.Location = new System.Drawing.Point(512, 320);
            this.btn_get_key.Name = "btn_get_key";
            this.btn_get_key.Size = new System.Drawing.Size(133, 31);
            this.btn_get_key.TabIndex = 1;
            this.btn_get_key.Text = "Get Key";
            this.btn_get_key.UseVisualStyleBackColor = false;
            this.btn_get_key.Click += new System.EventHandler(this.btn_get_key_Click);
            // 
            // txt_key
            // 
            this.txt_key.BackColor = System.Drawing.Color.Teal;
            this.txt_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_key.ForeColor = System.Drawing.Color.White;
            this.txt_key.Location = new System.Drawing.Point(293, 618);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(531, 22);
            this.txt_key.TabIndex = 3;
            // 
            // txt_iv
            // 
            this.txt_iv.BackColor = System.Drawing.Color.Teal;
            this.txt_iv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_iv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iv.ForeColor = System.Drawing.Color.White;
            this.txt_iv.Location = new System.Drawing.Point(293, 667);
            this.txt_iv.Name = "txt_iv";
            this.txt_iv.Size = new System.Drawing.Size(531, 22);
            this.txt_iv.TabIndex = 4;
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.BackColor = System.Drawing.Color.Coral;
            this.btn_decrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_decrypt.FlatAppearance.BorderSize = 0;
            this.btn_decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_decrypt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decrypt.ForeColor = System.Drawing.Color.White;
            this.btn_decrypt.Location = new System.Drawing.Point(837, 618);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(101, 69);
            this.btn_decrypt.TabIndex = 7;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = false;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 229);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(317, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(621, 61);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(317, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(610, 61);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(317, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(610, 61);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(275, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = ">> ID";
            // 
            // rtb_1
            // 
            this.rtb_1.BackColor = System.Drawing.Color.Teal;
            this.rtb_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_1.ForeColor = System.Drawing.Color.White;
            this.rtb_1.Location = new System.Drawing.Point(375, 320);
            this.rtb_1.Name = "rtb_1";
            this.rtb_1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_1.Size = new System.Drawing.Size(100, 31);
            this.rtb_1.TabIndex = 13;
            this.rtb_1.Text = "";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(289, 588);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = ">> Secret Key";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(289, 641);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = ">> IV";
            // 
            // rtb_2
            // 
            this.rtb_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_2.Location = new System.Drawing.Point(98, 237);
            this.rtb_2.Name = "rtb_2";
            this.rtb_2.Size = new System.Drawing.Size(131, 450);
            this.rtb_2.TabIndex = 16;
            this.rtb_2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(964, 713);
            this.Controls.Add(this.rtb_2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtb_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.txt_iv);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.btn_get_key);
            this.Controls.Add(this.wb_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "FIEK_DECRYPTOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb_1;
        private System.Windows.Forms.Button btn_get_key;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.TextBox txt_iv;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtb_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtb_2;
    }
}

