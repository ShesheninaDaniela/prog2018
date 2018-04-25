using App;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;



namespace Test
{
    [TestClass]
    public class SeralizationTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dto = new AppointmentToTheDentist
            {
                FilledTime = DateTime.Now,
                Service = new List<ChoiceOfService>()
                {
                  ChoiceOfService. Consultation,

                },
                Price = 5200,
                Currency = Currency.Rubles,
                Person = new PersonalData()
                {
                    Sex = "Женский",
                    DateBirth = new DateTime(1998, 10, 14),
                    DocumentType = Document.Passport,
                    FullName = new NameBuyer()
                    {
                        LastName = "Орлова",
                        FirstName = "Ольга",
                        Patronymic = "Олеговна",
                    },
                    Number = 578964,
                    Series = 2587,
                },
            };
             var tempFileName = Path.GetTempFileName();
            try
            {
                DentistDtoHelper.WriteToFile(tempFileName, dto);
                var readDto = DentistDtoHelper.LoadFromFile(tempFileName);
                Assert.AreEqual(dto.FilledTime, readDto.FilledTime);
                Assert.AreEqual(dto.Person.DateBirth, readDto.Person.DateBirth);
                Assert.AreEqual(dto.Currency, readDto.Currency);
            }
            finally
            {
                File.Delete(tempFileName);
            }
        }

        
    }
}
