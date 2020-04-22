// //////////////////////////////////////////////////////////////////////////////////////
// Project:			SuperMarketSimulation
// File Name: 		Customer.cs
// Description: 	Customer class used to define each customer.
// Course:			CSCI 2210-001 - Data Structures
// Author:			Anthony Ellis, ellisah@etsu.edu, East Tennessee State University
// Created:			04-22-2020
//
// ///////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketSimulation
{
    /// <summary>
    /// Class Customer creates and edits a customer that has a unique
    /// identifier number.
    /// </summary>
    class Customer
    {
        #region Properties
        /// <summary>
        /// Gets the customer unique identifier.
        /// </summary>
        /// <value>The customer's unique identifier.</value>
        public int CustomerID { get; private set; }
        /// <summary>
        /// Gets or sets the arrival time.
        /// </summary>
        /// <value>The arrival time.</value>
        public int ArrivalTime { get; set; } 
        /// <summary>
        /// Gets or sets the time to serve the customer at each register.
        /// </summary>
        /// <value>The time to serve.</value>
        public int TimeToServe { get; set; }
        #endregion

        #region Constructors


        #endregion

        #region Methods

        

        #endregion


    }
}
