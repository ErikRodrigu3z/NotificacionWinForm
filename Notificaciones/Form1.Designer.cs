namespace Notificaciones
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEnableTimer = new System.Windows.Forms.CheckBox();
            this.txtInterval = new System.Windows.Forms.MaskedTextBox();
            this.btnTimer = new System.Windows.Forms.Button();
            this.txtImgH = new System.Windows.Forms.MaskedTextBox();
            this.txtImgW = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImgPadding = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPopupW = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPopupH = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIntervalo = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.MaskedTextBox();
            this.txtDelay = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Popup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Intervalo de Timer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimer);
            this.groupBox1.Controls.Add(this.txtInterval);
            this.groupBox1.Controls.Add(this.chkEnableTimer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // chkEnableTimer
            // 
            this.chkEnableTimer.AutoSize = true;
            this.chkEnableTimer.Checked = true;
            this.chkEnableTimer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableTimer.Location = new System.Drawing.Point(15, 64);
            this.chkEnableTimer.Name = "chkEnableTimer";
            this.chkEnableTimer.Size = new System.Drawing.Size(130, 17);
            this.chkEnableTimer.TabIndex = 3;
            this.chkEnableTimer.Text = "Habilitar / Deshabilitar";
            this.chkEnableTimer.UseVisualStyleBackColor = true;
            this.chkEnableTimer.CheckedChanged += new System.EventHandler(this.chkEnableTimer_CheckedChanged);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(15, 38);
            this.txtInterval.Mask = "0000000000000000000000000000";
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(177, 20);
            this.txtInterval.TabIndex = 4;
            this.txtInterval.Text = "9000";
            this.txtInterval.ValidatingType = typeof(int);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(198, 36);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(33, 23);
            this.btnTimer.TabIndex = 5;
            this.btnTimer.Text = "ok";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // txtImgH
            // 
            this.txtImgH.Location = new System.Drawing.Point(159, 36);
            this.txtImgH.Mask = "0000000";
            this.txtImgH.Name = "txtImgH";
            this.txtImgH.Size = new System.Drawing.Size(55, 20);
            this.txtImgH.TabIndex = 4;
            this.txtImgH.Text = "400";
            this.txtImgH.ValidatingType = typeof(int);
            // 
            // txtImgW
            // 
            this.txtImgW.Location = new System.Drawing.Point(9, 35);
            this.txtImgW.Mask = "0000000";
            this.txtImgW.Name = "txtImgW";
            this.txtImgW.Size = new System.Drawing.Size(55, 20);
            this.txtImgW.TabIndex = 5;
            this.txtImgW.Text = "400";
            this.txtImgW.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtImgPadding);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtImgW);
            this.groupBox2.Controls.Add(this.txtImgH);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 62);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Padding";
            // 
            // txtImgPadding
            // 
            this.txtImgPadding.Location = new System.Drawing.Point(85, 35);
            this.txtImgPadding.Mask = "0000000";
            this.txtImgPadding.Name = "txtImgPadding";
            this.txtImgPadding.Size = new System.Drawing.Size(55, 20);
            this.txtImgPadding.TabIndex = 8;
            this.txtImgPadding.Text = "0";
            this.txtImgPadding.ValidatingType = typeof(int);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtPopupH);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtPopupW);
            this.groupBox3.Location = new System.Drawing.Point(12, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 64);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Popup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Width";
            // 
            // txtPopupW
            // 
            this.txtPopupW.Location = new System.Drawing.Point(15, 34);
            this.txtPopupW.Mask = "0000000";
            this.txtPopupW.Name = "txtPopupW";
            this.txtPopupW.Size = new System.Drawing.Size(55, 20);
            this.txtPopupW.TabIndex = 7;
            this.txtPopupW.Text = "400";
            this.txtPopupW.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Height";
            // 
            // txtPopupH
            // 
            this.txtPopupH.Location = new System.Drawing.Point(85, 35);
            this.txtPopupH.Mask = "0000000";
            this.txtPopupH.Name = "txtPopupH";
            this.txtPopupH.Size = new System.Drawing.Size(55, 20);
            this.txtPopupH.TabIndex = 9;
            this.txtPopupH.Text = "400";
            this.txtPopupH.ValidatingType = typeof(int);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtIntervalo);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtDuracion);
            this.groupBox4.Controls.Add(this.txtDelay);
            this.groupBox4.Location = new System.Drawing.Point(12, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 64);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Animación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Intervalo";
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.Location = new System.Drawing.Point(85, 35);
            this.txtIntervalo.Mask = "0000000";
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(55, 20);
            this.txtIntervalo.TabIndex = 14;
            this.txtIntervalo.Text = "1";
            this.txtIntervalo.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Delay";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Duración";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(9, 35);
            this.txtDuracion.Mask = "0000000";
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(55, 20);
            this.txtDuracion.TabIndex = 11;
            this.txtDuracion.Text = "200";
            this.txtDuracion.ValidatingType = typeof(int);
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(159, 36);
            this.txtDelay.Mask = "0000000";
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(55, 20);
            this.txtDelay.TabIndex = 10;
            this.txtDelay.Text = "3000";
            this.txtDelay.ValidatingType = typeof(int);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Notificaciones.Properties.Resources.toasty;
            this.pictureBox1.Location = new System.Drawing.Point(259, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.7D;
            this.Text = "Toasty";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkEnableTimer;
        private System.Windows.Forms.MaskedTextBox txtInterval;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.MaskedTextBox txtImgH;
        private System.Windows.Forms.MaskedTextBox txtImgW;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtImgPadding;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtPopupH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtPopupW;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtIntervalo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtDuracion;
        private System.Windows.Forms.MaskedTextBox txtDelay;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

