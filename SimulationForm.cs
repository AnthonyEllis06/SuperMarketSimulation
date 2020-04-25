using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketSimulation
{
    public partial class SimulationForm : Form
    {
        private Simulation Simulate;
        private readonly String HourMinPattern = @"((20|21|22|23)|(0\d)|(1\d)):([0-5]\d)";
        private readonly String MinSecondPattern = @"([0-5][\d]):([0-5][\d])";
        public SimulationForm()
        {
            InitializeComponent();
        }



        private void ValuesChanged()
        {
            if (NumCustomerUpDown.Value > 0 &&
                ValidateHours(OpenTimeInput.Text) &&
                ValidateHours(CloseStoreInput.Text) &&
                NumRegisterUpDown.Value > 0 &&
                ValidateMinutes(DurationTimeInput.Text))
            {
                StartButton.Enabled = true;
            }
            else
            {
                StartButton.Enabled = false;
            }
        }

        private bool ValidateHours(String TimeString)
        {
            Regex r = new Regex(HourMinPattern);
            Match match = r.Match(TimeString);
            return match.Success;
        }

        private bool ValidateMinutes(String TimeString)
        {
            Regex r = new Regex(MinSecondPattern);
            Match match = r.Match(TimeString);
            return match.Success;
        }

        private DateTime StringToHours(String hours)
        {
            DateTime h = DateTime.ParseExact(hours, "HH:mm", CultureInfo.InvariantCulture);
            return h;
        }

        private DateTime StringToMinutes(String minutes)
        {
            DateTime m = DateTime.ParseExact(minutes, "mm:ss",CultureInfo.InvariantCulture);
            return m;
        }

        private void NumCustomerUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValuesChanged();
        }


        private void NumRegisterUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValuesChanged();
        }

       private void StartButton_Click(object sender, EventArgs e)
       {
           TimeSpan t = new TimeSpan(0,StringToMinutes(DurationTimeInput.Text).Minute, StringToMinutes(DurationTimeInput.Text).Second);
           Simulate = new Simulation((int)NumCustomerUpDown.Value, (int)NumRegisterUpDown.Value,StringToHours(OpenTimeInput.Text), StringToHours(CloseStoreInput.Text),t);
           int events = (int)NumCustomerUpDown.Value * 2;
           while (Simulate.CheckedOut)
           {
               this.Refresh();
                Simulate.Simulate();
               RegistersTextBox.Text = $"{Simulate.ToString()}";
               
               Thread.Sleep(100);
           }
             


        }

        private void OpenTimeInput_TextChanged(object sender, EventArgs e)
        {
            ValuesChanged();
        }

        private void DurationTimeInput_TextChanged(object sender, EventArgs e)
        {
            ValuesChanged();
        }

        private void CloseStoreInput_TextChanged(object sender, EventArgs e)
        {
            ValuesChanged();
        }
    }
}
