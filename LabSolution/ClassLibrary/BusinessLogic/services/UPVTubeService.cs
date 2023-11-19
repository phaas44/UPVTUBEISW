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

        public void logoutUser(Member user)
        {
            if (this.Logged == user)
            {
                user.LastAccessDate = DateTime.Now;
                dal.Commit();

                this.Logged = null;
            } 
            else throw new ServiceException("The user provided is not logged in!");
        }

        public void uploadNewContent(Member user)
        {
            if (this.Logged == user)
            {
                Console.Write("Please provide the following data to upload your content:\n\n");

                Console.Write("Title:\n");
                string title = Console.ReadLine();

                Console.Write("Description:\n");
                string desc = Console.ReadLine();

                Console.Write("Content URI:\n");
                string uri = Console.ReadLine();

                Console.Write("Privacy status (public / private):\n");
                string privacy = Console.ReadLine();
                bool isPublic;

                while (privacy.ToLower() != "public" || privacy.ToLower() != "private")
                {
                    Console.WriteLine("Error! Please provide a permitted privacy status (public / private):\n");
                    privacy = Console.ReadLine();
                }

                if (privacy.ToLower() == "public")
                    isPublic = true;

                else if (privacy.ToLower() == "private")
                    isPublic = false;

                Console.WriteLine("Related subjects of the content (comma-separated, leave blank if none):\n");
                string[] relatedSubjects = Console.ReadLine().Split(',');
                List<string> listSubjects = new List<string>(relatedSubjects); 

                Console.WriteLine("Done! Verifying info...");

            }
            else throw new ServiceException("The user provided is not logged in!");
        }

        private static bool VerifyData(string title, string description, string uri, List<string> subjects)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description)
                || string.IsNullOrWhiteSpace(uri) || subjects.Count == 0)
            {
                return false;
            }
            else return true;
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
