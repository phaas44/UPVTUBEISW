using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Diagnostics.Metrics;
using System.Reflection;
using UPVTube.Entities;

namespace UPVTubeObjectDesignTests
{
    [TestClass]
    public class ContentTest
    {
        [TestMethod]
        public void VirtualPropertiesDefined()
        {
            // Virtual properties are Owner and Evaluation

            PropertyInfo property = typeof(Content).GetProperty("Owner");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Owner property should be declared virtual.");
            property = typeof(Content).GetProperty("Evaluation");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Evaluation property should be declared virtual.");
        }


        [TestMethod]
        public void NoParamsConstructorInitializesCollections()
        {
            // Collections are Comments, Visualizations and Subjects

            Content content = new Content();
            Assert.AreNotSame(null, content, "There must be a constructor without parameters.");
            Assert.IsNotNull(content.Comments, "Collection of Comments not properly initialized. \n Patch the problem adding:  Comments = new List<Comment>();");
            Assert.IsNotNull(content.Visualizations, "Collection of Visualizations not properly initialized. \n Patch the problem adding:  Visualizations = new List<Visualization>();");
            Assert.IsNotNull(content.Subjects, "Collection of Subjects not properly initialized. \n Patch the problem adding:  Subjects = new List<Subjects>();");


            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, content.Comments.Count, "Collection of Comments not properly initialized. \n The list should be empty\n");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, content.Visualizations.Count, "Collection of Visualizations not properly initialized. \n The list should be empty\n");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, content.Subjects.Count, "Collection of Subjects not properly initialized. \n The list should be empty\n");
        }


        [TestMethod]
        public void ConstructorInitializesProps()
        {
            // public Content(string contentURI, string description, bool isPublic, string title, DateTime uploadDate, Member owner)

            Content content = new Content(TestData.EXPECTED_CONTENT_CONTENTURI, TestData.EXPECTED_CONTENT_DESCRIPTION, TestData.EXPECTED_CONTENT_ISPUBLIC, TestData.EXPECTED_CONTENT_TITLE, TestData.EXPECTED_CONTENT_UPLOADDATE, TestData.EXPECTED_CONTENT_OWNER);

            Assert.AreEqual(TestData.EXPECTED_CONTENT_CONTENTURI, content.ContentURI, "URI not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_CONTENT_DESCRIPTION, content.Description, "Description not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_CONTENT_ISPUBLIC, content.IsPublic, "isPublic not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_CONTENT_TITLE, content.Title, "Title not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_CONTENT_UPLOADDATE, content.UploadDate, "UploadDate not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_CONTENT_OWNER, content.Owner, "Owner not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");

            // Verify the empty constructor is called (Collections)
            Assert.IsNotNull(content.Comments, "Collection of Comments not properly initialized. \n Patch the problem calling :this() and/or adding:  Comments = new List<Comment>();");
            Assert.IsNotNull(content.Visualizations, "Collection of Visualizations not properly initialized. \n Patch the problem calling :this() and/or adding:  Visualizations = new List<Visualization>();");
            Assert.IsNotNull(content.Subjects, "Collection of Subjects not properly initialized. \n Patch the problem calling :this() and/or adding:  Subjects = new List<Subjects>();");
        }
    }
}
