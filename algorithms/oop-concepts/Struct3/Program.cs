using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct GPSKonum
{
    public double Latitude { get; private set; }  // Enlem
    public double Longitude { get; private set; }  // Boylam

    // Yapıcı (Constructor) metodu
    public GPSKonum(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    // Haversine formülüne göre mesafeyi hesaplayan metot
    public static double Mesafe(GPSKonum konum1, GPSKonum konum2)
    {
        double R = 6371;  // Dünya'nın yarıçapı kilometre cinsinden
        double lat1Rad = DegerToRadyan(konum1.Latitude);  // Enlem derecesi radyan cinsine çevrilir
        double lon1Rad = DegerToRadyan(konum1.Longitude);  // Boylam derecesi radyan cinsine çevrilir
        double lat2Rad = DegerToRadyan(konum2.Latitude);  // Enlem derecesi radyan cinsine çevrilir
        double lon2Rad = DegerToRadyan(konum2.Longitude);  // Boylam derecesi radyan cinsine çevrilir

        double dLat = lat2Rad - lat1Rad;  // Enlem farkı
        double dLon = lon2Rad - lon1Rad;  // Boylam farkı

        // Haversine formülü kullanılarak mesafe hesaplanır
        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                   Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                   Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return R * c;  // Mesafe kilometre olarak döndürülür
    }

    // Dereceyi radyana çeviren yardımcı metot
    private static double DegerToRadyan(double derece)
    {
        return derece * (Math.PI / 180);  // Dereceyi radyan cinsine çevirir
    }
}

class Program
{
    static void Main()
    {
        GPSKonum konum1 = new GPSKonum(40.7128, -74.0060);  // New York koordinatları
        GPSKonum konum2 = new GPSKonum(34.0522, -118.2437);  // Los Angeles koordinatları

        double mesafe = GPSKonum.Mesafe(konum1, konum2);  // İki konum arasındaki mesafe hesaplanıyor
        Console.WriteLine($"Mesafe: {mesafe} km");  // Mesafe yazdırılıyor

        Console.Read();
    }
}
