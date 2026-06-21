using System;
using System.Collections.Generic;
using RentaniApp.Models;

namespace RentaniApp.Controllers
{
    internal class BerandaController
    {
        public Dictionary<string, object> GetStatistikPenyewa(int idPenyewa)
        {
            try
            {
                return Penyewaan.AmbilStatistikBeranda(idPenyewa);
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memproses data beranda: " + ex.Message);
            }
        }
    }
}