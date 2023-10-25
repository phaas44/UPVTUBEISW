using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Linq;
using UPVTube.Entities;

namespace UPVTubePersistenceTests
{
    [TestClass]
    public class CommentTest : BaseTest
    {
        [TestMethod]
        public void StoresInitialData()
        {
            // A Comment object requires content and member objects to be initialized. So, this TestMethod is not used. 
        }

        [TestMethod]
        public void StoresDataWithRelations()
        {
            // Adding a Writer
            Member writer = new Member(TestData.EXPECTED_MEMBER_EMAIL, TestData.EXPECTED_MEMBER_FULLNAME, TestData.EXPECTED_MEMBER_LASTACCESSDATE, TestData.EXPECTED_MEMBER_NICK, TestData.EXPECTED_MEMBER_PASSWORD);
            // Adding a Content
            Content content = new Content(TestData.EXPECTED_CONTENT_CONTENTURI, TestData.EXPECTED_CONTENT_DESCRIPTION, TestData.EXPECTED_CONTENT_ISPUBLIC, TestData.EXPECTED_CONTENT_TITLE, TestData.EXPECTED_CONTENT_UPLOADDATE, writer);
            // Adding as Comment
            Comment comment = new Comment(TestData.EXPECTED_COMMENT_TEXT, TestData.EXPECTED_COMMENT_WRITINGDATE, content, writer);

            dal.Insert(content);
            dal.Insert(writer);
            dal.Insert(comment);
            dal.Commit();

            Comment commentFromDAL = dal.GetById<Comment>(comment.Id);

            // Test non virtual properties properly stored
            Assert.AreEqual(TestData.EXPECTED_COMMENT_TEXT, commentFromDAL.Text, "Text attribute not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_COMMENT_WRITINGDATE, commentFromDAL.WritingDate, "WritingDate attribute not properly stored.");

            // Test virtual properties properly stored
            // They must be initially instanced because they are all 1
            // Content, Writer
            Assert.AreEqual(content, commentFromDAL.Content, "Content not properly initialized.");
            Assert.AreEqual(writer, commentFromDAL.Writer, "Writer not properly initialized.");

            // Verify bidirectional relationships: all collections are not null after inserting one element      
            Assert.AreEqual(writer.Comments.FirstOrDefault(), commentFromDAL, "Bidirectional Member-Comment relationship not properly set");
            Assert.AreEqual(content.Comments.FirstOrDefault(), commentFromDAL, "Bidirectional Content-Comment relationship not properly created.");

        }
    }
}