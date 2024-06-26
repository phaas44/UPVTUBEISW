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
        void RegisterNewUser(string email, string name, string nick, string password);

        void RemoveAllData();

        void Commit();

        void LoginUser(string nick, string password);

        void LogoutUser();

        void UploadNewContent(Content c, List<int> related);
        List<Content> SearchContent(DateTime Start, DateTime End, string nick, string title, string subject);
        List<Content> GetAllPendingContents();
        void AddEvaluation(int contentId, string RejectionReason, bool rejected);

        void AddComment(string comment, string nickname, Content c);

        Member GetLoggedInMember();

        List<Subject> GetAllSubjects();

        bool IsProfessor();

        bool IsStudent();

        void AddSubscription( string nickSubscribed);

        void RemoveSubscription( string nickSubscribed);

        Content GetContentDetails(string contentURI);
    }
}
