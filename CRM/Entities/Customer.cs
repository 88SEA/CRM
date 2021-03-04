using CRM.Abstract;
using System;

//--------------------------------- Senaryo ------------------------------------------

//   - Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz.
//   - Starbucks ve Nero Firması için çalışıyoruz.
//   - İki firma da müşterilerini veri tabanına kaydetmek istiyor.
//   - Starbucks müşterilerini kaydederken, mutlaka mernis doğrulaması istiyor. 
//   - Nero müşterileri kaydederken böyle birşey istemiyor.
//   - Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor.

namespace CRM.Entities //Customer Relationship Management - Musteri Takip Sistemi
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }

    }
}
