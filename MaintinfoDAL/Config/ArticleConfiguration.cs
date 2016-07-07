using MaintinfoBo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintinfoDAL.Config
{
    public class ArticleConfiguration : EntityTypeConfiguration<Article>
    {
        public ArticleConfiguration() : base()
        {
            ToTable("ARTICLE");
            HasKey(k => k.DesignationArticle);
            Property(p => p.DesignationArticle).HasColumnName("DESIGNATION_ARTICLE");
            Property(p => p.NomArticle).HasColumnName("NOM_ARTICLE");
            Property(p => p.QuantiteArticle).HasColumnName("QUANTITE_STOCK");
            Property(p => p.SeuilMinimal).HasColumnName("SEUIL_MINIMAL");
            Property(p => p.Parent).HasColumnName("PARENT_DESIGNATION_ARTICLE").IsOptional();
        }
    }
}
