using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301163364_Karur__Lab2
{
    public partial class ManageNotificationSubscription : Form
    {
        private List<string> esub;
        private List<string> tsub;
        private NotificationManager nm;

        public ManageNotificationSubscription(List<String> esub, List<String> tsub, NotificationManager nm)
        {
            InitializeComponent();
            this.esub = esub;
            this.tsub = tsub;
            this.nm = nm;
        }

        private void Emailchecked_CheckedChanged(object sender, EventArgs e)
        {
            emailValidationlabel.Text = "";
            textEmail.Clear();
            Phonecheck.Checked = false;
            if(emailcheck.Checked)
            {
                textEmail.Enabled =true;
                emailValidationlabel.Text = "";
            }
            else if(!emailcheck.Checked || Phonecheck.Checked)
            {
                emailcheck.Checked = false;
                textEmail.Enabled = false;
                emailValidationlabel.Text = "";
                phonevalidationlabel.Text = "";
                subscribe.Enabled = false;
                unsubscribe.Enabled = false;
            }
        }

        private void emailvalidation(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex expr =
                new System.Text.RegularExpressions.Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            if(textEmail.Text=="")
            { 
                this.subscribe.Enabled = false;
                this.unsubscribe.Enabled = false;
            }

            if (expr.IsMatch(textEmail.Text))
            {
                emailValidationlabel.Text = "";
                if(esub.Count!=0)
                {
                    for (int i = 0; i < esub.Count; i++)
                    {
                        if (textEmail.Text == esub[i])
                        {
                            this.subscribe.Enabled = false;
                            MessageBox.Show("User already subscribed!\n Please click on unsubscribe if you wish to... ");
                            this.unsubscribe.Enabled = true;
                            break;
                        }
                        else
                        {
                            subscribe.Enabled = true;
                            unsubscribe.Enabled = false;
                        }
                    }
                }
                else
                {
                    subscribe.Enabled = true;
                }
                
            }

            else
            {
                emailValidationlabel.Text = "invalid email";
                subscribe.Enabled = false;
            }

        }

        private void numbervalidation(object sender, EventArgs e)
        {
            int valid = 1;
            if (textPhone.Text.Length == 10)
            {
                phonevalidationlabel.Text = "";
                for(int i=0;i<tsub.Count;i++)
                {
                    if(textPhone.Text == tsub[i])
                    {
                        MessageBox.Show("User Already Exists!\n Unsubscribe if you wish to...");
                        subscribe.Enabled = false;
                        unsubscribe.Enabled = true;
                        valid = 0;
                        break;
                    }
                }
                if(valid==1)
                {
                    subscribe.Enabled = true;
                    unsubscribe.Enabled = false;
                }
                
            }
            else
            {
                phonevalidationlabel.Text = "invalid mobile contact number";
                subscribe.Enabled = false;
                unsubscribe.Enabled = false;
            }
        }

        private void Phonecheck_CheckedChanged(object sender, EventArgs e)
        {
            emailcheck.Checked = false;
            textEmail.Clear();
            textPhone.Clear();
            subscribe.Enabled = false;
            unsubscribe.Enabled = false;
            emailValidationlabel.Text = "";
            phonevalidationlabel.Text = "";
            if (Phonecheck.Checked)
            {
                textPhone.Enabled = true;
            }
            else if(!Phonecheck.Checked || emailcheck.Checked)
            {
                textPhone.Enabled = false;
                textPhone.Clear();
                textEmail.Clear();
                emailValidationlabel.Text = "";
                phonevalidationlabel.Text = "";
                subscribe.Enabled = false;
                unsubscribe.Enabled = false;
            }
        }

        private void unsubscribe_Click(object sender, EventArgs e)
        {
            if(emailcheck.Checked)
            {
                for(int i=0;i<esub.Count; i++)
                {
                    if (esub[i] == textEmail.Text)
                    {
                        esub.RemoveAt(i);
                        MessageBox.Show("User unsubscribed!");
                        emailcheck.Checked = false;
                        subscribe.Enabled = false;
                        unsubscribe.Enabled = false;
                        textEmail.Clear();
                        textEmail.Enabled = false;
                        phonevalidationlabel.Text = "";
                        emailValidationlabel.Text = "";
                        if(esub.Count==0)
                        {
                            nm.disablepublish();
                        }
                        break;
                    }
                }
            }
            if(Phonecheck.Checked)
            {
                for (int i = 0; i < tsub.Count; i++)
                {
                    if (tsub[i] == textPhone.Text)
                    {
                        tsub.RemoveAt(i);
                        MessageBox.Show("User unsubscribed!");
                        Phonecheck.Checked = false;
                        subscribe.Enabled = false;
                        unsubscribe.Enabled = false;
                        textPhone.Clear();
                        textPhone.Enabled = false;
                        phonevalidationlabel.Text = "";
                        emailValidationlabel.Text = "";
                        if (tsub.Count == 0)
                        {
                            nm.disablepublish();
                        }
                        break;
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            nm = new NotificationManager(esub, tsub, this);
            this.Hide();
            this.Close();
            if (esub.Count != 0 || tsub.Count != 0)
            {
                nm.enablepublish();
            }
            else
            {
                nm.disablepublish();
            }
            nm.ShowDialog();
        }

        private void subscribe_Click(object sender, EventArgs e)
        {
            if (emailcheck.Checked && textEmail.Text != "")
            {
                esub.Add(textEmail.Text);
                MessageBox.Show("user subscribed for email!");
                emailcheck.Checked = false;
                Phonecheck.Checked = false;
                textEmail.Clear();
                textPhone.Clear();
                textEmail.Enabled = false;
                textPhone.Enabled = false;
                subscribe.Enabled = false;
                unsubscribe.Enabled = false;
                emailValidationlabel.Text = "";
                phonevalidationlabel.Text = "";
                //this.ShowDialog();
            }
            if (Phonecheck.Checked && textPhone.Text != "")
            {
                tsub.Add(textPhone.Text);
                MessageBox.Show("user subscribed for text messages!");
                Phonecheck.Checked = false;
                emailcheck.Checked = false;
                textPhone.Clear();
                textEmail.Clear();
                textPhone.Enabled = false;
                textEmail.Enabled = false;
                subscribe.Enabled = false;
                unsubscribe.Enabled = false;
                phonevalidationlabel.Text = "";
                emailValidationlabel.Text = "";
                //this.ShowDialog();
            }
        }
    }
}
