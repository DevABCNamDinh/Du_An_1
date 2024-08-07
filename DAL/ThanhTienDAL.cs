

using Data.Modee;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThanhTienDAL
    {
        CsdlDuAn1Context dbContext = new CsdlDuAn1Context();
        public ThanhTien? GetThanhTienbyMaHoaDon(string maHoaDon)
        {
            return dbContext.ThanhTiens.FirstOrDefault(x=>x.IdhoaDon==maHoaDon);
        }

        public List<ThanhTien> GetAllThanhtien()
        {
            return dbContext.ThanhTiens.ToList();
        }
        public void TaoThanhTien(ThanhTien thanhTien)
        {
            dbContext.ThanhTiens.Add(thanhTien);
            dbContext.SaveChanges();
        }
    }
}
