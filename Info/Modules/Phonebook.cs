using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.	Создать абстрактный класс Телефонный_справочник с методами, позволяющими вывести на экран информацию о записях в телефонном справочнике, а также определить соответствие записи критерию поиска.*/

namespace Info.Modules
{
    public abstract class Phonebook
    {
        private string _Name;
        public string Name { get => _Name; set => _Name = value.Replace("<center><b><font size=7>", "").Replace("</font></b></center>", "").Replace("\n", ""); }
        public int PhoneNumber { get; set; }

        public abstract void Show();
    }
}
