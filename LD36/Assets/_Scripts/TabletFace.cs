﻿using UnityEngine;
using System.Collections.Generic;

public class TabletFace : MonoBehaviour
{
    public List<Pictograph> pictographList = new List<Pictograph>();
    [TextArea(10, 100)]
    public string documentText;
    public string archeologistName;
    public string carbonDate;
    public string artifactName;
}
