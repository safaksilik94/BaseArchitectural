using Safak.Core.Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.Business.Constants
{
    public static class Messages
    {
        //Todo:Çoklu Dil desteği için Db ile yönetilmeli.
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydeldi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
