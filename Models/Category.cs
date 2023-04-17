using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Task.Models
{
    internal class Category
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public Category(string name)
        {
            Id = ++_id;
            Name = name;    
        }
        public void Add(Product product)
        {
            Products.Add(product);
            string json = JsonConvert.SerializeObject(Products);
            using (StreamWriter sw = new StreamWriter(@"C:\Users\cngzl\OneDrive\Desktop\JSON_Task\jsonfile.json"))
            {
                sw.Write(json);
            }
        }



    }
}
