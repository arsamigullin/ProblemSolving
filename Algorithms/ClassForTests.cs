using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Algorithms.Attributes;

namespace Algorithms
{
    [DisplayInfo("Tests", "Class For Tests", typeof(List<int>))]
    class ClassForTests
    {
        class Lang
        {
            public Lang(int name, bool val)
            {
                Name = name;
                IsEnabled = val;
            }
            public int Name { get; set; }
            public bool IsEnabled { get; set; }
        }

        class Org
        {
            public Dictionary<int, VideoLang> VideoLangs { get; set; }
        }

        class VideoLang
        {
            public Lang lang { get; set; }
            public VideoLang(Lang l)
            {
                lang = l;
            }
        }
        
        private void setLang(KeyValuePair<int, Lang> lLang)
        {
            lLang.Value.IsEnabled = false;
        }
        public List<int> Go()
        {

            List<List<int>> list = new List<List<int>>();
          //  list.Add(new List<int> {1,2,3});
          //  list.Add(new List<int> { 3,4,5 });
            var g = list.GroupBy(x => x.Count).FirstOrDefault();
            var sm = g.SelectMany(x => x);
            string  fg = "asdfasdf";
            var has = fg.GetHashCode();
            string s = "123";
            var sfd = s.Contains('%');
            List<int> mylist = new List<int>();
            mylist.Add(1);
            object ob = mylist.Select(x => new {MyInt = x});
            var rhd = ob.GetType();
            dynamic dym = ob;
            

            foreach (var vb in dym)
            {
                var fds = vb.T;
            }
            var nu = (int?) null;
            int? m = null;
            ConcurrentDictionary<int, Lang> ll = new ConcurrentDictionary<int, Lang>();
            ll.TryAdd(1, new Lang(1, true));
            ll.TryAdd(2, new Lang(2, true));
            Org o =new Org();
            o.VideoLangs = new Dictionary<int, VideoLang>();
            VideoLang vl;
            foreach (var lan in ll.Keys)
            {
                vl = new VideoLang(ll[lan]);
                o.VideoLangs.Add(lan, vl);
            }
            foreach (var kvp in ll)
            {
                setLang(kvp);
            }
            o.VideoLangs[1].lang.IsEnabled = true;


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
            var sdf =l.Distinct();
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
