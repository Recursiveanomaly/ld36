using UnityEngine;
using System.Collections.Generic;

public class Tablet : MonoBehaviour
{
    public List<Pictograph> pictographList = new List<Pictograph>();

    public Tablet(List<Pictograph> pictoList)
    {
        pictographList = pictoList;
    }
}
