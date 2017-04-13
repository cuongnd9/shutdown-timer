namespace ShutdownTimer
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.circleDays = new CircularProgressBar.CircularProgressBar();
            this.circleHours = new CircularProgressBar.CircularProgressBar();
            this.circleMinutes = new CircularProgressBar.CircularProgressBar();
            this.circleSeconds = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // circleDays
            // 
            this.circleDays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.circleDays.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circleDays.AnimationSpeed = 500;
            this.circleDays.BackColor = System.Drawing.Color.Transparent;
            this.circleDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circleDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circleDays.InnerColor = System.Drawing.Color.Transparent;
            this.circleDays.InnerMargin = 2;
            this.circleDays.InnerWidth = -1;
            this.circleDays.Location = new System.Drawing.Point(24, 49);
            this.circleDays.MarqueeAnimationSpeed = 2000;
            this.circleDays.Maximum = 59;
            this.circleDays.Name = "circleDays";
            this.circleDays.OuterColor = System.Drawing.Color.White;
            this.circleDays.OuterMargin = -25;
            this.circleDays.OuterWidth = 26;
            this.circleDays.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.circleDays.ProgressWidth = 5;
            this.circleDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circleDays.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circleDays.Size = new System.Drawing.Size(100, 100);
            this.circleDays.StartAngle = 270;
            this.circleDays.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleDays.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circleDays.SubscriptText = ".23";
            this.circleDays.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleDays.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circleDays.SuperscriptText = "°C";
            this.circleDays.TabIndex = 10;
            this.circleDays.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circleDays.Value = 30;
            // 
            // circleHours
            // 
            this.circleHours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.circleHours.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circleHours.AnimationSpeed = 500;
            this.circleHours.BackColor = System.Drawing.Color.Transparent;
            this.circleHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circleHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circleHours.InnerColor = System.Drawing.Color.Transparent;
            this.circleHours.InnerMargin = 2;
            this.circleHours.InnerWidth = -1;
            this.circleHours.Location = new System.Drawing.Point(157, 49);
            this.circleHours.MarqueeAnimationSpeed = 2000;
            this.circleHours.Maximum = 23;
            this.circleHours.Name = "circleHours";
            this.circleHours.OuterColor = System.Drawing.Color.White;
            this.circleHours.OuterMargin = -25;
            this.circleHours.OuterWidth = 26;
            this.circleHours.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.circleHours.ProgressWidth = 5;
            this.circleHours.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circleHours.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circleHours.Size = new System.Drawing.Size(100, 100);
            this.circleHours.StartAngle = 270;
            this.circleHours.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleHours.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circleHours.SubscriptText = ".23";
            this.circleHours.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleHours.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circleHours.SuperscriptText = "°C";
            this.circleHours.TabIndex = 11;
            this.circleHours.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circleHours.Value = 23;
            // 
            // circleMinutes
            // 
            this.circleMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.circleMinutes.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circleMinutes.AnimationSpeed = 500;
            this.circleMinutes.BackColor = System.Drawing.Color.Transparent;
            this.circleMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circleMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circleMinutes.InnerColor = System.Drawing.Color.Transparent;
            this.circleMinutes.InnerMargin = 2;
            this.circleMinutes.InnerWidth = -1;
            this.circleMinutes.Location = new System.Drawing.Point(287, 49);
            this.circleMinutes.MarqueeAnimationSpeed = 2000;
            this.circleMinutes.Maximum = 59;
            this.circleMinutes.Name = "circleMinutes";
            this.circleMinutes.OuterColor = System.Drawing.Color.White;
            this.circleMinutes.OuterMargin = -25;
            this.circleMinutes.OuterWidth = 26;
            this.circleMinutes.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.circleMinutes.ProgressWidth = 5;
            this.circleMinutes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circleMinutes.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circleMinutes.Size = new System.Drawing.Size(100, 100);
            this.circleMinutes.StartAngle = 270;
            this.circleMinutes.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleMinutes.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circleMinutes.SubscriptText = ".23";
            this.circleMinutes.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleMinutes.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circleMinutes.SuperscriptText = "°C";
            this.circleMinutes.TabIndex = 12;
            this.circleMinutes.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circleMinutes.Value = 30;
            // 
            // circleSeconds
            // 
            this.circleSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.circleSeconds.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circleSeconds.AnimationSpeed = 500;
            this.circleSeconds.BackColor = System.Drawing.Color.Transparent;
            this.circleSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circleSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circleSeconds.InnerColor = System.Drawing.Color.Transparent;
            this.circleSeconds.InnerMargin = 2;
            this.circleSeconds.InnerWidth = -1;
            this.circleSeconds.Location = new System.Drawing.Point(417, 49);
            this.circleSeconds.MarqueeAnimationSpeed = 2000;
            this.circleSeconds.Maximum = 59;
            this.circleSeconds.Name = "circleSeconds";
            this.circleSeconds.OuterColor = System.Drawing.Color.White;
            this.circleSeconds.OuterMargin = -25;
            this.circleSeconds.OuterWidth = 26;
            this.circleSeconds.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.circleSeconds.ProgressWidth = 5;
            this.circleSeconds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circleSeconds.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circleSeconds.Size = new System.Drawing.Size(100, 100);
            this.circleSeconds.StartAngle = 270;
            this.circleSeconds.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleSeconds.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circleSeconds.SubscriptText = ".23";
            this.circleSeconds.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleSeconds.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circleSeconds.SuperscriptText = "°C";
            this.circleSeconds.TabIndex = 13;
            this.circleSeconds.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circleSeconds.Value = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(303, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(431, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Seconds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Days";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(20, 15);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(76, 20);
            this.lblStatus.TabIndex = 59;
            this.lblStatus.Text = "Waiting...";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblDays.ForeColor = System.Drawing.Color.White;
            this.lblDays.Location = new System.Drawing.Point(59, 90);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(33, 20);
            this.lblDays.TabIndex = 60;
            this.lblDays.Text = "000";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblHours.ForeColor = System.Drawing.Color.White;
            this.lblHours.Location = new System.Drawing.Point(195, 90);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(25, 20);
            this.lblHours.TabIndex = 61;
            this.lblHours.Text = "00";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblMinutes.ForeColor = System.Drawing.Color.White;
            this.lblMinutes.Location = new System.Drawing.Point(324, 90);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(25, 20);
            this.lblMinutes.TabIndex = 62;
            this.lblMinutes.Text = "00";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblSeconds.ForeColor = System.Drawing.Color.White;
            this.lblSeconds.Location = new System.Drawing.Point(455, 90);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(25, 20);
            this.lblSeconds.TabIndex = 63;
            this.lblSeconds.Text = "00";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circleSeconds);
            this.Controls.Add(this.circleMinutes);
            this.Controls.Add(this.circleHours);
            this.Controls.Add(this.circleDays);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(546, 196);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar circleDays;
        private CircularProgressBar.CircularProgressBar circleHours;
        private CircularProgressBar.CircularProgressBar circleMinutes;
        private CircularProgressBar.CircularProgressBar circleSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconds;
    }
}
