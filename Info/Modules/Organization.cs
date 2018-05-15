using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Организация (название, адрес, телефон, факс, контактное лицо)*/

namespace Info.Modules
{
    public class Organization : Phonebook
    {
        private string _ContactPerson;

        public string OrganizationName { get; set; }
        public int Fax { get; set; }
        public string ContactPerson { get => _ContactPerson; set => _ContactPerson = value.Replace("<center><b><font size=7>", "").Replace("</font></b></center>", "").Replace("\n", ""); }
        public string Address { get; set; }

        public override void Show()
        {
            Console.WriteLine("Название: {0}, Номер телефона: {1}, адрес: {2}, факс: {3}, контактное лицо: {4}", OrganizationName, PhoneNumber, Address, Fax, ContactPerson);
        }
    }
}
