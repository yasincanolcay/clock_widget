
namespace clock_widget
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clockLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borderRadiusOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opacityOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity70ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWidgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWidgetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.borderRadius30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borderRadius50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.speratorVisibleOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.guna2VSeparator1);
            this.panel1.Controls.Add(this.dayLabel);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.clockLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 157);
            this.panel1.TabIndex = 0;
            // 
            // clockLabel
            // 
            this.clockLabel.BackColor = System.Drawing.Color.Transparent;
            this.clockLabel.Font = new System.Drawing.Font("Tahoma", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clockLabel.ForeColor = System.Drawing.Color.White;
            this.clockLabel.Location = new System.Drawing.Point(4, 17);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(238, 88);
            this.clockLabel.TabIndex = 2;
            this.clockLabel.Text = "12:50";
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(291, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(81, 139);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "12  eyl  2023";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayLabel
            // 
            this.dayLabel.BackColor = System.Drawing.Color.Transparent;
            this.dayLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.ForeColor = System.Drawing.Color.White;
            this.dayLabel.Location = new System.Drawing.Point(18, 100);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(224, 40);
            this.dayLabel.TabIndex = 4;
            this.dayLabel.Text = "Cumartesi";
            this.dayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borderRadiusOffToolStripMenuItem,
            this.opacityOffToolStripMenuItem,
            this.opacity50ToolStripMenuItem,
            this.opacity70ToolStripMenuItem,
            this.defaultToolStripMenuItem,
            this.closeWidgetToolStripMenuItem,
            this.toolStripMenuItem1,
            this.borderRadius30ToolStripMenuItem,
            this.borderRadius50ToolStripMenuItem,
            this.changeThemeToolStripMenuItem,
            this.speratorVisibleOffToolStripMenuItem,
            this.closeWidgetToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 268);
            // 
            // borderRadiusOffToolStripMenuItem
            // 
            this.borderRadiusOffToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.borderRadiusOffToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.borderRadiusOffToolStripMenuItem.Name = "borderRadiusOffToolStripMenuItem";
            this.borderRadiusOffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borderRadiusOffToolStripMenuItem.Text = "BorderRadius On";
            this.borderRadiusOffToolStripMenuItem.Click += new System.EventHandler(this.borderRadiusOffToolStripMenuItem_Click);
            // 
            // opacityOffToolStripMenuItem
            // 
            this.opacityOffToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.opacityOffToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.opacityOffToolStripMenuItem.Name = "opacityOffToolStripMenuItem";
            this.opacityOffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opacityOffToolStripMenuItem.Text = "Opacity On";
            this.opacityOffToolStripMenuItem.Click += new System.EventHandler(this.opacityOffToolStripMenuItem_Click);
            // 
            // opacity50ToolStripMenuItem
            // 
            this.opacity50ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.opacity50ToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.opacity50ToolStripMenuItem.Name = "opacity50ToolStripMenuItem";
            this.opacity50ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opacity50ToolStripMenuItem.Text = "Opacity 50%";
            this.opacity50ToolStripMenuItem.Click += new System.EventHandler(this.opacity50ToolStripMenuItem_Click);
            // 
            // opacity70ToolStripMenuItem
            // 
            this.opacity70ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.opacity70ToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.opacity70ToolStripMenuItem.Name = "opacity70ToolStripMenuItem";
            this.opacity70ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opacity70ToolStripMenuItem.Text = "Opacity 70";
            this.opacity70ToolStripMenuItem.Click += new System.EventHandler(this.opacity70ToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.defaultToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // closeWidgetToolStripMenuItem
            // 
            this.closeWidgetToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.closeWidgetToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.closeWidgetToolStripMenuItem.Name = "closeWidgetToolStripMenuItem";
            this.closeWidgetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeWidgetToolStripMenuItem.Text = "Drop On";
            this.closeWidgetToolStripMenuItem.Click += new System.EventHandler(this.closeWidgetToolStripMenuItem_Click);
            // 
            // closeWidgetToolStripMenuItem1
            // 
            this.closeWidgetToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.closeWidgetToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.closeWidgetToolStripMenuItem1.Name = "closeWidgetToolStripMenuItem1";
            this.closeWidgetToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.closeWidgetToolStripMenuItem1.Text = "Close Widget";
            this.closeWidgetToolStripMenuItem1.Click += new System.EventHandler(this.closeWidgetToolStripMenuItem1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // borderRadius30ToolStripMenuItem
            // 
            this.borderRadius30ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.borderRadius30ToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.borderRadius30ToolStripMenuItem.Name = "borderRadius30ToolStripMenuItem";
            this.borderRadius30ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borderRadius30ToolStripMenuItem.Text = "BorderRadius 40";
            this.borderRadius30ToolStripMenuItem.Click += new System.EventHandler(this.borderRadius30ToolStripMenuItem_Click);
            // 
            // borderRadius50ToolStripMenuItem
            // 
            this.borderRadius50ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.borderRadius50ToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.borderRadius50ToolStripMenuItem.Name = "borderRadius50ToolStripMenuItem";
            this.borderRadius50ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borderRadius50ToolStripMenuItem.Text = "BorderRadius 50";
            this.borderRadius50ToolStripMenuItem.Click += new System.EventHandler(this.borderRadius50ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "BorderRadius 30";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // changeThemeToolStripMenuItem
            // 
            this.changeThemeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.changeThemeToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.changeThemeToolStripMenuItem.Name = "changeThemeToolStripMenuItem";
            this.changeThemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeThemeToolStripMenuItem.Text = "Change Theme";
            this.changeThemeToolStripMenuItem.Click += new System.EventHandler(this.changeThemeToolStripMenuItem_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.clockLabel;
            this.guna2DragControl2.TransparentWhileDrag = false;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.TargetControl = this.dayLabel;
            this.guna2DragControl3.TransparentWhileDrag = false;
            // 
            // guna2DragControl4
            // 
            this.guna2DragControl4.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl4.TargetControl = this.dateLabel;
            this.guna2DragControl4.TransparentWhileDrag = false;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(264, 16);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 127);
            this.guna2VSeparator1.TabIndex = 5;
            this.guna2VSeparator1.Visible = false;
            // 
            // speratorVisibleOffToolStripMenuItem
            // 
            this.speratorVisibleOffToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.speratorVisibleOffToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.speratorVisibleOffToolStripMenuItem.Name = "speratorVisibleOffToolStripMenuItem";
            this.speratorVisibleOffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speratorVisibleOffToolStripMenuItem.Text = "Sperator Visible(Off)";
            this.speratorVisibleOffToolStripMenuItem.Click += new System.EventHandler(this.speratorVisibleOffToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 157);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.68D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem borderRadiusOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opacityOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opacity50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opacity70ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeWidgetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeWidgetToolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borderRadius30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borderRadius50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeThemeToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl4;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.ToolStripMenuItem speratorVisibleOffToolStripMenuItem;
    }
}

