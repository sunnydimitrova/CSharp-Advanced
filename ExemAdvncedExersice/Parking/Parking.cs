using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private string type;
        private int capacity;
        private List<Car> data;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Data = new List<Car>();
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }        

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }       

        public List<Car> Data
        {
            get { return data; }
            set { data = value; }
        }

        public int Count => data.Count;
        public void Add(Car car)
        {

        }
    }
}
