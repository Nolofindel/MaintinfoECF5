using MaintinfoBo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintinfoDAL.Config
{
    class DepanneurConfiguration : EntityTypeConfiguration<Depanneur>
    {
        public DepanneurConfiguration() : base()
        {
            ToTable("DEPANNEUR");
            HasKey(k => k.MatriculeDepanneur);
            Property(p => p.MatriculeDepanneur).HasColumnName("MATRICULE_DEPANNEUR");
            Property(p => p.NomDepanneur).HasColumnName("NOM_DEPANNEUR");
            Property(p => p.NumSecteur).HasColumnName("NUMSECTEUR");
            Property(p => p.NumSpecialite).HasColumnName("NUM_SPECIALITE");
            HasRequired(p => p.SecteurGeographiqueDepanneur).WithMany().HasForeignKey(p => p.NumSecteur);
            HasRequired(p => p.SpecialiteDepanneur).WithMany().HasForeignKey(p => p.NumSpecialite);
        }
    }
}
