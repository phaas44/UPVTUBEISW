using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Entities;

namespace UPVTubePersistenceTests
{
    

        [TestClass]
        public class EvaluationTest : BaseTest
        {
            [TestMethod]
            public void StoresInitialData()
            {
                // An Evaluation object requires content and member objects to be initialized. So, this TestMethod is not used. 
            }

            [TestMethod]
            public void StoresDataWithRelations()
            {
                // Adding a censor
                Member censor = new Member(TestData.EXPECTED_MEMBER_EMAIL, TestData.EXPECTED_MEMBER_FULLNAME, TestData.EXPECTED_MEMBER_LASTACCESSDATE, TestData.EXPECTED_MEMBER_NICK, TestData.EXPECTED_MEMBER_PASSWORD);
                // Adding a content
                Content content = new Content(TestData.EXPECTED_CONTENT_CONTENTURI, TestData.EXPECTED_CONTENT_DESCRIPTION, TestData.EXPECTED_CONTENT_ISPUBLIC, TestData.EXPECTED_CONTENT_TITLE, TestData.EXPECTED_CONTENT_UPLOADDATE, censor);
                // Adding an Evaluation
                Evaluation evaluation = new Evaluation(TestData.EXPECTED_EVALUATION_EVALUATIONDATE, TestData.EXPECTED_EVALUATION_REJECTIONREASON, censor, content);               
                dal.Insert(content);
                dal.Insert(censor);
                dal.Insert(evaluation);
                dal.Commit();

                Evaluation evaluationFromDAL = dal.GetById<Evaluation>(evaluation.Id);

                // Test non virtual properties properly stored
                Assert.AreEqual(TestData.EXPECTED_EVALUATION_EVALUATIONDATE, evaluationFromDAL.EvaluationDate, "EvaluationDate attribute not properly stored.");
                Assert.AreEqual(TestData.EXPECTED_EVALUATION_REJECTIONREASON, evaluationFromDAL.RejectionReason, "RejectionReason attribute not properly stored.");
                
                // Test virtual properties properly stored
                // They must be initially instanced because they are all 1
                // censor, content
                Assert.AreEqual(content, evaluationFromDAL.Content, "Content not properly initialized.");
                Assert.AreEqual(censor, evaluationFromDAL.Censor, "Censor not properly initialized.");
            
            // Verify bidirectional relationships: all collections are not null after inserting one element      
       
            Assert.AreEqual(censor.Evaluations.FirstOrDefault(), evaluationFromDAL, "Bidirectional Member-Evaluation relationship not properly set");
            Assert.AreEqual(content.Evaluation, evaluationFromDAL, "Bidirectional Content-Evaluation relationship not properly created.");

        }
    }
    }

