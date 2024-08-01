
using Data.Models;
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
        CsdlDuAn1NewNewContext dbContext = new CsdlDuAn1NewNewContext();

        public ChucVu? GetChucVuById(string maChucVu)
        {
            return dbContext.ChucVus.FirstOrDefault(cv => cv.IdchucVu == maChucVu);
        }
    }
}
