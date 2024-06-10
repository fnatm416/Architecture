using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    ShortSword,
    DualSword,
    LargeSword
}

[System.Serializable]
public class WeaponData
{
    //public string name;
    public WeaponType type;
    public GameObject prefab;
}