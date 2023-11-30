using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Persistence;
using UPVTube.Entities;
using System.Xml.Linq;

namespace UPVTube.Services
{
    public class UPVTubeService : IUPVTubeService
    {

        private readonly IDAL dal;
        private Member Logged { get; set; }

        public UPVTubeService(IDAL dal) {
            this.dal = dal;
        }

        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        public void Commit()
        {
            dal.Commit();
        }

        public void DBInitialization()
        {
            RemoveAllData();
            Subject s1 = new Subject(11555, "Ingeniería del software","ISW");
            AddSubject(s1);
            Subject s2 = new Subject(11553, "Arquitectura e ingeniería de computadores", "AIC");
           
            AddSubject(s2);
            Subject s3 = new Subject(11548, "Bases de datos y sistemas de información", "BDA");
           
            AddSubject(s3);
            Subject s4 = new Subject(11560, "Sistemas inteligentes", "SIN");
            AddSubject(s4);

            //Create a member of UPV
            Member a1 = new Member("member.student@inf.upv.es", "Member Student", DateTime.Now, "MemberStudent", "1234");
            dal.Insert<Member>(a1); //adding to the DBset 

            Content c1 = new Content("http://fake.uri.es", "Inheritance driven polymorphism explained", true, "Polymorphism", DateTime.Now, a1);
            a1.AddContent(c1);
            dal.Insert<Content>(c1);

            Comment cm1 = new Comment("Very good video", DateTime.Now, c1, a1);
            a1.AddComment(cm1);
            dal.Insert<Comment>(cm1);

            //Create a professor
            Member p1 = new Member("fjaen@dsic.upv.es", "Javier Jaen", DateTime.Now, "fjaen", "password");
            dal.Insert<Member>(p1);

            //Create user not member of UPV
            Member p2 = new Member("notmember@gmail.com", "NotMember Person", DateTime.Now, "NotMember", "1234");
            dal.Insert<Member>(p2);


            //Create an evaluation
            Evaluation e1 = new Evaluation(DateTime.Now, "Accepted", p1, c1);
            p1.AddEvaluation(e1);
            c1.Evaluation = e1; //Add a evaluation to the content manually because cardinality is 0..1 
            c1.Authorized = Authorized.Yes; //authorizing the content c1 
            dal.Insert<Evaluation>(e1);

            //Adding a visualization
            Visualization v1 = new Visualization(DateTime.Now, c1, p1);
            p1.AddVisualization(v1);
            c1.AddVisualization(v1);
            dal.Insert<Visualization>(v1);

            c1.AddSubject(s1);
            


        }

        public void AddSubject(Subject s)
        {
            // Restriction: Not two subjects with the same code
            if (dal.GetById<Subject>(s.Code) == null)
            {
                // Restriction: Not two courses with same name
                if (!dal.GetWhere<Subject>(x => x.Name == s.Name).Any())
                {
                    // Inserting in the DB
                    dal.Insert<Subject>(s);
                    dal.Commit();
                }
                else
                    throw new ServiceException("Subject with name " + s.Name + "already exists.");
            }
            else
                throw new ServiceException("Subject with code " + s.Code + "already exists.");
        }


        public void RegisterNewUser(string email, string name, DateTime date, string nick, string password)
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

        public void LoginUser(string nick, string password)
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

        public void uploadNewContent(Content c, List<int> related)
        {
            if (Domains.IsUPVMemberDomain(this.Logged.Email))
            {
                if (!dal.GetWhere<Content>(z => z.ContentURI == c.ContentURI).Any())
                {
                    foreach (int n in related)
                    {
                        Subject subject = dal.GetById<Subject>(n);
                        c.AddSubject(subject);
                        subject.AddContent(c);
                    }

                    this.Logged.AddContent(c);
                    dal.Insert<Content>(c);
                    dal.Commit();
                }
                else throw new ServiceException("That Content URI already exists!");
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
