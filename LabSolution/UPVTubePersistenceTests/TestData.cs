using UPVTube.Entities;
using System;

namespace UPVTubePersistenceTests
{
    public class TestData
    {
        //GENERIC
        public static int EXPECTED_EMPTY_LIST_COUNT = 0;
        public static int EXPECTED_ONE_ELEMENT_LIST_COUNT = 1;

        //MEMBER
        public static string EXPECTED_MEMBER_EMAIL = "member1@gmail.com";
        public static string EXPECTED_MEMBER_FULLNAME = "Nombre1 Apellido1";
        public static DateTime EXPECTED_MEMBER_LASTACCESSDATE = DateTime.Now;
        public static string EXPECTED_MEMBER_NICK = "member1";
        public static string EXPECTED_MEMBER_PASSWORD = "p1111";

        public static string EXPECTED_MEMBER2_EMAIL = "member2@gmail.com";
        public static string EXPECTED_MEMBER2_FULLNAME = "Nombre2 Apellido2";
        public static DateTime EXPECTED_MEMBER2_LASTACCESSDATE = DateTime.Now;
        public static string EXPECTED_MEMBER2_NICK = "member2";
        public static string EXPECTED_MEMBER2_PASSWORD = "p2222";

        public static string EXPECTED_MEMBER3_EMAIL = "member3@gmail.com";
        public static string EXPECTED_MEMBER3_FULLNAME = "Nombre3 Apellido3";
        public static DateTime EXPECTED_MEMBER3_LASTACCESSDATE = DateTime.Now;
        public static string EXPECTED_MEMBER3_NICK = "member3";
        public static string EXPECTED_MEMBER3_PASSWORD = "p3333";

        //COMMENT
        public static string EXPECTED_COMMENT_TEXT = "generic comment text";
        public static DateTime EXPECTED_COMMENT_WRITINGDATE = DateTime.Now;

        //SUBJECT
        public static int EXPECTED_SUBJECT_CODE = 111;
        public static string EXPECTED_SUBJECT_FULLNAME = "subject1";
        public static string EXPECTED_SUBJECT_NAME = "s1";

        //VISUALIZATION
        public static DateTime EXPECTED_VISUALIZATION_VISUALIZATIONDATE = DateTime.Now;
        public static Member EXPECTED_VISUALIZATION_MEMBER = new Member();
        public static Content EXPECTED_VISUALIZATION_CONTENT = new Content();

        //CONTENT
        public static string EXPECTED_CONTENT_CONTENTURI = "http://www.upv.es";
        public static string EXPECTED_CONTENT_DESCRIPTION = "This is a ISW Chapter 2 video";
        public static bool EXPECTED_CONTENT_ISPUBLIC = true;
        public static string EXPECTED_CONTENT_TITLE = "Agile Software Processes";
        public static DateTime EXPECTED_CONTENT_UPLOADDATE = DateTime.Now;
        // OWNER debe tener creado un member con correo, ya que se comprueba en el constructor de CONTENT
        //public static Member EXPECTED_CONTENT_OWNER = new Member();
        // Constructor:  public Member(string email, string fullName, DateTime lastAccessDate, string nick, string password)
        public static Member EXPECTED_CONTENT_OWNER = new Member(EXPECTED_MEMBER_EMAIL, EXPECTED_MEMBER_FULLNAME, EXPECTED_MEMBER_LASTACCESSDATE, EXPECTED_MEMBER_NICK, EXPECTED_MEMBER_PASSWORD);


        //EVALUATION
        public static DateTime EXPECTED_EVALUATION_EVALUATIONDATE = DateTime.Now;
        public static string EXPECTED_EVALUATION_REJECTIONREASON = "This video is unappropriate";
    }

}