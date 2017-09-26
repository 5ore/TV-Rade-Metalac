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
            this.tabSendMessage = new System.Windows.Forms.TabPage();
            this.lbDateEnd = new System.Windows.Forms.Label();
            this.lbDateStart = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteText = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.lbDeleteText = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lbPath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.gbTipoviCasova.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.tabSendMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMusic
            // 
            this.cbMusic.AutoSize = true;
            this.cbMusic.Location = new System.Drawing.Point(43, 179);
            this.cbMusic.Name = "cbMusic";
            this.cbMusic.Size = new System.Drawing.Size(60, 17);
            this.cbMusic.TabIndex = 3;
            this.cbMusic.Text = "Muzika";
            this.cbMusic.UseVisualStyleBackColor = true;
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
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(589, 477);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 46);
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
            this.mainTabControl.Size = new System.Drawing.Size(671, 459);
            this.mainTabControl.TabIndex = 13;
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.btnPath);
            this.tabOptions.Controls.Add(this.lbPath);
            this.tabOptions.Controls.Add(this.tbPath);
            this.tabOptions.Controls.Add(this.lbDeleteText);
            this.tabOptions.Controls.Add(this.lbMessages);
            this.tabOptions.Controls.Add(this.btnApply);
            this.tabOptions.Controls.Add(this.gbTipoviCasova);
            this.tabOptions.Controls.Add(this.cbMusic);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(663, 433);
            this.tabOptions.TabIndex = 0;
            this.tabOptions.Text = "Konfiguracija";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // tabSendMessage
            // 
            this.tabSendMessage.Controls.Add(this.lbDateEnd);
            this.tabSendMessage.Controls.Add(this.lbDateStart);
            this.tabSendMessage.Controls.Add(this.dateTimePicker2);
            this.tabSendMessage.Controls.Add(this.dateTimePicker1);
            this.tabSendMessage.Controls.Add(this.btnDeleteText);
            this.tabSendMessage.Controls.Add(this.btnSend);
            this.tabSendMessage.Controls.Add(this.label1);
            this.tabSendMessage.Controls.Add(this.richTextBox1);
            this.tabSendMessage.Location = new System.Drawing.Point(4, 22);
            this.tabSendMessage.Name = "tabSendMessage";
            this.tabSendMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabSendMessage.Size = new System.Drawing.Size(663, 433);
            this.tabSendMessage.TabIndex = 1;
            this.tabSendMessage.Text = "Obavestenje";
            this.tabSendMessage.UseVisualStyleBackColor = true;
            // 
            // lbDateEnd
            // 
            this.lbDateEnd.AutoSize = true;
            this.lbDateEnd.Location = new System.Drawing.Point(383, 271);
            this.lbDateEnd.Name = "lbDateEnd";
            this.lbDateEnd.Size = new System.Drawing.Size(64, 13);
            this.lbDateEnd.TabIndex = 20;
            this.lbDateEnd.Text = "Datum kraja";
            // 
            // lbDateStart
            // 
            this.lbDateStart.AutoSize = true;
            this.lbDateStart.Location = new System.Drawing.Point(127, 271);
            this.lbDateStart.Name = "lbDateStart";
            this.lbDateStart.Size = new System.Drawing.Size(80, 13);
            this.lbDateStart.TabIndex = 19;
            this.lbDateStart.Text = "Datum početka";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(386, 297);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 297);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // btnDeleteText
            // 
            this.btnDeleteText.Location = new System.Drawing.Point(514, 379);
            this.btnDeleteText.Name = "btnDeleteText";
            this.btnDeleteText.Size = new System.Drawing.Size(128, 23);
            this.btnDeleteText.TabIndex = 16;
            this.btnDeleteText.Text = "Izbrisi";
            this.btnDeleteText.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(32, 379);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(128, 23);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Posalji";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Novo obaveštenje učenicima:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Location = new System.Drawing.Point(32, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(600, 194);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(479, 363);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(137, 40);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Potvrdi izmene";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.Location = new System.Drawing.Point(224, 77);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(392, 147);
            this.lbMessages.TabIndex = 5;
            // 
            // lbDeleteText
            // 
            this.lbDeleteText.AutoSize = true;
            this.lbDeleteText.Location = new System.Drawing.Point(224, 40);
            this.lbDeleteText.Name = "lbDeleteText";
            this.lbDeleteText.Size = new System.Drawing.Size(219, 13);
            this.lbDeleteText.TabIndex = 6;
            this.lbDeleteText.Text = "Odaberite obaveštenje koje želite da obrišete";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(22, 246);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(150, 20);
            this.tbPath.TabIndex = 7;
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(22, 227);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(43, 13);
            this.lbPath.TabIndex = 8;
            this.lbPath.Text = "Putanja";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(178, 246);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(33, 23);
            this.btnPath.TabIndex = 9;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // TVRadeMetalacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(695, 535);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TVRadeMetalacForm";
            this.Text = "TV \"Rade Metalac\"";
            this.gbTipoviCasova.ResumeLayout(false);
            this.gbTipoviCasova.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.tabOptions.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDeleteText;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lbDeleteText;
        private System.Windows.Forms.ListBox lbMessages;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.TextBox tbPath;
    }
}

