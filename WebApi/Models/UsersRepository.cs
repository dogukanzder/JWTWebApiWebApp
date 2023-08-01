using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class UsersRepository : IDisposable
    {
        readonly UserModel context = new UserModel();
        public USERS ValidateUser(string username, string password) //Kullanıcı adı ve şifrenin doğruluğunu kontrol eden metod
        {
            return context.USERS.FirstOrDefault(user =>
            user.KULLANICI_ADI.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.SIFRE == password);
        }
        public List<UsersWithoutPass> GetUsers() //Şifre hariç bilgileri geri döndüren GetUsers() metodu
        {
            List<USERS> users = context.USERS.ToList();
            List<UsersWithoutPass> usersWithoutPass = new List<UsersWithoutPass>();
            foreach (var user in users)
            {
                UsersWithoutPass userWithoutPass = new UsersWithoutPass
                {
                    ID = user.ID,
                    ADI = user.ADI,
                    SOYADI = user.SOYADI,
                    KULLANICI_ADI = user.KULLANICI_ADI
                };
                usersWithoutPass.Add(userWithoutPass);
            }

            return usersWithoutPass;
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}