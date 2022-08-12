using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_4
{
    public class Person
    {
        private string _fio;
        private string _streetAddress;
        private int _houseNumber;
        private int _flatNumber;
        private int _mobilePhone;
        private int _flatPhone;

        public Person()
        {

        }

        public Person(string fio, string streetAddress, int houseNumber, int flatNumber, int mobilePhone, int flatPhone)
        {
            this._fio = fio;
            this._streetAddress = streetAddress;
            this._houseNumber = houseNumber;
            this._flatNumber = flatNumber;
            this._mobilePhone = mobilePhone;
            this._flatPhone = flatPhone;
        }

        public string FIO
        {
            get => _fio;
            set => _fio = value;
        }

        public string StreetAddress
        {
            get => _streetAddress;
            set => _streetAddress = value;
        }

        public int HouseNumber
        {
            get => _houseNumber;
            set => _houseNumber = value;
        }

        public int FlatNumber
        {
            get => _flatNumber;
            set => _flatNumber = value;
        }

        public int MobilePhone
        {
            get => _mobilePhone;
            set => _mobilePhone = value;
        }

        public int FlatPhone
        {
            get => _flatPhone;
            set => _flatPhone = value;
        }
    }
}
