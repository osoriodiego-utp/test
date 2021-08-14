using System;
using System.Collection.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        public static List<int> Change(List<int> houses, int days)
        {
            var cell = houses.ToList();
            var res = new List<int>();
            for (int i =0; i<days; i++)
            {
                for (int j=0; j<houses.Count; j++{
                    var left = i == 0 ? 0 : houses[i-1];
                    var right = i == cell.Count - 1 ? 0 : cell[i+1];

                    res.Add(left == der ? 0 : 1);
                }

                cell = res.ToList();
            }
        }
        static void Main(string[] args)
        {
            // var houses = new List<int> {1,0,0,0,0,1,0,0}
            var houses = new List<int> {1,1,1,0,1,1,1,1};
            var days = 1;
            var res = Change(houses, days);
        }
    }
}