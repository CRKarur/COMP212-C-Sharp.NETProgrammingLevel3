
namespace _301163364_Karur__Lab2
{
    partial class SendNotification
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
            this.NotificationDetails = new System.Windows.Forms.Label();
            this.publishText = new System.Windows.Forms.RichTextBox();
            this.Publish = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textSentTo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // NotificationDetails
            // 
            this.NotificationDetails.AutoSize = true;
            this.NotificationDetails.Location = new System.Drawing.Point(34, 22);
            this.NotificationDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotificationDetails.Name = "NotificationDetails";
            this.NotificationDetails.Size = new System.Drawing.Size(145, 20);
            this.NotificationDetails.TabIndex = 0;
            this.NotificationDetails.Text = "Notification Details:";
            // 
            // publishText
            // 
            this.publishText.Location = new System.Drawing.Point(36, 61);
            this.publishText.Name = "publishText";
            this.publishText.Size = new System.Drawing.Size(649, 74);
            this.publishText.TabIndex = 1;
            this.publishText.Text = "";
            // 
            // Publish
            // 
            this.Publish.Location = new System.Drawing.Point(155, 155);
            this.Publish.Name = "Publish";
            this.Publish.Size = new System.Drawing.Size(190, 40);
            this.Publish.TabIndex = 2;
            this.Publish.Text = "Publish";
            this.Publish.UseVisualStyleBackColor = true;
            this.Publish.Click += new System.EventHandler(this.Publish_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(402, 154);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(190, 41);
            this.back.TabIndex = 3;
            this.back.Text = "Back to Main Menu";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Notification sent to following subscribers:";
            // 
            // textSentTo
            // 
            this.textSentTo.Location = new System.Drawing.Point(38, 266);
            this.textSentTo.Name = "textSentTo";
            this.textSentTo.Size = new System.Drawing.Size(647, 183);
            this.textSentTo.TabIndex = 5;
            this.textSentTo.Text = "";
            // 
            // SendNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 481);
            this.Controls.Add(this.textSentTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Publish);
            this.Controls.Add(this.publishText);
            this.Controls.Add(this.NotificationDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SendNotification";
            this.Text = "Send Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NotificationDetails;
        private System.Windows.Forms.RichTextBox publishText;
        private System.Windows.Forms.Button Publish;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textSentTo;
    }
}