
using Microsoft.EntityFrameworkCore;

namespace CarRental.Models{

    public class DataContext : DbContext {

        public DataContext(DbContextOptions<DataContext> options) : base(options){

        }

        //define here below which of your model classes should have a table on the DB
        
        public DbSet<Car> Cars {get; set;}

    }


}