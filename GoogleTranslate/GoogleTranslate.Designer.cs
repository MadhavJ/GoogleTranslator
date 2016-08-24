namespace GoogleTranslate
{
    partial class GoogleTranslate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoogleTranslate));
            this.comboFrom = new System.Windows.Forms.ComboBox();
            this.comboTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReverseLang = new System.Windows.Forms.Button();
            this.editSourceText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editTarget = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.CopyRightText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboFrom
            // 
            this.comboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFrom.FormattingEnabled = true;
            this.comboFrom.Location = new System.Drawing.Point(34, 46);
            this.comboFrom.Name = "comboFrom";
            this.comboFrom.Size = new System.Drawing.Size(234, 24);
            this.comboFrom.TabIndex = 0;
            // 
            // comboTo
            // 
            this.comboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTo.FormattingEnabled = true;
            this.comboTo.Location = new System.Drawing.Point(346, 46);
            this.comboTo.Name = "comboTo";
            this.comboTo.Size = new System.Drawing.Size(218, 24);
            this.comboTo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source language:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target language:";
            // 
            // ReverseLang
            // 
            this.ReverseLang.Image = ((System.Drawing.Image)(resources.GetObject("ReverseLang.Image")));
            this.ReverseLang.Location = new System.Drawing.Point(293, 47);
            this.ReverseLang.Name = "ReverseLang";
            this.ReverseLang.Size = new System.Drawing.Size(26, 23);
            this.ReverseLang.TabIndex = 13;
            this.ReverseLang.UseVisualStyleBackColor = true;
            this.ReverseLang.Click += new System.EventHandler(this.ReverseLang_Click);
            // 
            // editSourceText
            // 
            this.editSourceText.BackColor = System.Drawing.Color.PowderBlue;
            this.editSourceText.ForeColor = System.Drawing.Color.Black;
            this.editSourceText.Location = new System.Drawing.Point(34, 126);
            this.editSourceText.Multiline = true;
            this.editSourceText.Name = "editSourceText";
            this.editSourceText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.editSourceText.Size = new System.Drawing.Size(530, 147);
            this.editSourceText.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Source text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Target text :";
            // 
            // editTarget
            // 
            this.editTarget.BackColor = System.Drawing.Color.PowderBlue;
            this.editTarget.ForeColor = System.Drawing.Color.Black;
            this.editTarget.Location = new System.Drawing.Point(34, 351);
            this.editTarget.Multiline = true;
            this.editTarget.Name = "editTarget";
            this.editTarget.ReadOnly = true;
            this.editTarget.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.editTarget.Size = new System.Drawing.Size(533, 137);
            this.editTarget.TabIndex = 17;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(402, 551);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(162, 23);
            this.btnTranslate.TabIndex = 18;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // CopyRightText
            // 
            this.CopyRightText.AutoSize = true;
            this.CopyRightText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CopyRightText.Location = new System.Drawing.Point(0, 596);
            this.CopyRightText.Name = "CopyRightText";
            this.CopyRightText.Size = new System.Drawing.Size(119, 17);
            this.CopyRightText.TabIndex = 19;
            this.CopyRightText.Text = "© MSJ Beta V 1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 541);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblStatus.Location = new System.Drawing.Point(154, 551);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 21;
            // 
            // GoogleTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(602, 613);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CopyRightText);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editTarget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editSourceText);
            this.Controls.Add(this.ReverseLang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboTo);
            this.Controls.Add(this.comboFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GoogleTranslate";
            this.Text = "Google Translate  ©2016 MSJ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFrom;
        private System.Windows.Forms.ComboBox comboTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button ReverseLang;
        private System.Windows.Forms.TextBox editSourceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox editTarget;
        private System.Windows.Forms.Button btnTranslate;
        internal System.Windows.Forms.Label CopyRightText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStatus;
    }
}

