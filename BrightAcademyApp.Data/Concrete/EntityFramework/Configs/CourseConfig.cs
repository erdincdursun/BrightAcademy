using BrightAcademyApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Data.Concrete.EntityFramework.Configs
{
    public class CourseConfig : IEntityTypeConfiguration<Course>

    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(

                new Course
                {
                    Id = 1,
                    Name = "Full Stack Programlama",
                    Description = "Full stack developer olarak çalışan uzmanlar, yazılımların back-end (arka katman) ve front-end(ön katman) olarak nitelendirilen bölümlerinde rol almaktadırlar.",
                    CourseHours = 600,
                    EducationGains = "Bu eğitim sayesinde; Temel ve ileri veritabanı mantığını,· Web’in ve yazılımın çalışma prensibini ve tüm süreçlerini,· Yeni nesil tüm programlama araç ve dillerini,· Back end programlamayı ve API yazmayı,· Uçtan uca bir proje geliştirmeyi öğreneceksiniz",
                    ImageUrl = "full-stack-programlama.jpg",
                    EducationLevel = "Medium",
                    EducationTime = 6,
                    IsActive = true,
                    EducationStatus = true,
                    EducationEvaluation = "Web kariyeri açısından çok faydalı bir eğitim.",
                    EducationTitle = "Temel Programlama : • C# ile Programlama• Değişkenler• Veri Tipleri, Tip Dönüşümleri• Hata Kontrolü, Özel Fonksiyonlar• Döngüler, Koşullu İfadeler• Diziler",
                    Price = 45000,
                    EducationType = "Sınıf",
                    Url = "full-stack-programlama"
                },
                new Course
                {
                    Id = 2,
                    Name = "C# Programlama",
                    Description = "Katılımcıların C# programlama dilini kullanarak farklı platformlarda uygulama geliştirebilecek eğitimlere katılma yeterliliğini elde etmelerini sağlamaktır.",
                    CourseHours = 80,
                    EducationGains = "Bu eğitim sayesinde; Herhangi bir programlama bilgi ve becerisine sahip olmayan her kişinin  C# programlama dilinin en temel özelliklerini kolaylıkla öğrenebileceği başlangıç seviyesinde bir eğitimdir. Bu eğitimle C# programlama dilinin en temel özellikleri öğretilecektir.",
                    ImageUrl = "c-sharp.jpg",
                    EducationLevel = "Easy",
                    EducationTime = 2,
                    IsActive = true,
                    EducationStatus = true,
                    EducationEvaluation = "Temel Programlama açısından çok faydalı bir eğitim.",
                    EducationTitle = "Temel Programlama: Değişkenler,Koşullar,Döngüler,Diziler, Visual Studio Code",
                    Price = 15000,
                    EducationType = "Online",
                    Url = "csharp-programlama"
                },
                new Course
                {
                    Id = 3,
                    Name = "Java",
                    Description = "Bu eğitimin amacı, Java programlama dilini bilenlerin sektörde en yaygın kullanılan teknolojilere adaptasyonunu sağlamaktır.",
                    CourseHours = 180,
                    EducationGains = "Java'yı gerçek projelerde kullanıldığı gibi sıfırdan öğrenecek,Java ile Nesne Yönelimli Programlama (OOP) yapabilecek,SOLID yazılım geliştirme prensiplerini öğrenecek,Tasarım Desenlerine (Design Patterns) giriş yapacak,Sektörde en çok kullanılan Java teknolojilerini öğrenecek.",
                    ImageUrl = "java.jpg",
                    EducationLevel = "Senior",
                    EducationTime = 4,
                    IsActive = true,
                    EducationStatus = true,
                    EducationEvaluation = "Web kariyeri açısından çok faydalı bir eğitim.",
                    EducationTitle = "Spring Boot, Maven, Spring Rest servisi ile backend",
                    Price = 35000,
                    EducationType = "Sınıf",
                    Url ="java"
                },
                new Course
                {
                    Id = 4,
                    Name = "React Native",
                    Description = "Bu eğitim; React Native ile HTML, CSS ve JavaScript dillerini kullanımını, Visual Studio Code ortamında, Android ve iOS işletim sistemleri için mobil uygulama geliştirmenin detaylarını kapsamaktadır..",
                    CourseHours = 120,
                    EducationGains = "Bu eğitim sayesinde; Mobil programlamaya dair herşeyi öğreneceksiniz",
                    ImageUrl = "react-native.jpg",
                    EducationLevel = "Medium",
                    EducationTime = 3,
                    IsActive = true,
                    EducationStatus = true,
                    EducationEvaluation = "Mobile alanda çalışmak adına çok faydalı bir eğitim.",
                    EducationTitle = "HTML,CSS,JavaScript,Proje Oluşturma,Component Nedir? Cihaz Yönetimi Web Servis Kullanımı Push Notification Mobil Project Development Market",
                    EducationType = "Online",
                    Url="react-native"
                },
                new Course
                {
                    Id = 5,
                    Name = "Flutter",
                    Description = "Bu eğitimin amacı Flutter ile Mobil Geliştirmeyi sıfırdan ileri seviyeye gelecek şekilde öğretmektir.",
                    CourseHours = 80,
                    EducationGains = "Bu eğitim sayesinde; Mobil programlamaya dair herşeyi öğreneceksiniz",
                    ImageUrl = "flutter.jpg",
                    EducationLevel = "Medium",
                    EducationTime = 2,
                    IsActive = true,
                    EducationStatus = true,
                    EducationEvaluation = "Mobile alanda çalışmak adına çok faydalı bir eğitim.",
                    EducationTitle = "HTML,CSS,JavaScript,Proje Oluşturma,Component Nedir? Cihaz Yönetimi Web Servis Kullanımı Push Notification Mobil Project Development Market",
                    EducationType = "Online",
                    Url = "flutter"
                },
                new Course
                {
                    Id = 6,
                    Name = "Unity ile 3D Oyun Geliştirme",
                    Description = "Katılımcıların 3 boyutlu Unity uzayına hakimiyet sağlayarak seviye tasarımları geliştirecek bilgi birikimine ulaşmaları ve C# programlama dili yardımı ile bu görsel süreçleri çalışır bir yapı haline dönüştürmelerini sağlamaktır.",
                    CourseHours = 80,
                    EducationGains = "Unity oyun motoru ile oyun geliştirebilir,3 boyutlu seviye tasarımları oluşturabilir,C# programlama dili ile programlama yapabilir.",
                    ImageUrl = "unity.jpg",
                    EducationLevel = "Medium",
                    EducationTime = 2,
                    IsActive = true,
                    EducationStatus = true,
                    EducationEvaluation = "Oyun geliştirme sürecine hâkim olmak isteyenler için çok faydalı bir eğitim.",
                    EducationTitle = "Eğitimimize önce 3 boyutlu Unity uzayına hakimiyet sağlayarak başlayacağız, daha sonrasında çevre tasarımları geliştirecek ardından ise programlama tarafına odaklanacağız. Bu alanda yaptığımız çalışmaları tamamladıktan sonra ise üç ayrı oyun örneği ile öğrendiklerimizi uygulamaya geçireceğiz",
                    EducationType = "Online",
                    Url = "unity-ile-3d-oyun-gelistirme"
                },
                new Course
                {
                    Id = 7,
                    Name = "Python ile Siber Güvenlik Uygulamaları",
                    Description = "Bu eğitimin amacı çeşitli Python kütüphanelerini kullanarak farklı araçların Python ile nasıl entegre edilebileceğini öğrenip, Python ile siber güvenlik kapsamında kullanılabilecek uygulamalar geliştirebilmesini sağlamaktır.",
                    CourseHours = 120,
                    EducationGains = " Siber güvenlik için Python ile araç geliştirebilir. Farklı uygulamaları Python ile otomatize edebilir. Web kazıma yapabilir..",
                    ImageUrl = "python.jpg",
                    EducationLevel = "Sen,or",
                    EducationTime = 4,
                    IsActive = true,
                    EducationStatus = true,
                    EducationEvaluation = "Siber güvenlik alanına ilgi kişiler,Siber güvenlik kapsamında kendi aracını geliştirmek isteyenler için güzel bir eğitim,",
                    EducationTitle = "Bu eğitimde ilk olarak Python programlamaya giriş yapılacak ve çeşitli Python kütüphaneleri kullanılacak sonrasında Socket programlama ile ağ sızma ve web kazıma öğretilecektir.",
                    EducationType = "Sınıf",
                    Url = "python-ile-siber-guvenlik-uygulamalari"
                },
                new Course
                {
                    Id = 8,
                    Name = "Oracle Veritabanı",
                    Description = "Oracle veritabanı ile ilgili, kurulum ve konfigurasyonlar adım adım anlatılacak ve Oracle Veritabanı Mimarisi, Oracle Networking gibi Veritabanı Yöneticiliği Temel Bilgiler örneklendirilecektir.",
                    CourseHours = 80,
                    EducationGains = "Oracle Veritabanı Mimarisi ve Temel Bilgiler konularına hakim olur,.",
                    ImageUrl = "oracle.jpg",
                    EducationLevel = "Medium",
                    EducationTime = 2,
                    IsActive = true,
                    EducationStatus = true,
                    EducationEvaluation = "Günümüzde Veri Bilimi, Makine Öğrenmesi, Yapay Zekâ, Büyük Veri gibi kavramlar oldukça popüler. Bu kavram ve teknolojileri besleyen asıl yapı verinin kendisidir.",
                    EducationTitle = "Kurs tamamlandığında kariyerine Oracle Veritabanı Yöneticisi olarak devam etmek isteyen herkes ilgili alanlarda çalışabilecek temel bilgi ve beceri edinebilecektir.",
                    EducationType = "Online",
                    Url="oracle-veritabani"
                },
                 new Course
                 {
                     Id = 9,
                     Name = "TSQL ile Veri Tabanı Programlama",
                     Description = "Veritabanı sistemleri ve ilişkisel veritabanlarını sorgulama dili olan SQL dilinin daha da derinlere inerek T-SQL'i öğretmek. T-SQL sorguları oluşturma, veri türleriyle çalışma, verileri toplama işlevlerini kullanma ve hata işleme konusunda uygulamalı deneyim kazanılmasını sağlamak.",
                     CourseHours = 80,
                     EducationGains = "TSQL kullaranarak SQL Server üzerinde ileri seviye kodlama yapabilir,TSQL fonksiyonlarını kullanmayı öğrenir.Veribilimi projelerinin gerek şartı olan veri önişleme işlemlerini gerçekleştirebilir.",
                     ImageUrl = "tsql.jpg",
                     EducationLevel = "Medium",
                     EducationTime = 2,
                     IsActive = true,
                     EducationStatus = true,
                     EducationEvaluation = "Günümüzde Veri Bilimi, Makine Öğrenmesi, Yapay Zekâ, Büyük Veri gibi kavramlar oldukça popüler. Bu kavram ve teknolojileri besleyen asıl yapı verinin kendisidir.",
                     EducationTitle = "TSQL ile Veritabanı programlama eğitimi SQL Server’ın temel dili olan TSQL’i kullanarak veritabanı üzerinde kodlama yapmayı öğretmeyi amaçlamaktadır.",
                     EducationType = "Sınıf",
                     Url = "tsql-ile-veritabani-programlama"
                 }
            );
        }
    }
}
