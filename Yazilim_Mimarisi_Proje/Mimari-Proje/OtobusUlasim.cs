﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari_Proje
{
    public class OtobusUlasim : Ulasim
    {
        public OtobusUlasim(string firmaAdi, DateTime gidisTarihi, DateTime donusTarihi, int fiyat, string ulasimTipi)
            : base(firmaAdi, gidisTarihi, donusTarihi, fiyat, ulasimTipi)
        {
        }
    }
}
