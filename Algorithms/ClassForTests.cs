using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms
{
    [DisplayInfo("Tests", "Class For Tests", typeof(List<int>))]
    class ClassForTests
    {
        public List<int> Go()
        {

            var r = true && (true || false && false);
            r = false && (false || true && false);
            r = true && (true || false && false);

            r = true && (true || false) && false;
            r = false && (true || true) && false;
            r = true && (true || false) && false;


            r = false && true || true && true;

            r = false || false && true;
            r = (false || false) && true;
            r = false && true || false && true;

            r = true || false && true;
            r = (true || false) && true;
            r = true && false || true && true;

            r = true || true && true;
            r = (true || true) && true;
            r = true && true || true && true;

            List<int> l = new List<int>();
            var t = l.First();
            DateTime timeUtc = DateTime.UtcNow;
            TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            DateTime pstTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, pstZone);
       
            DateTime dt1 = DateTime.Parse("Dec 03, 2003 12:00:00 AM");
            var ut = dt1.AddHours(3);
            dt1 = DateTime.Parse("Dec 03, 2003 12:00:00 AM");
            dt1 = dt1.ToUniversalTime().AddHours(3).ToLocalTime();

            dt1 = DateTime.Parse("Dec 03, 2003 12:00:00 AM");
            DateTime dt2 = DateTime.Parse("Dec 03, 2003 00:10:00 AM");
            var res = dt1.TimeOfDay.CompareTo(dt2.TimeOfDay);
            int [] arr = new int[0];
           
            Dictionary<int, List<MyClass>> d = new Dictionary<int, List<MyClass>>();
            d.Add(1, new List<MyClass> {new MyClass(), new MyClass(), new MyClass() });
            d.Add(2, new List<MyClass> { new MyClass() });

            var f = d.Max(x => x.Value.Count);

            return new List<int>();
        }


        class MyClass
        {
            
        }
    }
}
