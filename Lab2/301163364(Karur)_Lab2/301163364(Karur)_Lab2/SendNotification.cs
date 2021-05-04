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
    public partial class SendNotification : Form
    {
        private List<string> esub;
        private List<string> tsub;
       // private List<String> sub;
        private NotificationManager nm;
       
        //declaring a delegate
        public delegate void publish();

        public SendNotification()
        {
            InitializeComponent();
        }

        public SendNotification(List<string> esub, List<string> tsub, NotificationManager nm)
        {
            this.esub = esub;
            this.tsub = tsub;
            this.nm = nm;
            InitializeComponent();
        }

        private void Publish_Click(object sender, EventArgs e)
        {
            //delegate method as an object
            publish pmsg = new publish(notifyEmail);
            pmsg();
            pmsg = notifyText;
            pmsg();

        }

        private void notifyEmail()
        {
            foreach (string msg in esub)
            {
                textSentTo.Text += msg + "\r\n";
            }
        }
        private void notifyText()
        {
            foreach (string msg in tsub)
            {
                textSentTo.Text += msg + "\r\n";
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
    }
}
