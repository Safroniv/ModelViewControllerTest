using Microsoft.EntityFrameworkCore;
using ModelViewControllerTest.Models;

namespace ModelViewControllerTest
{
    public class WebStoreContext : DbContext
    {
        public WebStoreContext (DbContextOptions option) : base (option)
        {

        }
        public DbSet <Product> Products { get; set; }
    }
}
