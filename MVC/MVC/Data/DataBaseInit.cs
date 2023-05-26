using Microsoft.EntityFrameworkCore;

namespace MVC.Data
{
    public class DataBaseInit
    {
        public static void Init(LibraryContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}

