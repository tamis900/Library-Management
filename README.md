# Kütüphane Yönetim Paneli

Hakkında:
Bu proje, C# (.NET) ve MySQL kullanılarak geliştirilmiş bir Kütüphane Yönetim Sistemidir. Kütüphane işlemlerini yönetmek için basit ve kullanıcı dostu bir arayüz sunar.

Özellikler:
-> Kitap yönetimi (Ekleme, Güncelleme, Silme, Arama)
-> Üye yönetimi
-> Ödünç alma ve iade işlemleri
-> MySQL veritabanı entegrasyonu
-> CRUD (Oluşturma, Okuma, Güncelleme, Silme) işlemleri

# Kullanılan Teknolojiler:
- C#
- .NET
- MySQL
- Windows Forms

Amaç:
Bu proje; C#, veritabanı yönetimi, SQL ve masaüstü uygulama geliştirme konusundaki becerilerimi geliştirmek amacıyla hazırlanmıştır.



# KULLANIM KLAVUZU:
#### -> Kendi MySQL veritabanınızı oluşturun. İsmi "kutuphane" olsun.
#### -> Tablolar kısmına "kitaplar", "kitap_turleri", "ogrenciler" ve "odunc_kitaplar" tablolarını ekleyiniz.

#### -> "kitaplar" tablosu içerikleri:
```
int kitap_id // primary key otomatik artış (auto increment)
tinyint tur_id
varchar kitap_adi
varchar yazar
varchar yayinevi
smallint sayfa_sayisi
```
#### -> "kitap_turleri" tablosu içerikleri:
```
tinyint tur_id // primary key otomatik artış (auto increment)
varchar tur_adi
```
#### -> "ogrenciler" tablosu içerikleri:
```
int ogrenci_no // primary key
varchar ad
varchar soyad
tinyint sinif
varchar cinsiyet
varchar telefon
```
#### -> "odunc_kitaplar" tablosu içerikleri:
```
int id // primary key auto increment
int ogr_no
int kitap_id
date verilis_tarihi
date teslim_tarihi
varchar aciklama
```

#### -> Reverse Engineer kısmından veri tabanınızın diyagramını oluşturun.
#### -> Yanda verilen resimdeki simgeyi bulup tıklayınız. <img width="58" height="35" alt="image" src="https://github.com/user-attachments/assets/493fe358-27cd-44ce-b269-0e5212b4a3f9" />

#### -> Altta verilen resim gibi gözükene kadar adımlara uyunuz:
<img width="713" height="301" alt="image" src="https://github.com/user-attachments/assets/9c8ac797-c134-482f-8ffd-15b4fb626d2e" />


* "kitaplar" tablosundaki FK alanı olan tur_id alanı seçildikten sonra "kitap_turleri" tablosundaki PK alanı
olan tur_id alanını seçiniz.
* "odunc_kitaplar" tablosunda FK alanı olan ogr_no, sonra "ogrenciler" tablosundaki PK alanı olan öğrenci_no alanını seçiniz.
* "odunc_kitaplar" tablosunda FK alanı olan kitap_id, sonra "kitaplar" tablosunda PK alanı olan kitap_id alanını seçiniz.
*  İlişkiyi tanımlamak için oluşturulan bağlantıya çift tıklandıktan sonra alt tarafta "Relationship" penceresinde
"Foreign Key" sekmesine geçiniz. Sonra da "Identifying Relationship" kutucuğunu seçiniz.
* Yapılan değişikliklerin veri tabanına uygulanması için "Database" menüsünden "Synchronize Model" seçeneğini işaretleyiniz.


#### -> Veri tabanına istediğiniz gibi veri girişi yapabilirsiniz.

### MySQL Server Bağlantısı:
<img width="930" height="96" alt="image" src="https://github.com/user-attachments/assets/083b7aa2-259c-4688-bc0f-ebe6f947dd08" />

Yukarıdaki görselde göründüğü gibi projenin App.Config sayfasını açıp alttaki kodu kendi sunucunuza göre yazınız.
```
<connectionStrings>
	<add name="baglanticumlesi" connectionString="Server=(sunucu adınız);Database=kutuphane;Uid=(kullanıcı);Pwd=(şifre);" />
</connectionStrings>
```







 
