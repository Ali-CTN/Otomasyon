using System.Windows.Forms;

namespace Giris
{
    partial class Personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel));
            this.PersonelCikisBTN = new System.Windows.Forms.Button();
            this.PersonelGeriBTN = new System.Windows.Forms.Button();
            this.PersonelGuncelleBTN = new System.Windows.Forms.Button();
            this.PersonelSilBTN = new System.Windows.Forms.Button();
            this.PersonelAraTextBox = new System.Windows.Forms.TextBox();
            this.PersonelAraBTN = new System.Windows.Forms.Button();
            this.PersonelDataGridView = new System.Windows.Forms.DataGridView();
            this.PersonelKaydetBTN = new System.Windows.Forms.Button();
            this.PersonelTelefonTextBox = new System.Windows.Forms.TextBox();
            this.PersonelSoyadTextBox = new System.Windows.Forms.TextBox();
            this.PersonelEmailLabel = new System.Windows.Forms.Label();
            this.PersonelTelefonLabel = new System.Windows.Forms.Label();
            this.PersonelSoyadLabel = new System.Windows.Forms.Label();
            this.PersonelVazifeLabel = new System.Windows.Forms.Label();
            this.PersonelAdiLabel = new System.Windows.Forms.Label();
            this.PersonelEmailTextBox = new System.Windows.Forms.TextBox();
            this.PersonelMaasLabel = new System.Windows.Forms.Label();
            this.PersonelMaasTextBox = new System.Windows.Forms.TextBox();
            this.PersonelVazifeComboBox = new System.Windows.Forms.ComboBox();
            this.PersonelKullaniciAdiLabel = new System.Windows.Forms.Label();
            this.PersonelKullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.PersonelSifreLabel = new System.Windows.Forms.Label();
            this.PersonelSifreTextBox = new System.Windows.Forms.TextBox();
            this.PersonelGizliSoruLabel = new System.Windows.Forms.Label();
            this.PersonelGizliSoruComboBox = new System.Windows.Forms.ComboBox();
            this.PersonelCevapLabel = new System.Windows.Forms.Label();
            this.PersonelCevapTextBox = new System.Windows.Forms.TextBox();
            this.PersonelAdiTextBox = new System.Windows.Forms.TextBox();
            this.PersonelIsGirisLabel = new System.Windows.Forms.Label();
            this.PersonelGirisDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PersonelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonelCikisBTN
            // 
            this.PersonelCikisBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PersonelCikisBTN.BackgroundImage")));
            this.PersonelCikisBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PersonelCikisBTN.Location = new System.Drawing.Point(732, 12);
            this.PersonelCikisBTN.Name = "PersonelCikisBTN";
            this.PersonelCikisBTN.Size = new System.Drawing.Size(100, 100);
            this.PersonelCikisBTN.TabIndex = 39;
            this.PersonelCikisBTN.UseVisualStyleBackColor = true;
            this.PersonelCikisBTN.Click += new System.EventHandler(this.PersonelCikisBTN_Click);
            // 
            // PersonelGeriBTN
            // 
            this.PersonelGeriBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PersonelGeriBTN.BackgroundImage")));
            this.PersonelGeriBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PersonelGeriBTN.Location = new System.Drawing.Point(12, 12);
            this.PersonelGeriBTN.Name = "PersonelGeriBTN";
            this.PersonelGeriBTN.Size = new System.Drawing.Size(100, 100);
            this.PersonelGeriBTN.TabIndex = 38;
            this.PersonelGeriBTN.UseVisualStyleBackColor = true;
            this.PersonelGeriBTN.Click += new System.EventHandler(this.PersonelGeriBTN_Click);
            // 
            // PersonelGuncelleBTN
            // 
            this.PersonelGuncelleBTN.BackColor = System.Drawing.Color.Linen;
            this.PersonelGuncelleBTN.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.PersonelGuncelleBTN.Location = new System.Drawing.Point(546, 370);
            this.PersonelGuncelleBTN.Name = "PersonelGuncelleBTN";
            this.PersonelGuncelleBTN.Size = new System.Drawing.Size(140, 35);
            this.PersonelGuncelleBTN.TabIndex = 36;
            this.PersonelGuncelleBTN.Text = "Güncelle";
            this.PersonelGuncelleBTN.UseVisualStyleBackColor = false;
            this.PersonelGuncelleBTN.Click += new System.EventHandler(this.PersonelGuncelleBTN_Click);
            // 
            // PersonelSilBTN
            // 
            this.PersonelSilBTN.BackColor = System.Drawing.Color.Linen;
            this.PersonelSilBTN.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.PersonelSilBTN.Location = new System.Drawing.Point(692, 370);
            this.PersonelSilBTN.Name = "PersonelSilBTN";
            this.PersonelSilBTN.Size = new System.Drawing.Size(140, 35);
            this.PersonelSilBTN.TabIndex = 35;
            this.PersonelSilBTN.Text = "Sil";
            this.PersonelSilBTN.UseVisualStyleBackColor = false;
            this.PersonelSilBTN.Click += new System.EventHandler(this.PersonelSilBTN_Click);
            // 
            // PersonelAraTextBox
            // 
            this.PersonelAraTextBox.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.PersonelAraTextBox.Location = new System.Drawing.Point(12, 370);
            this.PersonelAraTextBox.Multiline = true;
            this.PersonelAraTextBox.Name = "PersonelAraTextBox";
            this.PersonelAraTextBox.Size = new System.Drawing.Size(176, 35);
            this.PersonelAraTextBox.TabIndex = 34;
            this.PersonelAraTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PersonelAraTextBox_KeyPress);
            // 
            // PersonelAraBTN
            // 
            this.PersonelAraBTN.BackColor = System.Drawing.Color.Linen;
            this.PersonelAraBTN.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.PersonelAraBTN.Location = new System.Drawing.Point(199, 370);
            this.PersonelAraBTN.Name = "PersonelAraBTN";
            this.PersonelAraBTN.Size = new System.Drawing.Size(140, 35);
            this.PersonelAraBTN.TabIndex = 33;
            this.PersonelAraBTN.Text = "Ara";
            this.PersonelAraBTN.UseVisualStyleBackColor = false;
            this.PersonelAraBTN.Click += new System.EventHandler(this.PersonelAraBTN_Click);
            // 
            // PersonelDataGridView
            // 
            this.PersonelDataGridView.AllowUserToDeleteRows = false;
            this.PersonelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonelDataGridView.Location = new System.Drawing.Point(12, 411);
            this.PersonelDataGridView.Name = "PersonelDataGridView";
            this.PersonelDataGridView.ReadOnly = true;
            this.PersonelDataGridView.Size = new System.Drawing.Size(820, 218);
            this.PersonelDataGridView.TabIndex = 32;
            this.PersonelDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PersonelDataGridView_RowHeaderMouseClick);
            // 
            // PersonelKaydetBTN
            // 
            this.PersonelKaydetBTN.BackColor = System.Drawing.Color.Linen;
            this.PersonelKaydetBTN.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.PersonelKaydetBTN.Location = new System.Drawing.Point(362, 309);
            this.PersonelKaydetBTN.Name = "PersonelKaydetBTN";
            this.PersonelKaydetBTN.Size = new System.Drawing.Size(140, 35);
            this.PersonelKaydetBTN.TabIndex = 31;
            this.PersonelKaydetBTN.Text = "Kaydet";
            this.PersonelKaydetBTN.UseVisualStyleBackColor = false;
            this.PersonelKaydetBTN.Click += new System.EventHandler(this.PersonelKaydetBTN_Click);
            // 
            // PersonelTelefonTextBox
            // 
            this.PersonelTelefonTextBox.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.PersonelTelefonTextBox.Location = new System.Drawing.Point(362, 105);
            this.PersonelTelefonTextBox.MaxLength = 11;
            this.PersonelTelefonTextBox.Multiline = true;
            this.PersonelTelefonTextBox.Name = "PersonelTelefonTextBox";
            this.PersonelTelefonTextBox.Size = new System.Drawing.Size(200, 28);
            this.PersonelTelefonTextBox.TabIndex = 29;
            this.PersonelTelefonTextBox.TextChanged += new System.EventHandler(this.PersonelTelefonTextBox_TextChanged);
            this.PersonelTelefonTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PersonelTelefonTextBox_KeyPress);
            // 
            // PersonelSoyadTextBox
            // 
            this.PersonelSoyadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PersonelSoyadTextBox.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.PersonelSoyadTextBox.Location = new System.Drawing.Point(362, 73);
            this.PersonelSoyadTextBox.MaxLength = 20;
            this.PersonelSoyadTextBox.Multiline = true;
            this.PersonelSoyadTextBox.Name = "PersonelSoyadTextBox";
            this.PersonelSoyadTextBox.Size = new System.Drawing.Size(200, 28);
            this.PersonelSoyadTextBox.TabIndex = 28;
            this.PersonelSoyadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PersonelSoyadTextBox_KeyPress);
            // 
            // PersonelEmailLabel
            // 
            this.PersonelEmailLabel.AutoSize = true;
            this.PersonelEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.PersonelEmailLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.PersonelEmailLabel.Location = new System.Drawing.Point(264, 139);
            this.PersonelEmailLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.PersonelEmailLabel.Name = "PersonelEmailLabel";
            this.PersonelEmailLabel.Size = new System.Drawing.Size(92, 23);
            this.PersonelEmailLabel.TabIndex = 25;
            this.PersonelEmailLabel.Text = "E-Mail :";
            // 
            // PersonelTelefonLabel
            // 
            this.PersonelTelefonLabel.AutoSize = true;
            this.PersonelTelefonLabel.BackColor = System.Drawing.Color.Transparent;
            this.PersonelTelefonLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.PersonelTelefonLabel.Location = new System.Drawing.Point(250, 106);
            this.PersonelTelefonLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.PersonelTelefonLabel.Name = "PersonelTelefonLabel";
            this.PersonelTelefonLabel.Size = new System.Drawing.Size(106, 23);
            this.PersonelTelefonLabel.TabIndex = 24;
            this.PersonelTelefonLabel.Text = "Telefon :";
            // 
            // PersonelSoyadLabel
            // 
            this.PersonelSoyadLabel.AutoSize = true;
            this.PersonelSoyadLabel.BackColor = System.Drawing.Color.Transparent;
            this.PersonelSoyadLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.PersonelSoyadLabel.Location = new System.Drawing.Point(158, 73);
            this.PersonelSoyadLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.PersonelSoyadLabel.Name = "PersonelSoyadLabel";
            this.PersonelSoyadLabel.Size = new System.Drawing.Size(198, 23);
            this.PersonelSoyadLabel.TabIndex = 23;
            this.PersonelSoyadLabel.Text = "Personel Soyadı :";
            // 
            // PersonelVazifeLabel
            // 
            this.PersonelVazifeLabel.AutoSize = true;
            this.PersonelVazifeLabel.BackColor = System.Drawing.Color.Transparent;
            this.PersonelVazifeLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.PersonelVazifeLabel.Location = new System.Drawing.Point(480, 172);
            this.PersonelVazifeLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.PersonelVazifeLabel.Name = "PersonelVazifeLabel";
            this.PersonelVazifeLabel.Size = new System.Drawing.Size(92, 23);
            this.PersonelVazifeLabel.TabIndex = 22;
            this.PersonelVazifeLabel.Text = "Vazife :";
            // 
            // PersonelAdiLabel
            // 
            this.PersonelAdiLabel.AutoSize = true;
            this.PersonelAdiLabel.BackColor = System.Drawing.Color.Transparent;
            this.PersonelAdiLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.PersonelAdiLabel.Location = new System.Drawing.Point(195, 40);
            this.PersonelAdiLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.PersonelAdiLabel.Name = "PersonelAdiLabel";
            this.PersonelAdiLabel.Size = new System.Drawing.Size(161, 23);
            this.PersonelAdiLabel.TabIndex = 21;
            this.PersonelAdiLabel.Text = "Personel Adı :";
            // 
            // PersonelEmailTextBox
            // 
            this.PersonelEmailTextBox.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.PersonelEmailTextBox.Location = new System.Drawing.Point(362, 139);
            this.PersonelEmailTextBox.MaxLength = 25;
            this.PersonelEmailTextBox.Multiline = true;
            this.PersonelEmailTextBox.Name = "PersonelEmailTextBox";
            this.PersonelEmailTextBox.Size = new System.Drawing.Size(200, 28);
            this.PersonelEmailTextBox.TabIndex = 40;
            // 
            // PersonelMaasLabel
            // 
            this.PersonelMaasLabel.AutoSize = true;
            this.PersonelMaasLabel.BackColor = System.Drawing.Color.Transparent;
            this.PersonelMaasLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.PersonelMaasLabel.Location = new System.Drawing.Point(276, 172);
            this.PersonelMaasLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.PersonelMaasLabel.Name = "PersonelMaasLabel";
            this.PersonelMaasLabel.Size = new System.Drawing.Size(80, 23);
            this.PersonelMaasLabel.TabIndex = 41;
            this.PersonelMaasLabel.Text = "Maaş :";
            // 
            // PersonelMaasTextBox
            // 
            this.PersonelMaasTextBox.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.PersonelMaasTextBox.Location = new System.Drawing.Point(362, 172);
            this.PersonelMaasTextBox.Multiline = true;
            this.PersonelMaasTextBox.Name = "PersonelMaasTextBox";
            this.PersonelMaasTextBox.Size = new System.Drawing.Size(95, 28);
            this.PersonelMaasTextBox.TabIndex = 42;
            this.PersonelMaasTextBox.TextChanged += new System.EventHandler(this.PersonelMaasTextBox_TextChanged);
            this.PersonelMaasTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PersonelMaasTextBox_KeyPress);
            // 
            // PersonelVazifeComboBox
            // 
            this.PersonelVazifeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonelVazifeComboBox.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.PersonelVazifeComboBox.FormattingEnabled = true;
            this.PersonelVazifeComboBox.Items.AddRange(new object[] {
            "Yönetici",
            "Pazarlama Mdr",
            "Depo Sorumlusu",
            "Modelist",
            "Diğer"});
            this.PersonelVazifeComboBox.Location = new System.Drawing.Point(578, 171);
            this.PersonelVazifeComboBox.Name = "PersonelVazifeComboBox";
            this.PersonelVazifeComboBox.Size = new System.Drawing.Size(226, 28);
            this.PersonelVazifeComboBox.TabIndex = 43;
            this.PersonelVazifeComboBox.SelectedIndexChanged += new System.EventHandler(this.PersonelVazifeComboBox_SelectedIndexChanged);
            // 
            // PersonelKullaniciAdiLabel
            // 
            this.PersonelKullaniciAdiLabel.AutoSize = true;
            this.PersonelKullaniciAdiLabel.BackColor = System.Drawing.Color.Transparent;
            this.PersonelKullaniciAdiLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.PersonelKullaniciAdiLabel.Location = new System.Drawing.Point(194, 208);
            this.PersonelKullaniciAdiLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.PersonelKullaniciAdiLabel.Name = "PersonelKullaniciAdiLabel";
            this.PersonelKullaniciAdiLabel.Size = new System.Drawing.Size(162, 23);
            this.PersonelKullaniciAdiLabel.TabIndex = 44;
            this.PersonelKullaniciAdiLabel.Text = "Kullanıcı Adı :";
            // 
            // PersonelKullaniciAdiTextBox
            // 
            this.PersonelKullaniciAdiTextBox.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.PersonelKullaniciAdiTextBox.Location = new System.Drawing.Point(362, 206);
            this.PersonelKullaniciAdiTextBox.Multiline = true;
            this.PersonelKullaniciAdiTextBox.Name = "PersonelKullaniciAdiTextBox";
            this.PersonelKullaniciAdiTextBox.Size = new System.Drawing.Size(200, 28);
            this.PersonelKullaniciAdiTextBox.TabIndex = 45;
            this.PersonelKullaniciAdiTextBox.TextChanged += new System.EventHandler(this.PersonelKullaniciAdiTextBox_TextChanged);
            this.PersonelKullaniciAdiTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PersonelKullaniciAdiTextBox_KeyPress);
            // 
            // PersonelSifreLabel
            // 
            this.PersonelSifreLabel.AutoSize = true;
            this.PersonelSifreLabel.BackColor = System.Drawing.Color.Transparent;
            this.PersonelSifreLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.PersonelSifreLabel.Location = new System.Drawing.Point(582, 206);
            this.PersonelSifreLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.PersonelSifreLabel.Name = "PersonelSifreLabel";
            this.PersonelSifreLabel.Size = new System.Drawing.Size(76, 23);
            this.PersonelSifreLabel.TabIndex = 46;
            this.PersonelSifreLabel.Text = "Şifre :";
            // 
            // PersonelSifreTextBox
            // 
            this.PersonelSifreTextBox.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.PersonelSifreTextBox.Location = new System.Drawing.Point(664, 205);
            this.PersonelSifreTextBox.Multiline = true;
            this.PersonelSifreTextBox.Name = "PersonelSifreTextBox";
            this.PersonelSifreTextBox.Size = new System.Drawing.Size(140, 28);
            this.PersonelSifreTextBox.TabIndex = 47;
            this.PersonelSifreTextBox.TextChanged += new System.EventHandler(this.PersonelSifreTextBox_TextChanged);
            this.PersonelSifreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PersonelSifreTextBox_KeyPress);
            // 
            // PersonelGizliSoruLabel
            // 
            this.PersonelGizliSoruLabel.AutoSize = true;
            this.PersonelGizliSoruLabel.BackColor = System.Drawing.Color.Transparent;
            this.PersonelGizliSoruLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.PersonelGizliSoruLabel.Location = new System.Drawing.Point(227, 241);
            this.PersonelGizliSoruLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.PersonelGizliSoruLabel.Name = "PersonelGizliSoruLabel";
            this.PersonelGizliSoruLabel.Size = new System.Drawing.Size(129, 23);
            this.PersonelGizliSoruLabel.TabIndex = 48;
            this.PersonelGizliSoruLabel.Text = "Gizli Soru :";
            // 
            // PersonelGizliSoruComboBox
            // 
            this.PersonelGizliSoruComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonelGizliSoruComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.PersonelGizliSoruComboBox.FormattingEnabled = true;
            this.PersonelGizliSoruComboBox.Items.AddRange(new object[] {
            "Annenizin kızlık soyadı nedir?",
            "İlk evcil hayvanınızın adı nedir?",
            "İlk aracınızın modeli nedir?",
            "Hangi şehirde doğdunuz?",
            "Çocukluk lakabınız nedir?"});
            this.PersonelGizliSoruComboBox.Location = new System.Drawing.Point(362, 240);
            this.PersonelGizliSoruComboBox.Name = "PersonelGizliSoruComboBox";
            this.PersonelGizliSoruComboBox.Size = new System.Drawing.Size(200, 26);
            this.PersonelGizliSoruComboBox.TabIndex = 49;
            // 
            // PersonelCevapLabel
            // 
            this.PersonelCevapLabel.AutoSize = true;
            this.PersonelCevapLabel.BackColor = System.Drawing.Color.Transparent;
            this.PersonelCevapLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.PersonelCevapLabel.Location = new System.Drawing.Point(568, 241);
            this.PersonelCevapLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.PersonelCevapLabel.Name = "PersonelCevapLabel";
            this.PersonelCevapLabel.Size = new System.Drawing.Size(90, 23);
            this.PersonelCevapLabel.TabIndex = 50;
            this.PersonelCevapLabel.Text = "Cevap :";
            // 
            // PersonelCevapTextBox
            // 
            this.PersonelCevapTextBox.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.PersonelCevapTextBox.Location = new System.Drawing.Point(664, 240);
            this.PersonelCevapTextBox.Multiline = true;
            this.PersonelCevapTextBox.Name = "PersonelCevapTextBox";
            this.PersonelCevapTextBox.Size = new System.Drawing.Size(140, 28);
            this.PersonelCevapTextBox.TabIndex = 51;
            this.PersonelCevapTextBox.TextChanged += new System.EventHandler(this.PersonelCevapTextBox_TextChanged);
            this.PersonelCevapTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PersonelCevapTextBox_KeyPress);
            // 
            // PersonelAdiTextBox
            // 
            this.PersonelAdiTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PersonelAdiTextBox.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.PersonelAdiTextBox.Location = new System.Drawing.Point(362, 39);
            this.PersonelAdiTextBox.MaxLength = 25;
            this.PersonelAdiTextBox.Multiline = true;
            this.PersonelAdiTextBox.Name = "PersonelAdiTextBox";
            this.PersonelAdiTextBox.Size = new System.Drawing.Size(200, 28);
            this.PersonelAdiTextBox.TabIndex = 52;
            this.PersonelAdiTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PersonelAdiTextBox_KeyPress);
            // 
            // PersonelIsGirisLabel
            // 
            this.PersonelIsGirisLabel.AutoSize = true;
            this.PersonelIsGirisLabel.BackColor = System.Drawing.Color.Transparent;
            this.PersonelIsGirisLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.PersonelIsGirisLabel.Location = new System.Drawing.Point(171, 274);
            this.PersonelIsGirisLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.PersonelIsGirisLabel.Name = "PersonelIsGirisLabel";
            this.PersonelIsGirisLabel.Size = new System.Drawing.Size(185, 23);
            this.PersonelIsGirisLabel.TabIndex = 53;
            this.PersonelIsGirisLabel.Text = "İşe Giriş Tarihi :";
            // 
            // PersonelGirisDateTimePicker
            // 
            this.PersonelGirisDateTimePicker.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.PersonelGirisDateTimePicker.Location = new System.Drawing.Point(362, 274);
            this.PersonelGirisDateTimePicker.Name = "PersonelGirisDateTimePicker";
            this.PersonelGirisDateTimePicker.Size = new System.Drawing.Size(292, 29);
            this.PersonelGirisDateTimePicker.TabIndex = 54;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 641);
            this.Controls.Add(this.PersonelGirisDateTimePicker);
            this.Controls.Add(this.PersonelIsGirisLabel);
            this.Controls.Add(this.PersonelAdiTextBox);
            this.Controls.Add(this.PersonelCevapTextBox);
            this.Controls.Add(this.PersonelCevapLabel);
            this.Controls.Add(this.PersonelGizliSoruComboBox);
            this.Controls.Add(this.PersonelGizliSoruLabel);
            this.Controls.Add(this.PersonelSifreTextBox);
            this.Controls.Add(this.PersonelSifreLabel);
            this.Controls.Add(this.PersonelKullaniciAdiTextBox);
            this.Controls.Add(this.PersonelKullaniciAdiLabel);
            this.Controls.Add(this.PersonelVazifeComboBox);
            this.Controls.Add(this.PersonelMaasTextBox);
            this.Controls.Add(this.PersonelMaasLabel);
            this.Controls.Add(this.PersonelEmailTextBox);
            this.Controls.Add(this.PersonelCikisBTN);
            this.Controls.Add(this.PersonelGeriBTN);
            this.Controls.Add(this.PersonelGuncelleBTN);
            this.Controls.Add(this.PersonelSilBTN);
            this.Controls.Add(this.PersonelAraTextBox);
            this.Controls.Add(this.PersonelAraBTN);
            this.Controls.Add(this.PersonelDataGridView);
            this.Controls.Add(this.PersonelKaydetBTN);
            this.Controls.Add(this.PersonelTelefonTextBox);
            this.Controls.Add(this.PersonelSoyadTextBox);
            this.Controls.Add(this.PersonelEmailLabel);
            this.Controls.Add(this.PersonelTelefonLabel);
            this.Controls.Add(this.PersonelSoyadLabel);
            this.Controls.Add(this.PersonelVazifeLabel);
            this.Controls.Add(this.PersonelAdiLabel);
            this.Name = "Personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button PersonelCikisBTN;
        private System.Windows.Forms.Button PersonelGeriBTN;
        private System.Windows.Forms.Button PersonelGuncelleBTN;
        private System.Windows.Forms.Button PersonelSilBTN;
        private System.Windows.Forms.TextBox PersonelAraTextBox;
        private System.Windows.Forms.Button PersonelAraBTN;
        private System.Windows.Forms.DataGridView PersonelDataGridView;
        private System.Windows.Forms.Button PersonelKaydetBTN;
        private System.Windows.Forms.TextBox PersonelTelefonTextBox;
        private System.Windows.Forms.TextBox PersonelSoyadTextBox;
        private System.Windows.Forms.Label PersonelEmailLabel;
        private System.Windows.Forms.Label PersonelTelefonLabel;
        private System.Windows.Forms.Label PersonelSoyadLabel;
        private System.Windows.Forms.Label PersonelVazifeLabel;
        private System.Windows.Forms.Label PersonelAdiLabel;
        private System.Windows.Forms.TextBox PersonelEmailTextBox;
        private System.Windows.Forms.Label PersonelMaasLabel;
        private System.Windows.Forms.TextBox PersonelMaasTextBox;
        private System.Windows.Forms.ComboBox PersonelVazifeComboBox;
        private System.Windows.Forms.Label PersonelKullaniciAdiLabel;
        private System.Windows.Forms.TextBox PersonelKullaniciAdiTextBox;
        private System.Windows.Forms.Label PersonelSifreLabel;
        private System.Windows.Forms.TextBox PersonelSifreTextBox;
        private System.Windows.Forms.Label PersonelGizliSoruLabel;
        private System.Windows.Forms.ComboBox PersonelGizliSoruComboBox;
        private System.Windows.Forms.Label PersonelCevapLabel;
        private System.Windows.Forms.TextBox PersonelCevapTextBox;
        private System.Windows.Forms.TextBox PersonelAdiTextBox;
        private System.Windows.Forms.Label PersonelIsGirisLabel;
        private System.Windows.Forms.DateTimePicker PersonelGirisDateTimePicker;
        private System.Windows.Forms.ToolTip toolTip1;
        private ErrorProvider errorProvider1;
    }
}