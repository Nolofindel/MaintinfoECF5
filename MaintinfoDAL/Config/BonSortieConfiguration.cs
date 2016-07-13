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
    class BonSortieConfiguration : EntityTypeConfiguration<BonSortie>
    {
        public BonSortieConfiguration() : base()
        {
            ToTable("BON_SORTIE");
            HasKey(k => k.NumSortie);
            Property(p => p.NumSortie).HasColumnName("NUM_SORTIE");
            Property(p => p.Articleid).HasColumnName("DESIGNATION_ARTICLE");
            Property(p => p.QuantiteSortie).HasColumnName("QUANTITE_SORTIE");
            Property(p => p.DateDemande).HasColumnName("DATE_SORTIE");
            HasRequired(p => p.ArticleSortie).WithMany().HasForeignKey(p => p.Articleid);
            HasRequired(p => p.Depanneur).WithMany().HasForeignKey(p => p.NumDepanneur);
        }
    }
}
