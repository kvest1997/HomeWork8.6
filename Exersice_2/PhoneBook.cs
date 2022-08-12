using System.Collections.Generic;

namespace Exercise_2
{
    class PhoneBook
    {
        long numberPhone;
        string fio;

        public PhoneBook(long numberPhone, string fio)
        {
            this.numberPhone = numberPhone;
            this.fio = fio;
        }


        public long NumberPhone
        {
            get => numberPhone;
            set => numberPhone = value;
        }

        public string FIO
        {
            get => fio;
            set => fio = value;
        }
    }
}
