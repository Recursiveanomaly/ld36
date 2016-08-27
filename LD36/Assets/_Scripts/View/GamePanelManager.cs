using UnityEngine;
using System.Collections;

public class GamePanelManager : SingletonMonoBehaviour<GamePanelManager>
{
    public GameObject m_cityPanel;
    public GameObject m_tabletPanel;

    void Awake()
    {
        if (m_cityPanel != null) m_cityPanel.gameObject.SetActive(true);
        if (m_tabletPanel != null) m_tabletPanel.gameObject.SetActive(false);
    }


    public void ShowCityPanel()
    {
        // todo: animate
        if (m_cityPanel != null) m_cityPanel.gameObject.SetActive(true);
        if (m_tabletPanel != null) m_tabletPanel.gameObject.SetActive(false);
    }

    public void ShowTabletPanel()
    {
        // todo: animate
        if (m_cityPanel != null) m_cityPanel.gameObject.SetActive(false);
        if (m_tabletPanel != null) m_tabletPanel.gameObject.SetActive(true);
    }
}
