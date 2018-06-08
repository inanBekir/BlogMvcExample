using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category() {KategoriAdi="C#"},
                new Category() {KategoriAdi="C#2"},
                new Category() {KategoriAdi="C#3"},
                new Category() {KategoriAdi="C#4"},
            };

            foreach (var item in kategoriler)
            {

                context.Kategoriler.Add(item);

            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog() { Baslik="C# deşegates Hakkında", Aciklama="C# deşegates Hakkında C# deşegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10) , Anasayfa=true,Onay=false,icerik="C# deşegates HakkındaC# deşegates HakkındaC# deşegates HakkındaC# deşegates Hakkında", Resim="1.jpg",CategoryId=1},
                new Blog() { Baslik="C# deşegates ", Aciklama="C# deşegates Hakkında C# deşegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10) , Anasayfa=true,Onay=true,icerik="C# deşegates HakkındaC# deşegates HakkındaC# deşegates HakkındaC# deşegates Hakkında", Resim="1.jpg",CategoryId=1},
                new Blog() { Baslik="C# deşegates ", Aciklama="C# deşegates Hakkında C# deşegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-30) , Anasayfa=false,Onay=false,icerik="C# deşegates HakkındaC# deşegates HakkındaC# deşegates HakkındaC# deşegates Hakkında", Resim="1.jpg",CategoryId=1},
                new Blog() { Baslik="C# generic Hakkında", Aciklama="C# deşegates Hakkında C# deşegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-40) , Anasayfa=true,Onay=true,icerik="C# deşegates HakkındaC# deşegates HakkındaC# deşegates HakkındaC# deşegates Hakkında", Resim="2.jpg",CategoryId=2},
                new Blog() { Baslik="C# deşegates Hakkında", Aciklama="C# deşegates Hakkında C# deşegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10) , Anasayfa=true,Onay=true,icerik="C# deşegates HakkındaC# deşegates HakkındaC# deşegates HakkındaC# deşegates Hakkında", Resim="2.jpg",CategoryId=2},
                new Blog() { Baslik="C# deşegates Hakkında", Aciklama="C# deşegates Hakkında C# deşegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-20) , Anasayfa=false,Onay=true,icerik="C# deşegates HakkındaC# deşegates HakkındaC# deşegates HakkındaC# deşegates Hakkında", Resim="2.jpg",CategoryId=2},
                new Blog() { Baslik="C# deşegates Hakkında", Aciklama="C# deşegates Hakkında C# deşegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10) , Anasayfa=true,Onay=true,icerik="C# deşegates HakkındaC# deşegates HakkındaC# deşegates HakkındaC# deşegates Hakkında", Resim="3.jpg",CategoryId=3},
                new Blog() { Baslik="C# deşegates Hakkında", Aciklama="C# deşegates Hakkında C# deşegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10) , Anasayfa=true,Onay=true,icerik="C# deşegates HakkındaC# deşegates HakkındaC# deşegates HakkındaC# deşegates Hakkında", Resim="3.jpg",CategoryId=3},
                new Blog() { Baslik="C# deşegates Hakkında", Aciklama="C# deşegates Hakkında C# deşegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10) , Anasayfa=false,Onay=true,icerik="C# deşegates HakkındaC# deşegates HakkındaC# deşegates HakkındaC# deşegates Hakkında", Resim="3.jpg",CategoryId=3},
                new Blog() { Baslik="C# deşegates Hakkında", Aciklama="C# deşegates Hakkında C# deşegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-5) , Anasayfa=true,Onay=false,icerik="C# deşegates HakkındaC# deşegates HakkındaC# deşegates HakkındaC# deşegates Hakkında", Resim="4.jpg",CategoryId=4},
                new Blog() { Baslik="C# deşegates Hakkında", Aciklama="C# deşegates Hakkında C# deşegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-60) , Anasayfa=true,Onay=true,icerik="C# deşegates HakkındaC# deşegates HakkındaC# deşegates HakkındaC# deşegates Hakkında", Resim="4.jpg",CategoryId=4},
                new Blog() { Baslik="C# deşegates Hakkında", Aciklama="C# deşegates Hakkında C# deşegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10) , Anasayfa=false,Onay=false,icerik="C# deşegates HakkındaC# deşegates HakkındaC# deşegates HakkındaC# deşegates Hakkında", Resim="4.jpg",CategoryId=4},

            };
            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }

    }
}