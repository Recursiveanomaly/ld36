using UnityEngine;
using System.Collections.Generic;

public class City
{
    public List<Tablet> tabletList = new List<Tablet>();

    public City(List<Tablet> tabList)
    {
        tabletList = tabList;
    }
}
