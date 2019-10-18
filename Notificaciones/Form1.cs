using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Notificaciones
{
    public partial class Form1 : Form
    {
        // Install-Package Tulpep.NotificationWindow


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        public void Toasty()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.toasty;
            popup.ImageSize = new Size(400, 400);
            popup.ImagePadding = new Padding(0);

            popup.IsRightToLeft = true;
            popup.ShowOptionsButton = false;
            popup.ContentText = "";

            popup.HeaderHeight = 1;
            popup.HeaderColor = Color.Transparent;
            popup.BodyColor = Color.Transparent;
            popup.BodyColor = Color.Transparent;

            popup.ButtonBorderColor = Color.Transparent;
            popup.AnimationDuration = 200;
            popup.AnimationInterval = 1;
            popup.Delay = 3000;
            popup.ShowGrip = false;

            popup.ShowOptionsButton = false;
            popup.Scroll = true;
            popup.Size = new System.Drawing.Size(400, 400);
            popup.ContentPadding = new Padding(1000);
            popup.Popup();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Toasty();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 9000;
        }
    }
}
