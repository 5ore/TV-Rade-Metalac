namespace TVRadeMetalac
{
    partial class TVRadeMetalacForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TVRadeMetalacForm));
            this.cbMusic = new System.Windows.Forms.CheckBox();
            this.gbTipoviCasova = new System.Windows.Forms.GroupBox();
            this.rbShort = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvObavestenja = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnNextSong = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.lbPath = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lbDeleteText = new System.Windows.Forms.Label();
            this.tabSendMessage = new System.Windows.Forms.TabPage();
            this.lbDateEnd = new System.Windows.Forms.Label();
            this.lbDateStart = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteText = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.gbTipoviCasova.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavestenja)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabSendMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMusic
            // 
            this.cbMusic.AutoSize = true;
            this.cbMusic.Location = new System.Drawing.Point(9, 28);
            this.cbMusic.Name = "cbMusic";
            this.cbMusic.Size = new System.Drawing.Size(60, 17);
            this.cbMusic.TabIndex = 3;
            this.cbMusic.Text = "Muzika";
            this.cbMusic.UseVisualStyleBackColor = true;
            this.cbMusic.CheckedChanged += new System.EventHandler(this.Music);
            // 
            // gbTipoviCasova
            // 
            this.gbTipoviCasova.Controls.Add(this.rbShort);
            this.gbTipoviCasova.Controls.Add(this.rbNormal);
            this.gbTipoviCasova.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbTipoviCasova.Location = new System.Drawing.Point(22, 40);
            this.gbTipoviCasova.Name = "gbTipoviCasova";
            this.gbTipoviCasova.Size = new System.Drawing.Size(137, 111);
            this.gbTipoviCasova.TabIndex = 2;
            this.gbTipoviCasova.TabStop = false;
            this.gbTipoviCasova.Text = "Tip časova";
            // 
            // rbShort
            // 
            this.rbShort.AutoSize = true;
            this.rbShort.Location = new System.Drawing.Point(21, 64);
            this.rbShort.Name = "rbShort";
            this.rbShort.Size = new System.Drawing.Size(65, 21);
            this.rbShort.TabIndex = 1;
            this.rbShort.Text = "30 min";
            this.rbShort.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(21, 37);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(65, 21);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "45 min";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.SwitchClassType);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(805, 595);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 26);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabOptions);
            this.mainTabControl.Controls.Add(this.tabSendMessage);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(887, 577);
            this.mainTabControl.TabIndex = 13;
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.btnRefresh);
            this.tabOptions.Controls.Add(this.btnDelete);
            this.tabOptions.Controls.Add(this.btnUpdate);
            this.tabOptions.Controls.Add(this.dgvObavestenja);
            this.tabOptions.Controls.Add(this.groupBox1);
            this.tabOptions.Controls.Add(this.lbDeleteText);
            this.tabOptions.Controls.Add(this.gbTipoviCasova);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(879, 551);
            this.tabOptions.TabIndex = 0;
            this.tabOptions.Text = "Kontrole";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(486, 494);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 40);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Osveži obaveštenja";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.RefreshDataGrid);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(723, 494);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 40);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Obriši obaveštenja";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.DeleteSelectedMessages);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(238, 494);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 40);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Izmeni obaveštenja";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvObavestenja
            // 
            this.dgvObavestenja.AllowUserToResizeRows = false;
            this.dgvObavestenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavestenja.Location = new System.Drawing.Point(238, 77);
            this.dgvObavestenja.Name = "dgvObavestenja";
            this.dgvObavestenja.Size = new System.Drawing.Size(622, 387);
            this.dgvObavestenja.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPlayPause);
            this.groupBox1.Controls.Add(this.btnNextSong);
            this.groupBox1.Controls.Add(this.cbMusic);
            this.groupBox1.Controls.Add(this.btnPath);
            this.groupBox1.Controls.Add(this.lbPath);
            this.groupBox1.Controls.Add(this.tbPath);
            this.groupBox1.Location = new System.Drawing.Point(18, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 172);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcije za muziku";
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(113, 121);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(81, 35);
            this.btnPlayPause.TabIndex = 11;
            this.btnPlayPause.Text = "Pusti/Pauziraj";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnNextSong
            // 
            this.btnNextSong.Location = new System.Drawing.Point(9, 121);
            this.btnNextSong.Name = "btnNextSong";
            this.btnNextSong.Size = new System.Drawing.Size(81, 35);
            this.btnNextSong.TabIndex = 10;
            this.btnNextSong.Text = "Sledeća pesma";
            this.btnNextSong.UseVisualStyleBackColor = true;
            this.btnNextSong.Click += new System.EventHandler(this.btnNextSong_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(161, 74);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(33, 23);
            this.btnPath.TabIndex = 9;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(6, 58);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(155, 13);
            this.lbPath.TabIndex = 8;
            this.lbPath.Text = "Putanja do foldera sa pesmama";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(6, 77);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(138, 20);
            this.tbPath.TabIndex = 7;
            // 
            // lbDeleteText
            // 
            this.lbDeleteText.AutoSize = true;
            this.lbDeleteText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDeleteText.Location = new System.Drawing.Point(235, 40);
            this.lbDeleteText.Name = "lbDeleteText";
            this.lbDeleteText.Size = new System.Drawing.Size(294, 19);
            this.lbDeleteText.TabIndex = 6;
            this.lbDeleteText.Text = "Odaberite obaveštenje koje želite da promenite";
            // 
            // tabSendMessage
            // 
            this.tabSendMessage.Controls.Add(this.lbDateEnd);
            this.tabSendMessage.Controls.Add(this.lbDateStart);
            this.tabSendMessage.Controls.Add(this.dtpEnd);
            this.tabSendMessage.Controls.Add(this.dtpStart);
            this.tabSendMessage.Controls.Add(this.btnDeleteText);
            this.tabSendMessage.Controls.Add(this.btnSend);
            this.tabSendMessage.Controls.Add(this.label1);
            this.tabSendMessage.Controls.Add(this.rtbMessage);
            this.tabSendMessage.Location = new System.Drawing.Point(4, 22);
            this.tabSendMessage.Name = "tabSendMessage";
            this.tabSendMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabSendMessage.Size = new System.Drawing.Size(879, 551);
            this.tabSendMessage.TabIndex = 1;
            this.tabSendMessage.Text = "Obavestenje";
            this.tabSendMessage.UseVisualStyleBackColor = true;
            // 
            // lbDateEnd
            // 
            this.lbDateEnd.AutoSize = true;
            this.lbDateEnd.Location = new System.Drawing.Point(575, 390);
            this.lbDateEnd.Name = "lbDateEnd";
            this.lbDateEnd.Size = new System.Drawing.Size(64, 13);
            this.lbDateEnd.TabIndex = 20;
            this.lbDateEnd.Text = "Datum kraja";
            // 
            // lbDateStart
            // 
            this.lbDateStart.AutoSize = true;
            this.lbDateStart.Location = new System.Drawing.Point(168, 390);
            this.lbDateStart.Name = "lbDateStart";
            this.lbDateStart.Size = new System.Drawing.Size(80, 13);
            this.lbDateStart.TabIndex = 19;
            this.lbDateStart.Text = "Datum početka";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "d/MM/yyyy HH:mm";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(578, 415);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(142, 20);
            this.dtpEnd.TabIndex = 18;
            this.dtpEnd.Value = new System.DateTime(2017, 9, 29, 0, 0, 0, 0);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "d/MM/yyyy HH:mm";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(171, 415);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(143, 20);
            this.dtpStart.TabIndex = 17;
            this.dtpStart.Value = new System.DateTime(2017, 9, 29, 0, 0, 0, 0);
            // 
            // btnDeleteText
            // 
            this.btnDeleteText.Location = new System.Drawing.Point(721, 472);
            this.btnDeleteText.Name = "btnDeleteText";
            this.btnDeleteText.Size = new System.Drawing.Size(131, 40);
            this.btnDeleteText.TabIndex = 16;
            this.btnDeleteText.Text = "Izbrisi";
            this.btnDeleteText.UseVisualStyleBackColor = true;
            this.btnDeleteText.Click += new System.EventHandler(this.btnDeleteText_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(35, 472);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(130, 40);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Posalji";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Novo obaveštenje učenicima:";
            // 
            // rtbMessage
            // 
            this.rtbMessage.BackColor = System.Drawing.Color.White;
            this.rtbMessage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtbMessage.Location = new System.Drawing.Point(35, 84);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(817, 289);
            this.rtbMessage.TabIndex = 13;
            this.rtbMessage.Text = "";
            // 
            // TVRadeMetalacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(911, 633);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TVRadeMetalacForm";
            this.Text = "TV \"Rade Metalac\"";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyCodeAdminOptions);
            this.gbTipoviCasova.ResumeLayout(false);
            this.gbTipoviCasova.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.tabOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavestenja)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabSendMessage.ResumeLayout(false);
            this.tabSendMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbMusic;
        private System.Windows.Forms.GroupBox gbTipoviCasova;
        private System.Windows.Forms.RadioButton rbShort;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.TabPage tabSendMessage;
        private System.Windows.Forms.Label lbDateEnd;
        private System.Windows.Forms.Label lbDateStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnDeleteText;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Label lbDeleteText;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnNextSong;
        private System.Windows.Forms.DataGridView dgvObavestenja;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
    }
}

