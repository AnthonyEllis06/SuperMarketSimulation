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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        /// <summary>
        /// Initializes a new  default instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer()
        {
            CustomerID = 0;
            TimeToServe = 0;
        }
        /// <summary>
        /// Initializes a new parameterized instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="id">The identifier used for each customer.</param>
        /// <param name="timeToServe">The time to serve the customer during the transaction.</param>
        public Customer(int id, int timeToServe)
        {
            CustomerID = id;
            TimeToServe = timeToServe;
        }

        #endregion

        #region Methods        
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return CustomerID.ToString();
        }

        #endregion


    }
}
