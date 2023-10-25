using System;
using System.Collections.Generic;


namespace UPVTube.Services
{
    // This class simulates the existence of a Directory Service
    // to know whether an Email belongs to a student or lecturer

    public class Domains
    {
        private static List<String> TeacherDomains = new List<string> { "@dsic.upv.es", "@dsica.upv.es" };
        private static List<String> StudentDomains = new List<string> { "@inf.upv.es" };
        /// <summary>
		/// Returns true if Email has a lecturer domain
		/// </summary>
		/// <returns></returns>
		public static bool IsTeacherDomain(string Email)
        {
            foreach (String alias in TeacherDomains)
                if (Email.Contains(alias)) return true;
            return false;
        }

        /// <summary>
        /// Returns true if Email has a student domain
        /// </summary>
        /// <returns></returns>
        public static bool IsStudentDomain(string Email)
        {
            foreach (String alias in StudentDomains)
                if (Email.Contains(alias)) return true;
            return false;
        }

        /// <summary>
        /// Returns true if Email belongs to UPV Member
        /// </summary>
        /// <returns></returns>
        public static bool IsUPVMemberDomain(string Email)
        {
            return IsStudentDomain(Email) || IsTeacherDomain(Email);
        }
    }
}
