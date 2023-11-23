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

        void logoutUser();

        void uploadNewContent(string title, string desc, string uri, bool privacy, List<Subject> related);

        bool isLoggedIn(Member user);

        List<Content> SearchContentByDate(DateTime Start, DateTime End);


    }
}
