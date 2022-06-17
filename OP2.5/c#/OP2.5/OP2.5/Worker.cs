using System;
using System.Collections.Generic;

namespace OP2._5
{
    public class Worker
    {
        public Dictionary<Time, Money> getValues()
        {
            Random random = new Random();
            Console.Write("enter the number of workers:");
            int n = int.Parse(Console.ReadLine());
            Dictionary<Time, Money> people = new Dictionary<Time, Money>();
            for (int i = 0; i < n; i++)
            {
                people.Add(new Time(random.Next(0, 24), (random.Next(0, 59))),
                    new Money(random.Next(0, 10), (random.Next(0, 99))));
            }

            return people;
        }

        public void Print(Dictionary<Time, Money> people)
        {
            int workersCounter = 1;
            foreach (var worker in people)
            {
                Console.WriteLine($"worker {workersCounter} : {worker.Key}-{worker.Value}");
                workersCounter++;
            }
        }
        public void PrintPayment(Money[] money)
        {
            int workerCounter = 1;
            foreach (var workermoney in money)
            {
                Console.WriteLine($"worker {workerCounter} : {workermoney}");
                workerCounter++;
            }
        }


        public Money[] GetTax(Dictionary<Time, Money> people)
        {
            List<Money> payment = new List<Money>();
            int counter = 0;
            foreach (var employee in people)
            {
                var taxTime = employee.Key;
                while (taxTime.Key > -1)
                {
                    employee.Key.Decrem() ;
                    counter++;
                }
                counter--;
                payment.Add(new Money(employee.Value.Key * counter, employee.Value.Value * counter));
                

            }

            return payment.ToArray();
        }

        /*public Money[] TryPay(Dictionary<Time, Money> people)
        {
            List<Money> pay = new List<Money>();
            foreach (var worker in people)
            {
                var taxTime = worker.Key;
                var taxMoney = worker.Value;
                int counter = 0;
                while (taxTime.Key >= 0)
                {
                    worker.Key.Decrem() ;
                    counter++;
                }
                taxMoney 
                if (taxMoney!=null) pay.Add(taxMoney) ;
            }
        }*/
    }
}