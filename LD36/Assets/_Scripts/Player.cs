using UnityEngine;
using System.Collections.Generic;
using System;

public class Player : SingletonMonoBehaviour<Player>
{
    Dictionary<string, bool> m_knownPictographs = new Dictionary<string, bool>();

    void Awake()
    {
        SetIsKnown("make", true);
        SetIsKnown("has", true);
        SetIsKnown("are", true);
        SetIsKnown("with", true);
        SetIsKnown("of", true);
        SetIsKnown("from", true);

        SetIsKnown("no", true);

        SetIsKnown("man", true);
        SetIsKnown("love", true);
        SetIsKnown("woman", true);
        SetIsKnown("make", true);
        SetIsKnown("name", true);
        SetIsKnown("child", true);
        SetIsKnown("kill", true);
    }

    public bool IsKnown(string pictograph)
    {
        pictograph = pictograph.Trim().ToLower();

        return !string.IsNullOrEmpty(pictograph) && m_knownPictographs.ContainsKey(pictograph) && m_knownPictographs[pictograph];
    }

    public void SetIsKnown(string pictograph, bool isKnown)
    {
        pictograph = pictograph.Trim().ToLower();

        if (string.IsNullOrEmpty(pictograph)) return;

        m_knownPictographs[pictograph] = isKnown;

        if (KnownPictographsChanged != null) KnownPictographsChanged();
    }

    public event Action KnownPictographsChanged;
}
