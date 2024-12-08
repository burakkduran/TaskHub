using Microsoft.EntityFrameworkCore;

namespace TaskHub.Models
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lesson>().HasData(
            new Lesson() { Id = 1, Title = "İnternet Programcılığı"},
            new Lesson() { Id = 2, Title = "Yazılım Mimarileri"},
            new Lesson() { Id = 3, Title = "Grafik Animasyon 1"},
            new Lesson() { Id = 4, Title = "Bilgisayar Donanımı"},
            new Lesson() { Id = 5, Title = "İçerik Yönetim Sistemleri"}
            );

        }
    }
}
