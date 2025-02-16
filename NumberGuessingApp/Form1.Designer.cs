namespace NumberGuessingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            play_button = new Button();
            textBox1 = new TextBox();
            exit_button = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // play_button
            // 
            play_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            play_button.BackColor = Color.Bisque;
            play_button.BackgroundImageLayout = ImageLayout.None;
            play_button.FlatStyle = FlatStyle.Popup;
            play_button.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            play_button.ForeColor = SystemColors.ControlDarkDark;
            play_button.Location = new Point(123, 244);
            play_button.Name = "play_button";
            play_button.Size = new Size(89, 43);
            play_button.TabIndex = 0;
            play_button.Text = "Guess";
            play_button.UseVisualStyleBackColor = false;
            play_button.Click += play_button_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(181, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 32);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // exit_button
            // 
            exit_button.BackColor = Color.Silver;
            exit_button.FlatStyle = FlatStyle.Popup;
            exit_button.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit_button.ForeColor = Color.DimGray;
            exit_button.Location = new Point(261, 244);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(90, 43);
            exit_button.TabIndex = 3;
            exit_button.Text = "Exit";
            exit_button.UseVisualStyleBackColor = false;
            exit_button.Click += exit_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(523, 282);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Cooper Black", 11.25F);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(191, 314);
            button1.Name = "button1";
            button1.Size = new Size(89, 34);
            button1.TabIndex = 5;
            button1.Text = "HINT!!!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(471, 403);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(exit_button);
            Controls.Add(textBox1);
            Controls.Add(play_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(20, 20);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Number Guessing";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button play_button;
        private Button hint_button;
        private TextBox textBox1;
        private Button exit_button;
        public PictureBox pictureBox1;
        private Button button1;
    }
}
