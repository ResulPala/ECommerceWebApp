﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

public class Program
{
    private static void Main(string[] args)
    {
        ProductTest();
        //CategoryTest();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var item in categoryManager.GetAll())
        {
            Console.WriteLine(item.CategoryName);
        }  
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var product in productManager.GetProductDetails())
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }
}