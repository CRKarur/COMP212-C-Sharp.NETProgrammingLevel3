
namespace _301163364_Karur__Lab2
{
    partial class NotificationManager
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
            this.Subscribe = new System.Windows.Forms.Button();
            this.publishNotification = new System.Windows.Forms.Button();
            this.ExitNotificationManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Subscribe
            // 
            this.Subscribe.Location = new System.Drawing.Point(26, 47);
            this.Subscribe.Name = "Subscribe";
            this.Subscribe.Size = new System.Drawing.Size(164, 37);
            this.Subscribe.TabIndex = 0;
            this.Subscribe.Text = "Manage Subscription";
            this.Subscribe.UseVisualStyleBackColor = true;
            this.Subscribe.Click += new System.EventHandler(this.Subscribe_Click);
            // 
            // publishNotification
            // 
            this.publishNotification.Enabled = false;
            this.publishNotification.Location = new System.Drawing.Point(235, 47);
            this.publishNotification.Name = "publishNotification";
            this.publishNotification.Size = new System.Drawing.Size(153, 37);
            this.publishNotification.TabIndex = 1;
            this.publishNotification.Text = "Publish Notification";
            this.publishNotification.UseVisualStyleBackColor = true;
            this.publishNotification.Click += new System.EventHandler(this.publishnotification_Clicked);
            // 
            // ExitNotificationManager
            // 
            this.ExitNotificationManager.Location = new System.Drawing.Point(440, 47);
            this.ExitNotificationManager.Name = "ExitNotificationManager";
            this.ExitNotificationManager.Size = new System.Drawing.Size(137, 37);
            this.ExitNotificationManager.TabIndex = 2;
            this.ExitNotificationManager.Text = "Exit";
            this.ExitNotificationManager.UseVisualStyleBackColor = true;
            this.ExitNotificationManager.Click += new System.EventHandler(this.ExitNotificationManager_Click);
            // 
            // NotificationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 131);
            this.Controls.Add(this.ExitNotificationManager);
            this.Controls.Add(this.publishNotification);
            this.Controls.Add(this.Subscribe);
            this.Name = "NotificationManager";
            this.Text = "Notification Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Subscribe;
        private System.Windows.Forms.Button publishNotification;
        private System.Windows.Forms.Button ExitNotificationManager;
    }
}

