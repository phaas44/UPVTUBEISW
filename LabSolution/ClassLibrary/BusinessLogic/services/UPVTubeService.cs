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
        public Member User { get; set; }

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
            this.User = user;

        }

        public bool isLoggedIn(Member user)
        {
            // Check if there is a possible user that is logged in.
            if (this.User == null)
            {
                return false;
            }
            else
            {
                throw new ServiceException("User is indeed logged in.");
                return this.User.Nick == user.Nick;

            }
        }


    }
}
