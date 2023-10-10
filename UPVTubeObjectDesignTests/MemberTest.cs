using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using UPVTube.Entities;

namespace UPVTubeObjectDesignTests
{
    [TestClass]
    public class MemberTest
    {
        [TestMethod]
        public void VirtualPropertiesDefined()
        {
            // Virtual properties are Comments, Evaluations, Contents, Visualizations,
            // Subscriptors and SubscribedTo
            
            PropertyInfo property = typeof(Member).GetProperty("Comments");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Comments property should be declared virtual.");
            property = typeof(Member).GetProperty("Evaluations");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Evaluations property should be declared virtual.");
            property = typeof(Member).GetProperty("Contents");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Evaluations property should be declared virtual.");
            property = typeof(Member).GetProperty("Visualizations");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Visualizations property should be declared virtual.");
            property = typeof(Member).GetProperty("Subscriptors");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Subscriptors property should be declared virtual.");
            property = typeof(Member).GetProperty("SubscribedTo");
            Assert.IsTrue(property.GetMethod.IsVirtual, "SubscribedTo property should be declared virtual.");

        }
        [TestMethod]
        public void NoParamsConstructorInitializesCollections()
        {
            // Collections are Comments, Evaluations, Contents, Visualizations,
            // Subscriptors and SubscribedTo

            Member member = new Member();
            Assert.AreNotSame(null, member, "There must be a constructor without parameters.");
            Assert.IsNotNull(member.Comments, "Collection of Comments not properly initialized. \n Patch the problem adding:  Comments = new List<Comment>();");
            Assert.IsNotNull(member.Evaluations, "Collection of Evaluations not properly initialized. \n Patch the problem adding:  Evaluations = new List<Evaluation>();");
            Assert.IsNotNull(member.Contents, "Collection of Contents not properly initialized. \n Patch the problem adding:  Contents = new List<Content>();");
            Assert.IsNotNull(member.Visualizations, "Collection of Visualizations not properly initialized. \n Patch the problem adding:  Visualizations = new List<Visualization>();");
            Assert.IsNotNull(member.Subscriptors, "Collection of Subscriptors not properly initialized. \n Patch the problem adding:  Subscriptors = new List<Member>();");
            Assert.IsNotNull(member.SubscribedTo, "Collection of Subscriptors not properly initialized. \n Patch the problem adding:  SubscribedTo = new List<Member>();");


            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, member.Comments.Count, "Collection of Comments not properly initialized. \n The list should be empty\n");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, member.Evaluations.Count, "Collection of Evaluations not properly initialized. \n The list should be empty\n");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, member.Contents.Count, "Collection of Contents not properly initialized. \n The list should be empty\n");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, member.Visualizations.Count, "Collection of Visualizations not properly initialized. \n The list should be empty\n");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, member.Subscriptors.Count, "Collection of Subscriptors not properly initialized. \n The list should be empty\n");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, member.SubscribedTo.Count, "Collection  SubscribedTo not properly initialized. \n The list should be empty\n");
        }
        

        [TestMethod]
        public void ConstructorInitializesProps()
        {
            // Member(string email, string fullName, DateTime lastAccessDate, string nick, string password)

            Member member = new Member(TestData.EXPECTED_MEMBER_EMAIL, TestData.EXPECTED_MEMBER_FULLNAME, TestData.EXPECTED_MEMBER_LASTACCESSDATE,TestData.EXPECTED_MEMBER_NICK, TestData.EXPECTED_MEMBER_PASSWORD);

            Assert.AreEqual(TestData.EXPECTED_MEMBER_EMAIL, member.Email, "Email not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_MEMBER_FULLNAME, member.FullName, "FullName not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_MEMBER_LASTACCESSDATE, member.LastAccessDate, "LastAccessDate not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_MEMBER_NICK, member.Nick, "Nick not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_MEMBER_PASSWORD, member.Password, "Password not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");

            // Verify the empty constructor is called
            Assert.IsNotNull(member.Comments, "Collection of Comments not properly initialized. \n Patch the problem calling :this() and/or adding:  Comments = new List<Comment>();");
            Assert.IsNotNull(member.Evaluations, "Collection of Evaluations not properly initialized. \n Patch the problem calling :this() and/or adding:  Evaluations = new List<Evaluation>();");
            Assert.IsNotNull(member.Contents, "Collection of Contents not properly initialized. \n Patch the problem calling :this() and/or adding:  Contents = new List<Content>();");
            Assert.IsNotNull(member.Visualizations, "Collection of Visualizations not properly initialized. \n Patch the problem calling :this() and/or adding:  Visualizations = new List<Visualization>();");
            Assert.IsNotNull(member.Subscriptors, "Collection of Subscriptors not properly initialized. \n Patch the problem calling :this() and/or adding:  Subscriptors = new List<Member>();");
            Assert.IsNotNull(member.SubscribedTo, "Collection of Subscriptors not properly initialized. \n Patch the problem calling :this() and/or adding:  SubscribedTo = new List<Member>();");
        }
    }
}
