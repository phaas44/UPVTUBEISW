using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using UPVTube.Entities;

namespace UPVTubeObjectDesignTests
{

    [TestClass]
    public class EvaluationTest
    {
        [TestMethod]
        public void VirtualPropertiesDefined()
        {
            // Virtual properties are Censor and Content

            PropertyInfo property = typeof(Evaluation).GetProperty("Censor");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Censor property should be declared virtual.");
            property = typeof(Evaluation).GetProperty("Content");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Content property should be declared virtual.");
        }
        [TestMethod]
        public void NoParamsConstructorInitializesCollections()
        {
            // There are no collections

            Evaluation evaluation = new Evaluation();
            Assert.AreNotSame(null, evaluation, "There must be a constructor without parameters.");

        }


        [TestMethod]
        public void ConstructorInitializesProps()
        {
            //  public Evaluation(DateTime evaluationDate, String rejectionReason, Member censor, Content evaluatedContent)

        
            Evaluation evaluation = new Evaluation(TestData.EXPECTED_EVALUATION_EVALUATIONDATE, TestData.EXPECTED_EVALUATION_REJECTIONREASON,
                                                   TestData.EXPECTED_CENSOR, TestData.EXPECTED_EVALUATION_CONTENT);

            
            
            
            Assert.AreEqual(TestData.EXPECTED_EVALUATION_EVALUATIONDATE, evaluation.EvaluationDate, "EvaluationDate not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_EVALUATION_REJECTIONREASON, evaluation.RejectionReason, "RejectionReason not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_CENSOR, evaluation.Censor, "Censor not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_EVALUATION_CONTENT, evaluation.Content, "Content not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
        
        }
    }






}