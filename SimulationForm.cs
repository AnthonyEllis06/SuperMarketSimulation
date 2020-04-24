using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketSimulation
{
    public partial class SimulationForm : Form
    {
        private Simulation Simulate;
        private readonly String Pattern = @"^(20|21|22|23|[01]d|d)(([:][0-5]d){1,2})$";
        public SimulationForm()
        {
            InitializeComponent();
        }



        private void ValuesChanged()
        {
            if (NumCustomerUpDown.Value > 0 &&
                TimeStartUpDown.Value >0 &&
                TimeCloseUpDown.Value > 0 &&
                NumRegisterUpDown.Value > 0 &&
                CheckOutDurUpDown.Value > 0)
            {
                StartButton.Enabled = true;
            }
            else
            {
                StartButton.Enabled = false;
            }
        }

        private void NumCustomerUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValuesChanged();
        }


        private void NumRegisterUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValuesChanged();
        }

        private void CheckOutDurUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValuesChanged();
        }

        private void TimeStartUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValuesChanged();
        }

        private void TimeCloseUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValuesChanged();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {

            Simulate = new Simulation(NumCustomerUpDown);
        }
    }
}
