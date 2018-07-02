using System;
using System.Collections.Generic;

namespace box_unbox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> BoxedData = new List<object>();
            BoxedData.Add(7);
            BoxedData.Add(28);
            BoxedData.Add(-1);
            BoxedData.Add(true);
            BoxedData.Add("Chair");
            var sum = 0;
            foreach (object box in BoxedData)
            {
                Console.WriteLine(box);
                if (box is int)
                {
                    sum += (int)box;
                };
            };
            Console.WriteLine(sum); 
        }
    }
}
