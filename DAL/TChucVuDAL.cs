
using Microsoft.EntityFrameworkCore;

using Data.Model;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TChucVuDAL
    {

        CsdlDuAn1Context _context;
        public TChucVuDAL()

        {
            _context = new CsdlDuAn1Context(); 
        }

        public List <ChucVu> GetallChucVu()
        {
            return _context.ChucVus.ToList();
        }

        public ChucVu GetbyId(string id)
        {
            return _context.ChucVus.Find(id);
        }

        public bool Delete(string id)
        {
            try
            {
                var find = _context.ChucVus.Where(x => x.IdchucVu == id).ToList();
                if (find != null)
                {
                    for (int i = 0; i < find.Count; i++)
                    {
                        _context.ChucVus.Remove(find[i]);
                        _context.SaveChanges();
                    }

                }
                return true;
            } catch { return false; }
        }


    }
}
