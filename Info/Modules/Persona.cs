using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2.	Создать производные классы: Персона (фамилия, адрес, номер телефона)*/

namespace Info.Modules
{
    public class Persona : Phonebook
    {
        public string Address { get; set; }

        public override void Show()
        {
            Console.WriteLine();
            Console.WriteLine("Имя: {0}, Номер телефона: {1}, адрес: {2}", Name, PhoneNumber, Address);
            Console.WriteLine();
        }
    }
}
