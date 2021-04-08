using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda";

        public static string CarAdded = "Araç eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string CarNameLengthShort = "Araç ismi 2'den kısa olamaz";
        public static string CarDailyPriceInvalid = "Araç günlük fiyatı 0'dan büyük olmalıdır";
        public static string CarDeleted = "Araç başarıyla silindi";
        public static string CarUpdated = "Araç başarıyla güncellendi";
        public static string CarsListed = "Araçlar listelendi";
        
        public static string RentalAdded = "Kiralama başarıyla eklendi.";
        public static string RentalDeleted = "Kiralama başarıyla silindi.";
        public static string RentalUpdated = "Kiralama başarıyla güncellendi";

        public static string UserAdded = "Kullanıcı başarıyla eklendi";
        public static string UserDeleted = "Kullanıcı başarıyla silindi";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi";

        public static string CustomerAdded = "Müşteri başarıyla eklendi";
        public static string CustomerDeleted = "Müşteri başarıyla silindi";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi";

        public static string ColorAdded = "Renk başarıyla eklendi";
        public static string ColorListed = "Renkler listelendi";
        public static string ColorDeleted = "Renk başarıyla silindi";
        public static string ColorUpdated = "Renk başarıyla güncellendi";

        public static string BrandAdded = "Marka başarıyla eklendi";
        public static string BrandUpdated = "Marka başarıyla güncellendi";
        public static string BrandDeleted = "Marka başarıyla silindi";

        public static string CarImageDeleted="Araç resmi silindi";
        public static string CarImageAdded="Araç resmi eklendi";
        public static string CarImagesListed="Araç resimleri listelendi";
        public static string CheckIfCarImageLimited="Araç için resim limitine ulaşıldı";

        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered="Kayıt oldu.";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string PasswordError="Parola hatası.";
        public static string SuccessfulLogin="Başarılı giriş.";
        public static string UserAlreadyExists="Kullanıcı mevcut.";
        public static string AccessTokenCreated="Token Oluşturuldu.";
        public static string CarNameAlreadyExists="Bu isimde zaten başka araç var";
    }
}
