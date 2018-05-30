using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Monitors.xml";

            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("Monitor");
            doc.AppendChild(root);
            doc.Save(path);
            XmlComment comment;

            XmlElement MonitorName = doc.CreateElement("MonitorName");
            MonitorName.InnerText = ("LG");
            comment = doc.CreateComment("Monitor name");
            MonitorName.AppendChild(comment);

            XmlElement MonitorModel = doc.CreateElement("MonitorModel");
            MonitorModel.InnerText = ("uc79m-g");
            comment = doc.CreateComment("Monitor model");
            MonitorModel.AppendChild(comment);

            XmlElement DisplayType = doc.CreateElement("DisplayType");
            DisplayType.InnerText = ("IPS");
            comment = doc.CreateComment("Display type");
            DisplayType.AppendChild(comment);

            XmlElement ScreenWide = doc.CreateElement("ScreenWide");
            ScreenWide.InnerText = ("33 inches");
            comment = doc.CreateComment("Screen wide");
            ScreenWide.AppendChild(comment);

            XmlElement ProductionCountry = doc.CreateElement("ProductionCountry");
            ProductionCountry.InnerText = ("Korea");
            comment = doc.CreateComment("Production country");
            ProductionCountry.AppendChild(comment);

            root.AppendChild(MonitorName);
            root.AppendChild(MonitorModel);
            root.AppendChild(DisplayType);
            root.AppendChild(ScreenWide);
            root.AppendChild(ProductionCountry);
            doc.Save(path);

            XmlElement Monitor2 = doc.CreateElement("Monitor2");
            comment = doc.CreateComment("Just another one monitor");
            Monitor2.AppendChild(comment);

            XmlElement Monitor3 = doc.CreateElement("Monitor3");
            comment = doc.CreateComment("Just another one monitor");
            Monitor3.AppendChild(comment);

            XmlElement Monitor4 = doc.CreateElement("Monitor4");
            comment = doc.CreateComment("Just another one monitor");
            Monitor4.AppendChild(comment);

            XmlElement Monitor5 = doc.CreateElement("Monitor5");
            comment = doc.CreateComment("Just another one monitor");
            Monitor5.AppendChild(comment);

            XmlElement Monitor6 = doc.CreateElement("Monitor6");
            comment = doc.CreateComment("Just another one monitor");
            Monitor6.AppendChild(comment);


            root.AppendChild(Monitor2);
            root.AppendChild(Monitor3);
            root.AppendChild(Monitor4);
            root.AppendChild(Monitor5);
            root.AppendChild(Monitor6);
            doc.Save(path);


        }
    }
}
