using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataBase
{
    class Sax : IStrategy
    {
        List<Sights> info = new List<Sights>();

        public Sax(string path) { }

        public List<Sights> Algorithm(Sights sight, string path)
        {
            info.Clear();
            var TheReader = new XmlTextReader(path);

            List<Sights> result = new List<Sights>();
            Sights st = null;

            while (TheReader.Read())
            {
                if (TheReader.Name == "sight")
                {
                    if (st == null)
                    {
                        st = new Sights();

                    }
                    else
                    {
                        st = new Sights();
                    }


                    if (TheReader.HasAttributes)
                    {
                        
                            while (TheReader.MoveToNextAttribute())
                            {

                                if (TheReader.Name == "NAME")
                                {
                                    st.Name = TheReader.Value;
                                }

                                if (TheReader.Name == "CITY")
                                {
                                    st.City = TheReader.Value;
                                }

                                if (TheReader.Name == "TYPE")
                                {
                                    st.Type = TheReader.Value;
                                }

                                if (TheReader.Name == "HEIGHT")
                                {
                                    st.Height = TheReader.Value;
                                }

                                if (TheReader.Name == "AGE")
                                {
                                    st.Age = TheReader.Value;
                                }
                            }
                        
                        result.Add(st);
                    }
                }
            }
            info = Filtr(result, sight);
            return info;
        }

        public List<Sights> Filtr(List<Sights> allSigh, Sights param)
        {
            List<Sights> result = new List<Sights>();
            
            if (allSigh != null)
            {
                foreach (Sights e in allSigh)
                {
                   
                        if (
                            (e.City == param.City || param.City == null) &&
                            (e.Name == param.Name || param.Name == null) &&
                            (e.Type == param.Type || param.Type == null) &&
                            (e.Height == param.Height || param.Height == null) &&
                            (e.Age == param.Age || param.Age == null)
                            ) result.Add(e);
                   
                }
            }
            return result;
        }
    }
}
