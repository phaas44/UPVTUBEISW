using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using UPVTube.Entities;

namespace UPVTubeObjectDesignTests
{
    [TestClass]
    public class SubjectTest
    {
        [TestMethod]
        public void VirtualPropertiesDefined()
        {
            // Virtual properties are: Contents

            PropertyInfo property = typeof(Subject).GetProperty("Contents");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Contents property should be declared virtual.");
        }
        [TestMethod]
        public void NoParamsConstructorInitializesCollections()
        {
            // Collections are: Contents

            Subject subject = new Subject();
            Assert.AreNotSame(null, subject, "There must be a constructor without parameters.");
            Assert.IsNotNull(subject.Contents, "Collection of Contents not properly initialized. \n Patch the problem adding:  Contents = new List<Content>();");

            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, subject.Contents.Count, "Collection of Contents not properly initialized. \n The list should be empty\n");
        }


        [TestMethod]
        public void ConstructorInitializesProps()
        {
            // public Subject(int code, string fullName, string name)

            Subject subject = new Subject(TestData.EXPECTED_SUBJECT_CODE, TestData.EXPECTED_SUBJECT_FULLNAME, TestData.EXPECTED_SUBJECT_NAME);

            Assert.AreEqual(TestData.EXPECTED_SUBJECT_CODE, subject.Code, "Code not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_SUBJECT_FULLNAME, subject.FullName, "FullName not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_SUBJECT_NAME, subject.Name, "Name not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");

            // Verify the empty constructor is called
            Assert.IsNotNull(subject.Contents, "Collection of Contents not properly initialized. \n Patch the problem calling :this() and/or adding:  Contents = new List<Content>();");
       }
    }
}