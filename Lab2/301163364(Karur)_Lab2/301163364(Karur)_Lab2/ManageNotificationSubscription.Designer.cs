
namespace _301163364_Karur__Lab2
{
    partial class ManageNotificationSubscription
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
            this.emailcheck = new System.Windows.Forms.CheckBox();
            this.Phonecheck = new System.Windows.Forms.CheckBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.subscribe = new System.Windows.Forms.Button();
            this.unsubscribe = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.emailValidationlabel = new System.Windows.Forms.Label();
            this.phonevalidationlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailcheck
            // 
            this.emailcheck.Location = new System.Drawing.Point(72, 43);
            this.emailcheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailcheck.Name = "emailcheck";
            this.emailcheck.Size = new System.Drawing.Size(201, 26);
            this.emailcheck.TabIndex = 0;
            this.emailcheck.Text = "Email Notification to:";
            this.emailcheck.UseVisualStyleBackColor = true;
            this.emailcheck.CheckedChanged += new System.EventHandler(this.Emailchecked_CheckedChanged);
            // 
            // Phonecheck
            // 
            this.Phonecheck.AutoSize = true;
            this.Phonecheck.Location = new System.Drawing.Point(72, 146);
            this.Phonecheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Phonecheck.Name = "Phonecheck";
            this.Phonecheck.Size = new System.Drawing.Size(163, 24);
            this.Phonecheck.TabIndex = 1;
            this.Phonecheck.Text = "Text Notification to:";
            this.Phonecheck.UseVisualStyleBackColor = true;
            this.Phonecheck.CheckedChanged += new System.EventHandler(this.Phonecheck_CheckedChanged);
            // 
            // textEmail
            // 
            this.textEmail.Enabled = false;
            this.textEmail.Location = new System.Drawing.Point(252, 43);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(260, 26);
            this.textEmail.TabIndex = 2;
            this.textEmail.CausesValidationChanged += new System.EventHandler(this.emailvalidation);
            this.textEmail.TextChanged += new System.EventHandler(this.emailvalidation);
            // 
            // textPhone
            // 
            this.textPhone.Enabled = false;
            this.textPhone.Location = new System.Drawing.Point(252, 146);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(260, 26);
            this.textPhone.TabIndex = 3;
            this.textPhone.TextChanged += new System.EventHandler(this.numbervalidation);
            // 
            // subscribe
            // 
            this.subscribe.Enabled = false;
            this.subscribe.Location = new System.Drawing.Point(35, 237);
            this.subscribe.Name = "subscribe";
            this.subscribe.Size = new System.Drawing.Size(154, 39);
            this.subscribe.TabIndex = 4;
            this.subscribe.Text = "Subscribe";
            this.subscribe.UseVisualStyleBackColor = true;
            this.subscribe.Click += new System.EventHandler(this.subscribe_Click);
            // 
            // unsubscribe
            // 
            this.unsubscribe.Enabled = false;
            this.unsubscribe.Location = new System.Drawing.Point(255, 237);
            this.unsubscribe.Name = "unsubscribe";
            this.unsubscribe.Size = new System.Drawing.Size(154, 39);
            this.unsubscribe.TabIndex = 5;
            this.unsubscribe.Text = "Unsubscribe";
            this.unsubscribe.UseVisualStyleBackColor = true;
            this.unsubscribe.Click += new System.EventHandler(this.unsubscribe_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(466, 237);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(158, 39);
            this.back.TabIndex = 6;
            this.back.Text = "Back to Main Menu";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // emailValidationlabel
            // 
            this.emailValidationlabel.AutoSize = true;
            this.emailValidationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailValidationlabel.ForeColor = System.Drawing.Color.Red;
            this.emailValidationlabel.Location = new System.Drawing.Point(251, 84);
            this.emailValidationlabel.Name = "emailValidationlabel";
            this.emailValidationlabel.Size = new System.Drawing.Size(0, 13);
            this.emailValidationlabel.TabIndex = 7;
            // 
            // phonevalidationlabel
            // 
            this.phonevalidationlabel.AutoSize = true;
            this.phonevalidationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonevalidationlabel.ForeColor = System.Drawing.Color.Red;
            this.phonevalidationlabel.Location = new System.Drawing.Point(251, 177);
            this.phonevalidationlabel.Name = "phonevalidationlabel";
            this.phonevalidationlabel.Size = new System.Drawing.Size(0, 13);
            this.phonevalidationlabel.TabIndex = 8;
            // 
            // ManageNotificationSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 327);
            this.Controls.Add(this.phonevalidationlabel);
            this.Controls.Add(this.emailValidationlabel);
            this.Controls.Add(this.back);
            this.Controls.Add(this.unsubscribe);
            this.Controls.Add(this.subscribe);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.Phonecheck);
            this.Controls.Add(this.emailcheck);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageNotificationSubscription";
            this.Text = "Manage Notification Subscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox emailcheck;
        private System.Windows.Forms.CheckBox Phonecheck;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Button subscribe;
        private System.Windows.Forms.Button unsubscribe;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label emailValidationlabel;
        private System.Windows.Forms.Label phonevalidationlabel;
    }
}