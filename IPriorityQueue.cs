// //////////////////////////////////////////////////////////////////////////////////////
// Project:			SuperMarketSimulation
// File Name: 		IPriorityQueue.cs
// Description: 	Priority Queue Interface Class
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
    /// Interface IPriorityQueue
    /// Implements the <see cref="SuperMarketSimulation.IContainer{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="SuperMarketSimulation.IContainer{T}" />
    public interface IPriorityQueue<T> : IContainer<T>
                            where T : IComparable
    {
        /// <summary>
        /// Enqueues the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        void Enqueue(T item);
        /// <summary>
        /// Dequeues this instance.
        /// </summary>
        void Dequeue();
        /// <summary>
        /// Peeks this instance.
        /// </summary>
        /// <returns>T.</returns>
        T Peek();
    }
}
