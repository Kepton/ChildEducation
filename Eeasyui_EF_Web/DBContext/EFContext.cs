using Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;


namespace MyDBContext
{
    public class EFContext : DbContext, IDisposable
    {
        public EFContext() :
            base("name=" + ConfigName) 
        {
        }
        public static string ConfigName { get; set; }
        public DbSet<school> schools { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new schoolMap());
        }

        public string ConString()
        {
            return this.Database.Connection.ConnectionString;
        }

        public DbTransaction BeginTransaction()
        {

            //WfStartedResult StartProcess(IDbConnection conn, WfAppRunner starter, IDbTransaction trans);

            DbConnection dbConnection = this.Database.Connection;
            dbConnection.Open();
            return dbConnection.BeginTransaction();
        }
        public DbConnection dbConnection()
        {
            return this.Database.Connection;
        }
    }
}
