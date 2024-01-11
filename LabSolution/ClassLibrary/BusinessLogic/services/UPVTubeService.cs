using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Persistence;
using UPVTube.Entities;
using System.Xml.Linq;
using System.Data.Entity.Infrastructure;

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

            Content c1 = new Content("fake.uri.es", "Inheritance driven polymorphism explained", true, "Polymorphism", DateTime.Now, a1);
            a1.AddContent(c1);
            dal.Insert<Content>(c1);

            Comment cm1 = new Comment("Very good video", DateTime.Now, c1, a1);
            a1.AddComment(cm1);
            dal.Insert<Comment>(cm1);

            //Create a professor
            Member p1 = new Member("fjaen@dsic.upv.es", "Javier Jaen", DateTime.Now, "fjaen", "password");
            dal.Insert<Member>(p1);

            Member p4 = new Member("asdf@dsic.upv.es", "asdf", DateTime.Now, "asdf", "password");
            dal.Insert<Member>(p4);

            Content c2 = new Content("Test", "Inheritance driven polymorphism explained", false, "Polymorphism", DateTime.Now, p4);
            p4.AddContent(c2);
            dal.Insert<Content>(c2);

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

            Commit();


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


        public void RegisterNewUser(string email, string name, string nick, string password)
        {
            //Check if email, nick or password are empty
            if (string.IsNullOrEmpty(email)) throw new ServiceException("Please provide an email address.");
            if (string.IsNullOrEmpty(nick)) throw new ServiceException("Please provide a nick.");
            if (string.IsNullOrEmpty(password)) throw new ServiceException("Please provide a password.");


            

            //Check if Member nick or email is not already in the system
            if (dal.GetById<Member>(nick) == null)
            {
                if (!dal.GetWhere<Member>(m => m.Email == email).Any())
                {
                    DateTime date = DateTime.Now;
                    Member newMember = new Member(email, name, date, nick, password);

                    dal.Insert(newMember);
                    dal.Commit();

                }

                else throw new ServiceException("This email address already has been used.");
                
            }

            else throw new ServiceException("This nick already exists.");
        }

        public void LoginUser(string nick, string password)
        {
            //Check if nick or password are null or empty
            if (string.IsNullOrEmpty(nick)) throw new ServiceException("Please provide a nick.");
            if (string.IsNullOrEmpty(password)) throw new ServiceException("Please provide a password.");


            Member user = dal.GetById<Member>(nick);

            if(user.Nick != nick) { throw new ServiceException("Provided nick or password is wrong!"); }

            //Check if user is not registered: throw error
            if (user == null)
            {
                throw new ServiceException("Member not registered!");
            }

           //User is registered: ask for credentials
            
            if (user.Password != password)
            {
                throw new ServiceException("Provided nick or password is wrong!");
            }


            //If all check succeed, we add user to session

            //Load Member object from database

            
            this.Logged = user;

        }

        public void LogoutUser()
        {
            if (this.Logged != null)
            {
                this.Logged.LastAccessDate = DateTime.Now;
                dal.Commit();

                this.Logged = null;
            } 
            else throw new ServiceException("User is not logged in!");
        }

        public void UploadNewContent(Content c, List<int> related)
        {
            if (c == null || !VerifyContentData(c.Title, c.Description, c.ContentURI)) 
                throw new ServiceException("Please provide a valid content!");
            
            if (this.Logged == null) throw new ServiceException("User is not logged in!");

            if (related.Count > 3) throw new ServiceException("Only up to 3 different subjects can be added!");

            if (Domains.IsUPVMemberDomain(this.Logged.Email))
            {
                if (!dal.GetWhere<Content>(z => z.ContentURI == c.ContentURI).Any())
                {
                    foreach (int n in related)
                    {
                        Subject subject = dal.GetById<Subject>(n);
                        if (subject == null) throw new ServiceException("One or more of the subjects provided do not exist!");
                        
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

        public List<Content> SearchContent(DateTime Start, DateTime End, string nick, string title, string subject)
        {
            if (this.Logged == null)
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
                c = c.Where(cn => cn.Owner.Nick.ToLower().Contains(nick.ToLower())).ToList();
            }
            if (title != "")
            {
                c = c.Where(cn => cn.Title.ToLower().Contains(title.ToLower())).ToList();
            }
            if (subject != "")
            {
                c = c.Where(cn => cn.Subjects.Any(s => s.Name.Contains(subject))).ToList();
            }

            if (!Domains.IsUPVMemberDomain(this.Logged.Email))
            {
                List<Content> result = new List<Content>();

                //Is a bad solution but .Where() doesnt work.
                foreach(Content cont in c)
                {
                    if(cont.IsPublic) { result.Add(cont); }
                }

                //c.Where(cn => cn.IsPublic).ToList();
                return result;
            }
            else
            {
                return c;
            }

        }

        public List<Content> GetAllPendingContents()
        {
            if (!Domains.IsTeacherDomain(this.Logged.Email)) throw new ServiceException("You must be a teacher to see content pending for review!");
            
            return dal.GetWhere<Content>(c => c.Authorized == Authorized.Pending).ToList();
        }
        public void AddEvaluation(int contentId, string RejectionReason, bool accepted)
        {
            if (!accepted) 
            {
                Content content = dal.GetById<Content>(contentId);
                content.Authorized = Authorized.No;

                Evaluation eval = new Evaluation(DateTime.Now, RejectionReason, this.Logged, content);
                content.Evaluation = eval;

                dal.Insert<Evaluation>(eval);
                dal.Commit();

            }
            else
            {
                Content content = dal.GetById<Content>(contentId);
                content.Authorized = Authorized.Yes;
                Evaluation eval = new Evaluation(DateTime.Now, RejectionReason, this.Logged, content);
                content.Evaluation = eval;

                dal.Insert<Evaluation>(eval);
                Commit();
            }
        }
        public void AddComment(string text, string nickname, Content c)
        {
            Member member = dal.GetById<Member>(nickname);

            Comment comment = new Comment(text, DateTime.Now, c, member);
            c.AddComment(comment);
            member.AddComment(comment);

            dal.Insert<Comment>(comment);
            dal.Commit();
        }

        public Member GetLoggedInMember()
        {
            if(this.Logged != null)
            {
                return this.Logged;
            }
            
            else { throw new ServiceException("No User logged in."); }
        }

        public List<Subject> GetAllSubjects()
        {
            return dal.GetAll<Subject>().ToList();
        }

        public bool IsProfessor()
        {
            return Domains.IsTeacherDomain(this.Logged.Email);
        }

        public bool IsStudent()
        {
            return Domains.IsStudentDomain(this.Logged.Email);
        }

        //Only Suscribed needed since only a loged in person can subscribe.
        public void AddSubscription(string nickSubscribed)
        {
            if(this.Logged == null) { throw new ServiceException("Login first to subscribe."); }

            Member Subscribed = dal.GetById<Member>(nickSubscribed);

            if(Subscribed == null) { throw new ServiceException("Subscribed person does not exist."); }
            
            if(Domains.IsUPVMemberDomain(this.Logged.Email))
            {
                if (this.Logged.SubscribedTo.Any(m => m.Nick == Subscribed.Nick)) { throw new ServiceException("You alraedy subscribed to this content creator."); }

                else
                {
                    Subscribed.Subscriptors.Add(this.Logged);
                    this.Logged.SubscribedTo.Add(Subscribed);
                    Commit();

                }

            }

            else { throw new ServiceException("Logged in user is not an UPV member."); }
        }

        public void RemoveSubscription(string nickSubscribed)
        {
            if (this.Logged == null) { throw new ServiceException("Login first to unsubscribe."); }
            
            if(!this.Logged.SubscribedTo.Any(m => m.Nick == nickSubscribed))
            {
                throw new ServiceException("Logged in user did not subscribe to this content creator.");
            }
            Member Subscribed = dal.GetById<Member>(nickSubscribed);

            if( Subscribed == null) { throw new ServiceException("Subscribed person does not exist."); }

            if (Domains.IsUPVMemberDomain(this.Logged.Email))
            {

                Subscribed.Subscriptors.Remove(this.Logged);
                
                this.Logged.SubscribedTo.Remove(Subscribed);

                Commit();
            }

            else { throw new ServiceException("Logged in user is not an UPV member."); }
        }

        public Content GetContentDetails(string contentId)
        {
            List<Content> contents = new List<Content>();
            contents.AddRange(dal.GetWhere<Content>(c => c.ContentURI== contentId).ToList()); 

            if(contents.Count > 1) { throw new ServiceException("There are multiple contents with the same URI!"); }
            
            if (contents[0] == null) { throw new ServiceException("Content for according contentID cannot be found."); }

            Visualization v = new Visualization(DateTime.Now, contents[0],this.Logged);
            contents[0].AddVisualization(v);
            Commit();

            return contents[0];
        }




    }




} 

