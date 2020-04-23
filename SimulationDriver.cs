// //////////////////////////////////////////////////////////////////////////////////////
// Project:			SuperMarketSimulation
// File Name: 		SimulationDriver.cs
// Description: 	The Driver file containing the main method.
// Course:			CSCI 2210-001 - Data Structures
// Author:			Anthony Ellis, ellisah@etsu.edu, East Tennessee State University
// Created:			04-22-2020
//
// ///////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketSimulation
{
    /// <summary>
    /// Class SimulationDriver is used to call the main method.
    /// </summary>
    static class SimulationDriver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SimulationForm());
        }
    }
}
