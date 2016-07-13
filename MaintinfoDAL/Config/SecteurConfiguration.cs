using MaintinfoBo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintinfoDAL.Config
{
    class SecteurConfiguration:EntityTypeConfiguration<SecteurGeographique>
    {
        public SecteurConfiguration() : base()
        {
            ToTable("SECTEUR_GEOGRAPHIQUE");
            HasKey(k => k.NumSecteur);
            Property(p => p.NumSecteur).HasColumnName("NUMSECTEUR");
            Property(p => p.NomSecteurGeographique).HasColumnName("NOMSECTEUR");


        }
    }
}