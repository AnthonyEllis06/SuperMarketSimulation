// //////////////////////////////////////////////////////////////////////////////////////
// Project:			SuperMarketSimulation
// File Name: 		Node.cs
// Description: 	Generic Node Class
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
    /// Class Node.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T> where T:IComparable
    {
        #region Properties

        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        /// <value>The item.</value>
        public T Item { get; set; }
        /// <summary>
        /// Gets or sets the next.
        /// </summary>
        /// <value>The next.</value>
        public Node<T> Next { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="next">The next.</param>
        public Node(T item, Node<T> next)
        {
            Item = item;
            Next = next;
        }

        #endregion
    }
}
