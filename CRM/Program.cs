using CRM.Abstract;
using CRM.Adapters;
using CRM.Concrete;
using CRM.Entities;
using System;
//--------------------------------- Senaryo ------------------------------------------

//   - Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz.
//   - Starbucks ve Nero Firması için çalışıyoruz.
//   - İki firma da müşterilerini veri tabanına kaydetmek istiyor.
//   - Starbucks müşterilerini kaydederken, mutlaka mernis doğrulaması istiyor. 
//   - Nero müşterileri kaydederken böyle birşey istemiyor.
//   - Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor.

namespace CRM //Customer Relationship Management - Musteri Takip Sistemi
{
    class Program 
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new CustomerCheckManager());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1988), FirstName = "Ethem Anil", LastName = "SANDALCI", NationalityId = "45157983158" });
            Console.ReadLine();
        }
    }




}
