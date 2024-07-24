using DAL;
using Data.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DChucVuBUS
    {
        public DChucVuDAL _chucvuDAL = new DChucVuDAL();

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
