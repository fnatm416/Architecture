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
        // ���� �ڽ�Ƭ�� ��������
        return currentCostumes[type];
    }

    public void SetCostumeData(CostumeData data)
    {
        // �ڽ�Ƭ�� �����ϱ�
        currentCostumes[data.type] = data;
    }
}
