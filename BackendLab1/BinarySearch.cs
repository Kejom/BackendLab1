using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendLab1
{
    public class BinarySearch
    {
        public int BinarySort(List<int> listToSearch, int valToSearch)
        {
            if (listToSearch.Count == 0)
                return -1;

            var index = 0;
            var limit = listToSearch.Count - 1;

            while (limit - index > 1)
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
