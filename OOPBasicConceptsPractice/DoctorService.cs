using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicConceptsPractice
{
    public class DoctorService:Doctor
    {

        public DoctorService()
        {
            
        }
        public DoctorService(string fullName, int age, string eMail, string address) : base(fullName, age, eMail, address)
        {

        }

        public virtual void GetAll(Doctor[] doctors)
        {
            
            int doctorscount = 0;
            foreach (Doctor doctor in doctors)
            {
                doctorscount += 1;
                Console.WriteLine($"{doctorscount}.Doktorun melumatlari:\nAd soyad: {doctor.FullName}\nYashi: {doctor.Age}\nElektron pocth unvani: {doctor.Email}\nYashadigi unvan: {doctor.Address}\n");
            }

        }

        public  void SearchByFullname(Doctor[] doctors)
        {
            int doctorscount = 0;
            foreach (Doctor doctor in doctors)
            {
                doctorscount += 1;
                Console.WriteLine($"{doctorscount}.Doktorun melumatlari:\nAd soyad: {doctor.FullName}\n");
            }

        }

        public void SortByAge(Doctor[] doctors)
        {
            
            for(int i = 0; i < doctors.Length - 1; i++)
            {
                for(int j = 0; j < doctors.Length -1; j++)
                {
                    if (doctors[j].Age > doctors[j + 1].Age)
                    {
                        Doctor doctor = doctors[j];
                        doctors[j] = doctors[j + 1];
                        doctors[j+1] = doctor;
                    }
                }
            }
            int doctorscount = 0;
            foreach (Doctor doctor in doctors)
            {
                doctorscount += 1;
                Console.WriteLine($"{doctorscount}.Doktorun melumatlari:\nAd soyad: {doctor.FullName}\nYashi: {doctor.Age}\nElektron pocth unvani: {doctor.Email}\nYashadigi unvan: {doctor.Address}\n");
            }

        }

        public void AvarageByAge(Doctor[] doctors)
        {
            double count = 0;
            double sum = 0;
            int avarage = 0;
            for(int i = 0; i < doctors.Length; i++)
            {
                sum += doctors[i].Age;
                count++;
            }
            Console.WriteLine($"{sum/ count}");
        }
    }
}
