﻿using UnityEngine;
using System.Collections;
using DG.Tweening;

public class CityPanel : MonoBehaviour 
{
    public GameObject m_introPanel;
    public GameObject m_introPanelBlocker;
    float startingIntroY;
    bool m_isIntroOpen = true;

    void Awake()
    {
        if (m_introPanel != null)
        {
            m_introPanel.gameObject.SetActive(true);
            startingIntroY = m_introPanel.transform.position.y;
            if (m_introPanelBlocker != null) m_introPanelBlocker.gameObject.SetActive(true);
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

    public void ToggleIntro()
    {
        if(m_isIntroOpen)
        {
            CloseIntro();
        }
        else
        {
            ReOpenIntro();
        }
    }

    public void CloseIntro()
    {
        if (m_introPanel != null)
        {
            m_introPanel.transform.DOMoveY(-115f, 0.5f);
            m_isIntroOpen = false;
            if (m_introPanelBlocker != null) m_introPanelBlocker.gameObject.SetActive(false);
            //m_introPanel.gameObject.SetActive(false);
        }
    }

    public void ReOpenIntro()
    {
        if (m_introPanel != null)
        {
            m_introPanel.transform.DOMoveY(startingIntroY, 0.5f);
            m_isIntroOpen = true;
            if (m_introPanelBlocker != null) m_introPanelBlocker.gameObject.SetActive(true);
            //m_introPanel.gameObject.SetActive(true);
        }
    }
}
