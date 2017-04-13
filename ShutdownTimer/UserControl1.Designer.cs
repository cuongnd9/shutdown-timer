namespace ShutdownTimer
{
    partial class UserControl1
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
            this.lbDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbMinutes = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbHours = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbTotalMinutes = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Datepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.txbTotalHours = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTotalSeconds = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbSeconds = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbxTotalTime = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chbxSelectedTime = new Bunifu.Framework.UI.BunifuCheckbox();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(87, 147);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(117, 20);
            this.lbDate.TabIndex = 52;
            this.lbDate.Text = "Selected date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(321, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 19);
            this.label9.TabIndex = 51;
            this.label9.Text = ":";
            // 
            // txbMinutes
            // 
            this.txbMinutes.BorderColorFocused = System.Drawing.Color.White;
            this.txbMinutes.BorderColorIdle = System.Drawing.Color.White;
            this.txbMinutes.BorderColorMouseHover = System.Drawing.Color.White;
            this.txbMinutes.BorderThickness = 1;
            this.txbMinutes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMinutes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMinutes.ForeColor = System.Drawing.Color.White;
            this.txbMinutes.isPassword = false;
            this.txbMinutes.Location = new System.Drawing.Point(343, 86);
            this.txbMinutes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbMinutes.Name = "txbMinutes";
            this.txbMinutes.Size = new System.Drawing.Size(52, 35);
            this.txbMinutes.TabIndex = 4;
            this.txbMinutes.Text = "26";
            this.txbMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMinutes_KeyPress);
            // 
            // txbHours
            // 
            this.txbHours.BorderColorFocused = System.Drawing.Color.White;
            this.txbHours.BorderColorIdle = System.Drawing.Color.White;
            this.txbHours.BorderColorMouseHover = System.Drawing.Color.White;
            this.txbHours.BorderThickness = 1;
            this.txbHours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbHours.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHours.ForeColor = System.Drawing.Color.White;
            this.txbHours.isPassword = false;
            this.txbHours.Location = new System.Drawing.Point(259, 86);
            this.txbHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbHours.Name = "txbHours";
            this.txbHours.Size = new System.Drawing.Size(52, 35);
            this.txbHours.TabIndex = 3;
            this.txbHours.Text = "26";
            this.txbHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbHours_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(336, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Minutes";
            // 
            // txbTotalMinutes
            // 
            this.txbTotalMinutes.BorderColorFocused = System.Drawing.Color.White;
            this.txbTotalMinutes.BorderColorIdle = System.Drawing.Color.White;
            this.txbTotalMinutes.BorderColorMouseHover = System.Drawing.Color.White;
            this.txbTotalMinutes.BorderThickness = 1;
            this.txbTotalMinutes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTotalMinutes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalMinutes.ForeColor = System.Drawing.Color.White;
            this.txbTotalMinutes.isPassword = false;
            this.txbTotalMinutes.Location = new System.Drawing.Point(343, 15);
            this.txbTotalMinutes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTotalMinutes.Name = "txbTotalMinutes";
            this.txbTotalMinutes.Size = new System.Drawing.Size(52, 35);
            this.txbTotalMinutes.TabIndex = 1;
            this.txbTotalMinutes.Text = "00";
            this.txbTotalMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbTotalMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTotalMinutes_KeyPress);
            // 
            // Datepicker
            // 
            this.Datepicker.BackColor = System.Drawing.Color.White;
            this.Datepicker.BorderRadius = 0;
            this.Datepicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.Datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Datepicker.FormatCustom = null;
            this.Datepicker.Location = new System.Drawing.Point(261, 146);
            this.Datepicker.Name = "Datepicker";
            this.Datepicker.Size = new System.Drawing.Size(218, 36);
            this.Datepicker.TabIndex = 46;
            this.Datepicker.Value = new System.DateTime(2018, 3, 28, 19, 49, 2, 7);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(87, 92);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(113, 20);
            this.lblTime.TabIndex = 45;
            this.lblTime.Text = "Selected time:";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblTotalTime.ForeColor = System.Drawing.Color.White;
            this.lblTotalTime.Location = new System.Drawing.Point(86, 32);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(110, 20);
            this.lblTotalTime.TabIndex = 44;
            this.lblTotalTime.Text = "Duration time:";
            // 
            // txbTotalHours
            // 
            this.txbTotalHours.BorderColorFocused = System.Drawing.Color.White;
            this.txbTotalHours.BorderColorIdle = System.Drawing.Color.White;
            this.txbTotalHours.BorderColorMouseHover = System.Drawing.Color.White;
            this.txbTotalHours.BorderThickness = 1;
            this.txbTotalHours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTotalHours.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalHours.ForeColor = System.Drawing.Color.White;
            this.txbTotalHours.isPassword = false;
            this.txbTotalHours.Location = new System.Drawing.Point(259, 16);
            this.txbTotalHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTotalHours.Name = "txbTotalHours";
            this.txbTotalHours.Size = new System.Drawing.Size(52, 35);
            this.txbTotalHours.TabIndex = 0;
            this.txbTotalHours.Text = "00";
            this.txbTotalHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         //   this.txbTotalHours.OnValueChanged += new System.EventHandler(this.txbTotalHours_OnValueChanged);
            this.txbTotalHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTotalHours_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(413, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Senconds";
            // 
            // txbTotalSeconds
            // 
            this.txbTotalSeconds.BorderColorFocused = System.Drawing.Color.White;
            this.txbTotalSeconds.BorderColorIdle = System.Drawing.Color.White;
            this.txbTotalSeconds.BorderColorMouseHover = System.Drawing.Color.White;
            this.txbTotalSeconds.BorderThickness = 1;
            this.txbTotalSeconds.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTotalSeconds.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalSeconds.ForeColor = System.Drawing.Color.White;
            this.txbTotalSeconds.isPassword = false;
            this.txbTotalSeconds.Location = new System.Drawing.Point(426, 14);
            this.txbTotalSeconds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTotalSeconds.Name = "txbTotalSeconds";
            this.txbTotalSeconds.Size = new System.Drawing.Size(52, 35);
            this.txbTotalSeconds.TabIndex = 2;
            this.txbTotalSeconds.Text = "60";
            this.txbTotalSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbTotalSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTotalSeconds_KeyPress);
            // 
            // txbSeconds
            // 
            this.txbSeconds.BorderColorFocused = System.Drawing.Color.White;
            this.txbSeconds.BorderColorIdle = System.Drawing.Color.White;
            this.txbSeconds.BorderColorMouseHover = System.Drawing.Color.White;
            this.txbSeconds.BorderThickness = 1;
            this.txbSeconds.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSeconds.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSeconds.ForeColor = System.Drawing.Color.White;
            this.txbSeconds.isPassword = false;
            this.txbSeconds.Location = new System.Drawing.Point(427, 86);
            this.txbSeconds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbSeconds.Name = "txbSeconds";
            this.txbSeconds.Size = new System.Drawing.Size(52, 35);
            this.txbSeconds.TabIndex = 5;
            this.txbSeconds.Text = "26";
            this.txbSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSeconds_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(406, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 19);
            this.label3.TabIndex = 58;
            this.label3.Text = ":";
            // 
            // chbxTotalTime
            // 
            this.chbxTotalTime.BackColor = System.Drawing.Color.White;
            this.chbxTotalTime.ChechedOffColor = System.Drawing.Color.White;
            this.chbxTotalTime.Checked = true;
            this.chbxTotalTime.CheckedOnColor = System.Drawing.Color.White;
            this.chbxTotalTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.chbxTotalTime.Location = new System.Drawing.Point(60, 31);
            this.chbxTotalTime.Name = "chbxTotalTime";
            this.chbxTotalTime.Size = new System.Drawing.Size(20, 20);
            this.chbxTotalTime.TabIndex = 59;
            this.chbxTotalTime.OnChange += new System.EventHandler(this.chbxTotalTime_OnChange);
            // 
            // chbxSelectedTime
            // 
            this.chbxSelectedTime.BackColor = System.Drawing.Color.White;
            this.chbxSelectedTime.ChechedOffColor = System.Drawing.Color.White;
            this.chbxSelectedTime.Checked = true;
            this.chbxSelectedTime.CheckedOnColor = System.Drawing.Color.White;
            this.chbxSelectedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.chbxSelectedTime.Location = new System.Drawing.Point(60, 92);
            this.chbxSelectedTime.Name = "chbxSelectedTime";
            this.chbxSelectedTime.Size = new System.Drawing.Size(20, 20);
            this.chbxSelectedTime.TabIndex = 60;
            this.chbxSelectedTime.OnChange += new System.EventHandler(this.chbxSelectedTime_OnChange);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.chbxSelectedTime);
            this.Controls.Add(this.chbxTotalTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSeconds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTotalSeconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTotalHours);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbMinutes);
            this.Controls.Add(this.txbHours);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbTotalMinutes);
            this.Controls.Add(this.Datepicker);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTotalTime);
            this.Name = "UserControl1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(546, 196);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbMinutes;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbHours;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbTotalMinutes;
        private Bunifu.Framework.UI.BunifuDatepicker Datepicker;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTotalTime;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbTotalHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbTotalSeconds;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbSeconds;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox chbxTotalTime;
        private Bunifu.Framework.UI.BunifuCheckbox CheckBoxSelectedTime;
        private Bunifu.Framework.UI.BunifuCheckbox chbxSelectedTime;
    }
}
