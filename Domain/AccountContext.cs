namespace Domain
{
    using Domain.Entity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class AccountContext : DbContext
    {
        static AccountContext()
        {
            Database.SetInitializer<AccountContext>(new StoreDbInitializer());
        }
        public AccountContext(string connectionString)
            : base(connectionString)
        { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Account> Acoounts { get; set; }
    }
    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext db)
        {
            db.Users.Add(new User { FirstName = "Denis", LastName = "Kobl", CreateDate = DateTime.Now });
            db.SaveChanges();
        }
    }
}