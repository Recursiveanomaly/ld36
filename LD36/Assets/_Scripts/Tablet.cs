using UnityEngine;
using System.Collections.Generic;

public class Tablet : MonoBehaviour
{
    public List<Pictograph> pictographList = new List<Pictograph>();
    public string documentText;
    public string archeologistName;
    public string carbonDate;

    public Tablet(List<Pictograph> pictoList, string docuText, string archName, string carboDate)
    {
        pictographList = pictoList;
        documentText = docuText;
        archeologistName = archName;
        carbonDate = carboDate;
    }
}
