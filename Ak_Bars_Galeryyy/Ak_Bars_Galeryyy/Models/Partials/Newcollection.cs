using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ak_Bars_Galeryyy.Models
{
    public partial class Newcollection
    {



        public string GetPhoto
        {
            get
            {
              
                return Directory.GetCurrentDirectory() + @"\Resources\" + Photo.Trim();
            }
        }

    }
}