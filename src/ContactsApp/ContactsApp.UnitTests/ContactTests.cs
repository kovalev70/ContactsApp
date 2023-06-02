namespace ContactsApp.UnitTests
{
    using ContactsApp.Model;
    using NUnit.Framework;

    [TestFixture]
	class ContactTests
	{
		private Contact CreateEmptyContact()
		{
			return new Contact(" ", " ", "70000000000", DateTime.Now, "");
		}

        //Test Name start
        [Test(Description = "Positive test of the Name getter")]
        public void TestNameGet_ReturnCorrectValue()
        {
            //setup
            var expected = "Name";
            var contact = CreateEmptyContact();

            //act
            contact.FullName = expected;

            //assert
            var actual = contact.FullName;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative test of Name setter")]
        public void NameSet_ToLongName_ArgumentException()
        {
            //setup
            var contact = CreateEmptyContact();
            var name = "MichailMichailMichailMichailMichailMichailMichailMichailMichailMichail" +
                "MichailMichailMichailMichailMichailMichailMichailMichailMichailMichail";

            //assert
            Assert.Throws<ArgumentException>(
                () => { contact.FullName = name; });
        }

        [Test(Description = "Positive test of the Name setter")]
        public void NameSet_CorrectValue_DoesNotThrowException()
        {
            //setup
            var contact = CreateEmptyContact();
            var name = "Name";

            //assert
            Assert.DoesNotThrow(
                () => { contact.FullName = name; });
        }
        //Test Name end

        [Test(Description = "Positive test of the Email getter")]
        public void EmailGet_ReturnCorrectValue()
        {
            //setup
            var expected = "Email";
            var contact = CreateEmptyContact();
            contact.Email = expected;

            //act
            var actual = contact.Email;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative test of email setter")]
        public void EmailSet_ToLongEmail_ArgumentException()
        {
            //setup
            var contact = CreateEmptyContact();
            var Email = "erompompomerompompomerompompomerompompomerompompomerompompom" +
                "erompompomerompompomerompompomerompompomerompompomerompompom@gmail.com";

            //assert
            Assert.Throws<ArgumentException>(
                () => { contact.Email = Email; });
        }

        [Test(Description = "Positive test of the Email setter")]
        public void EmailSet_CorrectValue_DoesNotThrowException()
        {
            //setup
            var contact = CreateEmptyContact();
            var email = "Email";

            //assert
            Assert.DoesNotThrow(
                () => { contact.Email = email; });
        }

        //Test VkID start
        [Test(Description = "Positive test of the VKID getter")]
        public void VKIDGet_ReturnCorrectValue()
        {
            //setup
            var expected = "VKID";
            var contact = CreateEmptyContact();
            contact.VkId = expected;

            //act
            var actual = contact.VkId;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative VkID setter test")]
        public void VKIDSet_LongVkId_ArgumentException()
        {
            //setup
            var contact = CreateEmptyContact();
            var LongVkId = "vkIDvkIDvkIDvkIDvkIDvkIDvkIDvkIDvkIDvkIDvkIDvkIDvkIDvkID";

            //assert
            Assert.Throws<ArgumentException>(
                () => { contact.VkId = LongVkId; });
        }

        [Test(Description = "Positive test of the VKID setter")]
        public void VKIDSet_CorrectValue_DoesNotTrowException()
        {
            //setup
            var contact = CreateEmptyContact();
            var vkid = "VKID";

            //Assert
            Assert.DoesNotThrow(
                () => { contact.VkId = vkid; });
        }

        [Test(Description = "Positive test of the PhoneNumber getter")]
        public void PhoneNumberGet_ReturnCorrectValue()
        {
            //setup
            var expected = "78005553535";
            var contact = CreateEmptyContact();
            contact.PhoneNumber = expected;

            //act
            var actual = contact.PhoneNumber;

            //assert
            Assert.AreEqual(expected, actual,
                "Getter PhoneNumber returns incorrect value");
        }

        [Test(Description = "Negative test of PhoneNumber setter")]
        public void PhoneNumber_IncorrectNumberLength_ArgumentException()
        {
            //setup
            var contact = CreateEmptyContact();
            var wrongNumber = "71234567a";

            //assert
            Assert.Throws<ArgumentException>(
                () => { contact.PhoneNumber = wrongNumber; });
        }

        [Test(Description = "Positive test of the PhoneNumber setter")]
        public void PhoneNumberSet_CorrectValue()
        {
            //setup
            var contact = CreateEmptyContact();
            var phoneNumber = "78005553535";

            //assert
            Assert.DoesNotThrow(
                () => { contact.PhoneNumber = phoneNumber; },
                "Positive test of the PhoneNumber setter not passed");
        }

        [Test(Description = "Positive test of the Birthday getter")]
        public void BirthdayGet_ReturnCorrectValue()
        {
            //setup
            var expected = new DateTime(2000, 12, 12);
            var contact = CreateEmptyContact();
            contact.BirthDate = expected;

            //act
            var actual = contact.BirthDate;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative Test of Birthday setter")]
        public void BirthdaySet_FutureDate_ArgumentException()
        {
            //setup
            var contact = CreateEmptyContact();
            var wrongValue = DateTime.Now.AddDays(1);

            //assert
            Assert.Throws<ArgumentException>(
                () => { contact.BirthDate = wrongValue; });
        }

        [Test(Description = "Negative Test of Birthday setter")]
        public void BirthdaySet_PastDate_ArgumentException()
        {
            //setup
            var contact = CreateEmptyContact();
            var wrongValue = new DateTime(1899, 1, 1);

            //assert
            Assert.Throws<ArgumentException>(
                () => { contact.BirthDate = wrongValue; });
        }


        [Test(Description = "Positive test of the Birthday setter")]
        public void BirthdaySet_ReturnCorrectValue()
        {
            //setup
            var contact = CreateEmptyContact();
            var dateTime = new DateTime(2000, 12, 21);

            //assert
            Assert.DoesNotThrow(
                () => { contact.BirthDate = dateTime; });
        }

        [Test(Description = "test for the ToUpperFirst")]
        public void ToUpperFirst_ReturnCorrectValue()
        {
            //setup
            var expected = "Aaa";

            //act
            var actual = Contact.ToUpperFirst("aAa");

            //assert
            Assert.AreEqual(expected,
                actual, "Fail to find people's birthday");
        }

        [Test(Description = "Test constructor")]
        public void TestConstructor()
        {
            var expectedFullName = "Name";
            var expectedPhoneNumber = "78005553535";
            var expectedBirthday = new DateTime(2000, 12, 12);
            var expectedEmail = "Email";
            var expectedVkId = "VkId";

            Assert.DoesNotThrow(() =>
            {
                var contact = new Contact(expectedFullName, expectedEmail,
                    expectedPhoneNumber, expectedBirthday, expectedVkId);
            });
        }
    }
}