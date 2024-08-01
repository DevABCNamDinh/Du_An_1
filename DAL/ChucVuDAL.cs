
using Data.DataBase;


using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChucVuDAL
    {
        CsdlDuAn1NewNew2Context dbContext = new CsdlDuAn1NewNew2Context();

        public ChucVu? GetChucVuById(string maChucVu)
        {
            return dbContext.ChucVus.FirstOrDefault(cv => cv.IdchucVu == maChucVu);
        }
    }
}
