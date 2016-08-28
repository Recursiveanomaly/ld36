using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InfoPopup : MonoBehaviour
{
    public Text m_artifactName;
    public Text m_archaeologist;
    public Text m_carbonDate;
    public Text m_description;

    float m_showTime;
    float m_waitAfterShow = 0.2f;

    public void Setup(TabletFace tablet)
    {
        m_showTime = Time.time;

        m_artifactName.text = tablet.artifactName;
        m_archaeologist.text = tablet.archeologistName;
        m_carbonDate.text = tablet.carbonDate;
        m_description.text = tablet.documentText;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time > m_showTime + m_waitAfterShow && !GamePanelManager.Instance.DidUGUICaptureInput())
        {
            Close();
        }
    }

    public void Close()
    {
        TabletPanel.Instance.ResetToDefault();
    }
}
