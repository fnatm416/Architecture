using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CostumeType
{
    Head,
    Face,
    Upper,
    Lower,
    Foot
}

[System.Serializable]
public class CostumeData
{
    public CostumeType type;
    public int index;
}