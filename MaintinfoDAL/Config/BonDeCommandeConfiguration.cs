using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MaintinfoBo;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaintinfoDAL.Config
{
    public class BonDeCommandeConfiguration:EntityTypeConfiguration<BonDeCommande>
    {
        public BonDeCommandeConfiguration() : base()
        {
            ToTable("BON_DE_COMMANDE");
            HasKey(k => k.NumCommande);
            Property(p => p.NumCommande).HasColumnName("NUM_COMMANDE").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           Property(p => p.Articleid).HasColumnName("DESIGNATION_ARTICLE");
            Property(p => p.DateCommande).HasColumnName("DATE_COMMANDE");
           Property(p => p.QuantiteCommande).HasColumnName("QUANTITE_COMMANDE");
            Property(p => p.CommandeEffectue).HasColumnName("EFFECTUE");
            HasRequired(p => p.ArticleCommande).WithMany().HasForeignKey(f => f.Articleid);
        }
    }
}
