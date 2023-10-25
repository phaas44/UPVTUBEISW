using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Linq;
using UPVTube.Entities;

namespace UPVTubePersistenceTests
{
    [TestClass]
    public class ContentTest : BaseTest
    {
        [TestMethod]
        public void StoresInitialData()
        {
            // public Content(string contentURI, string description, bool isPublic, string title, DateTime uploadDate, Member owner)

            Content content = new Content(TestData.EXPECTED_CONTENT_CONTENTURI, TestData.EXPECTED_CONTENT_DESCRIPTION, TestData.EXPECTED_CONTENT_ISPUBLIC, TestData.EXPECTED_CONTENT_TITLE, TestData.EXPECTED_CONTENT_UPLOADDATE, TestData.EXPECTED_CONTENT_OWNER);

            dal.Insert(content);
            dal.Commit();


            // Test non virtual properties properly stored
            Content contentFromDAL = dal.GetAll<Content>().First();

            // Test non virtual properties properly stored
            Assert.AreEqual(TestData.EXPECTED_CONTENT_CONTENTURI, contentFromDAL.ContentURI, "ContentURI attribute not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_CONTENT_TITLE, contentFromDAL.Title, "Title attribute properly stored.");
            Assert.AreEqual(TestData.EXPECTED_CONTENT_UPLOADDATE, contentFromDAL.UploadDate, "UploadDate attribute not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_CONTENT_ISPUBLIC, contentFromDAL.IsPublic, "IsPublic attribute not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_CONTENT_DESCRIPTION, contentFromDAL.Description, "Description attribute not properly stored.");

            // Test virtual properties properly stored
            // They must be initially instanced because they are all 1
            // owner
            Assert.AreEqual(TestData.EXPECTED_CONTENT_OWNER, contentFromDAL.Owner, "Owner not properly initialized.");

            // Test virtual properties properly stored
            // They must be initially empty because they are all 0..*
            // Visualizations, Comments, Subjects

            Assert.IsNotNull(contentFromDAL.Visualizations, "Collection of Visualizations not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, contentFromDAL.Visualizations.Count, "Collection of Visualizations not properly initialized. \n The list should be empty\n");

            Assert.IsNotNull(contentFromDAL.Comments, "Collection of Comments not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, contentFromDAL.Comments.Count, "Collection of Comments not properly initialized. \n The list should be empty\n");

            Assert.IsNotNull(contentFromDAL.Subjects, "Collection of Subjects not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, contentFromDAL.Subjects.Count, "Collection of Subjects not properly initialized. \n The list should be empty\n");

        }

        [TestMethod]
        public void StoresDataWithRelations()
        {
            // public Content(string contentURI, string description, bool isPublic, string title, DateTime uploadDate, Member owner)

            Content content = new Content(TestData.EXPECTED_CONTENT_CONTENTURI, TestData.EXPECTED_CONTENT_DESCRIPTION, TestData.EXPECTED_CONTENT_ISPUBLIC, TestData.EXPECTED_CONTENT_TITLE, TestData.EXPECTED_CONTENT_UPLOADDATE, TestData.EXPECTED_CONTENT_OWNER);

            // Adding a Visualization, Comment, Subject 
            // Evaluation

            // First, we need another member to visualization, comment and evaluation.
            Member member = new Member(TestData.EXPECTED_MEMBER2_EMAIL, TestData.EXPECTED_MEMBER2_FULLNAME, TestData.EXPECTED_MEMBER2_LASTACCESSDATE, TestData.EXPECTED_MEMBER2_NICK, TestData.EXPECTED_MEMBER2_PASSWORD);
            
            
            // Visualization
            Visualization vis = new Visualization(TestData.EXPECTED_VISUALIZATION_VISUALIZATIONDATE, content, member);
            //This is not needed if we insert vis object first
            //EF takes care of bidirectional relationships
            //content.Visualizations.Add(vis);

            // Comment
            Comment comment = new Comment(TestData.EXPECTED_COMMENT_TEXT, TestData.EXPECTED_COMMENT_WRITINGDATE, content, member);
            //This is not needed if we insert comment object first
            //EF takes care of bidirectional relationships
            //content.Comments.Add(comment);

            // Subject
            Subject subject = new Subject(TestData.EXPECTED_SUBJECT_CODE, TestData.EXPECTED_SUBJECT_FULLNAME, TestData.EXPECTED_SUBJECT_NAME);
            subject.Contents.Add(content);
            content.Subjects.Add(subject);

            // Evaluation
            Evaluation eval = new Evaluation(TestData.EXPECTED_EVALUATION_EVALUATIONDATE, TestData.EXPECTED_EVALUATION_REJECTIONREASON, member, content);
            //This is not needed if we insert vis object first
            //EF takes care of bidirectional relationships
            //content.Evaluation=eval;

            dal.Insert(content);
            dal.Insert(member);
            dal.Insert(vis);
            dal.Insert(comment);
            dal.Insert(subject);
            dal.Insert(eval);
            dal.Commit();

            Content contentFromDAL = dal.GetById<Content>(content.Id);

            // Test non virtual properties properly stored
            Assert.AreEqual(TestData.EXPECTED_CONTENT_CONTENTURI, contentFromDAL.ContentURI, "ContentURI attribute not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_CONTENT_TITLE, contentFromDAL.Title, "Title attribute properly stored.");
            Assert.AreEqual(TestData.EXPECTED_CONTENT_UPLOADDATE, contentFromDAL.UploadDate, "UploadDate attribute not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_CONTENT_ISPUBLIC, contentFromDAL.IsPublic, "IsPublic attribute not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_CONTENT_DESCRIPTION, contentFromDAL.Description, "Description attribute not properly stored.");

            // Test virtual properties properly stored
            // They must be initially instanced because they are all 1
            // owner
            Assert.AreEqual(TestData.EXPECTED_CONTENT_OWNER, contentFromDAL.Owner, "Owner not properly initialized.");


            // Verify all collections are not null after inserting one element
            // Visualization, Comment, Subject       

            Assert.IsNotNull(contentFromDAL.Visualizations, "Collection of Visualizations not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, contentFromDAL.Visualizations.Count, "Collection of Visualizations not properly initialized. \n The list should have one element\n");
            Assert.AreEqual(vis, contentFromDAL.Visualizations.FirstOrDefault(), "Visualizations relationship not properly created.");
            Assert.AreEqual(vis.Content, contentFromDAL, "Bidirectional Visualizations-Content relationship not properly set");


            Assert.IsNotNull(contentFromDAL.Comments, "Collection of Comments not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, contentFromDAL.Comments.Count, "Collection of Comments not properly initialized. \n The list should have one element\n");
            Assert.AreEqual(comment, contentFromDAL.Comments.FirstOrDefault(), "Comments relationship not properly created.");
            Assert.AreEqual(comment.Content, contentFromDAL, "Bidirectional Content-Comments relationship not properly set");

            Assert.IsNotNull(contentFromDAL.Subjects, "Collection of Subjects not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, contentFromDAL.Subjects.Count, "Collection of Subjects not properly initialized. \n The list should have one element\n");
            Assert.AreEqual(subject, contentFromDAL.Subjects.FirstOrDefault(), "Subjects relationship not properly created.");
            Assert.AreEqual(subject.Contents.FirstOrDefault(), contentFromDAL, "Bidirectional Contents-Subjects relationship not properly set");

            // Verify Evaluation are not null after assign one element
            // Relationship Content-Evaluation

            Assert.IsNotNull(contentFromDAL.Evaluation, "Evaluation not properly stored.");
            Assert.AreEqual(eval, contentFromDAL.Evaluation, "Evaluation relationship not properly created"); 
            Assert.AreEqual(eval.Content, contentFromDAL, "Bidirectional Content-Evaluation relationship not properly set");

        }
    }
}
