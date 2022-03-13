using System;
using System.Collections.Generic;

namespace BackendLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var testList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Console.WriteLine(BinarySort(testList, 15));
        }

        static int BinarySort(List<int> listToSearch, int valToSearch)
        {
            if (listToSearch.Count == 0)
                return -1;

            var index = 0;
            var limit = listToSearch.Count - 1;

            while(limit - index > 1)
            {
                var point = (int)Math.Ceiling((double)(index + limit) / 2);
                var pointVal = listToSearch[point];

                if (pointVal == valToSearch)
                    return point;

                if (valToSearch < pointVal)
                    limit = point;
                else
                    index = point;
            }
            if (listToSearch[index] == valToSearch)
                return index;
            return -1;
        }
    }
}
