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
    public class BonDeCommandeRepo : Repository<BonDeCommande>
    {
        private MaintinfoContext m_Context = null;
        DbSet<BonDeCommande> m_DbSet;

        public BonDeCommandeRepo(MaintinfoContext context):base(context)
        {
            m_Context = context;
            m_DbSet = m_Context.Set<BonDeCommande>();
        }
        public new void Add(BonDeCommande entity)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                db.Entry(entity).State = EntityState.Added;
                db.Entry(entity.ArticleCommande).State = EntityState.Unchanged;
                db.SaveChanges();
            }
        }
    }
}
