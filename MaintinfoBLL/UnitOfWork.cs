using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoDAL;
using MaintinfoBo;
namespace MaintinfoBLL
{
   public  class UnitOfWork:IDisposable
    {
        private MaintinfoContext _context=null;
        private BonDeCommandeRepo bdCommandeRepo = null;
        private Repository<BonEntree> bEntreeRepo = null;
        private Repository<BonSortie> bSortieRepo = null;

        public BonDeCommandeRepo BdCommandeRepo
        {
            get
            {
                if (bdCommandeRepo == null)
                {
                    bdCommandeRepo = new BonDeCommandeRepo(_context);
                }
                return bdCommandeRepo;
            }

        }

        public Repository<BonEntree> BEntreeRepo
        {
            get
            {
                if(bEntreeRepo==null)
                {
                    bEntreeRepo = new Repository<BonEntree>(_context);
                }
                return bEntreeRepo;
            }


        }

        public Repository<BonSortie> BSortieRepo
        {
            get
            {
                if (bSortieRepo == null)
                {
                    bSortieRepo = new Repository<BonSortie>(_context);
                }
                return bSortieRepo;
            }


        }

        public UnitOfWork()
        {
            _context = new MaintinfoContext();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}
