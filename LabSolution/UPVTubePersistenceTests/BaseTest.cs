using UPVTube.Entities;
using UPVTube.Persistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Reflection;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Eventing.Reader;

namespace UPVTubePersistenceTests
{
    [TestClass]
    public class BaseTest
    {
        protected private EntityFrameworkDAL dal;

        private static bool HasRequiredAnnotation(PropertyInfo property)
        {
            var attributes = property.GetCustomAttributes(false);
            Attribute[] attrs = System.Attribute.GetCustomAttributes(property);
            return attrs.Any((attr) =>
            {
                return attr is RequiredAttribute;
            });

        }

        private static bool HasKeyAnnotation(PropertyInfo property)
        {
            var attributes = property.GetCustomAttributes(false);
            Attribute[] attrs = System.Attribute.GetCustomAttributes(property);
            return attrs.Any((attr) =>
            {
                return attr is KeyAttribute;
            });

        }

        private static bool HasDatabaseGeneratedOptionNone(PropertyInfo property)
        {
            var attributes = property.GetCustomAttributes(false);
            Attribute[] attrs = System.Attribute.GetCustomAttributes(property);
            return attrs.Any((attr) =>
            {
                if (attr is DatabaseGeneratedAttribute)
                {
                    DatabaseGeneratedAttribute dbGenAtt = attr as DatabaseGeneratedAttribute;
                    return dbGenAtt.DatabaseGeneratedOption == DatabaseGeneratedOption.None;
                }
                else return false;
                    
        
            });

        }

        [TestInitialize]
        public void IniTests()
        {
            // Si no hacemos este test aquí da otra excepción que no es trivial
            // para los alumnos saber qué está ocurriendo
            // Con estos assert sabrán que han de añadir los Required
            // Required en Comment: Writer y Content
            // Required en Visualization: Member y Content
            // Required en Content: Owner
            // Required en Evaluation: Censor y Content
            Assert.IsTrue(HasRequiredAnnotation(typeof(Comment).GetProperty("Writer")), "Property named \"Writer\" in \"Comment\" class should have Data Annotation [Required]");
            Assert.IsTrue(HasRequiredAnnotation(typeof(Comment).GetProperty("Content")), "Property named \"Content\" in \"Comment\" class should have Data Annotation [Required]");
            Assert.IsTrue(HasRequiredAnnotation(typeof(Visualization).GetProperty("Member")), "Property named \"Member\" in \"Visualization\" class should have Data Annotation [Required]");
            Assert.IsTrue(HasRequiredAnnotation(typeof(Visualization).GetProperty("Content")), "Property named \"Content\" in \"Visualization\" class should have Data Annotation [Required]");
            Assert.IsTrue(HasRequiredAnnotation(typeof(Content).GetProperty("Owner")), "Property named \"Owner\" in \"Content\" class should have Data Annotation [Required]");
            Assert.IsTrue(HasRequiredAnnotation(typeof(Evaluation).GetProperty("Censor")), "Property named \"Censor\" in \"Evaluation\" class should have Data Annotation [Required]");
            Assert.IsTrue(HasRequiredAnnotation(typeof(Evaluation).GetProperty("Content")), "Property named \"Content\" in \"Evaluation\" class should have Data Annotation [Required]");

            //Key Annotations
            Assert.IsTrue(HasKeyAnnotation(typeof(Member).GetProperty("Nick")), "Property named \"Nick\" in \"Member\" class should have Data Annotation [Key]");
            Assert.IsTrue(HasKeyAnnotation(typeof(Subject).GetProperty("Code")), "Property named \"Code\" in \"Subject\" class should have Data Annotation [Key]");

            //DatabaseGeneratedOption
            Assert.IsTrue(HasDatabaseGeneratedOptionNone(typeof(Subject).GetProperty("Code")), "Property named \"Code\" in \"Subject\" class should have Data Annotation [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]");
           
            dal = new EntityFrameworkDAL(new UPVTubeDbContext());
            dal.RemoveAllData();
        }
        [TestCleanup]
        public void CleanTests()
        {
            dal.RemoveAllData();
        }
    }
}
