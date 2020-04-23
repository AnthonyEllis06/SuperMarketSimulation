// //////////////////////////////////////////////////////////////////////////////////////
// Project:			SuperMarketSimulation
// File Name: 		Event.cs
// Description: 	Defines and generates events
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
    /// Enum EVENTTYPE
    /// </summary>
    enum EVENTTYPE { ARRIVAL, lEAVE }
    enum EventEnum { ENTER, LEAVE }
    /// <summary>
    /// Class Event.
    /// </summary>
    class Event:IComparable
    {
        
        #region Properties
        /// <summary>
        /// Gets or sets the current customer.
        /// </summary>
        /// <value>The curr customer.</value>
        public Customer CurrCustomer { get; set; }

        public DateTime Time  { get; set; }
        public EVENTTYPE Type { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        public Event() { }
        #endregion

        #region Overridden Methods 
        
        /// <summary>
        /// Compares the current instance with another object of the same type and returns an
        /// integer that indicates whether the current instance precedes, follows, or occurs in
        /// the same position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>A value that indicates the relative order of the objects being compared. The return value
        /// has these meanings: Value Meaning Less than zero This instance precedes <paramref name="obj" /> in
        /// the sort order. Zero This instance occurs in the same position in the sort order
        /// as <paramref name="obj" />. Greater than zero This instance follows <paramref name="obj" /> in the sort order.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public int CompareTo(object obj)
        {
            if(!(obj is Event))
                throw new ArgumentException("The argument is not an Event object");
            Event e = (Event) obj;
            return (e.Time.CompareTo(Time));
        }

        public override string ToString()
        {
            String str = "";
            return string.Format("Customer {0} ", CurrCustomer.ToString());
        }

        #endregion
    }
}
