using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Persistence;
using UPVTube.Entities;

namespace UPVTube.Services
{
    public class UPVTubeService : IUPVTubeService
    {

        private readonly IDAL dal;
        private Member Logged { get; set; }

        public UPVTubeService(IDAL dal) {
            this.dal = dal;
        }

        public void removeAllData()
        {
            dal.Clear<Subject>();
            dal.Clear<Member>();
            dal.Clear<Content>();
            dal.Clear<Visualization>();
            dal.Clear<Comment>();
            dal.Clear<Evaluation>();
        }


        public void registerNewUser(string email, string name, DateTime date, string nick, string password)
        {
            Member newMember = new Member(email, name, date, nick, password);

            //Check if Member is not already in the system
            if (dal.GetById<Member>(newMember.Nick) == null)
            {
                dal.Insert(newMember);
                dal.Commit();
            }

            else throw new ServiceException("Member already exists.");
        }

        public void loginUser(string nick, string password)
        {
            //Check if user is not registered: throw error
            if (dal.GetById<Member>(nick) == null)
            {
                throw new ServiceException("Member not registered!");
            }

            //User is registered: ask for credentials

            if (dal.GetById<Member>(nick).Password != password)
            {
                throw new ServiceException("Provided nick or password is wrong!");
            }


            //If all check succeed, we add user to session

            //Load Member object from database

            Member user = dal.GetById<Member>(nick);
            this.Logged = user;

        }

        public void logoutUser()
        {
            if (this.Logged != null)
            {
                Member m = dal.GetById<Member>(this.Logged.Nick);
                m.LastAccessDate = DateTime.Now;
                dal.Commit();

                this.Logged = null;
            } 
            else throw new ServiceException("User is not logged in!");
        }

        public void uploadNewContent(string title, string desc, string uri, bool privacy, List<Subject> related)
        {
            if (Domains.IsUPVMemberDomain(this.Logged.Email))
            {
                if (VerifyContentData(title, desc, uri))
                {
                    Content c = new Content(uri, desc, privacy, title, DateTime.Now, this.Logged);

                    foreach (Subject s in related)
                    {
                        c.AddSubject(s);
                    }
                    this.Logged.AddContent(c);
                    dal.Insert<Content>(c);
                    dal.Commit();
                }
                else throw new ServiceException("Please fill all the required data.");
            }
            else throw new ServiceException("You must be a UPV member to upload content!");
        }

        private static bool VerifyContentData(string title, string desc, string uri)
        {
            return !string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(desc)
                && !string.IsNullOrWhiteSpace(uri);
        }

        public bool isLoggedIn(Member user)
        {
            // Check if there is a possible user that is logged in.
            if (this.Logged == null)
            {
                return false;
            }
            else
            {
                //throw new ServiceException("User is indeed logged in.");
                return this.Logged.Nick == user.Nick;

            }
        }

        public List<Content> SearchContentByDate(DateTime Start, DateTime End)
        {
            return dal.GetWhere<Content>(c => c.UploadDate < End && c.UploadDate > Start).ToList();
        }


    }
}
