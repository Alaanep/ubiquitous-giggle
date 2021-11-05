using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExample
{
    public class NumbersList
    {
        private List<int> _numbers = new List<int>();

        public void AddListItems(int nr)
        {
            if (nr < 100)
            {
                _numbers.Add(nr);
            }
        }

        public int GetListLength()
        {
            return _numbers.Count;
        }

        public void ClearList()
        {
            _numbers.Clear();
        }

        public int FindSumOfListItems()
        {
            int sum=0;
            foreach (int number in _numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int FindMiddleListItem()
        {
            if (_numbers.Count == 0)
            {
                return 0;
            }
            int middleIndex = _numbers.Count / 2;
            return _numbers[middleIndex];
        }
    }
}
