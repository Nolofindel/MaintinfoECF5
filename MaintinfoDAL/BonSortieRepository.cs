using MaintinfoBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace MaintinfoDAL
{
    public class BonSortieRepository : Repository<BonSortie>
    {
        private MaintinfoContext m_Context = null;
        DbSet<BonSortie> m_DbSet;

        public BonSortieRepository(MaintinfoContext context) : base(context)
        {
            m_Context = context;
            m_DbSet = m_Context.Set<BonSortie>();
        }
        public new void Add(BonSortie entity)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                db.Entry(entity).State = EntityState.Added;
                db.Entry(entity.ArticleSortie).State = EntityState.Unchanged;
                db.Entry(entity.Depanneur).State = EntityState.Unchanged;
                db.Entry(entity.Depanneur.SecteurGeographiqueDepanneur).State = EntityState.Unchanged;
                db.Entry(entity.Depanneur.SpecialiteDepanneur).State = EntityState.Unchanged;
                db.SaveChanges();
            }
        }
    }
}
