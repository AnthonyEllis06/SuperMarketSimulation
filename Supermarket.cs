// //////////////////////////////////////////////////////////////////////////////////////
// Project:			SuperMarketSimulation
// File Name: 		Supermarket.cs
// Description: 	Supermarket class defines the registers and .
// Course:			CSCI 2210-001 - Data Structures
// Author:			Anthony Ellis, ellisah@etsu.edu, East Tennessee State University
// Created:			04-22-2020
//
// ///////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketSimulation
{
    /// <summary>
    /// Class Supermarket.
    /// </summary>
    class Supermarket
    {
        #region MyRegion
        public int EventCounter { get; set; }
        public int Arrivals { get; set; }
        public int Departures { get; set; }
        public int LongestQueue { get; set; }
        public PriorityQueue<Event> Events;
        public List<Queue<Customer>> Registers;
        public int NumCustomers;
        public int NumHours;
        public int NumRegisters;
        public Double ExpectedTime;
        #endregion

        #region Constructor
        public Supermarket(int numCustomers, int numHours, int numRegisters, Double expectedTime)
        {
            NumCustomers = numCustomers;
            NumHours = numHours;
            NumRegisters = numHours;
            ExpectedTime = expectedTime;
            for (int i = 0; i < NumRegisters; i++)
            {
                Registers.Add(new Queue<Customer>());
            }
        }
        #endregion

        #region Methods

        

        #endregion
    }
}
