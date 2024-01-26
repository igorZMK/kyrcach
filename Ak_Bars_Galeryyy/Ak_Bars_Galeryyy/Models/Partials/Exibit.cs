using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ak_Bars_Galeryyy.Models
{
    public partial class Exibit
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
