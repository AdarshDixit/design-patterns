/*
 * Factory pattern
 * The object creation is handled by a common product factory. 
 * Client just needs to call a single factory.
 * Components:
 * Base product (IProduct)
 * Concrete product (Personal, Commercial)
 * Factory (ProductFactory)
 */

// call factory
var factory = new ProductFactory();
var product = factory.CreateProduct("commercial");
Console.WriteLine($"{product.GetName()} has price: {product.GetPrice()}");


// Base product
public interface IProduct
{
    public string GetName();
    public int GetPrice();
}

// Product 1
public class PersonalProduct : IProduct
{
    public string GetName()
    {
        return "Personal product";
    }

    public int GetPrice()
    {
        return 10;
    }
}

// Product 2
public class CommercialProduct : IProduct
{
    public string GetName()
    {
        return "Commercial product";
    }

    public int GetPrice()
    {
        return 100;
    }
}

// Factory to create product
public class ProductFactory
{
    public IProduct CreateProduct(string productType)
    {
        switch (productType.ToLower())
        {
            case "personal":
                return new PersonalProduct();
            case "commercial":
                return new CommercialProduct();
            default:
                throw new NotImplementedException();
        }
    }
}