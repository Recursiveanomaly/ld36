using UnityEngine;
using System.Collections;

public class CityPanel : MonoBehaviour 
{
    public GameObject m_introPanel;

    void Awake()
    {
        if (m_introPanel != null)
        {
            m_introPanel.gameObject.SetActive(true);
        }
    }


    void Update()
    {
        if (m_introPanel != null)
        {
            if (m_introPanel.gameObject.activeInHierarchy && Input.GetKeyDown(KeyCode.Mouse0) && !GamePanelManager.Instance.DidUGUICaptureInput())
            {
                CloseIntro();
            }
        }
    }

    public void CloseIntro()
    {
        if (m_introPanel != null)
        {
            m_introPanel.gameObject.SetActive(false);
        }
    }
}
