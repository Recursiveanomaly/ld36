using UnityEngine;
using System.Collections;

public class GuessPopup : MonoBehaviour 
{
    float m_showTime;
    float m_waitAfterShow = 0.2f;

    public void Setup(Pictograph pictograph)
    {
        m_showTime = Time.time;   
    }

    void Update()
    {
        if (Input.anyKeyDown && Time.time > m_showTime + m_waitAfterShow)
        {
            TabletPanel.Instance.ResetToDefault();
        }
    }
}
