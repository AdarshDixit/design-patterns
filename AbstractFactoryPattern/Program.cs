// See https://aka.ms/new-console-template for more information
/*
 * Abstract factory design pattern:
 * One Super factory that creates other factories which create final object.
 * 2 type of ABSTRACT products: Personal and Commercial
 * 2 types of mode: Online vs Offline
 * Type of concrete product combinations: OnlinePersonalProduct, OnlineCommercialProduct, OfflinePersonalProduct, OfflineCommercialProduct
 * All components:
 * - Abstract product (IPersonalProduct, ICommercialProduct)
 * - Concrete product (OnlinePersonalProduct, OnlineCommercialProduct, OfflinePersonalProduct, OnlineCommercialProduct)
 * - Abstract factory (IProductFactory)
 * - Concrete factory (OnlineProductFactory, OfflineProductFactory)
 */
var onlinePersonalProduct = new OnlineProductFactory().CreatePersonalProduct();
Console.WriteLine($"{onlinePersonalProduct.GetName()} has price: {onlinePersonalProduct.GetPrice()}");
var onlineCommercialProduct = new OnlineProductFactory().CreateCommercialProduct();
Console.WriteLine($"{onlineCommercialProduct.GetName()} has price: {onlineCommercialProduct.GetPrice()}");
var offlinePersonalProduct = new OfflineProductFactory().CreatePersonalProduct();
Console.WriteLine($"{offlinePersonalProduct.GetName()} has price: {offlinePersonalProduct.GetPrice()}");
var offlineCommercialProduct = new OfflineProductFactory().CreateCommercialProduct();
Console.WriteLine($"{offlineCommercialProduct.GetName()} has price: {offlineCommercialProduct.GetPrice()}");


// Base product
public interface IProduct 
{
    public string GetName();
    public int GetPrice();
}

// abstract product 1
public interface IPersonalProduct : IProduct
{
}

// abstract product 2
public interface ICommercialProduct : IProduct
{
}


// Product 1 type 1
public class OnlinePersonalProduct : IPersonalProduct
{
    public string GetName()
    {
        return "Online Personal product";
    }

    public int GetPrice()
    {
        return 20;
    }
}

// Product 1 type 2
public class OfflinePersonalProduct : IPersonalProduct
{
    public string GetName()
    {
        return "Offline Personal product";
    }

    public int GetPrice()
    {
        return 10;
    }
}

// Product 2 type 1
public class OnlineCommercialProduct : ICommercialProduct
{
    public string GetName()
    {
        return "Online Commercial product";
    }

    public int GetPrice()
    {
        return 200;
    }
}

// Product 2 type 2
public class OfflineCommercialProduct : ICommercialProduct
{
    public string GetName()
    {
        return "Offline Commercial product";
    }

    public int GetPrice()
    {
        return 100;
    }
}

// Abstract Product Factory
public interface IProductFactroy
{
    //Abstract Product A creation
    IPersonalProduct CreatePersonalProduct();
    //Abstract Product B creation
    ICommercialProduct CreateCommercialProduct();
}

// concrete type 1 factory
public class OnlineProductFactory : IProductFactroy
{
    public ICommercialProduct CreateCommercialProduct()
    {
        return new OnlineCommercialProduct();
    }

    public IPersonalProduct CreatePersonalProduct()
    {
        return new OnlinePersonalProduct();
    }
}

// concrete type 2 factory
public class OfflineProductFactory : IProductFactroy
{
    public ICommercialProduct CreateCommercialProduct()
    {
        return new OfflineCommercialProduct();
    }

    public IPersonalProduct CreatePersonalProduct()
    {
        return new OfflinePersonalProduct();
    }
}