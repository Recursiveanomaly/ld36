using UnityEngine;
using System.Collections;

public class GamePanelManager : SingletonMonoBehaviour<GamePanelManager>
{
    public GameObject m_cityPanel;
    public GameObject m_tabletPanel;

    public Vector3 m_cameraLocCity_01;
    public Vector3 m_cameraLocCity_02;
    public Vector3 m_cameraLocCity_03;

    Vector3 m_cityPanelCameraLoc;

    void Awake()
    {
        m_cityPanelCameraLoc = Camera.main.transform.position;
        if (m_cityPanel != null) m_cityPanel.gameObject.SetActive(true);
        if (m_tabletPanel != null) m_tabletPanel.gameObject.SetActive(false);
    }


    public void ShowCityPanel()
    {
        // todo: animate

        Camera.main.transform.position = m_cityPanelCameraLoc;

        if (m_cityPanel != null) m_cityPanel.gameObject.SetActive(true);
        if (m_tabletPanel != null) m_tabletPanel.gameObject.SetActive(false);
    }

    public void ShowTabletPanel(int city)
    {
        // todo: animate

        switch (city)
        {
            default:
            case 1:
                TabletPanel.Instance.m_defaultCameraPosition = m_cameraLocCity_01;
                break;
            case 2:
                TabletPanel.Instance.m_defaultCameraPosition = m_cameraLocCity_02;
                break;
            case 3:
                TabletPanel.Instance.m_defaultCameraPosition = m_cameraLocCity_03;
                break;
        }

        TabletPanel.Instance.ResetToDefault();

        if (m_cityPanel != null) m_cityPanel.gameObject.SetActive(false);
        if (m_tabletPanel != null) m_tabletPanel.gameObject.SetActive(true);
    }
}
