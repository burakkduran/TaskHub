using Microsoft.EntityFrameworkCore;

namespace TaskHub.Models
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lessons>().HasData(
            new Lessons() { Id = 1, Title = "İnternet Programcılığı"},
            new Lessons() { Id = 2, Title = "Yazılım Mimarileri"},
            new Lessons() { Id = 3, Title = "Grafik Animasyon 1"},
            new Lessons() { Id = 4, Title = "Bilgisayar Donanımı"},
            new Lessons() { Id = 5, Title = "İçerik Yönetim Sistemleri"}
            );

        }
    }
}
