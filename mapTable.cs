using UnityEngine;

[System.Serializable]
public struct mapTableItem
{
    public string animation;
    public string music;
}

public class mapTable : ScriptableObject
{ 
    public mapTableItem[] animationKV;
}