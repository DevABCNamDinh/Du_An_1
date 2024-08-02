using Data.Data;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LLoaiSanPhamDAL
    {
        CsdlDuAn1Context _context;
        public LLoaiSanPhamDAL()
        {
            _context = new CsdlDuAn1Context();
        }

        public List<LoaiSanPham> GetallLoaiSanPham()
        {
            return _context.LoaiSanPhams.ToList();
        }

        public LoaiSanPham GetbyId(string id)
        {
            return _context.LoaiSanPhams.Find(id);
        }

        public bool CreateLSP(LoaiSanPham loaiSanPham)
        {

            try
            {
                _context.LoaiSanPhams.Add(loaiSanPham);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public void createLSP(LoaiSanPham loaiSanPham)
        {
            _context.LoaiSanPhams.Add(loaiSanPham);
            _context.SaveChanges();
        }

        public bool Update(LoaiSanPham loaiSanPham)
        {

            try
            {
                var UpdateItem = _context.LoaiSanPhams.Find(loaiSanPham.IdloaiSanPham);
                UpdateItem.IdkhuyenMai = loaiSanPham.IdkhuyenMai;
                UpdateItem.LoaiSanPham1 = loaiSanPham.LoaiSanPham1;

                _context.LoaiSanPhams.Update(UpdateItem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    
        public List<string> GetFilteredOptions(string filter)
            {
                
                List<string> options = new List<string>
                 {
                    "Cơ Thể",
                    "Mặt"
          
                    };

                return options.Where(o => o.StartsWith(filter)).ToList();
            }




        public bool SuaLoaiSanPham(LoaiSanPham sp)
        {
            if (sp == null)
            {
                return false;
            }
            _context.LoaiSanPhams.Update(sp);
            _context.SaveChanges();
            return true;
        }




    }
}
