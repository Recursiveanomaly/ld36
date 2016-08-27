using UnityEngine;
using System.Collections;

public class CityView : MonoBehaviour 
{
    public void OnClick()
    {
        GamePanelManager.Instance.ShowTabletPanel();
    }
}
