namespace EncryptionTextP1
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TextBackgroundPanel = new System.Windows.Forms.Panel();
            this.MainPanaleStroke = new System.Windows.Forms.Panel();
            this.ProgramNameText = new System.Windows.Forms.Label();
            this.MainEncryptPanel = new System.Windows.Forms.Panel();
            this.EncryptTextPanel = new System.Windows.Forms.Panel();
            this.EncryptTextTitle = new System.Windows.Forms.Label();
            this.SettetingPanel = new System.Windows.Forms.Panel();
            this.SettingsTitle = new System.Windows.Forms.Label();
            this.ShiftKeyText = new System.Windows.Forms.Label();
            this.EncryptTextBox = new System.Windows.Forms.TextBox();
            this.ShiftKeyTextBox = new System.Windows.Forms.TextBox();
            this.DecreaseKeyButton = new System.Windows.Forms.Button();
            this.IncreaseKeyButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EncryotedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EncryptTextButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.RandomPaddingCheckBox = new System.Windows.Forms.CheckBox();
            this.MainPanel.SuspendLayout();
            this.TextBackgroundPanel.SuspendLayout();
            this.MainEncryptPanel.SuspendLayout();
            this.EncryptTextPanel.SuspendLayout();
            this.SettetingPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPanel.Controls.Add(this.CopyButton);
            this.MainPanel.Controls.Add(this.ClearButton);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.MainEncryptPanel);
            this.MainPanel.Controls.Add(this.TextBackgroundPanel);
            this.MainPanel.Location = new System.Drawing.Point(87, 126);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(827, 563);
            this.MainPanel.TabIndex = 0;
            // 
            // TextBackgroundPanel
            // 
            this.TextBackgroundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextBackgroundPanel.Controls.Add(this.ProgramNameText);
            this.TextBackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.TextBackgroundPanel.Name = "TextBackgroundPanel";
            this.TextBackgroundPanel.Size = new System.Drawing.Size(827, 66);
            this.TextBackgroundPanel.TabIndex = 1;
            // 
            // MainPanaleStroke
            // 
            this.MainPanaleStroke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanaleStroke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.MainPanaleStroke.Location = new System.Drawing.Point(81, 121);
            this.MainPanaleStroke.Name = "MainPanaleStroke";
            this.MainPanaleStroke.Size = new System.Drawing.Size(838, 574);
            this.MainPanaleStroke.TabIndex = 2;
            this.MainPanaleStroke.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // ProgramNameText
            // 
            this.ProgramNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgramNameText.AutoSize = true;
            this.ProgramNameText.Font = new System.Drawing.Font("VIP Hala Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.ProgramNameText.Location = new System.Drawing.Point(3, 0);
            this.ProgramNameText.Name = "ProgramNameText";
            this.ProgramNameText.Size = new System.Drawing.Size(430, 65);
            this.ProgramNameText.TabIndex = 0;
            this.ProgramNameText.Text = "Encryption Text Pro";
            // 
            // MainEncryptPanel
            // 
            this.MainEncryptPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainEncryptPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainEncryptPanel.Controls.Add(this.RandomPaddingCheckBox);
            this.MainEncryptPanel.Controls.Add(this.SettingsTitle);
            this.MainEncryptPanel.Controls.Add(this.SettetingPanel);
            this.MainEncryptPanel.Controls.Add(this.EncryptTextTitle);
            this.MainEncryptPanel.Controls.Add(this.EncryptTextPanel);
            this.MainEncryptPanel.Location = new System.Drawing.Point(14, 81);
            this.MainEncryptPanel.Name = "MainEncryptPanel";
            this.MainEncryptPanel.Size = new System.Drawing.Size(326, 465);
            this.MainEncryptPanel.TabIndex = 2;
            // 
            // EncryptTextPanel
            // 
            this.EncryptTextPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptTextPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.EncryptTextPanel.Controls.Add(this.EncryptTextBox);
            this.EncryptTextPanel.Location = new System.Drawing.Point(12, 40);
            this.EncryptTextPanel.Name = "EncryptTextPanel";
            this.EncryptTextPanel.Size = new System.Drawing.Size(299, 100);
            this.EncryptTextPanel.TabIndex = 0;
            // 
            // EncryptTextTitle
            // 
            this.EncryptTextTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptTextTitle.AutoSize = true;
            this.EncryptTextTitle.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptTextTitle.ForeColor = System.Drawing.Color.White;
            this.EncryptTextTitle.Location = new System.Drawing.Point(16, 7);
            this.EncryptTextTitle.Name = "EncryptTextTitle";
            this.EncryptTextTitle.Size = new System.Drawing.Size(96, 26);
            this.EncryptTextTitle.TabIndex = 1;
            this.EncryptTextTitle.Text = "Input Text";
            // 
            // SettetingPanel
            // 
            this.SettetingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettetingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SettetingPanel.Controls.Add(this.DecreaseKeyButton);
            this.SettetingPanel.Controls.Add(this.IncreaseKeyButton);
            this.SettetingPanel.Controls.Add(this.ShiftKeyTextBox);
            this.SettetingPanel.Controls.Add(this.ShiftKeyText);
            this.SettetingPanel.Location = new System.Drawing.Point(12, 194);
            this.SettetingPanel.Name = "SettetingPanel";
            this.SettetingPanel.Size = new System.Drawing.Size(299, 129);
            this.SettetingPanel.TabIndex = 1;
            // 
            // SettingsTitle
            // 
            this.SettingsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsTitle.AutoSize = true;
            this.SettingsTitle.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTitle.ForeColor = System.Drawing.Color.White;
            this.SettingsTitle.Location = new System.Drawing.Point(16, 156);
            this.SettingsTitle.Name = "SettingsTitle";
            this.SettingsTitle.Size = new System.Drawing.Size(83, 26);
            this.SettingsTitle.TabIndex = 2;
            this.SettingsTitle.Text = "Settings";
            this.SettingsTitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // ShiftKeyText
            // 
            this.ShiftKeyText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShiftKeyText.AutoSize = true;
            this.ShiftKeyText.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftKeyText.ForeColor = System.Drawing.Color.White;
            this.ShiftKeyText.Location = new System.Drawing.Point(90, 12);
            this.ShiftKeyText.Name = "ShiftKeyText";
            this.ShiftKeyText.Size = new System.Drawing.Size(118, 26);
            this.ShiftKeyText.TabIndex = 3;
            this.ShiftKeyText.Text = "Security Key";
            this.ShiftKeyText.Click += new System.EventHandler(this.label3_Click);
            // 
            // EncryptTextBox
            // 
            this.EncryptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptTextBox.Font = new System.Drawing.Font("Helvetica Rounded", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptTextBox.Location = new System.Drawing.Point(20, 18);
            this.EncryptTextBox.Multiline = true;
            this.EncryptTextBox.Name = "EncryptTextBox";
            this.EncryptTextBox.Size = new System.Drawing.Size(259, 61);
            this.EncryptTextBox.TabIndex = 0;
            this.EncryptTextBox.Text = "Enter your text to encrypt...";
            this.EncryptTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EncryptTextBox.TextChanged += new System.EventHandler(this.EncryptTextBox_TextChanged);
            // 
            // ShiftKeyTextBox
            // 
            this.ShiftKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShiftKeyTextBox.Font = new System.Drawing.Font("Helvetica Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftKeyTextBox.Location = new System.Drawing.Point(108, 53);
            this.ShiftKeyTextBox.Multiline = true;
            this.ShiftKeyTextBox.Name = "ShiftKeyTextBox";
            this.ShiftKeyTextBox.ReadOnly = true;
            this.ShiftKeyTextBox.Size = new System.Drawing.Size(80, 54);
            this.ShiftKeyTextBox.TabIndex = 1;
            this.ShiftKeyTextBox.Text = "1";
            this.ShiftKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DecreaseKeyButton
            // 
            this.DecreaseKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecreaseKeyButton.BackgroundImage = global::EncryptionTextP1.Properties.Resources.minus_sign;
            this.DecreaseKeyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DecreaseKeyButton.FlatAppearance.BorderSize = 0;
            this.DecreaseKeyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.DecreaseKeyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.DecreaseKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecreaseKeyButton.Location = new System.Drawing.Point(55, 60);
            this.DecreaseKeyButton.Name = "DecreaseKeyButton";
            this.DecreaseKeyButton.Size = new System.Drawing.Size(40, 40);
            this.DecreaseKeyButton.TabIndex = 5;
            this.DecreaseKeyButton.UseVisualStyleBackColor = true;
            this.DecreaseKeyButton.Click += new System.EventHandler(this.DecreaseKeyButton_Click);
            this.DecreaseKeyButton.MouseLeave += new System.EventHandler(this.DecreaseKeyButton_MouseLeave);
            this.DecreaseKeyButton.MouseHover += new System.EventHandler(this.DecreaseKeyButton_MouseHover);
            // 
            // IncreaseKeyButton
            // 
            this.IncreaseKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncreaseKeyButton.BackgroundImage = global::EncryptionTextP1.Properties.Resources.plus;
            this.IncreaseKeyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IncreaseKeyButton.FlatAppearance.BorderSize = 0;
            this.IncreaseKeyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.IncreaseKeyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.IncreaseKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncreaseKeyButton.Location = new System.Drawing.Point(194, 60);
            this.IncreaseKeyButton.Name = "IncreaseKeyButton";
            this.IncreaseKeyButton.Size = new System.Drawing.Size(40, 40);
            this.IncreaseKeyButton.TabIndex = 4;
            this.IncreaseKeyButton.UseVisualStyleBackColor = true;
            this.IncreaseKeyButton.Click += new System.EventHandler(this.button1_Click);
            this.IncreaseKeyButton.MouseLeave += new System.EventHandler(this.IncreaseKeyButton_MouseLeave);
            this.IncreaseKeyButton.MouseHover += new System.EventHandler(this.IncreaseKeyButton_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.EncryptTextButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(359, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 310);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.EncryotedTextBox);
            this.panel2.Location = new System.Drawing.Point(17, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 100);
            this.panel2.TabIndex = 4;
            // 
            // EncryotedTextBox
            // 
            this.EncryotedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryotedTextBox.Font = new System.Drawing.Font("Helvetica Rounded", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryotedTextBox.Location = new System.Drawing.Point(14, 18);
            this.EncryotedTextBox.Multiline = true;
            this.EncryotedTextBox.Name = "EncryotedTextBox";
            this.EncryotedTextBox.ReadOnly = true;
            this.EncryotedTextBox.Size = new System.Drawing.Size(377, 61);
            this.EncryotedTextBox.TabIndex = 1;
            this.EncryotedTextBox.Text = "Encrypted Text Appears Here....";
            this.EncryotedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output Text";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EncryptTextButton
            // 
            this.EncryptTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptTextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.EncryptTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EncryptTextButton.Font = new System.Drawing.Font("VIP Hala Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptTextButton.Location = new System.Drawing.Point(69, 181);
            this.EncryptTextButton.Name = "EncryptTextButton";
            this.EncryptTextButton.Size = new System.Drawing.Size(296, 85);
            this.EncryptTextButton.TabIndex = 5;
            this.EncryptTextButton.Text = "Encrypt Text";
            this.EncryptTextButton.UseVisualStyleBackColor = false;
            this.EncryptTextButton.Click += new System.EventHandler(this.EncryptTextButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Font = new System.Drawing.Font("VIP Hala Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(369, 415);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(262, 114);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyButton.Font = new System.Drawing.Font("VIP Hala Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.Location = new System.Drawing.Point(637, 415);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(157, 114);
            this.CopyButton.TabIndex = 5;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // RandomPaddingCheckBox
            // 
            this.RandomPaddingCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RandomPaddingCheckBox.AutoSize = true;
            this.RandomPaddingCheckBox.Font = new System.Drawing.Font("VIP Hala Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomPaddingCheckBox.ForeColor = System.Drawing.Color.DarkGray;
            this.RandomPaddingCheckBox.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RandomPaddingCheckBox.Location = new System.Drawing.Point(21, 360);
            this.RandomPaddingCheckBox.Name = "RandomPaddingCheckBox";
            this.RandomPaddingCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RandomPaddingCheckBox.Size = new System.Drawing.Size(273, 49);
            this.RandomPaddingCheckBox.TabIndex = 7;
            this.RandomPaddingCheckBox.Text = "Random Padding";
            this.RandomPaddingCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RandomPaddingCheckBox.UseVisualStyleBackColor = true;
            this.RandomPaddingCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1015, 868);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MainPanaleStroke);
            this.Name = "Form1";
            this.Text = "Encryption Text Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.TextBackgroundPanel.ResumeLayout(false);
            this.TextBackgroundPanel.PerformLayout();
            this.MainEncryptPanel.ResumeLayout(false);
            this.MainEncryptPanel.PerformLayout();
            this.EncryptTextPanel.ResumeLayout(false);
            this.EncryptTextPanel.PerformLayout();
            this.SettetingPanel.ResumeLayout(false);
            this.SettetingPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TextBackgroundPanel;
        private System.Windows.Forms.Panel MainPanaleStroke;
        private System.Windows.Forms.Label ProgramNameText;
        private System.Windows.Forms.Panel MainEncryptPanel;
        private System.Windows.Forms.Panel EncryptTextPanel;
        private System.Windows.Forms.Label EncryptTextTitle;
        private System.Windows.Forms.Label SettingsTitle;
        private System.Windows.Forms.Panel SettetingPanel;
        private System.Windows.Forms.Label ShiftKeyText;
        private System.Windows.Forms.TextBox EncryptTextBox;
        private System.Windows.Forms.TextBox ShiftKeyTextBox;
        private System.Windows.Forms.Button IncreaseKeyButton;
        private System.Windows.Forms.Button DecreaseKeyButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox EncryotedTextBox;
        private System.Windows.Forms.Button EncryptTextButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.CheckBox RandomPaddingCheckBox;
    }
}

