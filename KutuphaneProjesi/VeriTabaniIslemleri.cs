using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace KutuphaneProjesi
{
    internal class VeriTabaniIslemleri
    {
        string baglantiCumlesi = ConfigurationManager.ConnectionStrings["baglanticumlesi"].ConnectionString;
        // App.config dosyasının içindeki veri tabanı bağlantı cümlesi bir değişkene aktarıldı

        public MySqlConnection baglan()
        {
            MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi);
            // Veri tabanı bağlantısı oluşturuldu
            MySqlConnection.ClearPool(baglanti); // Önceki bağlantılar temizlendi
            return baglanti; // Oluşturulan bağlantı fonksiyonun çağırıldığı yere gönderildi
        }
    }
}
