using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class Database
    {
        public Database()
        {
            using (var context = new QLCuaHang())
            {
                System.Data.Entity.Database.SetInitializer(new Initializer());
            }
        }
    }
}