using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace Exercise_4
{
    class XMLCreator
    {
        private List<Person> _listPerson;

        public XMLCreator(List<Person> listPerson)
        {
            this._listPerson = listPerson;
        }

        public void SerializationPersonList(string path)
        {
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

                using (StreamWriter stream = new StreamWriter(path, true))
                {
                    myPerson.Save(stream);
                }
            }


        }
    }
}
