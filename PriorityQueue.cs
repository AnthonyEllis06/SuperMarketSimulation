// //////////////////////////////////////////////////////////////////////////////////////
// Project:			SuperMarketSimulation
// File Name: 		PriorityQueue.cs
// Description: 	Generic Priority Queue Class
// Course:			CSCI 2210-001 - Data Structures
// Author:			Anthony Ellis, ellisah@etsu.edu, East Tennessee State University
// Created:			04-22-2020
//
// ///////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketSimulation
{
    /// <summary>
    /// Class PriorityQueue.
    /// Implements the <see cref="SuperMarketSimulation.IPriorityQueue{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="SuperMarketSimulation.IPriorityQueue{T}" />
    public class PriorityQueue<T> : IPriorityQueue<T>
                            where T : IComparable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>The count.</value>
        public int Count { get; set; }
        /// <summary>
        /// The top
        /// </summary>
        private Node<T> Top;
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PriorityQueue{T}"/> class.
        /// </summary>
        public PriorityQueue()
        {
            Top = null;
            Count = 0;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Enqueues the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Enqueue(T item)
        {
            if (Count == 0)
            {
                Top = new Node<T>(item, null);
            }
            else
            {
                Node<T> curr = Top;
                Node<T> prev = null;
                while (curr != null && curr.Item.CompareTo(item)>=0)
                {
                    prev = curr;
                    curr = curr.Next;
                }
                Node<T> newNode = new Node<T>(item,curr);
                if (prev != null)
                {
                    prev.Next = newNode;
                }
                else
                {
                    Top = newNode;
                }

                Count++;
            }
        }

        /// <summary>
        /// Dequeues this instance.
        /// </summary>
        /// <exception cref="InvalidOperationException">Cannot Remove from Empty queue.</exception>
        public void Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Cannot Remove from Empty queue.");
            }
            else
            {
                Node<T> oldNode = Top;
                Top = Top.Next;
                Count--;
                oldNode = null;
            }
        }

        /// <summary>
        /// Peeks this instance.
        /// </summary>
        /// <returns>T.</returns>
        /// <exception cref="InvalidOperationException">Cannot obtain top of empty priority queue.</exception>
        public T Peek()
        {
            if (!IsEmpty())
            {
                return Top.Item;
            }
            else
            {
                throw new InvalidOperationException("Cannot obtain top of empty priority queue.");
            }
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns><c>true</c> if this instance is empty; otherwise, <c>false</c>.</returns>
        public bool IsEmpty()
        {
            return Count == 0;
        }

        /// <summary>
        /// Clears the contents of the container.
        /// </summary>
        public void Clear()
        {
            Top = null;
        }
        #endregion


    }
}
