using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Services
{
    public interface IUPVTubeService
    {
        void registerNewUser(string email, string name, DateTime date, string nick, string password);

        void removeAllData();

        void loginUser(string nick, string password);


    }
}
