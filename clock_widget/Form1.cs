using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clock_widget
{
    public partial class Form1 : Form
    {
        bool isOpenDrop = true;
        bool isOpenRadius = true;
        bool isOpenOpacity = true;
        bool isOpenLightTheme = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clock.Enabled = true;
            clock.Start();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            string hour = DateTime.Now.Hour.ToString();
            string minutes = DateTime.Now.Minute.ToString();
            var dayName = DateTime.Now.DayOfWeek;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            if (DateTime.Now.Hour < 10)
            {
                hour = "0"+DateTime.Now.Hour.ToString();
            }
            if(DateTime.Now.Minute < 10)
            {
                minutes = "0"+ DateTime.Now.Minute.ToString();
            }
            string clockString = hour + ":" + minutes;
            clockLabel.Text = clockString;
            dayLabel.Text = dayName.ToString();
            dateLabel.Text = day.ToString() + "\n" + months[month] + "\n" + year.ToString();
        }

        private void opacityOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isOpenOpacity)
            {
                isOpenOpacity = false;
                this.Opacity = 1;
                opacityOffToolStripMenuItem.Text = "Opacity Off";
            }
            else
            {
                isOpenOpacity = true;
                this.Opacity = 0.68;
                opacityOffToolStripMenuItem.Text = "Opacity On(68%)";
            }
        }

        private void opacity50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void opacity70ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.7;

        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.68;
            guna2Elipse1.BorderRadius = 40;
            isOpenDrop = true;
            isOpenRadius = true;
        }

        private void closeWidgetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void borderRadiusOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isOpenRadius)
            {
                isOpenRadius = false;
                guna2Elipse1.BorderRadius = 0;
                borderRadiusOffToolStripMenuItem.Text = "BorderRadius Off";
            }
            else
            {
                isOpenRadius = true;
                guna2Elipse1.BorderRadius = 40;
                borderRadiusOffToolStripMenuItem.Text = "BorderRadius On";
            }
        }

        private void closeWidgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isOpenDrop)
            {
                isOpenDrop = false;
                closeWidgetToolStripMenuItem.Text = "Drop Off";
                guna2DragControl1.TargetControl = null;
                guna2DragControl2.TargetControl = null;
                guna2DragControl3.TargetControl = null;
                guna2DragControl4.TargetControl = null;
            }
            else
            {
                isOpenDrop = true;
                closeWidgetToolStripMenuItem.Text = "Drop On";
                guna2DragControl1.TargetControl = panel1;
                guna2DragControl2.TargetControl = clockLabel;
                guna2DragControl3.TargetControl = dayLabel;
                guna2DragControl4.TargetControl = dateLabel;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            guna2Elipse1.BorderRadius = 30;
        }

        private void borderRadius30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guna2Elipse1.BorderRadius = 40;
        }

        private void borderRadius50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guna2Elipse1.BorderRadius = 50;
        }

        private void changeThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isOpenLightTheme)
            {
                isOpenLightTheme = true;
                this.BackColor = Color.White;
                clockLabel.ForeColor = Color.Black;
                dayLabel.ForeColor = Color.Black;
                dateLabel.ForeColor = Color.Black;
                guna2VSeparator1.FillColor = Color.Black;
                changeThemeToolStripMenuItem.Text = "Change Theme (Active)";
            }
            else
            {
                isOpenLightTheme = false;
                this.BackColor = Color.Black;
                clockLabel.ForeColor = Color.White;
                dayLabel.ForeColor = Color.White;
                dateLabel.ForeColor = Color.White;
                guna2VSeparator1.FillColor = Color.FromArgb(193, 200, 207);
                changeThemeToolStripMenuItem.Text = "Change Theme";

            }
        }

        private void speratorVisibleOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(guna2VSeparator1.Visible == false)
            {
                guna2VSeparator1.Visible = true;
            }
            else
            {
                guna2VSeparator1.Visible = false;
            }
        }
    }
}
