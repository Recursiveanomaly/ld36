﻿using UnityEngine;
using System.Collections;
using DG.Tweening;

public class CityPanel : MonoBehaviour 
{
    public GameObject m_introPanel;
    public GameObject m_introPanelBlocker;

    bool m_startingIntroSet = false;
    float m_startingIntroY;

    bool m_isIntroOpen = true;

    void Awake()
    {
        if (m_introPanel != null)
        {
            m_introPanel.gameObject.SetActive(true);
            m_startingIntroY = m_introPanel.transform.position.y;
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

    public void Peek()
    {
        if (!m_startingIntroSet)
        {
            m_startingIntroSet = true;
            m_startingIntroY = transform.position.y;
        }
        m_introPanel.transform.DOMoveY(m_startingIntroY - 575f, 0f);
        m_introPanel.transform.DOMoveY(m_startingIntroY - 525f, 0.5f);
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
            if (!m_startingIntroSet)
            {
                m_startingIntroSet = true;
                m_startingIntroY = transform.position.y;
            }

            m_introPanel.transform.DOMoveY(m_startingIntroY - 525f, 0.5f);
            m_isIntroOpen = false;
            if (m_introPanelBlocker != null) m_introPanelBlocker.gameObject.SetActive(false);
            //m_introPanel.gameObject.SetActive(false);
        }
    }

    public void ReOpenIntro()
    {
        if (m_introPanel != null)
        {
            if(!m_startingIntroSet)
            {
                m_startingIntroSet = true;
                m_startingIntroY = transform.position.y;
            }

            m_introPanel.transform.DOMoveY(m_startingIntroY, 0.5f);
            m_isIntroOpen = true;
            if (m_introPanelBlocker != null) m_introPanelBlocker.gameObject.SetActive(true);
            //m_introPanel.gameObject.SetActive(true);
        }
    }
}
