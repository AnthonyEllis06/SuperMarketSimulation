// //////////////////////////////////////////////////////////////////////////////////////
// Project:			SuperMarketSimulation
// File Name: 		IContainer.cs
// Description: 	Container interface used in collections.
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
    /// Interface IContainer for collections
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IContainer<T>
    {
        /// <summary>
        /// Clears the contents of the container.
        /// </summary>
        void Clear();

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns><c>true</c> if this instance is empty; otherwise, <c>false</c>.</returns>
        bool IsEmpty();

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>The count.</value>
        int Count { get; set; }
    }
}
