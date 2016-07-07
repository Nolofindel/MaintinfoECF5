using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoBo;
using MaintinfoDAL.Config;
using System.Data.Entity;

namespace MaintinfoDAL
{
    public class MaintinfoContext : DbContext
    {
        public MaintinfoContext() : base("name=MaintinfoConnection")
        { }

        public DbSet<Article> Articles { get; set; }
        //public DbSet<BonDeCommande> BonDeCommandes { get; set; }
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

        public System.Data.Entity.DbSet<MaintinfoBo.BonDeCommande> BonDeCommandes { get; set; }
    }
}
