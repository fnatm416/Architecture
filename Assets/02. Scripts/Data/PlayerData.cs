using System;
using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils.Collections;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public WeaponData weaponData;
    public SerializableDictionary<CostumeType, int> costumeDatas = new SerializableDictionary<CostumeType, int>();

    public void Init()
    {
        // �ʱ�ȭ �۾�
        for(int i=0; i<Enum.GetValues(typeof(CostumeType)).Length; i++)
        {
            // enumŸ���� ��ȸ�Ͽ� �� Ÿ�Ժ��� ���Ҹ� �߰�
            var type = (CostumeType)Enum.ToObject(typeof(CostumeType), i);
            costumeDatas.Add(type, 0);
        }
    }

    public int GetCostumeData(CostumeType type)
    {
        // ���� �ڽ�Ƭ�� ��������
        return costumeDatas[type];
    }

    public void SetCostumeData(CostumeData data)
    {
        // �ڽ�Ƭ�� �����ϱ�
        costumeDatas[data.type] = data.index;
    }
}
