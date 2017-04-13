using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownTimer
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        public int Days
        {
            get
            {
                return int.Parse(lblDays.Text);
            }
            set
            {
                lblDays.Text = value.ToString("000");
            }
        }
        public int Hours
        {
            get
            {
                return int.Parse(lblHours.Text);
            }
            set
            {
                lblHours.Text = value.ToString("00");
            }
        }
        public int Minutes
        {
            get
            {
                return int.Parse(lblMinutes.Text);
            }
            set
            {
                lblMinutes.Text = value.ToString("00");
            }
        }
        public int Seconds
        {
            get
            {
                return int.Parse(lblSeconds.Text);
            }
            set
            {
                lblSeconds.Text = value.ToString("00");
            }
        }
        public int CircleDays_MaxValue
        {
            get
            {
                return circleDays.Maximum;
            }
            set
            {
                circleDays.Maximum = value;
            }
        }
        public int CircleDays_MinValue
        {
            get
            {
                return circleDays.Minimum;
            }
            set
            {
                circleDays.Minimum = value;
            }
        }
        public int CircleDays_Value
        {
            get
            {
                return circleDays.Value;
            }
            set
            {
                circleDays.Value = value;
            }
        }
        public int CircleHours_Value
        {
            get
            {
                return circleHours.Value;
            }
            set
            {
                circleHours.Value = value;
            }
        }
        public int CircleMinutes_Value
        {
            get
            {
                return circleMinutes.Value;
            }
            set
            {
                circleMinutes.Value = value;
            }
        }
        public int CircleSeconds_Value
        {
            get
            {
                return circleSeconds.Value;
            }
            set
            {
                circleSeconds.Value = value;
            }
        }
        public override string Text { get => lblStatus.Text; set => lblStatus.Text = value; }
    }
}
