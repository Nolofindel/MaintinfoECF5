using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoDAL;
using MaintinfoBo;
namespace BLL
{
   public  class UnitOfWork:IDisposable
    {
        private MaintinfoContext _context=null;
        private Repository<BonDeCommande> bdCommandeRepo = null;
        private Repository<BonEntree> bEntreeRepo = null;
        private Repository<BonSortie> bSortieRepo = null;

        public Repository<BonDeCommande> BdCommandeRepo
        {
            get
            {
                if (bdCommandeRepo == null)
                {
                    bdCommandeRepo = new Repository<BonDeCommande>(_context);
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
