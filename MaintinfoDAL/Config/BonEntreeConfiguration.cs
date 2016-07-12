using MaintinfoBo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintinfoDAL.Config
{
    class BonEntreeConfiguration : EntityTypeConfiguration<BonEntree>
    {
        public BonEntreeConfiguration() : base()
        {
            ToTable("BON_ENTREE");
            HasKey(k => k.NumEntree);
            Property(p => p.NumEntree).HasColumnName("NUM_ENTREE").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Articleid).HasColumnName("DESIGNATION_ARTICLE");
            Property(p => p.QuantiteEntree).HasColumnName("QUANTITE_ENTREE");
           Property(p => p.DateEntree).HasColumnName("DATE_ENTREE");
            HasRequired(p => p.ArticleEntree).WithMany().HasForeignKey(p => p.Articleid);
            
        }
    }
}
