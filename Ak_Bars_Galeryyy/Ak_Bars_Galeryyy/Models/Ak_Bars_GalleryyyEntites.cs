using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ak_Bars_Galeryyy.Models
{
    public partial class Ak_Bars_GalleryyyEntities : DbContext
    {
        private static Ak_Bars_GalleryyyEntities _context;
        public static Ak_Bars_GalleryyyEntities GetContext()
        {
            if(_context == null)
            {
                _context = new Ak_Bars_GalleryyyEntities();
            }
            return _context;
        }
    }
}
