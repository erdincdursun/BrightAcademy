using BrightAcademyApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BrightAcademyApp.Data.Concrete.EntityFramework.Configs
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>


    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Web Geliştirme ",
                    Description = "Web Geliştirme Kategorisi",
                    IsActive = true,
                    Url = "web-gelistirme"
                },
                new Category
                {
                    Id = 2,
                    Name = "Mobil Geliştirme ",
                    Description = "Mobil Geliştirme Kategorisi",
                    IsActive = true,
                    Url = "mobil-gelistirme"
                },
                new Category
                {
                    Id = 3,
                    Name = "Oyun Geliştirme ",
                    Description = "Oyun Geliştirme Kategorisi",
                    IsActive = true,
                    Url = "oyun-gelistirme"
                },
                new Category
                {
                    Id = 4,
                    Name = "Siber Güvenlik ",
                    Description = "Siber Güvenlik Kategorisi",
                    IsActive = true,
                    Url = "siber-guvenlik"
                },
                new Category
                {
                    Id = 5,
                    Name = "Veritabanı  ",
                    Description = "Veritabanı Kategorisi",
                    IsActive = true,
                    Url="veritabani"
                },
                new Category
                {
                    Id = 6,
                    Name = "Temel Programlama  ",
                    Description = "Temel Programlama Kategorisi",
                    IsActive = true,
                    Url = "temel-programla"
    }
                );
        }
    }
}
