using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////////////////////////////////////////////////////////////////////////////////////////
//
// Project:			SuperMarketSimulation
// File Name: 		Simulation.cs
// Description: 	This class simulates all the customers in the supermarket
// Course:			CSCI 2210-001 - Data Structures
// Author:			Hiren Patel, patelhm@etsu.edu, East Tennessee State University
// Created:			04-22-2020
//
// ///////////////////////////////////////////////////////////////////////////////////////
namespace SuperMarketSimulation
{
    class Simulation
    {
		#region Properties
		private Random rand = new Random();	

        public bool CheckedOut 
		{ 
			get; set; 
		} 

        public int NumOfCustomers 
		{
			get; set; 
		}

        public int NumOfRegisters 
		{
			get; set; 
		}

		public DateTime StartTime
		{
			get; set;
		}

		public DateTime EndTime
		{
			get; set;
		}

		public TimeSpan AvgCheckoutTime
		{
			get; set;
		}

		public List<Queue<Customer>> InLine
		{
			get; set;
		}

		public PriorityQueue<Event> EventPriorityQueue
		{
			get; set;
		}

		public int LargestQueue
		{
			get; set;
		}

		public int TotalArrivals
		{
			get; set;
		}

		public int TotalCheckouts
		{
			get; set;
		}

		public int TotalEvents
		{
			get; set;
		}

		public TimeSpan ShortestTime
		{
			get; set;
		}

		public TimeSpan LongestTime
		{
			get; set;
		}

		public TimeSpan TotalTime
		{
			get; set;
		}
		#endregion

		#region Constructors
		public Simulation()
		{
			CheckedOut = false;
			NumOfCustomers = 0;
			NumOfRegisters = 0;
			LargestQueue = 0;
			TotalArrivals = 0;
			TotalCheckouts = 0;
			TotalEvents = 0;
			StartTime = DateTime.Now;
			EndTime = DateTime.Now;
			ShortestTime = new TimeSpan(0, 2, 0);
			LongestTime = new TimeSpan(0, 0, 0);
			AvgCheckoutTime = new TimeSpan(0, 0, 0);
			InLine = new List<Queue<Customer>>();
			EventPriorityQueue = new PriorityQueue<Event>();
		}

		public Simulation(int PCustomers, int numOfRegisters, 
			DateTime startTime, DateTime endTime, TimeSpan avgCheckoutTime)
		{
			CheckedOut = false;
			NumOfRegisters = numOfRegisters;
			StartTime = startTime;
			EndTime = endTime;
			AvgCheckoutTime = avgCheckoutTime;
			ShortestTime = new TimeSpan(0, 2, 0);
			LongestTime = new TimeSpan(0, 0, 0);
			LargestQueue = 0;
			TotalArrivals = 0;
			TotalCheckouts = 0;
			TotalEvents = 0;
			NumOfCustomers = Poisson(PCustomers);
			InLine = new List<Queue<Customer>>();
			EventPriorityQueue = new PriorityQueue<Event>();
			StartSimulation();
		}
		#endregion

		#region Methods
		private int Poisson(int PCustomers)
		{
			double Limit = -PCustomers;
			double Total = Math.Log(rand.NextDouble());

			int i;
			for (i = 0; Total > Limit; i++)
				Total += Math.Log(rand.NextDouble());

			return i;
		} // end Poisson

		private double Negex(double Value)
		{
			return -Value * Math.Log(rand.NextDouble(), Math.E);
		}

		private void StartSimulation()
		{
			for (int register = 0; register < NumOfRegisters; register++)
			{
				InLine.Add(new Queue<Customer>());
			}
			ArrivalEvent();
		}

		private Queue<Customer> GetShortLine()
		{
			Queue<Customer> shortLine = InLine[0];

			// Search for the shortest line
			for (int i = 1; i < InLine.Count && InLine.Count > 1; i++)
			{
				if (shortLine.Count > InLine[i].Count)
					shortLine = InLine[i];
			}

			return shortLine;
		}

		public void Simulate()
		{
			Queue<Customer> shortLine = null;
			Queue<Customer> Line = null;

			if (EventPriorityQueue.IsEmpty())      // Indicates simulation is finished running
			{
				CheckedOut = true;
				return;
			}

			if (EventPriorityQueue.Peek().Type == EVENTTYPE.ARRIVAL)   // If the event is an arrival
			{
				// Find shortest line and add registrant
				shortLine = GetShortLine();
				shortLine.Enqueue(EventPriorityQueue.Peek().CurrCustomer);

				// Increment if new largest queue found
				if (shortLine.Count > LargestQueue)
				{
					LargestQueue++;
				}

				// Generate departure event if this customer is at the front of the line
				if (shortLine.Count == 1)
				{
					LeaveEvent(shortLine.Peek());
				}
					

				// Event completely handled; remove the event and add to counter
				EventPriorityQueue.Dequeue();
				TotalArrivals++;
				TotalEvents++;
			}
			else    // If the event is a departure
			{
				// Get the line that registrant is about to leave
				for (int i = 0; i < InLine.Count; i++)
				{
					if (InLine[i].Count > 0)
					{
						if (InLine[i].Peek().CustomerID == EventPriorityQueue.Peek().CurrCustomer.CustomerID)
						{
							Line = InLine[i];
							break;
						}
					}
				}

				// Remove registrant from wait line
				Line.Dequeue();
				TotalCheckouts++;
				TotalEvents++;

				// If the wait line is not empty, generate a departure event for the next registrant
				if (Line.Count > 0)
				{
					LeaveEvent(Line.Peek());
				}
		
				// Departure event handled; remove from Priority Queue
				EventPriorityQueue.Dequeue();
			}
		} // end RunSimulation
		#endregion

		#region Arrival and Leave Events
		private void ArrivalEvent()
		{
			TimeSpan Start;
			TimeSpan Open;

			Open = EndTime - StartTime;

			for (int customer = 1; customer <= NumOfCustomers; customer++)
			{
				Start = new TimeSpan(0, 0, rand.Next((int)Open.TotalMinutes));

				Event e = new Event(EVENTTYPE.ARRIVAL, (StartTime + Start));

				Customer c = new Customer(customer, e);

				e.CurrCustomer = c; 
				c.ArrivalTime = e;

				EventPriorityQueue.Enqueue(e);
			}
		}

		private void LeaveEvent(Customer customer)
		{
			// generates a random interval for how long the person takes, with a minimum of 1 minute
			// and 30 seconds
			TimeSpan waiting = new TimeSpan(0, 0, (int)(120 + Negex(AvgCheckoutTime.TotalSeconds - 120)));

			// Creates departure event based on the time interval plus the time we are currently
			// at in the Priority Queue
			Event e = new Event(EVENTTYPE.LEAVE, ((EventPriorityQueue.Peek().Time + waiting)));

			//Associates departure event with registrant
			e.CurrCustomer = customer;
			customer.Leave = e;

			// Adds departure event to the queue
			EventPriorityQueue.Enqueue(e);

			// Update wait times for statistic counters
			TotalTime += waiting;

			if (waiting > LongestTime)
			{
				LongestTime = waiting;
			}

			if (waiting < ShortestTime)
			{
				ShortestTime = waiting;
			}
		}
        #endregion

        #region ToString
        public override string ToString()
		{
			string display = string.Empty;

			for (int i = 0; i < InLine.Count; i++)
			{
				display += $"Register {(i + 1).ToString().PadLeft(3)}: ";

				if (InLine[i].Count > 0)
				{
					display += $"{InLine[i].Peek()}";

					for (int n = 0; n < InLine[i].Count - 1; n++)
						display += "| #### ";
				}

				display += "\r\n";
			}

			return display;
		}
        #endregion
    }
}