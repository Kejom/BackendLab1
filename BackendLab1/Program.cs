using System;
using System.Collections.Generic;

namespace BackendLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var testList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var fileActions = new FileActions();
            fileActions.WriteLines();
        }
    }
}
