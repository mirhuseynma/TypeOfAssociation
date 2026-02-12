using System.Net;

namespace OOPBasicConceptsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qeydiyyata almaq istediyiniz hekimlerin sayini yazin...");
            int countOfDoctor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa verilmis melumatlari doldurun");
            Doctor[] doctors = new Doctor[countOfDoctor];
            for (int i = 0; i < countOfDoctor; i++)
            {               
                doctors[i] = new Doctor();
                Console.WriteLine($"{i + 1}.Doktorun ad ve soyadi:");
                doctors[i].FullName = Console.ReadLine();
                Console.WriteLine($"{i + 1}.Doktorun yashi:");
                doctors[i].Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{i + 1}.Doktorun elektron pocth unvani:");
                doctors[i].Email = Console.ReadLine();
                Console.WriteLine($"{i + 1}.Doktorun yashadigi adress:");
                doctors[i].Address = Console.ReadLine();
                Console.WriteLine("\n");

            }
            DoctorService doctur = new DoctorService();
            //doctur.GetAll(doctors);
            //doctur.SearchByFullname(doctors);
            //doctur.SortByAge(doctors);
            doctur.AvarageByAge(doctors);


        }
    }
}
