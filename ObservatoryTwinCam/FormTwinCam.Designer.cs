namespace ObservatoryTwinCam
{
    partial class FormTwinCam
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.Camera1TextBox = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.Light1Button = new System.Windows.Forms.Button();
            this.Camera2TextBox = new System.Windows.Forms.TextBox();
            this.User1TextBox = new System.Windows.Forms.TextBox();
            this.Password1TextBox = new System.Windows.Forms.TextBox();
            this.Password2TextBox = new System.Windows.Forms.TextBox();
            this.User2TextBox = new System.Windows.Forms.TextBox();
            this.Light2Button = new System.Windows.Forms.Button();
            this.Up1Button = new System.Windows.Forms.Button();
            this.Down1Button = new System.Windows.Forms.Button();
            this.Right1Button = new System.Windows.Forms.Button();
            this.Left1Button = new System.Windows.Forms.Button();
            this.Left2Button = new System.Windows.Forms.Button();
            this.Right2Button = new System.Windows.Forms.Button();
            this.Down2Button = new System.Windows.Forms.Button();
            this.Up2Button = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.videoControl2 = new ObservatoryTwinCam.VideoControl();
            this.videoControl1 = new ObservatoryTwinCam.VideoControl();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(142, 539);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Camera1TextBox
            // 
            this.Camera1TextBox.Location = new System.Drawing.Point(37, 239);
            this.Camera1TextBox.Name = "Camera1TextBox";
            this.Camera1TextBox.Size = new System.Drawing.Size(114, 20);
            this.Camera1TextBox.TabIndex = 2;
            this.Camera1TextBox.Text = "Camera1";
            this.Camera1TextBox.TextChanged += new System.EventHandler(this.Camera1TextBox_TextChanged);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(238, 539);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Light1Button
            // 
            this.Light1Button.Location = new System.Drawing.Point(448, 180);
            this.Light1Button.Name = "Light1Button";
            this.Light1Button.Size = new System.Drawing.Size(43, 23);
            this.Light1Button.TabIndex = 4;
            this.Light1Button.Text = "Light";
            this.Light1Button.UseVisualStyleBackColor = true;
            this.Light1Button.Click += new System.EventHandler(this.Light1Button_Click);
            // 
            // Camera2TextBox
            // 
            this.Camera2TextBox.Location = new System.Drawing.Point(37, 503);
            this.Camera2TextBox.Name = "Camera2TextBox";
            this.Camera2TextBox.Size = new System.Drawing.Size(114, 20);
            this.Camera2TextBox.TabIndex = 6;
            this.Camera2TextBox.Text = "Camera2";
            this.Camera2TextBox.TextChanged += new System.EventHandler(this.Camera2TextBox_TextChanged);
            // 
            // User1TextBox
            // 
            this.User1TextBox.Location = new System.Drawing.Point(157, 239);
            this.User1TextBox.Name = "User1TextBox";
            this.User1TextBox.Size = new System.Drawing.Size(58, 20);
            this.User1TextBox.TabIndex = 7;
            this.User1TextBox.Text = "admin";
            this.User1TextBox.TextChanged += new System.EventHandler(this.User1TextBox_TextChanged);
            // 
            // Password1TextBox
            // 
            this.Password1TextBox.Location = new System.Drawing.Point(221, 239);
            this.Password1TextBox.Name = "Password1TextBox";
            this.Password1TextBox.Size = new System.Drawing.Size(114, 20);
            this.Password1TextBox.TabIndex = 8;
            this.Password1TextBox.Text = "noburgersafter3";
            this.Password1TextBox.TextChanged += new System.EventHandler(this.Password1TextBox_TextChanged);
            // 
            // Password2TextBox
            // 
            this.Password2TextBox.Location = new System.Drawing.Point(221, 503);
            this.Password2TextBox.Name = "Password2TextBox";
            this.Password2TextBox.Size = new System.Drawing.Size(114, 20);
            this.Password2TextBox.TabIndex = 10;
            this.Password2TextBox.Text = "noburgersafter3";
            this.Password2TextBox.TextChanged += new System.EventHandler(this.Password2TextBox_TextChanged);
            // 
            // User2TextBox
            // 
            this.User2TextBox.Location = new System.Drawing.Point(157, 503);
            this.User2TextBox.Name = "User2TextBox";
            this.User2TextBox.Size = new System.Drawing.Size(58, 20);
            this.User2TextBox.TabIndex = 9;
            this.User2TextBox.Text = "admin";
            this.User2TextBox.TextChanged += new System.EventHandler(this.User2TextBox_TextChanged);
            // 
            // Light2Button
            // 
            this.Light2Button.Location = new System.Drawing.Point(448, 429);
            this.Light2Button.Name = "Light2Button";
            this.Light2Button.Size = new System.Drawing.Size(43, 23);
            this.Light2Button.TabIndex = 11;
            this.Light2Button.Text = "Light";
            this.Light2Button.UseVisualStyleBackColor = true;
            this.Light2Button.Click += new System.EventHandler(this.Light2Button_Click);
            // 
            // Up1Button
            // 
            this.Up1Button.Location = new System.Drawing.Point(448, 54);
            this.Up1Button.Name = "Up1Button";
            this.Up1Button.Size = new System.Drawing.Size(43, 23);
            this.Up1Button.TabIndex = 12;
            this.Up1Button.Text = "Up";
            this.Up1Button.UseVisualStyleBackColor = true;
            this.Up1Button.Click += new System.EventHandler(this.Up1Button_Click);
            // 
            // Down1Button
            // 
            this.Down1Button.Location = new System.Drawing.Point(448, 103);
            this.Down1Button.Name = "Down1Button";
            this.Down1Button.Size = new System.Drawing.Size(43, 23);
            this.Down1Button.TabIndex = 13;
            this.Down1Button.Text = "Down";
            this.Down1Button.UseVisualStyleBackColor = true;
            this.Down1Button.Click += new System.EventHandler(this.Down1Button_Click);
            // 
            // Right1Button
            // 
            this.Right1Button.Location = new System.Drawing.Point(471, 78);
            this.Right1Button.Name = "Right1Button";
            this.Right1Button.Size = new System.Drawing.Size(43, 23);
            this.Right1Button.TabIndex = 14;
            this.Right1Button.Text = "Right";
            this.Right1Button.UseVisualStyleBackColor = true;
            this.Right1Button.Click += new System.EventHandler(this.Right1Button_Click);
            // 
            // Left1Button
            // 
            this.Left1Button.Location = new System.Drawing.Point(422, 78);
            this.Left1Button.Name = "Left1Button";
            this.Left1Button.Size = new System.Drawing.Size(43, 23);
            this.Left1Button.TabIndex = 15;
            this.Left1Button.Text = "Left";
            this.Left1Button.UseVisualStyleBackColor = true;
            this.Left1Button.Click += new System.EventHandler(this.Left1Button_Click);
            // 
            // Left2Button
            // 
            this.Left2Button.Location = new System.Drawing.Point(422, 328);
            this.Left2Button.Name = "Left2Button";
            this.Left2Button.Size = new System.Drawing.Size(43, 23);
            this.Left2Button.TabIndex = 19;
            this.Left2Button.Text = "Left";
            this.Left2Button.UseVisualStyleBackColor = true;
            this.Left2Button.Click += new System.EventHandler(this.Left2Button_Click);
            // 
            // Right2Button
            // 
            this.Right2Button.Location = new System.Drawing.Point(471, 328);
            this.Right2Button.Name = "Right2Button";
            this.Right2Button.Size = new System.Drawing.Size(43, 23);
            this.Right2Button.TabIndex = 18;
            this.Right2Button.Text = "Right";
            this.Right2Button.UseVisualStyleBackColor = true;
            this.Right2Button.Click += new System.EventHandler(this.Right2Button_Click);
            // 
            // Down2Button
            // 
            this.Down2Button.Location = new System.Drawing.Point(448, 353);
            this.Down2Button.Name = "Down2Button";
            this.Down2Button.Size = new System.Drawing.Size(43, 23);
            this.Down2Button.TabIndex = 17;
            this.Down2Button.Text = "Down";
            this.Down2Button.UseVisualStyleBackColor = true;
            this.Down2Button.Click += new System.EventHandler(this.Down2Button_Click);
            // 
            // Up2Button
            // 
            this.Up2Button.Location = new System.Drawing.Point(448, 304);
            this.Up2Button.Name = "Up2Button";
            this.Up2Button.Size = new System.Drawing.Size(43, 23);
            this.Up2Button.TabIndex = 16;
            this.Up2Button.Text = "Up";
            this.Up2Button.UseVisualStyleBackColor = true;
            this.Up2Button.Click += new System.EventHandler(this.Up2Button_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(334, 539);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 20;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // videoControl2
            // 
            this.videoControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.videoControl2.Location = new System.Drawing.Point(37, 275);
            this.videoControl2.Name = "videoControl2";
            this.videoControl2.Size = new System.Drawing.Size(375, 221);
            this.videoControl2.TabIndex = 5;
            // 
            // videoControl1
            // 
            this.videoControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.videoControl1.Location = new System.Drawing.Point(37, 12);
            this.videoControl1.Name = "videoControl1";
            this.videoControl1.Size = new System.Drawing.Size(375, 221);
            this.videoControl1.TabIndex = 0;
            // 
            // FormTwinCam
            // 
            this.AcceptButton = this.btnStop;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(522, 573);
            this.ControlBox = false;
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.Left2Button);
            this.Controls.Add(this.Right2Button);
            this.Controls.Add(this.Down2Button);
            this.Controls.Add(this.Up2Button);
            this.Controls.Add(this.Left1Button);
            this.Controls.Add(this.Right1Button);
            this.Controls.Add(this.Down1Button);
            this.Controls.Add(this.Up1Button);
            this.Controls.Add(this.Light2Button);
            this.Controls.Add(this.Password2TextBox);
            this.Controls.Add(this.User2TextBox);
            this.Controls.Add(this.Password1TextBox);
            this.Controls.Add(this.User1TextBox);
            this.Controls.Add(this.Camera2TextBox);
            this.Controls.Add(this.videoControl2);
            this.Controls.Add(this.Light1Button);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.Camera1TextBox);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.videoControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormTwinCam";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VideoControl videoControl1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox Camera1TextBox;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button Light1Button;
        private VideoControl videoControl2;
        private System.Windows.Forms.TextBox Camera2TextBox;
        private System.Windows.Forms.TextBox User1TextBox;
        private System.Windows.Forms.TextBox Password1TextBox;
        private System.Windows.Forms.TextBox Password2TextBox;
        private System.Windows.Forms.TextBox User2TextBox;
        private System.Windows.Forms.Button Light2Button;
        private System.Windows.Forms.Button Up1Button;
        private System.Windows.Forms.Button Down1Button;
        private System.Windows.Forms.Button Right1Button;
        private System.Windows.Forms.Button Left1Button;
        private System.Windows.Forms.Button Left2Button;
        private System.Windows.Forms.Button Right2Button;
        private System.Windows.Forms.Button Down2Button;
        private System.Windows.Forms.Button Up2Button;
        private System.Windows.Forms.Button QuitButton;
    }
}

