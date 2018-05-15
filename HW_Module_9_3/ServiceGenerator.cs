using GeneratorName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Info.Modules;

namespace HW_Module_9_3
{
    public enum AddressInfo
    {
        Мкр_айгерим,
        Мкр_айгерим_1,
        Мкр_айгерим_2,
        Мкр_айнабулак,
        Мкр_айнабулак_2,
        Мкр_айнабулак_3,
        Мкр_айнабулак_4,
        пос_бесагаш,
        Мкр_аксай_1А,
        Мкр_аксай_3А,
        Мкр_алмагуль,
        Мкр_алтай_1,
        Мкр_алтай_2
    }

    public enum OrganizationName
    {
        Российский_алюминий,
        УГМК_Металлургия,
        ГК_ТАИФ_Энергетика,
        Металлоинвест,
        Группа_ГАЗ,
        Русснефть,
        МегаФон,
        Эльдорадо,
        Евросеть,
        Объединенная_металлургическая_компания
    }

    public class ServiceGenerator
    {
        private Random rand = new Random();
        Generator generator = new Generator();

        public List<Phonebook> phonebooks;

        public ServiceGenerator()
        {
            phonebooks = new List<Phonebook>();
        }

        public void ServiceGeneratorPersona()
        {
            Persona persona = new Persona();
            persona.Name = generator.GenerateDefault(Gender.man);
            persona.PhoneNumber = rand.Next(7000000, 9000000);
            persona.Address = ((AddressInfo)rand.Next(0, 13)).ToString();

            phonebooks.Add(persona);
        }

        public void ServiceGeneratorOrganization()
        {
            Organization organization = new Organization();

            organization.OrganizationName = ((OrganizationName)rand.Next(1, 10)).ToString();            
            organization.PhoneNumber = rand.Next(7000000, 9000000);
            organization.Address = ((AddressInfo)rand.Next(0, 13)).ToString();
            organization.Fax = rand.Next(5000000, 7000000);
            organization.ContactPerson = generator.GenerateDefault(Gender.man);

            phonebooks.Add(organization);
        }

        public void ServiceGeneratorFriend()
        {
            Friend friend = new Friend();
            friend.Name = generator.GenerateDefault(Gender.man);
            friend.PhoneNumber = rand.Next(7000000, 9000000);
            friend.Address = ((AddressInfo)rand.Next(0, 13)).ToString();

            phonebooks.Add(friend);
        }

        public void PrintAll()
        {
            foreach (Phonebook item in phonebooks)
            {
                item.Show();
            }
        }

        public void Find(string name)
        {

            foreach (Phonebook item in phonebooks)
            {
                Console.WriteLine();
                Console.WriteLine("==============================================");
                Console.WriteLine();
                Console.Write("Введите имя, которое необходимо найти: ");
                if (item.Name == (name = (Console.ReadLine()).ToString()))
                    Console.WriteLine("Имя - {0}", item.Name);
                else
                    Console.WriteLine("Нет такого человека");
                break;
            }
        }
    }
}
