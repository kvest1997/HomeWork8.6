using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Exercise_4
{
    class XMLCreator
    {
        private List<Person> _listPerson;

        public XMLCreator()
        {

        }

        public XMLCreator(List<Person> listPerson)
        {
            this._listPerson = listPerson;
        }

        public void SerializationPersonList(string path)
        {
            XElement myRoot = new XElement("Root");
            XElement myPerson = new XElement("Person");

            XAttribute fioAttribute;

            XElement myAddress;

            XElement streetAttribute;
            XElement houseNumberAttribute;
            XElement flatNumberAttribute;


            XElement myPhone;
            XElement mobilePhoneAttribute;
            XElement flatPhoneAttribute;

            foreach (var item in _listPerson)
            {
                myPerson = new XElement("Person");

                myAddress = new XElement("Address");
                myPhone = new XElement("Phone");

                streetAttribute = new XElement("Street", item.StreetAddress);
                houseNumberAttribute = new XElement("HouseNumber", item.HouseNumber);
                flatNumberAttribute = new XElement("FlatNumber", item.FlatNumber);

                mobilePhoneAttribute = new XElement("MobilePhone", item.MobilePhone);
                flatPhoneAttribute = new XElement("FlatPhone", item.FlatPhone);

                fioAttribute = new XAttribute("name", item.FIO);

                myAddress.Add(streetAttribute, houseNumberAttribute, flatNumberAttribute);
                myPhone.Add(mobilePhoneAttribute, flatPhoneAttribute);

                myPerson.Add(fioAttribute);
                myPerson.Add(myAddress, myPhone);
                myRoot.Add(myPerson);


            }                

                using (StreamWriter stream = new StreamWriter(path, true))
                {
                    myRoot.Save(stream);
                }
        }

        public List<Person> DeserializationPersonList(string path)
        {
            List<Person> people = new List<Person>();
            string xml = File.ReadAllText(path);

            var colName = XDocument.Parse(xml).Descendants("Root").Descendants("Person").ToList();
            var colAddress = XDocument.Parse(xml).Descendants("Root").Descendants("Person").Descendants("Address").ToList();
            var colPhone = XDocument.Parse(xml).Descendants("Root").Descendants("Person").Descendants("Phone").ToList();

            for (int i = 0; i < colName.Count; i++)
            {
                people.Add(new Person(  colName[i].Attribute("name").Value,
                                        colAddress[i].Element("Street").Value,
                                        int.Parse(colAddress[i].Element("HouseNumber").Value),
                                        int.Parse(colAddress[i].Element("FlatNumber").Value),
                                        long.Parse(colPhone[i].Element("MobilePhone").Value),
                                        int.Parse(colPhone[i].Element("FlatPhone").Value)));
            }

            return people;
        }
    }
}
