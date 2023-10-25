using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Linq;
using UPVTube.Entities;

namespace UPVTubePersistenceTests
{
    [TestClass]
    public class VisualizationTest : BaseTest
    {
        [TestMethod]
        public void StoresInitialData()
        {
        // A Visualization object requires content and member objects to be initialized. So, this TestMethod is not used. 

        }

        [TestMethod]
        public void StoresDataWithRelations()
        {
            // Adding a Member
            Member member = new Member(TestData.EXPECTED_MEMBER_EMAIL, TestData.EXPECTED_MEMBER_FULLNAME, TestData.EXPECTED_MEMBER_LASTACCESSDATE, TestData.EXPECTED_MEMBER_NICK, TestData.EXPECTED_MEMBER_PASSWORD);
            // Adding a Content
            Content content = new Content(TestData.EXPECTED_CONTENT_CONTENTURI, TestData.EXPECTED_CONTENT_DESCRIPTION, TestData.EXPECTED_CONTENT_ISPUBLIC, TestData.EXPECTED_CONTENT_TITLE, TestData.EXPECTED_CONTENT_UPLOADDATE, member);
            // No neeed to add new content to member (owner)
            // owner.Contents.Add(content);

            // Visualization
            Visualization vis = new Visualization(TestData.EXPECTED_VISUALIZATION_VISUALIZATIONDATE, content, member);
            //This is not needed if we insert vis object first
            //EF takes care of bidirectional relationships
            //member.Visualizations.Add(vis);
            //content.Visualization.Add(vis)

            dal.Insert(content);
            dal.Insert(member);
            dal.Insert(vis);
            dal.Commit();
            
            Visualization visFromDAL = dal.GetById<Visualization>(vis.Id);
            // Test non virtual properties properly stored
            Assert.AreEqual(TestData.EXPECTED_VISUALIZATION_VISUALIZATIONDATE, visFromDAL.VisualizationDate, "Visualization attributes not properly stored.");         
            
            // Test virtual properties properly stored
            Assert.AreEqual(content, visFromDAL.Content, "Content not properly stored.");
            Assert.AreEqual(member, visFromDAL.Member, "Member not properly stored.");

            // Verify bidirectional relationships: all collections are not null after inserting one element      
            Assert.AreEqual(member.Visualizations.FirstOrDefault(), visFromDAL, "Bidirectional Member-Visualizations relationship not properly set");
            Assert.AreEqual(content.Visualizations.FirstOrDefault(), visFromDAL, "Bidirectional Content-Visualizations relationship not properly created.");

        }
    }
}