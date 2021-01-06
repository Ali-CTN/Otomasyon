namespace Giris
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.button1 = new System.Windows.Forms.Button();
            this.GirisCikisBTN = new System.Windows.Forms.Button();
            this.GirisIDLabel = new System.Windows.Forms.Label();
            this.GirisSifremiUnuttumLinkLabel = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(69, 155);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GirisCikisBTN
            // 
            this.GirisCikisBTN.BackColor = System.Drawing.Color.Linen;
            this.GirisCikisBTN.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.GirisCikisBTN.Location = new System.Drawing.Point(264, 155);
            this.GirisCikisBTN.Margin = new System.Windows.Forms.Padding(4);
            this.GirisCikisBTN.Name = "GirisCikisBTN";
            this.GirisCikisBTN.Size = new System.Drawing.Size(187, 43);
            this.GirisCikisBTN.TabIndex = 1;
            this.GirisCikisBTN.Text = "Çıkış";
            this.GirisCikisBTN.UseVisualStyleBackColor = false;
            this.GirisCikisBTN.Click += new System.EventHandler(this.GirisCikisBTN_Click);
            // 
            // GirisIDLabel
            // 
            this.GirisIDLabel.AutoSize = true;
            this.GirisIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.GirisIDLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.GirisIDLabel.Location = new System.Drawing.Point(99, 25);
            this.GirisIDLabel.Margin = new System.Windows.Forms.Padding(4, 9, 4, 4);
            this.GirisIDLabel.Name = "GirisIDLabel";
            this.GirisIDLabel.Size = new System.Drawing.Size(64, 29);
            this.GirisIDLabel.TabIndex = 2;
            this.GirisIDLabel.Text = "ID :";
            // 
            // GirisSifremiUnuttumLinkLabel
            // 
            this.GirisSifremiUnuttumLinkLabel.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.GirisSifremiUnuttumLinkLabel.AutoSize = true;
            this.GirisSifremiUnuttumLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.GirisSifremiUnuttumLinkLabel.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.GirisSifremiUnuttumLinkLabel.LinkColor = System.Drawing.Color.DarkRed;
            this.GirisSifremiUnuttumLinkLabel.Location = new System.Drawing.Point(64, 202);
            this.GirisSifremiUnuttumLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GirisSifremiUnuttumLinkLabel.Name = "GirisSifremiUnuttumLinkLabel";
            this.GirisSifremiUnuttumLinkLabel.Size = new System.Drawing.Size(219, 26);
            this.GirisSifremiUnuttumLinkLabel.TabIndex = 3;
            this.GirisSifremiUnuttumLinkLabel.TabStop = true;
            this.GirisSifremiUnuttumLinkLabel.Text = "Şifremi Unuttum";
            this.GirisSifremiUnuttumLinkLabel.VisitedLinkColor = System.Drawing.Color.DarkRed;
            this.GirisSifremiUnuttumLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GirisSifremiUnuttumLinkLabel_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(175, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 34);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(65, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 9, 4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(175, 65);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 34);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.GirisSifremiUnuttumLinkLabel);
            this.groupBox1.Controls.Add(this.GirisIDLabel);
            this.groupBox1.Controls.Add(this.GirisCikisBTN);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(123, 281);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(531, 258);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(123, 137);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 136);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 690);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GirisCikisBTN;
        private System.Windows.Forms.Label GirisIDLabel;
        private System.Windows.Forms.LinkLabel GirisSifremiUnuttumLinkLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

