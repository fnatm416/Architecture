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
        // 초기화 작업
        for(int i=0; i<Enum.GetValues(typeof(CostumeType)).Length; i++)
        {
            // enum타입을 순회하여 각 타입별로 원소를 추가
            var type = (CostumeType)Enum.ToObject(typeof(CostumeType), i);
            costumeDatas.Add(type, 0);
        }
    }

    public int GetCostumeData(CostumeType type)
    {
        // 현재 코스튬을 가져오기
        return costumeDatas[type];
    }

    public void SetCostumeData(CostumeData data)
    {
        // 코스튬을 세팅하기
        costumeDatas[data.type] = data.index;
    }
}
