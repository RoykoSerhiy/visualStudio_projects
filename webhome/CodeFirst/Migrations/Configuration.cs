namespace CodeFirst.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst.Contexts.UserProfileContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirst.Contexts.UserProfileContext context)
        {
           // if (System.Diagnostics.Debugger.IsAttached == false)
           //     System.Diagnostics.Debugger.Launch();
              //This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            //List<Driver> drivers = new List<Driver>(new Driver[]
            //    {
            //    new Driver{Name = "Petro" , Surname = "Vasilev" , MiddleName="Vasilevich" , Login="petya" , Password="1" , Phone="+380998844117" , LicenseNum="125478" , LicenseValidDate = new DateTime(2018 , 06 , 15) , Nationality = Nationality.Ukrainian,
            //    Car = new Car{CarBrand = "Ford" , CarModel = "Musstang GT" , CarNumber="AA2585PB" , VehicleType = VehicleType.Cupe , CarClass="A"}},
            //    new Driver{Name = "Ivan" , Surname = "Ivanenko" , MiddleName="Kuzmich" , Login="KUZmich" , Password="2" ,  Phone="+380685458894" , LicenseNum="876543" , LicenseValidDate = new DateTime(2019 , 04 , 19), Nationality = Nationality.Ukrainian,
            //    Car = new Car{CarBrand = "ZAZ" , CarModel = "Forza" , CarNumber="AC1258¿ " , VehicleType = VehicleType.Sedan , CarClass="A"}},
            //    new Driver{Name = "Vasiliy" , Surname = "Ivanchuk" , MiddleName="Olegovich" , Login="Vasya" , Password="3" , Phone="+380589888968" , LicenseNum="585245" , LicenseValidDate = new DateTime(2017 , 12 , 31), Nationality = Nationality.englishman,
            //    Car = new Car{CarBrand = "Mersedes" , CarModel = "Vito" , CarNumber="AA4878DC" , VehicleType = VehicleType.Minivan , CarClass="A"}},
            //    new Driver{Name = "Igor" , Surname = "Chertopoloh" , MiddleName="Stepanovich" , Login="@SSS" , Password="4" , Phone="+380895659698" , LicenseNum="753159" , LicenseValidDate = new DateTime(2020 , 01 , 08), Nationality = Nationality.American,
            //    Car = new Car{CarBrand = "VW" , CarModel = "GolfIII" , CarNumber="AA7678DC" , VehicleType = VehicleType.Cupe , CarClass="A"}},
            //    }).ToList();
            //List<User> users = new List<User>(new User[]
            //{
            //    new User{Name = "Serhiy" , Surname = "Royko" , MiddleName = "Oleksandrovich" , Login = "s" , Password="1",Phone="123123123" , Nationality = Nationality.Ukrainian},
            //}).ToList();
            //var drivers = context.Driver.Include("Car").ToList();
            //var Driver = drivers.Last();
            //var users = context.User.ToList();
            //var User = users[0];
           // List<History> history = new List<History>( new History[]
           // {
           //     new History{Driver = drivers[0] , User=users[0] , StartTime = new DateTime(2015,06,25,13,45,00) , FinishTime = new DateTime(2015,06,25,13,59,00),
           //     DepatureAddress="Chornovola14" , DestinationAddress="Soborna62"},
           //     new History{Driver = drivers[1] , User=users[0] , StartTime = new DateTime(2015,06,25,14,25,00) , FinishTime = new DateTime(2015,06,25,13,50,00),
           //     DepatureAddress="Chornovola14" , DestinationAddress="Soborna62"},
           //     new History{Driver = drivers.Last() , User=users[0] , StartTime = new DateTime(2015,06,25,13,45,00) , FinishTime = new DateTime(2015,06,25,13,59,00),
           //     DepatureAddress="Chornovola14" , DestinationAddress="Soborna62"},
           // }).ToList();
            
            //context.Driver.AddRange(drivers);
            //context.User.AddRange(users);
            //context.History.AddRange(history);
           // context.SaveChanges();
            
            //List<Role> roles = new List<Role>();
            //roles.Add(new Role { Name = "User" });
            //roles.Add(new Role { Name = "Driver" });
            //roles.Add(new Role { Name = "Admin" });
            //
            //context.Roles.AddRange(roles);
            //
            //var usersInfoes = drivers.Select(d => d as UserInfo).ToList();
            //usersInfoes.AddRange(users.Select(u => u as UserInfo));
            //for (int i = 0; i < usersInfoes.Count; i++)
            //{
            //    var user = usersInfoes[i];
            //    if (user.GetType() == typeof(Driver))
            //    {
            //        user.Roles.Add(roles[1]);
            //    }
            //    else
            //    {
            //        user.Roles.Add(roles[0]);
            //    }
            //}
            //
            //
            //Administrator admin = new Administrator
            //{
            //    Login = "admin",
            //    Password = "admin",
            //    Roles = roles
            //};
            //context.Admins.Add(admin);
           List<Street> streets = new List<Street>( new Street[]{
                   new Street { Name = "Chornovola" },
                   new Street { Name = "Soborna" },
                  
           });
           List<Region> regions = new List<Region>(
                   new Region[]{
                       new Region { Name="Central", Streets = streets}

                });
           City city = new City { Name = "Rivne" , Regions = regions};
           context.City.Add(city);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                var e = ex;
            }
        }
    }
}
