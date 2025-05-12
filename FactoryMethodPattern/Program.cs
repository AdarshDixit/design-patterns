/*
 * Factory method pattern
 * The object creation is handled by each product factory. 
 * But which factory needs to be called is decided by client itself.
 * Components:
 * BaseProduct (IProduct)
 * ConcreteProducts (PersonalProduct, ConcreteProduct)
 * BaseFactory (ProductFactory)
 * ConcreteFactory (PersonalProductFactory, CommercialProductFactory)
 */

var personalProduct = new PersonalProductFactory().CreateProduct();
Console.WriteLine($"{personalProduct.GetName()} has price: {personalProduct.GetPrice()}");

var commercialProduct = new CommercialProductFactory().CreateProduct();
Console.WriteLine($"{commercialProduct.GetName()} has price: {commercialProduct.GetPrice()}");


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

// Factories

// base factory
public abstract class ProductFactory
{
    // this method is implemented by individual factory and has logic to create that type of object
    public abstract IProduct CreateProductObject();
    public IProduct CreateProduct() 
    {
        return this.CreateProductObject();
    }
}

// product factory 1
public class PersonalProductFactory : ProductFactory
{
    public override IProduct CreateProductObject()
    {
        return new PersonalProduct();
    }
}

// product factory 2
public class CommercialProductFactory : ProductFactory
{
    public override IProduct CreateProductObject()
    {
        return new CommercialProduct();
    }
}