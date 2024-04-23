namespace Dev.Tech.Solutions.Domain.Tests;
using Dev.Tech.Solutions.Domain;
using Dev.Tech.Solutions.Domain.Catalog;


[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
    }

   

[TestMethod]
    public void Can_Create_New_Rating()
    {
	    //Arrange
	    var rating = new Rating(1, "Mike", "Great fit!");

	    //Act (empty)

	    //Assert
	    Assert.AreEqual(1, rating.Stars);
	    Assert.AreEqual("Mike", rating.UserName);
	    Assert.AreEqual("Great fit!", rating.Review);
    }


    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Cannot_Create_Rating_With_Invalid_Stars()
    {
	    //Arrange
	    var rating = new Rating(0, "Mike", "Great fit!");
    }






}