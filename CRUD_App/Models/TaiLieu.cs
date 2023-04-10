using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CRUD_App.Data
{
    public class TaiLieu
    {
        long maTaiLieu;
        string tenTaiLieu;

        public long MaTaiLieu { get => maTaiLieu; set => maTaiLieu = value; }
        public string TenTaiLieu { get => tenTaiLieu; set => tenTaiLieu = value; }
    }
}
