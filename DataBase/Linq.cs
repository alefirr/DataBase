using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataBase
{
    class Linq : IStrategy
    {
        List<Sights> info = new List<Sights>();
        XDocument doc = new XDocument();
        public Linq(string path)
        {
            doc = XDocument.Load(path);
        }
        public List<Sights> Algorithm(Sights sight, string path)
        {
                List<XElement> match = (from val in doc.Descendants("sight")
                                        where
                                        (sight.City == null || sight.City == Attrib("CITY", val)) &&
                                        (sight.Name == null || sight.Name == Attrib("NAME", val)) &&
                                        (sight.Type == null || sight.Type == Attrib("TYPE", val)) &&
                                        (sight.Height == null || sight.Height == Attrib("HEIGHT", val)) &&
                                        (sight.Age == null || sight.Age == Attrib("AGE", val))
                                        select val).ToList();
            
            foreach (XElement obj in match)
            {
                Sights sight1 = new Sights();
                try { sight1.City = obj.Attribute("CITY").Value; } catch { }
                try { sight1.Name = obj.Attribute("NAME").Value; } catch{ }
                try { sight1.Type = obj.Attribute("TYPE").Value;} catch { }
                try { sight1.Height = obj.Attribute("HEIGHT").Value; } catch { }
                try{ sight1.Age = obj.Attribute("AGE").Value; } catch { }
                info.Add(sight1);
            }
            return info;
        }

        private string Attrib(string att, XElement val)
        {
            try
            {
               return val.Attribute(att).Value;
            }
            catch { return null; }
        }
    }
}
