using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace WorkingWithXML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> skola = new List<string>() { "Mshenebloba", "Dizaini", "Programireba" };
            IList<Students> studentList = new List<Students>() {
                new Students(){ name="Lasha Tavlalashvili", phone="558-123-467", street="Nutsubidze", city="Tbilisi", skola=skola[2], faculity="Inpormatika", GPA=3.5f},
                new Students(){ name="Cotne Loladze", phone="555-133-427", street="Dadiani", city="Tbilisi", skola=skola[2], faculity="Inpormatika", GPA=2.5f},
                new Students(){ name="Vaja Metreveli", phone="599-154-432", street="Nutsubidze", city="Tbilisi", skola=skola[1], faculity="Inpormatika", GPA=2.8f},
                new Students(){ name="Giorgi Batsikadze", phone="555-517-174", street="Kandelaki", city="Tbilisi", skola=skola[0], faculity="Inpormatika", GPA=2.0f}
            };
            //XNamespace empNM = "urn:list-emp:emp";
            XElement students = new XElement("Students");
            foreach (var student in studentList) {
                XElement st =
                new XElement("Student",
                    new XElement("Name", student.name),
                    new XElement("Phone", student.phone),
                    new XElement("Address",
                        new XElement("Street", student.street),
                        new XElement("City", student.city)
                    ),
                    new XElement("Faculity", student.skola,
                    new XAttribute("Skola", student.faculity)),
                    new XElement("GPA", student.GPA)
                );
                students.Add(st);
            }
            XDocument xDoc = new XDocument(new XDeclaration("1.0", "UTF-16", null), students);
            xDoc.Save("C:\\Users\\lasha\\Desktop\\C#\\C_Sharp\\Davaleba 8\\WorkingWithXML\\WorkingWithXML\\Students.xml");
            Console.WriteLine("Saved");

            XElement xel = XElement.Load("..\\..\\Students.xml");
            //IEnumerable<XElement> address =
            //    from el in xel.Descendants("Address")
            //    where (string)el.Element("Street") == "Nutsubidze"
            //    select el;
            //foreach (XElement el in address)
            //    Console.WriteLine(el);

            //IEnumerable<XElement> gpa =
            //from el in xel.Descendants("Student")
            //where (float)el.Element("GPA") > 2.5f
            //select el;
            //foreach (XElement el in gpa)
            //    Console.WriteLine(el);


            IEnumerable<XElement> faculity =
            from el in xel.Descendants("Student")
            where (string)el.Element("Faculity") == "Programireba"
            select el;

            foreach (XElement el in faculity)
                Console.WriteLine(el);

            Console.ReadKey();
        }
    }
}
