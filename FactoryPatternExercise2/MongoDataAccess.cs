using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name="blender", Price= 150},
            new Product(){Name="Spirulina", Price= 55},
            new Product(){Name="DayQuil NyQuil", Price=28},
            new Product(){Name="Bolw", Price= 25},
        };
        public void SaveData()
        {
            Console.WriteLine("I am saving data from a Mongo Data Access.");
        }

        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine("I am reading data from Mongo data access");
            return Products;
        }
    }
}
