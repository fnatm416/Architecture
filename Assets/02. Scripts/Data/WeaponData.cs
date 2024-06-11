using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    None,
    ShortSword,
    DualSword,
    LargeSword
}

[System.Serializable]
public class WeaponData
{
    public WeaponType type;
    public int index;
}