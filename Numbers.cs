using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POK_ZAD4
{
    public class Numbers
    {
        public Numbers()
        {
            NumberList = new List<int>();
            NumberList.Add(2);
            NumberList.Add(3);
            NumberList.Add(4);
            NumberList.Add(5);
            NumberList.Add(6);
        }

        public IList<int> NumberList { get; set; }

        public void AddNumber(int number)
        {
            NumberList.Add(number);
        }
        private double avargeFromList;
        public double AvargeFromList
        {
            get
            {
                avargeFromList = GetAvargeFromList(NumberList);
                return avargeFromList;
            }
        }
        double GetAvargeFromList(IList<int> numberList)
        {
            var sum = 0;
            foreach (var number in numberList)
            {
                sum += number;
            }
            var avarge = numberList.Count() > 0 ? sum / numberList.Count() : 0;
            return avarge;
        }

        public override string ToString()
        {
            var message = "Numbers on list:";
            foreach (var number in NumberList)
            {
                message += " " + number;
            }
            message += ". Avarge from this numbers is equal to: " + AvargeFromList;

            return message;

        }
    }
}
