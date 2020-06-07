using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange


            //Act
            var result = new ProductModel();
           

            //Assert
            Assert.AreEqual("", result.Logistics);

        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange



            // Act
            var result = new ProductModel();



            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        [TestMethod]
        public void ProductModel_Initialize_All_Members_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel()
            {
                Id = "id",
                Maker = "maker",
                Image = "image.png",
                Url = "http://localhost:8080/",
                Title = "title",
                Description = "description",
                Sequence = "sequence",
                Email = "koenigm@seattleu.edu",
                Logistics = "logistics"
            };

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Average_Rating_Of_5_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            
            Assert.AreEqual(5, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Average_Rating_Of_Null_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel {Ratings = null};

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Average_Rating_Of_Empty_Array_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel { Ratings = new int[] { } };

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Average_Rating_Accurate_Calculation_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel
            {
                Ratings = new int[] { 1, 2, 3, 4, 5}
            };

            // Assert
            
            Assert.AreEqual(3, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_ToString_IsNotNull_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
           
            Assert.IsNotNull(result.ToString());
        }

        [TestMethod]
        public void ProductModel_ToString_Returns_Json_String_Should_Pass()
        {
            // Arrange
            const string productModelId = "productModelId";

            // Act
            var result = new ProductModel()
            {
                Id = productModelId,
            };

            // Assert
            
            Assert.IsTrue(result.ToString().Contains(productModelId));
        }
    }
}
