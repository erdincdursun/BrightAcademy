using BrightAcademyApp.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Data.Concrete.EntityFramework.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            #region Role
            List<Role> roles = new List<Role>
            {
                new Role { Name = "Admin",Description="Admin Rolü", NormalizedName="ADMIN"},
                new Role { Name = "SuperAdmin", Description = "Super Admin Rolü", NormalizedName = "SUPERADMIN" },
                new Role { Name = "Trainer", Description = "Trainer Rolü", NormalizedName = "TRANIER" },
                new Role { Name = "Traniee", Description = "Traniee Rolü", NormalizedName = "TRANIEE" },
                new Role { Name = "User", Description = "User Rolü", NormalizedName = "USER" },

            };
            modelBuilder.Entity<Role>().HasData(roles);
            #endregion
            #region User
            List<User> users = new List<User>
            {
               new User
               {
                    FirstName = "Ömer Ayaz",
                    LastName = "Dursun",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "omerayaz@gmail.com",
                    NormalizedEmail = "OMERAYAZ@GMAIL.COM",
                    Gender = "Erkek",
                    EmailConfirmed = true,
                    SecurityStamp = "",
                    LockoutEnabled = true,
                    PhoneNumber = "+905424597000",
                    PhoneNumberConfirmed = true,

               },
                 new User
               {
                    FirstName = "Ayse Hafsa",
                    LastName = "Dogan",
                    UserName = "superadmin",
                    NormalizedUserName = "SUPERADMIN",
                    Email = "aysehafsa@gmail.com",
                    NormalizedEmail = "AYSEHAFSA@GMAIL.COM",
                    Gender = "Kadın",
                    EmailConfirmed = true,
                    SecurityStamp = "",
                    LockoutEnabled = true,
                    PhoneNumber = "+905424597000",
                    PhoneNumberConfirmed = true,

               },
            };
            modelBuilder.Entity<User>().HasData(users);
            #endregion
            #region TraineeUser
            List<Trainee> trainees = new List<Trainee>
            {
                new Trainee
                {
                    Id ="1",  
                    FirstName = "Busra",
                    LastName = "Dursun",
                    UserName = "busradursun",
                    NormalizedUserName = "BUSRADURSUN",
                    Email = "busradursun@gmail.com",
                    NormalizedEmail = "BUSRADURSUN@GMAIL.COM",
                    Gender = "Kadın",
                    DateOfBirth = new DateTime(1994, 1, 23),
                    Address = "Paşa Mah.Evren Sk.No:8/4 Şişli/İSTANBUL",
                    City = "İstanbul",
                    EmailConfirmed = true,
                    SecurityStamp = "",
                    LockoutEnabled = true,
                    PhoneNumber = "+905424597000",
                    PhoneNumberConfirmed = true,
                    Education = "Beykent Üniversitesi Yazılım Mühendisliği",
                    
                    
                },
                new Trainee
                {
                    Id="2",
                    FirstName = "Erdinc",
                    LastName = "Dursun",
                    UserName = "erdincdursun",
                    NormalizedUserName = "ERDINCDURSUN",
                    Email = "erdincdursun@gmail.com",
                    NormalizedEmail = "ERDINCDURSUN@GMAIL.COM",
                    Gender = "Erkek",
                    DateOfBirth = new DateTime(1993, 1, 23),
                    Address = "Paşa Mah.Evren Sk.No:8/4 Şişli/İSTANBUL",
                    City = "İstanbul",
                    EmailConfirmed = true,
                    SecurityStamp = "",
                    LockoutEnabled = true,
                    PhoneNumber = "+905424597000",
                    PhoneNumberConfirmed = true,
                    Education = "Anadolu Üniversitesi Bilgisayar Mühendisliği"
                },
                new Trainee
                {
                    Id="3",
                    FirstName = "Şeyda Nur",
                    LastName = "Doğan",
                    UserName = "seydanur",
                    NormalizedUserName = "SEYDANUR",
                    Email = "seydanur@gmail.com",
                    NormalizedEmail = "SEYDANUR@GMAIL.COM",
                    Gender = "Kadın",
                    DateOfBirth = new DateTime(1990, 8, 30),
                    Address = "Talatpaşa Mah.Kiraz Sk.No:8/3 Şişli/İSTANBUL",
                    City = "İstanbul",
                    EmailConfirmed = true,
                    SecurityStamp = "",
                    LockoutEnabled = true,
                    PhoneNumber = "+905424597000",
                    PhoneNumberConfirmed = true,
                    Education = "Anadolu Üniversitesi Yazılım Mühendisliği"
                },
                new Trainee
                {
                    Id="4",
                    FirstName = "Habibe",
                    LastName = "Dursun",
                    UserName = "habibedursun",
                    NormalizedUserName = "HABIBEDURSUN",
                    Email = "habibedursun@gmail.com",
                    NormalizedEmail = "HABIBEDURSUN@GMAIL.COM",
                    Gender = "Kadın",
                    DateOfBirth = new DateTime(1968, 2, 8),
                    Address = "Yayla Mah.Bakır Sk.No:9/2 Şişli/İSTANBUL",
                    City = "İstanbul",
                    EmailConfirmed = true,
                    SecurityStamp = "",
                    LockoutEnabled = true,
                    PhoneNumber = "+905424597000",
                    PhoneNumberConfirmed = true,
                    Education = "Anadolu Üniversitesi Bilgisayar Programcılığı"
                 },

            };
            modelBuilder.Entity<Trainee>().HasData(trainees);


            #endregion
            #region TrainerUser
            List<Trainer> trainers = new List<Trainer>
            {
                  new Trainer
                {
                    Id = "5",
                    FirstName = "Arzu",
                    LastName = "Öztürk",
                    UserName = "arzuozturk",
                    NormalizedUserName = "ARZUOZTURK",
                    Email = "arzuozturk@gmail.com",
                    NormalizedEmail = "ARZUOZTURK@GMAIL.COM",
                    Gender = "Kadın",
                    DateOfBirth = new DateTime(1972, 5, 22),
                    Address = "Vakfıkebir Mah.Kamaliye Sk.No:8/4 Trabzon",
                    City = "Trabzon",
                    EmailConfirmed = true,
                    SecurityStamp = "",
                    LockoutEnabled = true,
                    PhoneNumber = "+905424597000",
                    PhoneNumberConfirmed = true,
                    Branch="Bilgisayar Öğretmeni",
                    Education="Marmara Üniversitesi Bilgisayar Öğretmenliği",
                    IsActive = true,
                    InstructorExperience = "Özel okul Bilgisayar Öğretmeliği",
                    InstructorPoints =  5
                },

                 new Trainer
                {
                    Id="6",
                    FirstName = "Nazlı",
                    LastName = "Öztürk",
                    UserName = "nazliozturk",
                    NormalizedUserName = "NAZLIOZTURK",
                    Email = "nazlıozturk@gmail.com",
                    NormalizedEmail = "NAZLIOZTURK@GMAIL.COM",
                    Gender = "Kadın",
                    DateOfBirth = new DateTime(2004, 3, 14),
                    Address = "Vakfıkebir Mah.Kamaliye Sk.No:8/4 Trabzon",
                    City = "Trabzon",
                    EmailConfirmed = true,
                    SecurityStamp = "",
                    LockoutEnabled = true,
                    PhoneNumber = "+905424597000",
                    PhoneNumberConfirmed = true,
                    Branch="Bilgisayar Öğretmeni",
                    Education="Aydın Üniversitesi Bilgisayar Öğretmenliği",
                    IsActive = true,
                    InstructorExperience = "Bilge adam Yazılım Eğitmenliği",
                    InstructorPoints =  5
                 }
            };
            modelBuilder.Entity<Trainer>().HasData(trainers);
            #endregion
            #region Password
            var passwordHasher = new PasswordHasher<User>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Qwe123.");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");

            var traineePasswordHasher = new PasswordHasher<Trainee>();
            trainees[0].PasswordHash = traineePasswordHasher.HashPassword(trainees[0], "Qwe123.");
            trainees[1].PasswordHash = traineePasswordHasher.HashPassword(trainees[1], "Qwe123.");
            trainees[1].PasswordHash = traineePasswordHasher.HashPassword(trainees[2], "Qwe123.");
            trainees[1].PasswordHash = traineePasswordHasher.HashPassword(trainees[3], "Qwe123.");


            var traineerPasswordHasher = new PasswordHasher<Trainer>();
            trainers[0].PasswordHash = traineerPasswordHasher.HashPassword(trainers[0], "Qwe123.");
            trainers[1].PasswordHash = traineerPasswordHasher.HashPassword(trainers[1], "Qwe123.");

            #endregion
            #region UserRole
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>{ UserId=users[0].Id, RoleId=roles[0].Id },
                new IdentityUserRole<string>{ UserId=users[1].Id, RoleId=roles[1].Id }
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion
            #region TraineeRole
            List<IdentityUserRole<string>> traineeRole = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>{ UserId=trainees[0].Id, RoleId=roles[3].Id },
                new IdentityUserRole<string>{ UserId=trainees[1].Id, RoleId=roles[3].Id },
                new IdentityUserRole<string>{ UserId=trainees[2].Id, RoleId=roles[3].Id },
                new IdentityUserRole<string>{ UserId=trainees[3].Id, RoleId=roles[3].Id }

            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(traineeRole);
            #endregion
            #region TrainerRole
            List<IdentityUserRole<string>> trainerRole = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>{ UserId=trainers[0].Id, RoleId=roles[2].Id },
                new IdentityUserRole<string>{ UserId=trainers[1].Id, RoleId=roles[2].Id }
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(trainerRole);
            #endregion

        }

    }
}
