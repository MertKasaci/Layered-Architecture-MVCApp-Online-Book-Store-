using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Repository.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>

    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(

                new User() { Id = 1, FirstName = "Mert", LastName = "Kasaci", PhoneNumber = "5307802852" , Email="ksccmrtt@gmail.com",AddressDescription="Emek/Ankara/Turkey",UserName="PiskoKral" ,Password="aabb12" },
                new User() { Id = 2, FirstName = "Serkan", LastName = "Demir", PhoneNumber = "5307801234", Email = "dmrsrkn@gmail.com", AddressDescription = "Kecioren/Ankara/Turkey", UserName = "FeristahKing", Password = "eqwe23" },
                new User() { Id = 3, FirstName = "Berkan", LastName = "Aktikan", PhoneNumber = "5307804567", Email = "aktnbrkn@gmail.com", AddressDescription = "Birlik/Ankara/Turkey", UserName = "OlumsuzKral", Password = "sqwe123" },
                new User() { Id = 4, FirstName = "Dilsat", LastName = "Kisabacak", PhoneNumber = "5307801435", Email = "ksbckdlsd@gmail.com", AddressDescription = "Sisli/Istanbul/Turkey", UserName = "BloombergTV", Password = "qweq123" },
                new User() { Id = 5, FirstName = "Oguzhan", LastName = "Celik", PhoneNumber = "5307801235", Email = "clkgzhn@gmail.com", AddressDescription = "Kayseri/Kayseri/Turkey", UserName = "RumKral", Password = "qwee123" },
                new User() { Id = 6, FirstName = "Ahmet", LastName = "Ertürkmen", PhoneNumber = "5307803242", Email = "trkmnhmt@gmail.com", AddressDescription = "Esenler/Istanbul/Turkey", UserName = "FullArtiFullPisko", Password = "asda12312" }




                );
        }
    }
}
