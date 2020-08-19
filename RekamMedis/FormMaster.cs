using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Qios.DevSuite.Components.Ribbon;
using Qios.DevSuite.Components;
namespace RekamMedis
{
    public partial class FormMaster : QRibbonForm
    {
        public FormMaster()
        {
            this.BackgroundImage = Properties.Resources.limijati_hospital_2;
            InitializeComponent();
            Timer tm = new Timer();
            tm.Interval = 10000;
            tm.Tick += new EventHandler(changeImage);
            tm.Start();
        }

        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources.limijati_hospital_2);
            b1.Add(Properties.Resources._41405030762_065c1fbb58_o);
            b1.Add(Properties.Resources.modern_wallpaper_for_bedroom_bedroom_at_real_estate_10_wallpaper_rumah_sakit_yang_inspiratif);
            int index = DateTime.Now.Second % 3;
            this.BackgroundImage = b1[index];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        FormUser usr;
        FormDokter dktr;
        FormJadwalDokter jdwldokter;
        FormObat obt;
        FormTindakan tindakan;
        FormKamar kmr;
        FormPasien psn;
        private void qRibbonPanel2_ItemActivated(object sender, QCompositeEventArgs e)
        {
            if (usr == null)
            {
                usr = new FormUser();
                usr.MdiParent = this;
                usr.FormClosed += new FormClosedEventHandler(FormUser_FormClosed);
                usr.Show();
            }
            else
            {
                usr.Activate();
            }
        }

        private void FormUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            usr = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txttanngal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            txtjam.Text = DateTime.Now.ToString("hh:mm");
        }

        private void qRibbonPage3_Activated(object sender, EventArgs e)
        {

        }

        private void panel1item1_ItemActivated(object sender, QCompositeEventArgs e)
        {
            if (dktr == null)
            {
                dktr = new FormDokter();
                dktr.MdiParent = this;
                dktr.FormClosed += new FormClosedEventHandler(FormDokter_FormClosed);
                dktr.Show();
            }
            else
            {
                dktr.Activate();
            }
        }

        private void FormDokter_FormClosed(object sender, FormClosedEventArgs e)
        {
            dktr = null;
        }

        private void qRibbonPage1_Activated(object sender, EventArgs e)
        {

        }

        private void qRibbonItem1_ItemActivated(object sender, QCompositeEventArgs e)
        {
            if (usr == null)
            {
                usr = new FormUser();
                usr.MdiParent = this;
                usr.FormClosed += new FormClosedEventHandler(FormUser_FormClosed);
                usr.Show();
            }
            else
            {
                usr.Activate();
            }
        }

        private void panel1item2_ItemActivated(object sender, QCompositeEventArgs e)
        {
            if (jdwldokter == null)
            {
                jdwldokter = new FormJadwalDokter();
                jdwldokter.MdiParent = this;
                jdwldokter.FormClosed += new FormClosedEventHandler(FormJadwalDokter_FormClosed);
                jdwldokter.Show();
            }
            else
            {
                jdwldokter.Activate();
            }
        }

        private void FormJadwalDokter_FormClosed(object sender, FormClosedEventArgs e)
        {
            jdwldokter = null;
        }

        private void qRibbonItem2_ItemActivated(object sender, QCompositeEventArgs e)
        {
            if (obt == null)
            {
                obt = new FormObat();
                obt.MdiParent = this;
                obt.FormClosed += new FormClosedEventHandler(FormObat_FormClosed);
                obt.Show();
            }
            else
            {
                obt.Activate();
            }
        }

        private void FormObat_FormClosed(object sender, FormClosedEventArgs e)
        {
            obt = null;
        }

        private void qRibbonPage5_Activated(object sender, EventArgs e)
        {

        }

        private void qRibbonItem3_ItemActivated(object sender, QCompositeEventArgs e)
        {
            if (tindakan == null)
            {
                tindakan = new FormTindakan();
                tindakan.MdiParent = this;
                tindakan.FormClosed += new FormClosedEventHandler(FormTindakan_FormClosed);
                tindakan.Show();
            }
            else
            {
                tindakan.Activate();
            }
        }

        private void FormTindakan_FormClosed(object sender, FormClosedEventArgs e)
        {
            tindakan = null;
        }

        private void qRibbonPage6_Activated(object sender, EventArgs e)
        {

        }

        private void qRibbonItem4_ItemActivated(object sender, QCompositeEventArgs e)
        {
            if (kmr == null)
            {
                kmr = new FormKamar();
                kmr.MdiParent = this;
                kmr.FormClosed += new FormClosedEventHandler(FormKamar_FormClosed);
                kmr.Show();
            }
            else
            {
                kmr.Activate();
            }
        }
        private void FormKamar_FormClosed(object sender, FormClosedEventArgs e)
        {
            kmr = null;
        }

        private void qRibbonItem5_ItemActivated(object sender, QCompositeEventArgs e)
        {
            if (psn == null)
            {
                psn = new FormPasien();
                psn.MdiParent = this;
                psn.FormClosed += new FormClosedEventHandler(FormPasien_FormClosed);
                psn.Show();
            }
            else
            {
                psn.Activate();
            }
        }
        private void FormPasien_FormClosed(object sender, FormClosedEventArgs e)
        {
            psn = null;
        }
    }
}
