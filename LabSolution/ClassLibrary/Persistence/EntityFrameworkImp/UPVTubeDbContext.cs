using UPVTube.Entities;
using System;
using System.Data.Entity;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace UPVTube.Persistence
{
    public class UPVTubeDbContext : DbContextISW
    {
        public UPVTubeDbContext() : base("Name=UPVTubeDbConnection") //this is the connection string name
        {
            /*
            See DbContext.Configuration documentation
            */
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        static UPVTubeDbContext()
        {
            //Database.SetInitializer<UPVtubeDbContext>(new CreateDatabaseIfNotExists<UPVTubeDbContext>());
            Database.SetInitializer<UPVTubeDbContext>(new DropCreateDatabaseIfModelChanges<UPVTubeDbContext>());
            //Database.SetInitializer<UPVtubeDbContext>(new DropCreateDatabaseAlways<UPVTubeDbContext>());
            //Database.SetInitializer<UPVtubeDbContext>(new UPVTubeDbContextInitializer());
            //Database.SetInitializer(new NullDatabaseInitializer<UPVTubeDbContext>());
        }

        // DbSets for persistent classes in your case study
        // To Do

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Model configuration to avoid circular delete infinite operations
            // If this is not done an exception is generated

            modelBuilder.Entity<Content>()
                        .HasRequired(c => c.Owner)
                        .WithMany(m=>m.Contents)
                        .WillCascadeOnDelete(false);
        }

        // Generic method to clear all the data (except some relations if needed)
         public override void RemoveAllData()
        {
            clearSomeRelationships();

            base.RemoveAllData(); 
        }

        // Sometimes it is needed to clear some relationships explicitly 
        private void clearSomeRelationships()
        {
            //TODO Para que no de problemas en el borrado en cascada de los miembros por la relación SubscribedTo hay que eliminar la relación (poner a null) antes de borrar todos los miembros relacionados
            foreach (Member m in Members)
                m.SubscribedTo.Clear(); // Elimina las relaciones entre los miembros por la relación SubscribedTo

            SaveChanges();
        }

    }

}
