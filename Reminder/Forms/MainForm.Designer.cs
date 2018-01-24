namespace Reminder.Forms
{
    partial class MainForm
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
            this.CreateReminder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.details = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.mainList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateReminder
            // 
            this.CreateReminder.Location = new System.Drawing.Point(12, 12);
            this.CreateReminder.Name = "CreateReminder";
            this.CreateReminder.Size = new System.Drawing.Size(175, 36);
            this.CreateReminder.TabIndex = 0;
            this.CreateReminder.Text = "Create";
            this.CreateReminder.UseVisualStyleBackColor = true;
            this.CreateReminder.Click += new System.EventHandler(this.ButtonCreate);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonDelete);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainList);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.details);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CreateReminder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 437);
            this.panel1.TabIndex = 2;
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(12, 293);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(362, 36);
            this.details.TabIndex = 3;
            this.details.Text = "Details";
            this.details.UseVisualStyleBackColor = true;
            this.details.Click += new System.EventHandler(this.showDetails);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(12, 335);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(362, 36);
            this.Close.TabIndex = 4;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // mainList
            // 
            this.mainList.FormattingEnabled = true;
            this.mainList.ItemHeight = 16;
            this.mainList.Location = new System.Drawing.Point(12, 67);
            this.mainList.Name = "mainList";
            this.mainList.Size = new System.Drawing.Size(362, 212);
            this.mainList.TabIndex = 5;
            this.mainList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 437);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateReminder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button details;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ListBox mainList;
    }
}

