using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class QueueDemo
    {
        public QueueDemo()
        {
            Queue<string> movieTicket = new Queue<string>();
            movieTicket.Enqueue("Sam Smith");
            movieTicket.Enqueue("John Doe");
            movieTicket.Enqueue("Tye Lee");
            movieTicket.Enqueue("Sammy Son");
            movieTicket.Enqueue("James Jade");

            Console.WriteLine("People in queue to buy movie ticket:");
            foreach (string person in movieTicket)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine($"\n\nTotal people in queue to buy movie ticket: {movieTicket.Count}");
            Console.WriteLine($"First Person in queue: {movieTicket.Peek()}");
            Console.WriteLine($"{movieTicket.Dequeue()} got ticket for the movie. So now he/she is not in queue.");
            Console.WriteLine($"Is Tye Lee still in queue? {movieTicket.Contains("Tye Lee")}");

            Console.WriteLine("\n");
            string person2 = "";
            while (movieTicket.TryDequeue(out person2))
            {
                Console.WriteLine($"{person2} got movie ticket");
            }
            Console.WriteLine($"\nTotal people in queue to buy movie ticket: {movieTicket.Count}");
        }
    }
}
