using DAL;

using Data.DataBase;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DChucVuBUS
    {
        public TChucVuDAL _chucvuDAL = new TChucVuDAL();

        public List<ChucVu> Getallchucvu()
        {
            return _chucvuDAL.GetallChucVu();
        }

        public ChucVu Getbyid(string id)
        {
            return _chucvuDAL.GetbyId(id);
        }
    }
}
