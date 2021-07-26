using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericMedicine;
using NUnit.Framework;
using Moq;

namespace TestGenericMedicine
{
    [TestFixture]
    public class GenericMedicineTests
    {
        [Test]
        [TestCase("Paracetamol", "Paracetamol", "Cl,Ca", "01/30/2022", 243.30, "Paracetamol")]
        [TestCase("Sumo 34", "Sumo 34", "Cl,Ca", "08/15/2022", 243.30, "Sumo 34")]
        [TestCase("Azithromycin", "Azithromycin", "Cl,Ca", "08/15/2022", 243.30, "Azithromycin")] 
        public void CreateMedicineDetailTest(
            string name, string genericMedicineName, string composition, string expiryDate, 
            double pricePerStrip, string expectedName)
        {
            DateTime expDate = Convert.ToDateTime(expiryDate);
            Program obj = new Program();
            Medicine result = obj.CreateMedicineDetail(name, genericMedicineName,composition,expDate,pricePerStrip);
            Assert.True(result.Name == expectedName);
            Assert.IsTrue(result.PricePerStrip <= 500);
            Assert.IsTrue(result.ExpiryDate.Year > DateTime.Now.Year);
        }

        Medicine med1 = new Medicine
        {
            Id = 1,
            Name = "Paracetamol",
            GenericMedicineName = "Paracetamol",
            Composition = "Cl,Ca",
            ExpiryDate = new DateTime(2022, 1, 1),
            PricePerStrip = 243.7
        };

        [Test]
        [TestCase(5, "12/12/2021", "USA", 1218.5)]
        [TestCase(3, "12/12/2021", "USA", 731.09999999999991)] 
        public void CreateCartonDetailTest(
            int medicineStripCount, string launch, string retailerAddress, double expectedTotal)
        {
            DateTime launchDate = Convert.ToDateTime(launch);
            Program obj = new Program();
            var result = obj.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, med1);
            Assert.AreEqual(expectedTotal, result.TotalAmount);
        }
    }
}
