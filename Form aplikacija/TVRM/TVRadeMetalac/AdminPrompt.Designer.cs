namespace TVRadeMetalac
{
    partial class AdminPrompt
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
            this.btnResetMessageUpdates = new System.Windows.Forms.Button();
            this.btnResetClassTypeUpdates = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResetMessageUpdates
            // 
            this.btnResetMessageUpdates.Location = new System.Drawing.Point(33, 28);
            this.btnResetMessageUpdates.Name = "btnResetMessageUpdates";
            this.btnResetMessageUpdates.Size = new System.Drawing.Size(156, 23);
            this.btnResetMessageUpdates.TabIndex = 0;
            this.btnResetMessageUpdates.Text = "Reset message updates";
            this.btnResetMessageUpdates.UseVisualStyleBackColor = true;
            this.btnResetMessageUpdates.Click += new System.EventHandler(this.btnResetMessageUpdates_Click);
            // 
            // btnResetClassTypeUpdates
            // 
            this.btnResetClassTypeUpdates.Location = new System.Drawing.Point(33, 57);
            this.btnResetClassTypeUpdates.Name = "btnResetClassTypeUpdates";
            this.btnResetClassTypeUpdates.Size = new System.Drawing.Size(156, 23);
            this.btnResetClassTypeUpdates.TabIndex = 1;
            this.btnResetClassTypeUpdates.Text = "Reset class type update";
            this.btnResetClassTypeUpdates.UseVisualStyleBackColor = true;
            this.btnResetClassTypeUpdates.Click += new System.EventHandler(this.btnResetClassTypeUpdates_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(33, 100);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(156, 23);
            this.btnResetAll.TabIndex = 2;
            this.btnResetAll.Text = "Reset both";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // AdminPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 146);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.btnResetClassTypeUpdates);
            this.Controls.Add(this.btnResetMessageUpdates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminPrompt";
            this.Text = "AdminPrompt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResetMessageUpdates;
        private System.Windows.Forms.Button btnResetClassTypeUpdates;
        private System.Windows.Forms.Button btnResetAll;
    }
}