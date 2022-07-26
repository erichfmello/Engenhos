using Teste002.Models;
using System.Windows.Forms;

namespace Teste002
{
    public partial class Form1 : Form
    {
        Bateria bateria = new Bateria();
        Lanterna lanterna = new Lanterna();

        public Form1()
        {
            InitializeComponent();
            Start();
        }

        #region ChangeFrontInformations
        private void Start()
        {
            lblBatery.Text = $"{bateria.Charge}% de bateria";

            if (lanterna.IsOn)
            {
                btnTurn.Text = "Desligar";
                lblLaterna.Text = "Lanterna ligada";
            }

            if (!lanterna.IsOn)
            {
                btnTurn.Text = "Ligar";
                lblLaterna.Text = "Lanterna desligada";
            }
        }
        #endregion ChangeFrontInformations

        #region Events
        private void btnTurn_Click(object sender, System.EventArgs e)
        {
            if (bateria.Charge == 0 && !lanterna.IsOn)
                return;

            lanterna.ChangeStatus();
            bateria.ChangeCharge();
            Start();
            ChangeTimerStatus();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            bateria = new Bateria();
            lanterna.IsOn = false;
            ChangeTimerStatus();
            Start();
        }
        #endregion Events

        #region Timer
        private void ChangeTimerStatus()
        {
            if (!lanterna.IsOn)
                TimerChangeChargeBatery.Stop();

            if (lanterna.IsOn)
            {
                TimerChangeChargeBatery.Start();
                TimerChangeChargeBatery.Tick += TimerChangeChargeBatery_Tick;
            }
        }

        private void TimerChangeChargeBatery_Tick(object sender, System.EventArgs e)
        {
            bateria.ChangeCharge();

            if (bateria.Charge == 0)
            {
                TimerChangeChargeBatery.Stop();
                lanterna.ChangeStatus();
                bateria.ChangeCharge();
            }

            Start();
        }
        #endregion Timer
    }
}