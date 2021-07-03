using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open closed prenciple
    class Program
    {
        static void Main(string[] args)
        {
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            var result = categoryManager.GetAll();

            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CategoryId + "/ " + item.CategoryName + " / " + item.Description);
            }
        }
    }
}
