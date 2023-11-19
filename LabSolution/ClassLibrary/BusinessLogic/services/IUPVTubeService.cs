using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Entities;

namespace UPVTube.Services
{
    public interface IUPVTubeService
    {
        void registerNewUser(string email, string name, DateTime date, string nick, string password);

        void removeAllData();

        void loginUser(string nick, string password);

        void logoutUser(Member user);

        void uploadNewContent(Member user);

        bool isLoggedIn(Member user);

        List<Content> SearchContentByDate(DateTime Start, DateTime End);


    }
}
