using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Друг (фамилия, адрес, номер телефона, дата рождения) */

namespace Info.Modules
{
    public class Friend : Phonebook
    {
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override void Show()
        {
            Console.WriteLine("Имя: {0}, Номер телефона: {1}, адрес: {2}, дата рождения: {3}", Name, PhoneNumber, Address, DateOfBirth);
        }
    }
}
