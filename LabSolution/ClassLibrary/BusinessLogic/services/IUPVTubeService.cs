﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Entities;

namespace UPVTube.Services
{
    public interface IUPVTubeService
    {
        void DBInitialization();
        void AddSubject(Subject s);
        void RegisterNewUser(string email, string name, DateTime date, string nick, string password);

        void RemoveAllData();

        void Commit();

        void LoginUser(string nick, string password);

        void logoutUser();

        void uploadNewContent(Content c, List<int> related);

        bool isLoggedIn(Member user);

        List<Content> SearchContentByDate(DateTime Start, DateTime End);


    }
}
