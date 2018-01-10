﻿using AktuelListesi.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AktuelListesi.Service
{
    public interface IAktuelService
    {
        IEnumerable<AktuelDto> GetLatestAktuels();
        IEnumerable<AktuelDto> GetAktuels();
        IEnumerable<AktuelDto> GetAktuelsByCompanyId(int CompanyId);
        AktuelDto GetAktuel(int Id);
        AktuelDto AddAktuel(AktuelDto dto);
        AktuelDto AddOrGetAktuel(AktuelDto dto);
        AktuelDto UpdateAktuel(AktuelDto dto);
        bool SoftDeleteAktuel(int Id);
        bool HardDeleteAktuel(int Id);

    }
}
