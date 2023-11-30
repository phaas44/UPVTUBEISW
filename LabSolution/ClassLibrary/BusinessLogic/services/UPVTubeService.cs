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

        public List<Content> SearchContent(DateTime Start, DateTime End, string nick, string title, string subject)
        {
            if (Logged == null)
            {
                throw new ServiceException("User is not logged.");
            }

            List<Content> c = dal.GetWhere<Content>(cn => cn.Authorized == Authorized.Yes).ToList();
            if (Start != null && End != null)
            {
                c = c.Where(cn => cn.UploadDate < End && cn.UploadDate > Start).ToList();

            }
            if (nick != "")
            {
                c = c.Where(cn => cn.Owner.Nick == nick).ToList();
            }
            if (title != "")
            {
                c = c.Where(cn => cn.Title == title).ToList();
            }
            if (subject != "")
            {
                c = c.Where(cn => cn.Subjects.Any(s => s.Name.Contains(subject))).ToList();
            }
            if (!Domains.IsUPVMemberDomain(this.Logged.Email))
            {
                c.Where(cn => cn.IsPublic).ToList();
                return c;
            }
            else
            {
                return c;
            }

        }

        public List<Content> GetAllPendingContents()
        {
            List<Content> list = null;
            if (Domains.IsTeacherDomain(this.Logged.Email))
            {
                list = dal.GetWhere<Content>(c => c.Authorized == Authorized.Pending).ToList();

            }
            return list;
        }
        public void AddEvaluation(int contentId, string RejectionReason, bool rejected)
        {
            if (rejected)
            {

            }
            Content content = dal.GetById<Content>(contentId);
            Evaluation eval = new Evaluation(DateTime.Now, RejectionReason, content.Owner, content);
            content.Evaluation = eval;
        }




    }




} 

