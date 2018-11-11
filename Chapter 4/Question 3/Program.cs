using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дадена фирма има име, адрес, телефонен номер, факс номер, уеб сайт
            и мениджър. Мениджърът има име, фамилия и телефонен номер.
            Напишете програма, която чете информацията за фирмата и ней-
            ния мениджър и я отпечатва след това на конзолата.*/

            Console.Write("Enter company name: ");
            string cName = Console.ReadLine();
            Console.Write("Enter company address: ");
            string cAdd = Console.ReadLine();
            Console.Write("Enter company phone number: ");
            string cPN = Console.ReadLine();
            Console.Write("Enter company Fax number: ");
            string cF = Console.ReadLine();
            Console.Write("Enter company Web Site: ");
            string cWeb = Console.ReadLine();
            Console.Write("Enter company manager name: ");
            string cM = Console.ReadLine();
            Console.Write("Enter company manager surname: ");
            string cMs = Console.ReadLine();
            Console.Write("Enter manager phone number: ");
            string mPN = Console.ReadLine();

            Console.WriteLine("About Company: {0} |  {1}  |  {2}  |  {3}  |  {4}  ", cName, cAdd, cPN, cF, cWeb);
            Console.WriteLine("About Manager: {0} |  {1}  |  {2}   ", cM , cMs , mPN);

        }

    }
}
