namespace Dev.Tech.Solutions.Domain.Tests;
using Dev.Tech.Solutions.Domain;
using Dev.Tech.Solutions.Domain.Catalog;



public class ItemsTests{


    [TestMethod]
    public void TestMethod()
    {
    }


    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Can_Create_New_Item()
    {
        var item = new Item("Name", "Description", "Brand", 10.00m);
   
        Assert.AreEqual("Name", item.Name);
        Assert.AreEqual("Description", item.Description);
        Assert.AreEqual("Brand", item.Brand);
        Assert.AreEqual(10.00m, item.Price);
    }


    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Cannot_Create_Item_With_Invalid_Brand()
    {
        var item = new Item("Name", "Description", null, 10.00m);
    }


    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Cannot_Create_Rating_With_Invalid_Price()
    {
        var item = new Item("Name", "Description", "Brand", -1);
    }




    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Can_Create_Add_Rating()
    {
        //Arrange
        var item = new Item("Name", "Description", "Brand", 10.00m);
        var rating = new Rating(5, "Name", "Review");


        //Act
        item.AddRating(rating);
        //Assert
        Assert.AreEqual(rating, item.Ratings[0]);  
    }


}
