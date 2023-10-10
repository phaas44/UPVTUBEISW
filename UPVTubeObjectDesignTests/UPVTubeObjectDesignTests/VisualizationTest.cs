using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using UPVTube.Entities;

namespace UPVTubeObjectDesignTests
{
    [TestClass]
    public class VisualizationTest
    {
        [TestMethod]
        public void VirtualPropertiesDefined()
        {
            // Virtual properties are: Content and Member

            PropertyInfo property = typeof(Visualization).GetProperty("Content");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Content property should be declared virtual.");
            property = typeof(Visualization).GetProperty("Member");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Member property should be declared virtual.");

        }
        [TestMethod]
        public void NoParamsConstructorInitializesCollections()
        {
            // There aren't Collections

            Visualization visualization = new Visualization();
            Assert.AreNotSame(null, visualization, "There must be a constructor without parameters.");

        }


        [TestMethod]
        public void ConstructorInitializesProps()
        {
            // public Visualization(DateTime visualizationDate, Content content, Member member)

            Visualization visualization = new Visualization(TestData.EXPECTED_VISUALIZATION_VISUALIZATIONDATE, TestData.EXPECTED_VISUALIZATION_CONTENT, TestData.EXPECTED_VISUALIZATION_MEMBER);

            Assert.AreEqual(TestData.EXPECTED_VISUALIZATION_VISUALIZATIONDATE, visualization.VisualizationDate, "VisualizationDate not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_VISUALIZATION_CONTENT, visualization.Content, "Content not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_VISUALIZATION_MEMBER, visualization.Member, "Member not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");

            // Verify the empty constructor is called
            
        }
    }
}
