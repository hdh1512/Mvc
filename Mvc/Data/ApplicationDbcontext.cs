using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc.Controllers;
using MvcMovie.Models;
namespace MvcMovie.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        { }
        public DbSet<Person> Person { get; set; }
    }
}