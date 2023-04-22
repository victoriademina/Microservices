using Play.Catalog.Service.Controllers;

namespace Play.Catalog.Service.Tests.Controllers;

public class ItemsControllerTest
{
    private ItemsController _itemsController;
    
    [SetUp]
    public void Setup()
    {
        _itemsController = new ItemsController();
    }

    [Test]
    public void GetReturnsItems()
    {
        // Act
        var result = _itemsController.Get();

        // Assert
        Assert.IsNotNull(result);
        Assert.IsInstanceOf<IEnumerable<ItemDto>>(result);
        Assert.That(result.Count(), Is.EqualTo(3));
        Assert.That(result.ElementAt(0).Name, Is.EqualTo("Potion"));
        Assert.That(result.ElementAt(1).Name, Is.EqualTo("Antidote"));
        Assert.That(result.ElementAt(2).Name, Is.EqualTo("Bronze sword"));
    }
}