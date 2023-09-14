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
    public class SettingConfig : IEntityTypeConfiguration<Settings>
    {
        public void Configure(EntityTypeBuilder<Settings> builder)
        {
            builder.HasData(
                new Settings
                {
                    Id = 1,
                    CompanyName = "Bright Academy",
                    About = "Akademi Merkezi",
                    Address = "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul",
                    Contact = "info@brightacademy.com",
                    Questions = "Sık Sorulan Sorular"
                    
                }
                );
        }
    }
}
