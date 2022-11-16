using System;
using System.Collections.Generic;
using System.Xml;

namespace DataBase
{
    class Dom : IStrategy
    {
        XmlDocument doc = new XmlDocument();
        public Dom(string path)
        {
            doc.Load(path);
        }
        public List<Sights> Algorithm(Sights sight, string path)
        {
            List<List<Sights>> info = new List<List<Sights>>();
            //try
            //{
                if (sight.Name != null)
                    info.Add(SearchByParam("NAME", sight.Name, doc));
                if (sight.City != null)
                    info.Add(SearchByParam("CITY", sight.City, doc));
                if (sight.Type != null)
                    info.Add(SearchByParam("TYPE", sight.Type, doc));
                if (sight.Height != null)
                    info.Add(SearchByParam("HEIGHT", sight.Height, doc));
                if (sight.Age != null)
                    info.Add(SearchByParam("AGE", sight.Age, doc));
            //}
            //catch { }
            if (sight.City == null && sight.Name == null && sight.Type == null && sight.Height == null && sight.Age == null)
                return AllSightss(doc);
            return Cross(info);
        }
        private Sights Info(XmlNode node)
        {
            Sights sight = new Sights();
            sight.Name = node.Attributes.GetNamedItem("NAME").Value;
            try { sight.City = node.Attributes.GetNamedItem("CITY").Value; } catch { }
            try { sight.Type = node.Attributes.GetNamedItem("TYPE").Value; } catch { }
            try { sight.Height = node.Attributes.GetNamedItem("HEIGHT").Value; } catch { }
            try { sight.Age = node.Attributes.GetNamedItem("AGE").Value; } catch { }
            return sight;
        }
        private List<Sights> AllSightss(XmlDocument doc)
        {
            List<Sights> data = new List<Sights>();
            XmlNodeList nodeList = doc.SelectNodes("//sight");
            //try
           // {
                foreach (XmlNode xml in nodeList)
                {
                    data.Add(Info(xml));
                }
           // }
           // catch { }
            return data;
        }
        private List<Sights> SearchByParam(string attribute, string param, XmlDocument doc)
        {
            List<Sights> sights = new List<Sights>();
            if (param != String.Empty && param != null)
            {
                XmlNodeList nodeList = doc.SelectNodes("//sight" + "[@" + attribute + "='" + param + "']");
                foreach (XmlElement element in nodeList)
                {
                    sights.Add(Info(element));
                }
            }
            return sights;
        }
        private List<Sights> Cross(List<List<Sights>> list)
        {
            List<Sights> result = new List<Sights>();
            try
            {
                if (list != null)
                {
                    Sights[] sights = list[0].ToArray();
                    if (sights != null)
                    {
                        foreach (Sights sight in sights)
                        {
                            bool isin = true;
                            foreach (List<Sights> sights1 in list)
                            {
                                foreach (Sights sight1 in sights1)
                                {
                                    isin = false;
                                    if (sight.Comparing(sight1))
                                    {
                                        isin = true;
                                        break;
                                    }
                                }
                                if (!isin)
                                    break;
                            }
                            if (isin)
                            {
                                result.Add(sight);
                            }
                        }
                    }
                }
            }
            catch
            { }
            return result;
        }

    }
}