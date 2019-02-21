using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CA3AdvancedHorseRaceTipster
{
    public partial class Form1 : Form
    {
        List<HorseTip> HorseTips;

        public Form1()
        {
            InitializeComponent();

            HorseTips = new List<HorseTip>();
            new HorseTip { Course = "Aintree", Horse = "Johnny", Date = "2017/5/12", Distance = 11.58, Won = true };
            new HorseTip { Course = "Punchestown", Horse = "Jim", Date = "2016/12/22", Distance = 122.52, Won = true };
            new HorseTip { Course = "Sandown", Horse = "Speeder", Date = "2017/11/17", Distance = 20.00, Won = false };

        }

        

        private void btnBet_Click(object sender, EventArgs e)
        {
            lblBet.Enabled = true;
            lblBet.Visible = true;
            lblHorse.Visible = true;
            lblRacecourse.Visible = true;
            lblDate.Visible = true;
            lblDistance.Visible = true;
            lblResult.Visible = true;
            txtHorseName.Visible = true;
            txtRacecourse.Visible = true;
            txtDate.Visible = true;
            txtDistance.Visible = true;
            rblLost.Visible = true;
            rblWon.Visible = true;
            btnEnter.Visible = true;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            btnBet.Visible = true;
            lblBet.Visible = false;
            lblHorse.Visible = false;
            lblRacecourse.Visible = false;
            lblDate.Visible = false;
            lblDistance.Visible = false;
            lblResult.Visible = false;
            txtHorseName.Visible = false;
            txtRacecourse.Visible = false;
            txtDate.Visible = false;
            txtDistance.Visible = false;
            rblLost.Visible = false;
            rblWon.Visible = false;
            btnEnter.Visible = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            HorseTip tip = new HorseTip();
            tip.Course = txtRacecourse.Text;
            tip.Horse = txtHorseName.Text;
            tip.Date = txtDate.Text;
            tip.Distance = double.Parse(txtDate.Text);
            
        }
    }
}
