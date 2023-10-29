using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Persistence;
using UPVTube.BusinessLogic;
using UPVTube.Entities;

namespace UPVTube.BusinessLogic.Services
{
    public class UPVTubeService: IUPVTubeService
    {

        private readonly IDAL dal;

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

            else throw new ServiceException("Person already exists.");
        }


    }
}
