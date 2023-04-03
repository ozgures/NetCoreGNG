using Entities;
using Microsoft.EntityFrameworkCore;

namespace NetCoreGNG.Data
{
    public static class DataSeeding
    {
        public static void Seed(ApplicationBuilder app)
        {
            var scop = app.ApplicationServices.CreateScope();
            var context = scop.ServiceProvider.GetService<DatabaseContext>();

            context.Database.Migrate();
            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Users.Count()==0)
                {
                    User user = new User()
                    {
                        CreateDate = DateTime.Now,
                        IsActive = true,
                        Name = "admin",
                        Password= "1234",
                        Username= "ozgur",
                        Eposta="ozgur@gmail.com"
                    };
                    context.Users.Add(user);
                }
                context.SaveChanges();
            }
        }
    }
}
