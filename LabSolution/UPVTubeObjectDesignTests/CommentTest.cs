using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using UPVTube.Entities;

namespace UPVTubeObjectDesignTests
{
    [TestClass]
    public class CommentTest
    {
        [TestMethod]
        public void VirtualPropertiesDefined()
        {
            // Virtual properties are Content and Writer

            PropertyInfo property = typeof(Comment).GetProperty("Content");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Content property should be declared virtual.");
            property = typeof(Comment).GetProperty("Writer");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Writer property should be declared virtual.");
        }
        [TestMethod]
        public void NoParamsConstructorInitializesCollections()
        {
            // There are no collections

            Comment comment = new Comment();
            Assert.AreNotSame(null, comment, "There must be a constructor without parameters.");

        }


        [TestMethod]
        public void ConstructorInitializesProps()
        {
            // Comment(string text, DateTime writingDate, Content content, Member writer)
            Comment comment = new Comment(TestData.EXPECTED_COMMENT_TEXT, TestData.EXPECTED_COMMENT_WRITINGDATE, TestData.EXPECTED_COMMENT_CONTENT, TestData.EXPECTED_COMMENT_WRITER);

            Assert.AreEqual(TestData.EXPECTED_COMMENT_TEXT, comment.Text, "Text not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_COMMENT_WRITINGDATE, comment.WritingDate, "WritingDate not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_COMMENT_CONTENT, comment.Content, "Content not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_COMMENT_WRITER, comment.Writer, "Writer not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
        }
    }
}
