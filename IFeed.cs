using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalWorld
{
    interface IFeed : IAnimal
    {
        Products Products { set; get; }
        LevelOfProfit Profit { set; get; }
    }
    enum Products
    {
        None,
        Meat,
        Eggs,
        Milk
    }
    enum LevelOfProfit
    {
        None,
        Little,
        High
    }
}
