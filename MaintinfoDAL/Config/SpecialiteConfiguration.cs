using MaintinfoBo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintinfoDAL.Config
{
    class SpecialiteConfiguration : EntityTypeConfiguration<Specialite>
    {
        public SpecialiteConfiguration() : base()
        {
            ToTable("SPECIALITE");
            HasKey(k => k.NumSpecialite);
            Property(p => p.NumSpecialite).HasColumnName("NUM_SPECIALITE");
            Property(p => p.NomSpecialite).HasColumnName("NOM_SPECIALITE");
            

        }
    }
}