using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public WeaponData weaponData;
    public CostumeData[] costumeDatas;
    private Dictionary<CostumeType, CostumeData> currentCostumes = new Dictionary<CostumeType, CostumeData>();

    public CostumeData GetCostumeData(CostumeType type)
    {
        // 현재 코스튬을 가져오기
        return currentCostumes[type];
    }

    public void SetCostumeData(CostumeData data)
    {
        // 코스튬을 세팅하기
        currentCostumes[data.type] = data;
    }
}
