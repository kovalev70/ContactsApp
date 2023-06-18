namespace ContactsApp.UnitTests
{
    using ContactsApp.Model;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    [TestFixture]
    public class ProjectTests
    {
        private Project GetCorrectProject()
        {
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact("C", "C","70000000000",new DateTime(2001, 11, 10), "C"),
                new Contact("A", "A","72300000000",new DateTime(2011, 10, 1), "A"),
                new Contact("B", "B","71800000000",new DateTime(2000, 9, 5), "B"),
            };
            return project;
        }

        [Test(Description = "Positive test of the Contacts setter")]
        public void ContactsSet_CurrentValue_DoesNotThrowException()
        {
            //setup
            Project project = new Project();
            var testList = new List<Contact>();

            //assert
            Assert.DoesNotThrow(
                () => { project.Contacts = testList; },
                "Positive test of the Contacts setter not passed");
        }

        [Test(Description = "Test the sort")]
        public void SortingContacts_CorrectValue_ReturnOrderedList()
        {
            //setup
            var actualProject = GetCorrectProject();
            var expected = new List<Contact>()
            {
                actualProject.Contacts[1],
                actualProject.Contacts[2],
                actualProject.Contacts[0]
            };

            //act
            var actual = actualProject.SortingContacts();

            //assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].FullName, 
                    actual[i].FullName, "Dotes not sorted");
            }
        }

        [Test(Description = "Test Sort without values")]
        public void SortingContacts_WithoutValues_ReturnEmptyList()
        {
            //setup
            var project = new Project();
            var expected = new List<Contact>();

            //act
            var actual = project.SortingContacts();

            //assert
            Assert.AreEqual(expected, actual,
                "Don't Contain Values");
        }

        [Test(Description = "Test the sort with substring")]
        public void FindContacts_CorrectValueSubstring_ReturnCorrectList()
        {
            //setup
            var project = GetCorrectProject();
            var expected = new List<Contact>()
            {
                project.Contacts[0],
            };

            //act
            var actual = project.FindContacts("C");

            //assert
            Assert.AreEqual(expected[0].FullName,
                actual[0].FullName, "Not found");
        }

        [Test(Description = "Test Sort without values with substring")]
        public void FindByNameAndSurname_WithoutValuesSubstring_EmptyString()
        {
            //setup
            var project = new Project();
            var excepted = new List<Contact>();

            //act
            var actual = project.FindContacts("A");

            //assert
            CollectionAssert.AreEqual(excepted, actual,
                "Don't Contain Values");
        }


        [Test(Description = "Birthday found")]
        public void FindBirthdayContacts_NoBirthdayInThisDate_ReturnEmptyList()
        {
            //setup
            var project = GetCorrectProject();
            var expected = new List<Contact>();

            //act
            var actual = project.FindBirthdayContacts(
                new DateTime(1900, 12, 31));

            //assert
            Assert.AreEqual(expected,
                actual, "Fail to find people's birthday");
        }

        [Test(Description = "Birthday found")]
        public void Test_FindBirthdayContacts_HasContacts()
        {
            //setup
            var project = GetCorrectProject();
            var expected = new List<Contact>
            {
                project.Contacts[0]
            };

            //act
            var actual = project.FindBirthdayContacts(new DateTime(2001, 11, 10));

            //assert
            Assert.AreEqual(expected[0].FullName,
                actual[0].FullName, "Fail to find people's birthday");
        }
    }
}
