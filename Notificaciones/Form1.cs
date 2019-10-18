using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Notificaciones
{
    public partial class Form1 : Form
    {
        // Install-Package Tulpep.NotificationWindow
        int interval = 9000;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toasty();
        }

        public void Toasty()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.toasty;
            popup.ImageSize = new Size(int.Parse(txtImgW.Text),int.Parse(txtImgH.Text));
            popup.ImagePadding = new Padding(int.Parse(txtImgPadding.Text));

            popup.IsRightToLeft = true;
            popup.ShowOptionsButton = false;
            popup.ContentText = "";

            popup.HeaderHeight = 1;
            popup.HeaderColor = Color.Transparent;
            popup.GradientPower = 100;
            popup.BodyColor = Color.Transparent;
            popup.BodyColor = Color.Transparent;

            popup.ButtonBorderColor = Color.Transparent;
            popup.AnimationDuration = int.Parse(txtDuracion.Text);
            popup.AnimationInterval = int.Parse(txtIntervalo.Text);
            popup.Delay = int.Parse(txtDelay.Text);
            popup.ShowGrip = false;

            popup.ShowOptionsButton = false;
            popup.Scroll = true;
            popup.Size = new System.Drawing.Size(int.Parse(txtPopupW.Text), int.Parse(txtPopupH.Text));
            popup.ContentPadding = new Padding(1000);
            popup.Popup();

            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.toastySound);           
            simpleSound.Play();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Toasty();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = interval;
        }

        private void chkEnableTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableTimer.Checked)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(txtInterval.Text);
        }
    }
}
