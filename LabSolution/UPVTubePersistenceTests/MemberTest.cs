using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Linq;
using UPVTube.Entities;

namespace UPVTubePersistenceTests
{
    [TestClass]
    public class MemberTest : BaseTest
    {
        [TestMethod]
        public void StoresInitialData()
        {
            Member member = new Member(TestData.EXPECTED_MEMBER_EMAIL, TestData.EXPECTED_MEMBER_FULLNAME, TestData.EXPECTED_MEMBER_LASTACCESSDATE, TestData.EXPECTED_MEMBER_NICK, TestData.EXPECTED_MEMBER_PASSWORD);

            dal.Insert(member);
            dal.Commit();

            // Test non virtual properties properly stored
            Member memberFromDAL = dal.GetAll<Member>().First();
            Assert.AreEqual(TestData.EXPECTED_MEMBER_FULLNAME, memberFromDAL.FullName, "Member attributes not properly stored.");

            // Test virtual properties properly stored
            // They must be initially empty because they are all 0..*
            // Subscriptors, SubscribedTo, Evaluations,
            // Visualizations, Comments, Contents
            Assert.IsNotNull(memberFromDAL.Subscriptors, "Collection of Subscriptors not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, memberFromDAL.Subscriptors.Count, "Collection of Subscriptors not properly initialized. \n The list should be empty\n");

            Assert.IsNotNull(memberFromDAL.SubscribedTo, "Collection of SubscribedTo not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, memberFromDAL.SubscribedTo.Count, "Collection of SubscribedTo not properly initialized. \n The list should be empty\n");

            Assert.IsNotNull(memberFromDAL.Evaluations, "Collection of Evaluations not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, memberFromDAL.Evaluations.Count, "Collection of Evaluations not properly initialized. \n The list should be empty\n");

            Assert.IsNotNull(memberFromDAL.Visualizations, "Collection of Visualizations not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, memberFromDAL.Visualizations.Count, "Collection of Visualizations not properly initialized. \n The list should be empty\n");

            Assert.IsNotNull(memberFromDAL.Comments, "Collection of Comments not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, memberFromDAL.Comments.Count, "Collection of Comments not properly initialized. \n The list should be empty\n");

            Assert.IsNotNull(memberFromDAL.Contents, "Collection of Contents not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, memberFromDAL.Contents.Count, "Collection of Contents not properly initialized. \n The list should be empty\n");

        }

        [TestMethod]
        public void StoresDataWithRelations()
        {
            Member member = new Member(TestData.EXPECTED_MEMBER_EMAIL, TestData.EXPECTED_MEMBER_FULLNAME, TestData.EXPECTED_MEMBER_LASTACCESSDATE, TestData.EXPECTED_MEMBER_NICK, TestData.EXPECTED_MEMBER_PASSWORD);

            // Adding a Subscriptor, SubscribedTo, Evaluation,
            // Visualization, Comment, Content
            // Subscriptor
            Member subscriptor = new Member(TestData.EXPECTED_MEMBER2_EMAIL, TestData.EXPECTED_MEMBER2_FULLNAME, TestData.EXPECTED_MEMBER2_LASTACCESSDATE, TestData.EXPECTED_MEMBER2_NICK, TestData.EXPECTED_MEMBER2_PASSWORD);
            member.Subscriptors.Add(subscriptor);

            // SubscribedTo
            Member subscribedTo = new Member(TestData.EXPECTED_MEMBER3_EMAIL, TestData.EXPECTED_MEMBER3_FULLNAME, TestData.EXPECTED_MEMBER3_LASTACCESSDATE, TestData.EXPECTED_MEMBER3_NICK, TestData.EXPECTED_MEMBER3_PASSWORD);
            member.SubscribedTo.Add(subscribedTo);

            // Evaluation
            
            Content content = new Content(TestData.EXPECTED_CONTENT_CONTENTURI, TestData.EXPECTED_CONTENT_DESCRIPTION, TestData.EXPECTED_CONTENT_ISPUBLIC, TestData.EXPECTED_CONTENT_TITLE, TestData.EXPECTED_CONTENT_UPLOADDATE, subscriptor);
            

            Evaluation eval = new Evaluation(TestData.EXPECTED_EVALUATION_EVALUATIONDATE, TestData.EXPECTED_EVALUATION_REJECTIONREASON, member, content);
            //This is not needed if we insert eval object first
            //EF takes care of bidirectional relationships
            //member.Evaluations.Add(eval);

            // Visualization
            Visualization vis = new Visualization(TestData.EXPECTED_VISUALIZATION_VISUALIZATIONDATE, content, member);
            //This is not needed if we insert vis object first
            //EF takes care of bidirectional relationships
            //member.Visualizations.Add(vis);

            // Comment
            Comment comment = new Comment(TestData.EXPECTED_COMMENT_TEXT, TestData.EXPECTED_COMMENT_WRITINGDATE, content, member);
            //This is not needed if we insert comment object first
            //EF takes care of bidirectional relationships
            //member.Comments.Add(comment);


            // Content
            // No neeed to add new content to member
            // We will verify that content has been added to
            // subscriptor member automatically because we added subscriptor as the 
            // owner of content object

            // Inserting these objects first makes EF deal with bidirectional
            // relationships, therefore no need to add them manually as explained
            // above. An alternative is to set all relationships manually
            // in member and then insert member only

            dal.Insert(content);
            dal.Insert(comment);
            dal.Insert(eval);
            dal.Insert(vis);
            dal.Insert(member);
            dal.Commit();

            Member memberFromDAL = dal.GetById<Member>(member.Nick);

            Assert.AreEqual(TestData.EXPECTED_MEMBER_NICK, memberFromDAL.Nick, "Member not properly stored.");

            // Verify all collections are not null after inserting one element
            // Subscriptor, SubscribedTo, Evaluation,
            // Visualization, Comment, Content       

            Assert.IsNotNull(memberFromDAL.Subscriptors, "Collection of Subscriptors not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, memberFromDAL.Subscriptors.Count, "Collection of Subscriptors not properly initialized. \n The list should have one element\n");
            Assert.AreEqual(subscriptor, memberFromDAL.Subscriptors.FirstOrDefault(), "Subscriptors relationship not properly created.");
            Assert.AreEqual(subscriptor.SubscribedTo.FirstOrDefault(), memberFromDAL, "Bidirectional Subscriptors-SubscribedTo relationship not properly set");

            Assert.IsNotNull(memberFromDAL.SubscribedTo, "Collection of SubscribedTo not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, memberFromDAL.SubscribedTo.Count, "Collection of SubscribedTo not properly initialized. \n The list should have one element\n");
            Assert.AreEqual(subscribedTo, memberFromDAL.SubscribedTo.FirstOrDefault(), "SubscribedTo relationship not properly created.");
            Assert.AreEqual(subscribedTo.Subscriptors.FirstOrDefault(), memberFromDAL, "Bidirectional SubscribedTo-Subscriptors relationship not properly set");

            Assert.IsNotNull(memberFromDAL.Evaluations, "Collection of Evaluations not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, memberFromDAL.Evaluations.Count, "Collection of Evaluations not properly initialized. \n The list should have one element\n");
            Assert.AreEqual(eval, memberFromDAL.Evaluations.FirstOrDefault(), "Evaluations relationship not properly created.");
            Assert.AreEqual(eval.Censor, memberFromDAL, "Bidirectional Evaluations-Censor relationship not properly set");

            Assert.IsNotNull(memberFromDAL.Visualizations, "Collection of Visualizations not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, memberFromDAL.Visualizations.Count, "Collection of Visualizations not properly initialized. \n The list should have one element\n");
            Assert.AreEqual(vis, memberFromDAL.Visualizations.FirstOrDefault(), "Visualizations relationship not properly created.");
            Assert.AreEqual(vis.Member, memberFromDAL, "Bidirectional Visualizations-Member relationship not properly set");


            Assert.IsNotNull(memberFromDAL.Comments, "Collection of Comments not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, memberFromDAL.Comments.Count, "Collection of Comments not properly initialized. \n The list should have one element\n");
            Assert.AreEqual(comment, memberFromDAL.Comments.FirstOrDefault(), "Comments relationship not properly created.");
            Assert.AreEqual(comment.Writer, memberFromDAL, "Bidirectional Writer-Comments relationship not properly set");


            Member subscriptorFromDAL = dal.GetById<Member>(subscriptor.Nick);
            Assert.IsNotNull(subscriptorFromDAL.Contents, "Collection of Contents not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, subscriptorFromDAL.Contents.Count, "Collection of Contents not properly initialized. \n The list should have one element\n");
            Assert.AreEqual(content, subscriptorFromDAL.Contents.FirstOrDefault(), "Contents relationship not properly created.");
            Assert.AreEqual(content.Owner, subscriptorFromDAL, "Bidirectional Owner-Contents relationship not properly set");

        }
    }
}