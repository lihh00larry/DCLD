using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace DCLD.Model
{
    class ComboBoxLists
    {
        private readonly XDocument xdoc = XDocument.Load(ConfigurationManager.AppSettings["ComboBoxListXML"]);
        public List<string> Customer
        {
            get { return XmlToList("Customer"); }
            private set { }
        }
        public List<string> OccuredPhase
        {
            get { return XmlToList("OccuredPhase"); }
            private set { }
        }
        public List<string> Axle
        {
            get { return XmlToList("Axle"); }
            private set { }
        }
        public List<string> ProductType
        {
            get { return XmlToList("ProductType"); }
            private set { }
        }
        public List<string> ProductLine
        {
            get { return XmlToList("ProductLine"); }
            private set { }
        }
        public List<string> RodSize
        {
            get { return XmlToList("RodSize"); }
            private set { }
        }
        public List<string> PistonSize
        {
            get { return XmlToList("PistonSize"); }
            private set { }
        }
        public List<string> Status
        {
            get { return XmlToList("Status"); }
            private set { }
        }
        public List<string> PrimaryFailure
        {
            get { return XmlToList("PrimaryFailure"); }
            private set { }
        }
        public Dictionary<string, List<string>> FailedBy
        {
            get { return XmlToDict("FailedBy"); }
            private set { }
        }

        private List<string> XmlToList(string element)
        {
            List<string> list = new List<string>();
            var query = from item in xdoc.Descendants(element)
                        select item;
            foreach (var item in query.Descendants())
            {
                list.Add(item.Value);
            }
            return list;
        }

        private Dictionary<string, List<string>> XmlToDict(string element)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            var query = from item in xdoc.Descendants(element)
                        select item;
            foreach (var item in query.Elements())
            {
                dict.Add(item.Name.ToString(), XmlToList(item.Name.ToString()));
            }
            return dict;
        }

    }
}
