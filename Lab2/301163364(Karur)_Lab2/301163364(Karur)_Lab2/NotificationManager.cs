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
    public partial class NotificationManager : Form
    {
        private List<String> esub = new List<string>();
        private List<String> tsub = new List<String>();
        private ManageNotificationSubscription mns;
        private SendNotification sn;


        public NotificationManager()
        {
            InitializeComponent();
        }
        public NotificationManager(List<String> esub, List<string> tsub, ManageNotificationSubscription mns)
        {
            InitializeComponent();
            this.esub = esub;
            this.tsub = tsub;
            this.mns = mns;
        }

        public NotificationManager(List<String> esub, List<string> tsub, SendNotification sn)
        {
            InitializeComponent();
            this.esub = esub;
            this.tsub = tsub;
            this.sn = sn;
        }

        private void Subscribe_Click(object sender, EventArgs e)
        {
            mns= new ManageNotificationSubscription(this.esub, this.tsub, this);
            this.Hide();
            mns.ShowDialog();
        }

        private void publishnotification_Clicked(object sender, EventArgs e)
        {
            sn = new SendNotification(this.esub, this.tsub, this);
            this.Hide();
            this.Close();
            sn.ShowDialog();
        }

        internal void enablepublish()
        {
            publishNotification.Enabled = true;
        }

        internal void disablepublish()
        {
            publishNotification.Enabled = false;
        }

        private void ExitNotificationManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
