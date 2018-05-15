using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.	Создать абстрактный класс Телефонный_справочник с методами, позволяющими вывести на экран информацию о записях в телефонном справочнике, а также определить соответствие записи критерию поиска.
  2.	Создать производные классы: Персона (фамилия, адрес, номер телефона), Организация (название, адрес, телефон, факс, контактное лицо), Друг (фамилия, адрес, номер телефона, дата рождения) 
        со своими методами вывода информации на экран, и определения соответствия искомому типу.
  3.	Создать базу (массив) из n товаров, вывести полную информацию из базы на экран, а также организовать поиск в базе по фамилии.
*/

namespace HW_Module_9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceGenerator sg = new ServiceGenerator();

            sg.ServiceGeneratorFriend();
            sg.ServiceGeneratorOrganization();
            sg.ServiceGeneratorPersona();

            sg.PrintAll();

            sg.Find("Максим");
        }
    }
}
