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
        void registerNewUser(string email, string name, DateTime date, string nick, string password);

        void removeAllData();

        void loginUser(string nick, string password);

        bool isLoggedIn(Member user);

        List<Content> SearchContent(DateTime Start, DateTime End, string nick, string title, string subject)
        List<Content> GetAllPendingContents();
        void AddEvaluation(int contentId, string RejectionReason, bool rejected);
    }
}
