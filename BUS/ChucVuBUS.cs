using DAL;

using Data.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChucVuBUS
    {
        ChucVuDAL chucVuDAL = new ChucVuDAL();

        public ChucVu? GetChucVuById(string maChucVu)
        {
            return chucVuDAL.GetChucVuById(maChucVu);
        }
    }
}
