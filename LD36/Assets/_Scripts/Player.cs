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
        SetIsKnown("for", true);
        SetIsKnown("man", true);
        SetIsKnown("woman", true);

        SetIsKnown("no", true);

        SetIsKnown("in", true);

        //SetIsKnown("man", true);
        //SetIsKnown("love", true);
        //SetIsKnown("woman", true);
        //SetIsKnown("make", true);
        //SetIsKnown("name", true);
        //SetIsKnown("child", true);
        //SetIsKnown("kill", true);
    }

    public bool IsKnown(string pictograph)
    {
        pictograph = SanitizeString(pictograph);

        return !string.IsNullOrEmpty(pictograph) && m_knownPictographs.ContainsKey(pictograph) && m_knownPictographs[pictograph];
    }

    public void SetIsKnown(string pictograph, bool isKnown)
    {
        pictograph = SanitizeString(pictograph);

        if (string.IsNullOrEmpty(pictograph)) return;

        m_knownPictographs[pictograph] = isKnown;

        if (KnownPictographsChanged != null) KnownPictographsChanged();
    }

    string SanitizeString(string pictograph)
    {
        pictograph = pictograph.Trim().ToLower();
        if (pictograph.EndsWith("s"))
        {
            pictograph = pictograph.Remove(pictograph.Length - 1, 1);
        }

        // special case
        if (pictograph.Equals("god")) pictograph = "gods";

        // special case
        if (pictograph.Equals("giant")) pictograph = "giants";

        // special case
        if (pictograph.Equals("men")) pictograph = "man";

        // special case
        if (pictograph.Equals("women")) pictograph = "woman";

        return pictograph;
    }

    public event Action KnownPictographsChanged;
}
