using UnityEngine;
using System.Collections.Generic;

public class DataSeterUpper : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Pictograph picto001 = new Pictograph("cow", "picto001.png");
        Pictograph picto002 = new Pictograph("money", "picto002.png");
        Pictograph picto003 = new Pictograph("warrior", "picto003.png");
        Pictograph picto004 = new Pictograph("woman", "picto004.png");
        Pictograph picto005 = new Pictograph("man", "picto005.png");
        Pictograph picto006 = new Pictograph("child", "picto006.png");
        Pictograph picto007 = new Pictograph("dog", "picto007.png");
        Pictograph picto008 = new Pictograph("horse", "picto008.png");
        Pictograph picto009 = new Pictograph("sword", "picto009.png");
        Pictograph picto010 = new Pictograph("bread", "picto010.png");

        List<Pictograph> tablet001List = new List<Pictograph>();
        tablet001List.Add(picto001);
        tablet001List.Add(picto002);
        tablet001List.Add(picto003);
        tablet001List.Add(picto004);
        tablet001List.Add(picto005);

        List<Pictograph> tablet002List = new List<Pictograph>();
        tablet002List.Add(picto006);
        tablet002List.Add(picto007);
        tablet002List.Add(picto008);
        tablet002List.Add(picto009);
        tablet002List.Add(picto010);

        Tablet tablet001 = new Tablet(tablet001List);
        Tablet tablet002 = new Tablet(tablet002List);

        List<Tablet> city001List = new List<Tablet>();
        city001List.Add(tablet001);
        city001List.Add(tablet002);
    }
}
