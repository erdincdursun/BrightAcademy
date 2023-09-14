using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BrightAcademyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Trainee_FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    Trainee_LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Trainee_Education = table.Column<string>(type: "TEXT", nullable: true),
                    Trainee_Gender = table.Column<string>(type: "TEXT", nullable: true),
                    Trainee_DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Trainee_Address = table.Column<string>(type: "TEXT", nullable: true),
                    Trainee_City = table.Column<string>(type: "TEXT", nullable: true),
                    Trainer_FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    Trainer_LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Education = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: true),
                    Branch = table.Column<string>(type: "TEXT", nullable: true),
                    InstructorExperience = table.Column<string>(type: "TEXT", nullable: true),
                    InstructorPoints = table.Column<int>(type: "INTEGER", nullable: true),
                    Trainer_Gender = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CourseHours = table.Column<int>(type: "INTEGER", nullable: false),
                    EducationTime = table.Column<int>(type: "INTEGER", nullable: false),
                    EducationStartTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EducationFinishTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EducationLevel = table.Column<string>(type: "TEXT", nullable: true),
                    EducationGains = table.Column<string>(type: "TEXT", nullable: true),
                    EducationType = table.Column<string>(type: "TEXT", nullable: true),
                    EducationTitle = table.Column<string>(type: "TEXT", nullable: true),
                    EducationEvaluation = table.Column<string>(type: "TEXT", nullable: true),
                    EducationStatus = table.Column<bool>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    About = table.Column<string>(type: "TEXT", nullable: true),
                    Contact = table.Column<string>(type: "TEXT", nullable: true),
                    Questions = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseCategories",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCategories", x => new { x.CourseId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CourseCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseCategories_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseTrainees",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    TraineeId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTrainees", x => new { x.CourseId, x.TraineeId });
                    table.ForeignKey(
                        name: "FK_CourseTrainees_AspNetUsers_TraineeId",
                        column: x => x.TraineeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseTrainees_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseTrainers",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    TrainerId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTrainers", x => new { x.CourseId, x.TrainerId });
                    table.ForeignKey(
                        name: "FK_CourseTrainers_AspNetUsers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseTrainers_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "154e8035-0610-4840-9309-1c9d19e5c19e", null, "Traniee Rolü", "Role", "Traniee", "TRANIEE" },
                    { "1cee760b-1b69-4d6b-8140-ac5149448a07", null, "Trainer Rolü", "Role", "Trainer", "TRANIER" },
                    { "5d0ac846-22b0-43cf-8b5d-6b9d3f6b01b4", null, "Super Admin Rolü", "Role", "SuperAdmin", "SUPERADMIN" },
                    { "75606044-e0da-4df7-8e91-9ea41d31fe16", null, "Admin Rolü", "Role", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Trainee_Address", "Trainee_City", "ConcurrencyStamp", "Trainee_DateOfBirth", "Discriminator", "Trainee_Education", "Email", "EmailConfirmed", "Trainee_FirstName", "Trainee_Gender", "Trainee_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "Paşa Mah.Evren Sk.No:8/4 Şişli/İSTANBUL", "İstanbul", "19f7e53d-3fd9-4094-b5bc-ff6dcd76aa16", new DateTime(1994, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trainee", "Beykent Üniversitesi Yazılım Mühendisliği", "busradursun@gmail.com", true, "Busra", "Kadın", "Dursun", true, null, "BUSRADURSUN@GMAIL.COM", "BUSRADURSUN", "AQAAAAIAAYagAAAAEMT2u7OSB341ZdDtPrcbEk4VWCAgrS3ipAy/NJvaT8Qtx7SR7b5Jrd0wb9dbRFBdHw==", "+905424597000", true, "", false, "busradursun" },
                    { "2", 0, "Paşa Mah.Evren Sk.No:8/4 Şişli/İSTANBUL", "İstanbul", "0d04af61-7ab1-4ebb-8e9a-f7ae05071161", new DateTime(1993, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trainee", "Anadolu Üniversitesi Bilgisayar Mühendisliği", "erdincdursun@gmail.com", true, "Erdinc", "Erkek", "Dursun", true, null, "ERDINCDURSUN@GMAIL.COM", "ERDINCDURSUN", "AQAAAAIAAYagAAAAEBkOussHNOIzu+3EF7gz2nNLZW3lrHoDYQ/Fz+cq/e4vEPri5TQHHwqnp/sQRSfWGA==", "+905424597000", true, "", false, "erdincdursun" },
                    { "3", 0, "Talatpaşa Mah.Kiraz Sk.No:8/3 Şişli/İSTANBUL", "İstanbul", "fd046d4f-5b61-4b69-9ea9-5748f9a4a367", new DateTime(1990, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trainee", "Anadolu Üniversitesi Yazılım Mühendisliği", "seydanur@gmail.com", true, "Şeyda Nur", "Kadın", "Doğan", true, null, "SEYDANUR@GMAIL.COM", "SEYDANUR", null, "+905424597000", true, "", false, "seydanur" },
                    { "4", 0, "Yayla Mah.Bakır Sk.No:9/2 Şişli/İSTANBUL", "İstanbul", "8fc1a511-5902-4081-89ce-b401a4e552f1", new DateTime(1968, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trainee", "Anadolu Üniversitesi Bilgisayar Programcılığı", "habibedursun@gmail.com", true, "Habibe", "Kadın", "Dursun", true, null, "HABIBEDURSUN@GMAIL.COM", "HABIBEDURSUN", null, "+905424597000", true, "", false, "habibedursun" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Branch", "City", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Education", "Email", "EmailConfirmed", "Trainer_FirstName", "Trainer_Gender", "InstructorExperience", "InstructorPoints", "IsActive", "Trainer_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5", 0, "Vakfıkebir Mah.Kamaliye Sk.No:8/4 Trabzon", "Bilgisayar Öğretmeni", "Trabzon", "14360811-ff05-40c2-8cd7-d68223ee61f4", new DateTime(1972, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trainer", "Marmara Üniversitesi Bilgisayar Öğretmenliği", "arzuozturk@gmail.com", true, "Arzu", "Kadın", "Özel okul Bilgisayar Öğretmeliği", 5, true, "Öztürk", true, null, "ARZUOZTURK@GMAIL.COM", "ARZUOZTURK", "AQAAAAIAAYagAAAAEC0i7/l1SvOAI1xO+csb6O+JEy0CY0fqOXIsArE08slz1XtFXZHkVtW1k872nfv7Xw==", "+905424597000", true, "", false, "arzuozturk" },
                    { "6", 0, "Vakfıkebir Mah.Kamaliye Sk.No:8/4 Trabzon", "Bilgisayar Öğretmeni", "Trabzon", "5ce96608-6dd8-4415-b297-763176ac20ed", new DateTime(2004, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trainer", "Aydın Üniversitesi Bilgisayar Öğretmenliği", "nazlıozturk@gmail.com", true, "Nazlı", "Kadın", "Bilge adam Yazılım Eğitmenliği", 5, true, "Öztürk", true, null, "NAZLIOZTURK@GMAIL.COM", "NAZLIOZTURK", "AQAAAAIAAYagAAAAEFu8YJaxS0EmWpMJQeqdSe53o3G+nPr/KajDnqfVrLxcMhHHY03+RzH+i+eeP17jJg==", "+905424597000", true, "", false, "nazliozturk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b69e6273-31f7-417d-a2ab-08c3a1b4adaf", 0, "83e4853d-bb95-4ad1-9863-09bc8ff5b3ed", "User", "omerayaz@gmail.com", true, "Ömer Ayaz", "Erkek", "Dursun", true, null, "OMERAYAZ@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAENfg0a+4lp90jeEzIUxr6U7Frxi7iYL3gqtxGVJh9FeNJj3IsWSJMJt+BOc9fyQl+Q==", "+905424597000", true, "", false, "admin" },
                    { "ebddca1e-a6ac-4af1-8cdc-175a534457de", 0, "c1d9598c-fb8a-4a47-98ca-6eed41451707", "User", "aysehafsa@gmail.com", true, "Ayse Hafsa", "Kadın", "Dogan", true, null, "AYSEHAFSA@GMAIL.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAEEor/fADQibZJZoWk87lwrJLkY3OtN5kP6VxUVnDho37tmLVpn0jt0VbZqfjPBTl6Q==", "+905424597000", true, "", false, "superadmin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "IsActive", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Web Geliştirme Kategorisi", true, "Web Geliştirme ", "web-gelistirme" },
                    { 2, "Mobil Geliştirme Kategorisi", true, "Mobil Geliştirme ", "mobil-gelistirme" },
                    { 3, "Oyun Geliştirme Kategorisi", true, "Oyun Geliştirme ", "oyun-gelistirme" },
                    { 4, "Siber Güvenlik Kategorisi", true, "Siber Güvenlik ", "siber-guvenlik" },
                    { 5, "Veritabanı Kategorisi", true, "Veritabanı  ", "veritabani" },
                    { 6, "Temel Programlama Kategorisi", true, "Temel Programlama  ", "temel-programla" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseHours", "Description", "EducationEvaluation", "EducationFinishTime", "EducationGains", "EducationLevel", "EducationStartTime", "EducationStatus", "EducationTime", "EducationTitle", "EducationType", "ImageUrl", "IsActive", "Name", "Price", "Url" },
                values: new object[,]
                {
                    { 1, 600, "Full stack developer olarak çalışan uzmanlar, yazılımların back-end (arka katman) ve front-end(ön katman) olarak nitelendirilen bölümlerinde rol almaktadırlar.", "Web kariyeri açısından çok faydalı bir eğitim.", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(990), "Bu eğitim sayesinde; Temel ve ileri veritabanı mantığını,· Web’in ve yazılımın çalışma prensibini ve tüm süreçlerini,· Yeni nesil tüm programlama araç ve dillerini,· Back end programlamayı ve API yazmayı,· Uçtan uca bir proje geliştirmeyi öğreneceksiniz", "Medium", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(935), true, 6, "Temel Programlama : • C# ile Programlama• Değişkenler• Veri Tipleri, Tip Dönüşümleri• Hata Kontrolü, Özel Fonksiyonlar• Döngüler, Koşullu İfadeler• Diziler", "Sınıf", "full-stack-programlama.jpg", true, "Full Stack Programlama", 45000m, "full-stack-programlama" },
                    { 2, 80, "Katılımcıların C# programlama dilini kullanarak farklı platformlarda uygulama geliştirebilecek eğitimlere katılma yeterliliğini elde etmelerini sağlamaktır.", "Temel Programlama açısından çok faydalı bir eğitim.", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(1010), "Bu eğitim sayesinde; Herhangi bir programlama bilgi ve becerisine sahip olmayan her kişinin  C# programlama dilinin en temel özelliklerini kolaylıkla öğrenebileceği başlangıç seviyesinde bir eğitimdir. Bu eğitimle C# programlama dilinin en temel özellikleri öğretilecektir.", "Easy", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(1009), true, 2, "Temel Programlama: Değişkenler,Koşullar,Döngüler,Diziler, Visual Studio Code", "Online", "c-sharp.jpg", true, "C# Programlama", 15000m, "csharp-programlama" },
                    { 3, 180, "Bu eğitimin amacı, Java programlama dilini bilenlerin sektörde en yaygın kullanılan teknolojilere adaptasyonunu sağlamaktır.", "Web kariyeri açısından çok faydalı bir eğitim.", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(1013), "Java'yı gerçek projelerde kullanıldığı gibi sıfırdan öğrenecek,Java ile Nesne Yönelimli Programlama (OOP) yapabilecek,SOLID yazılım geliştirme prensiplerini öğrenecek,Tasarım Desenlerine (Design Patterns) giriş yapacak,Sektörde en çok kullanılan Java teknolojilerini öğrenecek.", "Senior", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(1013), true, 4, "Spring Boot, Maven, Spring Rest servisi ile backend", "Sınıf", "java.jpg", true, "Java", 35000m, "java" },
                    { 4, 120, "Bu eğitim; React Native ile HTML, CSS ve JavaScript dillerini kullanımını, Visual Studio Code ortamında, Android ve iOS işletim sistemleri için mobil uygulama geliştirmenin detaylarını kapsamaktadır..", "Mobile alanda çalışmak adına çok faydalı bir eğitim.", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(1015), "Bu eğitim sayesinde; Mobil programlamaya dair herşeyi öğreneceksiniz", "Medium", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(1015), true, 3, "HTML,CSS,JavaScript,Proje Oluşturma,Component Nedir? Cihaz Yönetimi Web Servis Kullanımı Push Notification Mobil Project Development Market", "Online", "react-native.jpg", true, "React Native", 0m, "react-native" },
                    { 5, 80, "Bu eğitimin amacı Flutter ile Mobil Geliştirmeyi sıfırdan ileri seviyeye gelecek şekilde öğretmektir.", "Mobile alanda çalışmak adına çok faydalı bir eğitim.", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(1026), "Bu eğitim sayesinde; Mobil programlamaya dair herşeyi öğreneceksiniz", "Medium", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(1026), true, 2, "HTML,CSS,JavaScript,Proje Oluşturma,Component Nedir? Cihaz Yönetimi Web Servis Kullanımı Push Notification Mobil Project Development Market", "Online", "flutter.jpg", true, "Flutter", 0m, "flutter" },
                    { 6, 80, "Katılımcıların 3 boyutlu Unity uzayına hakimiyet sağlayarak seviye tasarımları geliştirecek bilgi birikimine ulaşmaları ve C# programlama dili yardımı ile bu görsel süreçleri çalışır bir yapı haline dönüştürmelerini sağlamaktır.", "Oyun geliştirme sürecine hâkim olmak isteyenler için çok faydalı bir eğitim.", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(1028), "Unity oyun motoru ile oyun geliştirebilir,3 boyutlu seviye tasarımları oluşturabilir,C# programlama dili ile programlama yapabilir.", "Medium", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(1028), true, 2, "Eğitimimize önce 3 boyutlu Unity uzayına hakimiyet sağlayarak başlayacağız, daha sonrasında çevre tasarımları geliştirecek ardından ise programlama tarafına odaklanacağız. Bu alanda yaptığımız çalışmaları tamamladıktan sonra ise üç ayrı oyun örneği ile öğrendiklerimizi uygulamaya geçireceğiz", "Online", "unity.jpg", true, "Unity ile 3D Oyun Geliştirme", 0m, "unity-ile-3d-oyun-gelistirme" },
                    { 7, 120, "Bu eğitimin amacı çeşitli Python kütüphanelerini kullanarak farklı araçların Python ile nasıl entegre edilebileceğini öğrenip, Python ile siber güvenlik kapsamında kullanılabilecek uygulamalar geliştirebilmesini sağlamaktır.", "Siber güvenlik alanına ilgi kişiler,Siber güvenlik kapsamında kendi aracını geliştirmek isteyenler için güzel bir eğitim,", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(1030), " Siber güvenlik için Python ile araç geliştirebilir. Farklı uygulamaları Python ile otomatize edebilir. Web kazıma yapabilir..", "Sen,or", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(1030), true, 4, "Bu eğitimde ilk olarak Python programlamaya giriş yapılacak ve çeşitli Python kütüphaneleri kullanılacak sonrasında Socket programlama ile ağ sızma ve web kazıma öğretilecektir.", "Sınıf", "python.jpg", true, "Python ile Siber Güvenlik Uygulamaları", 0m, "python-ile-siber-guvenlik-uygulamalari" },
                    { 8, 80, "Oracle veritabanı ile ilgili, kurulum ve konfigurasyonlar adım adım anlatılacak ve Oracle Veritabanı Mimarisi, Oracle Networking gibi Veritabanı Yöneticiliği Temel Bilgiler örneklendirilecektir.", "Günümüzde Veri Bilimi, Makine Öğrenmesi, Yapay Zekâ, Büyük Veri gibi kavramlar oldukça popüler. Bu kavram ve teknolojileri besleyen asıl yapı verinin kendisidir.", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(1032), "Oracle Veritabanı Mimarisi ve Temel Bilgiler konularına hakim olur,.", "Medium", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(1032), true, 2, "Kurs tamamlandığında kariyerine Oracle Veritabanı Yöneticisi olarak devam etmek isteyen herkes ilgili alanlarda çalışabilecek temel bilgi ve beceri edinebilecektir.", "Online", "oracle.jpg", true, "Oracle Veritabanı", 0m, "oracle-veritabani" },
                    { 9, 80, "Veritabanı sistemleri ve ilişkisel veritabanlarını sorgulama dili olan SQL dilinin daha da derinlere inerek T-SQL'i öğretmek. T-SQL sorguları oluşturma, veri türleriyle çalışma, verileri toplama işlevlerini kullanma ve hata işleme konusunda uygulamalı deneyim kazanılmasını sağlamak.", "Günümüzde Veri Bilimi, Makine Öğrenmesi, Yapay Zekâ, Büyük Veri gibi kavramlar oldukça popüler. Bu kavram ve teknolojileri besleyen asıl yapı verinin kendisidir.", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(1034), "TSQL kullaranarak SQL Server üzerinde ileri seviye kodlama yapabilir,TSQL fonksiyonlarını kullanmayı öğrenir.Veribilimi projelerinin gerek şartı olan veri önişleme işlemlerini gerçekleştirebilir.", "Medium", new DateTime(2023, 9, 14, 7, 40, 9, 51, DateTimeKind.Local).AddTicks(1034), true, 2, "TSQL ile Veritabanı programlama eğitimi SQL Server’ın temel dili olan TSQL’i kullanarak veritabanı üzerinde kodlama yapmayı öğretmeyi amaçlamaktadır.", "Sınıf", "tsql.jpg", true, "TSQL ile Veri Tabanı Programlama", 0m, "tsql-ile-veritabani-programlama" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "About", "Address", "CompanyName", "Contact", "Questions" },
                values: new object[] { 1, "Akademi Merkezi", "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", "Bright Academy", "info@brightacademy.com", "Sık Sorulan Sorular" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "154e8035-0610-4840-9309-1c9d19e5c19e", "1" },
                    { "154e8035-0610-4840-9309-1c9d19e5c19e", "2" },
                    { "154e8035-0610-4840-9309-1c9d19e5c19e", "3" },
                    { "154e8035-0610-4840-9309-1c9d19e5c19e", "4" },
                    { "1cee760b-1b69-4d6b-8140-ac5149448a07", "5" },
                    { "1cee760b-1b69-4d6b-8140-ac5149448a07", "6" },
                    { "75606044-e0da-4df7-8e91-9ea41d31fe16", "b69e6273-31f7-417d-a2ab-08c3a1b4adaf" },
                    { "5d0ac846-22b0-43cf-8b5d-6b9d3f6b01b4", "ebddca1e-a6ac-4af1-8cdc-175a534457de" }
                });

            migrationBuilder.InsertData(
                table: "CourseCategories",
                columns: new[] { "CategoryId", "CourseId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 6, 2 },
                    { 1, 3 },
                    { 6, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 6 },
                    { 4, 7 },
                    { 5, 8 },
                    { 5, 9 }
                });

            migrationBuilder.InsertData(
                table: "CourseTrainees",
                columns: new[] { "CourseId", "TraineeId" },
                values: new object[,]
                {
                    { 1, "1" },
                    { 1, "2" },
                    { 1, "3" },
                    { 1, "4" },
                    { 2, "1" },
                    { 2, "3" },
                    { 2, "4" },
                    { 3, "2" },
                    { 3, "4" },
                    { 4, "1" },
                    { 5, "3" },
                    { 6, "3" },
                    { 7, "3" }
                });

            migrationBuilder.InsertData(
                table: "CourseTrainers",
                columns: new[] { "CourseId", "TrainerId" },
                values: new object[,]
                {
                    { 1, "5" },
                    { 2, "6" },
                    { 3, "5" },
                    { 4, "6" },
                    { 5, "5" },
                    { 5, "6" },
                    { 6, "6" },
                    { 7, "5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseCategories_CategoryId",
                table: "CourseCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTrainees_TraineeId",
                table: "CourseTrainees",
                column: "TraineeId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTrainers_TrainerId",
                table: "CourseTrainers",
                column: "TrainerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CourseCategories");

            migrationBuilder.DropTable(
                name: "CourseTrainees");

            migrationBuilder.DropTable(
                name: "CourseTrainers");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
