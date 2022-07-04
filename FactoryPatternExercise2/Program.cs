using System;
using System.Threading;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctInput;
            do 
            {
                Console.Clear();
                correctInput = true;
                Console.WriteLine("what is the data base that you would like to use?");
                Console.WriteLine("Type:sql");
                Console.WriteLine("Type:Mongo");
                Console.WriteLine("Type:list");


                userInput = Console.ReadLine();

                if(userInput != "sql"&&userInput!="mongo"&&userInput!="list")
                {
                    correctInput = false;
                    Console.WriteLine("Bad input!");
                    Thread.Sleep(100);
                }
            } while (!correctInput);

            IDataAccess db=DataAccessFactory.GetDataAccessType(userInput);
            var products = db.LoadData();
            db.SaveData();

            foreach (var item in products)
            {
                Console.WriteLine($"Name:{item.Name} Price:{item.Price}");

            }

        }
    }
}
