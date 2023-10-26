using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Linq;
using UPVTube.Entities;

namespace UPVTubePersistenceTests
{
    [TestClass]
    public class SubjectTest : BaseTest
    {
        [TestMethod]
        public void StoresInitialData()
        {
            Subject subject = new Subject(TestData.EXPECTED_SUBJECT_CODE, TestData.EXPECTED_SUBJECT_FULLNAME, TestData.EXPECTED_SUBJECT_NAME);

            dal.Insert(subject);
            dal.Commit();

            // Test non virtual properties properly stored
            Subject subjectFromDAL = dal.GetAll<Subject>().First();
            Assert.AreEqual(TestData.EXPECTED_SUBJECT_CODE, subjectFromDAL.Code, "Subject attributes not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_SUBJECT_FULLNAME, subjectFromDAL.FullName, "Subject attributes not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_SUBJECT_NAME, subjectFromDAL.Name, "Subject attributes not properly stored.");

            // Test virtual properties properly stored
            // They must be initially empty because they are all 0..*
            // Contents
            Assert.IsNotNull(subjectFromDAL.Contents, "Collection of Contents not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, subjectFromDAL.Contents.Count, "Collection of Contents not properly initialized. \n The list should be empty\n");

        }

        [TestMethod]
        public void StoresDataWithRelations()
        {
            Subject subject = new Subject(TestData.EXPECTED_SUBJECT_CODE, TestData.EXPECTED_SUBJECT_FULLNAME, TestData.EXPECTED_SUBJECT_NAME);

            // Adding a Member
            Member owner = new Member(TestData.EXPECTED_MEMBER_EMAIL, TestData.EXPECTED_MEMBER_FULLNAME, TestData.EXPECTED_MEMBER_LASTACCESSDATE, TestData.EXPECTED_MEMBER_NICK, TestData.EXPECTED_MEMBER_PASSWORD);
            // Adding a Content
            Content content = new Content(TestData.EXPECTED_CONTENT_CONTENTURI, TestData.EXPECTED_CONTENT_DESCRIPTION, TestData.EXPECTED_CONTENT_ISPUBLIC, TestData.EXPECTED_CONTENT_TITLE, TestData.EXPECTED_CONTENT_UPLOADDATE, owner);
            // No neeed to add new content to member (owner)
            // owner.Contents.Add(content);
            subject.Contents.Add(content);
  


            dal.Insert(content);
            dal.Insert(owner);
            dal.Insert(subject);
            dal.Commit();

            Subject subjectFromDAL = dal.GetById<Subject>(subject.Code);

             Assert.AreEqual(TestData.EXPECTED_SUBJECT_CODE, subjectFromDAL.Code, "Subject not properly stored.");
            // Verify all collections are not null after inserting one element
            // Contents       


            Assert.IsNotNull(subjectFromDAL.Contents, "Collection of Contents not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, subjectFromDAL.Contents.Count, "Collection of Contents not properly initialized. \n The list should have one element\n");
            Assert.AreEqual(content, subjectFromDAL.Contents.FirstOrDefault(), "Contents relationship not properly created.");
            Assert.AreEqual(content.Subjects.FirstOrDefault(), subjectFromDAL, "Bidirectional Subject-Contents relationship not properly set");

        }
    }
}