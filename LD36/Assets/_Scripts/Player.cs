using UnityEngine;
using System.Collections.Generic;
using System;

public class Player : SingletonMonoBehaviour<Player>
{
    Dictionary<string, bool> m_knownPictographs = new Dictionary<string, bool>();

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
