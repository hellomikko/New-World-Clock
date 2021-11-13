namespace NWClock
{
    partial class NWClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NWClock));
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.closewindow = new System.Windows.Forms.Button();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.bug = new System.Windows.Forms.Button();
            this.discord = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // time
            // 
            resources.ApplyResources(this.time, "time");
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.time.ForeColor = System.Drawing.Color.Tan;
            this.time.Name = "time";
            // 
            // date
            // 
            resources.ApplyResources(this.date, "date");
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.date.ForeColor = System.Drawing.Color.Tan;
            this.date.Name = "date";
            // 
            // closewindow
            // 
            this.closewindow.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.closewindow, "closewindow");
            this.closewindow.FlatAppearance.BorderSize = 0;
            this.closewindow.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.closewindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closewindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closewindow.ForeColor = System.Drawing.Color.Transparent;
            this.closewindow.Name = "closewindow";
            this.closewindow.TabStop = false;
            this.closewindow.UseVisualStyleBackColor = false;
            this.closewindow.Click += new System.EventHandler(this.closewindow_Click_1);
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this;
            // 
            // bug
            // 
            this.bug.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bug, "bug");
            this.bug.FlatAppearance.BorderSize = 0;
            this.bug.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bug.ForeColor = System.Drawing.Color.Transparent;
            this.bug.Name = "bug";
            this.bug.TabStop = false;
            this.bug.UseVisualStyleBackColor = false;
            this.bug.Click += new System.EventHandler(this.button1_Click);
            // 
            // discord
            // 
            this.discord.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.discord, "discord");
            this.discord.FlatAppearance.BorderSize = 0;
            this.discord.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.discord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.discord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.discord.ForeColor = System.Drawing.Color.Transparent;
            this.discord.Name = "discord";
            this.discord.TabStop = false;
            this.discord.UseVisualStyleBackColor = false;
            this.discord.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Name = "button1";
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // NWClock
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NWClock.Properties.Resources.c;
            this.CausesValidation = false;
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.discord);
            this.Controls.Add(this.bug);
            this.Controls.Add(this.closewindow);
            this.Controls.Add(this.date);
            this.Controls.Add(this.time);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NWClock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button closewindow;
        private JDragControl.JDragControl jDragControl1;
        private System.Windows.Forms.Button bug;
        private System.Windows.Forms.Button discord;
        private System.Windows.Forms.Button button1;
    }
}

