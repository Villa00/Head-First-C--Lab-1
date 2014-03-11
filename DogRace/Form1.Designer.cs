namespace DogRace
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackPictureBox = new System.Windows.Forms.PictureBox();
            this.dog4PictureBox = new System.Windows.Forms.PictureBox();
            this.betGroupBox = new System.Windows.Forms.GroupBox();
            this.raceButton = new System.Windows.Forms.Button();
            this.dogNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.bettorLabel = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.betsLabel = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.dog3PictureBox = new System.Windows.Forms.PictureBox();
            this.dog2PictureBox = new System.Windows.Forms.PictureBox();
            this.dog1PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4PictureBox)).BeginInit();
            this.betGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 22;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackPictureBox
            // 
            this.trackPictureBox.ErrorImage = null;
            this.trackPictureBox.Image = global::DogRace.Properties.Resources.racetrack;
            this.trackPictureBox.Location = new System.Drawing.Point(13, 12);
            this.trackPictureBox.Name = "trackPictureBox";
            this.trackPictureBox.Size = new System.Drawing.Size(602, 200);
            this.trackPictureBox.TabIndex = 0;
            this.trackPictureBox.TabStop = false;
            // 
            // dog4PictureBox
            // 
            this.dog4PictureBox.ErrorImage = null;
            this.dog4PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dog4PictureBox.Image")));
            this.dog4PictureBox.Location = new System.Drawing.Point(12, 180);
            this.dog4PictureBox.Name = "dog4PictureBox";
            this.dog4PictureBox.Size = new System.Drawing.Size(95, 32);
            this.dog4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog4PictureBox.TabIndex = 4;
            this.dog4PictureBox.TabStop = false;
            // 
            // betGroupBox
            // 
            this.betGroupBox.Controls.Add(this.raceButton);
            this.betGroupBox.Controls.Add(this.dogNumericUpDown);
            this.betGroupBox.Controls.Add(this.label1);
            this.betGroupBox.Controls.Add(this.amountNumericUpDown);
            this.betGroupBox.Controls.Add(this.betButton);
            this.betGroupBox.Controls.Add(this.bettorLabel);
            this.betGroupBox.Controls.Add(this.alBetLabel);
            this.betGroupBox.Controls.Add(this.bobBetLabel);
            this.betGroupBox.Controls.Add(this.joeBetLabel);
            this.betGroupBox.Controls.Add(this.betsLabel);
            this.betGroupBox.Controls.Add(this.alRadioButton);
            this.betGroupBox.Controls.Add(this.bobRadioButton);
            this.betGroupBox.Controls.Add(this.joeRadioButton);
            this.betGroupBox.Controls.Add(this.minimumBetLabel);
            this.betGroupBox.Location = new System.Drawing.Point(13, 237);
            this.betGroupBox.Name = "betGroupBox";
            this.betGroupBox.Size = new System.Drawing.Size(602, 171);
            this.betGroupBox.TabIndex = 5;
            this.betGroupBox.TabStop = false;
            this.betGroupBox.Text = "Betting Parlor";
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(431, 32);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(143, 99);
            this.raceButton.TabIndex = 13;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // dogNumericUpDown
            // 
            this.dogNumericUpDown.Location = new System.Drawing.Point(304, 113);
            this.dogNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumericUpDown.Name = "dogNumericUpDown";
            this.dogNumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.dogNumericUpDown.TabIndex = 12;
            this.dogNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "bucks on dog number";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(131, 113);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.amountNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.amountNumericUpDown.TabIndex = 10;
            this.amountNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betButton
            // 
            this.betButton.AutoSize = true;
            this.betButton.Location = new System.Drawing.Point(50, 110);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 9;
            this.betButton.Text = "Bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // bettorLabel
            // 
            this.bettorLabel.AutoSize = true;
            this.bettorLabel.Location = new System.Drawing.Point(9, 115);
            this.bettorLabel.Name = "bettorLabel";
            this.bettorLabel.Size = new System.Drawing.Size(35, 13);
            this.bettorLabel.TabIndex = 8;
            this.bettorLabel.Text = "label1";
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(216, 78);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(139, 17);
            this.alBetLabel.TabIndex = 7;
            this.alBetLabel.Text = "label3";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(216, 55);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(139, 17);
            this.bobBetLabel.TabIndex = 6;
            this.bobBetLabel.Text = "label2";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(216, 34);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(139, 15);
            this.joeBetLabel.TabIndex = 5;
            this.joeBetLabel.Text = "label1";
            // 
            // betsLabel
            // 
            this.betsLabel.AutoSize = true;
            this.betsLabel.Location = new System.Drawing.Point(216, 16);
            this.betsLabel.Name = "betsLabel";
            this.betsLabel.Size = new System.Drawing.Size(28, 13);
            this.betsLabel.TabIndex = 4;
            this.betsLabel.Text = "Bets";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(9, 78);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(85, 17);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.Text = "radioButton3";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(9, 55);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(85, 17);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.Text = "radioButton2";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Checked = true;
            this.joeRadioButton.Location = new System.Drawing.Point(9, 32);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(85, 17);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "radioButton1";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Location = new System.Drawing.Point(6, 16);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(35, 13);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "label1";
            // 
            // dog3PictureBox
            // 
            this.dog3PictureBox.ErrorImage = null;
            this.dog3PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dog3PictureBox.Image")));
            this.dog3PictureBox.Location = new System.Drawing.Point(11, 124);
            this.dog3PictureBox.Name = "dog3PictureBox";
            this.dog3PictureBox.Size = new System.Drawing.Size(95, 32);
            this.dog3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog3PictureBox.TabIndex = 6;
            this.dog3PictureBox.TabStop = false;
            // 
            // dog2PictureBox
            // 
            this.dog2PictureBox.ErrorImage = null;
            this.dog2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dog2PictureBox.Image")));
            this.dog2PictureBox.Location = new System.Drawing.Point(12, 68);
            this.dog2PictureBox.Name = "dog2PictureBox";
            this.dog2PictureBox.Size = new System.Drawing.Size(95, 32);
            this.dog2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog2PictureBox.TabIndex = 7;
            this.dog2PictureBox.TabStop = false;
            // 
            // dog1PictureBox
            // 
            this.dog1PictureBox.ErrorImage = null;
            this.dog1PictureBox.Image = global::DogRace.Properties.Resources.dog;
            this.dog1PictureBox.Location = new System.Drawing.Point(12, 12);
            this.dog1PictureBox.Name = "dog1PictureBox";
            this.dog1PictureBox.Size = new System.Drawing.Size(95, 32);
            this.dog1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog1PictureBox.TabIndex = 8;
            this.dog1PictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 420);
            this.Controls.Add(this.dog1PictureBox);
            this.Controls.Add(this.dog2PictureBox);
            this.Controls.Add(this.dog3PictureBox);
            this.Controls.Add(this.betGroupBox);
            this.Controls.Add(this.dog4PictureBox);
            this.Controls.Add(this.trackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.trackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4PictureBox)).EndInit();
            this.betGroupBox.ResumeLayout(false);
            this.betGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox trackPictureBox;
        private System.Windows.Forms.PictureBox dog4PictureBox;
        private System.Windows.Forms.GroupBox betGroupBox;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.NumericUpDown dogNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label bettorLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label betsLabel;
        private System.Windows.Forms.PictureBox dog3PictureBox;
        private System.Windows.Forms.PictureBox dog2PictureBox;
        private System.Windows.Forms.PictureBox dog1PictureBox;
    }
}

