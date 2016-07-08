using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoBo;
using MaintinfoDAL.Config;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace MaintinfoDAL
{
    public class MaintinfoContext : DbContext
    {
        public MaintinfoContext() : base("name=MaintinfoConnection")
        { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<BonDeCommande> BonDeCommandes { get; set; }
        //public DbSet<BonEntree> BonEntrees { get; set; }
        //public DbSet<BonSortie> BonSorties { get; set; }
        //public DbSet<Depanneur> Depanneurs { get; set; }
        //public DbSet<SecteurGeographique> SecteurGeographiques { get; set; }
        //public DbSet<Specialite> Specialites { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new ArticleConfiguration());
            modelBuilder.Configurations.Add(new BonDeCommandeConfiguration());

            //modelBuilder.Entity<BonEntree>(entity =>{
            //    entity.ToTable("BON_ENTREE");
            //    entity.Property(e => e.ArticleEntree).IsRequired(true);
            //    entity.HasOne(a => a.ArticleEntree).WithMany().HasForeignKey(d => d.ArticleEntree.DesignationArticle);
            //});

            base.OnModelCreating(modelBuilder);
        }
        protected override DbEntityValidationResult ValidateEntity
    (System.Data.Entity.Infrastructure.DbEntityEntry entityEntry,
     IDictionary<object, object> items)
        {
            var result = new DbEntityValidationResult
             (entityEntry, new List<DbValidationError>());
            if (entityEntry.Entity is BonDeCommande && entityEntry.State == EntityState.Added)
            {
                BonDeCommande bdc = entityEntry.Entity as BonDeCommande;
                //check for uniqueness of post title 
                if (bdc.QuantiteCommande > (bdc.ArticleCommande.QuantiteArticle+bdc.ArticleCommande.SeuilMinimal))
                    result.ValidationErrors.Add(
                            new System.Data.Entity.Validation.DbValidationError("QuantiteCommande",
                            "Quantite doit etre correcte.")
                            );
            }
            if (result.ValidationErrors.Count > 0)
            {
                return result;
            }
            else
            {
                return base.ValidateEntity(entityEntry, items);
            }
        }

    }
}
