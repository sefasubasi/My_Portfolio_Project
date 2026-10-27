using Microsoft.EntityFrameworkCore;
using My_Portfolio_Project.Controllers.Entities;

namespace My_Portfolio_Project.Contex
{
    public class PortfolioContext:DbContext
    {
        public DbSet<Experience> Experiences{ get; set; }
        public DbSet<HeroSection> HeroSections { get; set; }
        public DbSet<HeroTitle> HeroTitles { get; set; }
        public DbSet<Message> Messages{ get; set; }
    }
}
