using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System;

public class PlayerAvatar : MonoBehaviour
{
    // ��Ų ���
    public Transform headTf;
    public Transform faceTf;
    public Transform upperTf;
    public Transform lowerTf;
    public Transform footTf;

    [SerializeField] private GameObject currentHead;
    [SerializeField] private GameObject currentFace;
    [SerializeField] private GameObject currentUpper;
    [SerializeField] private GameObject currentLower;
    [SerializeField] private GameObject currentFoot;

    public void Initialize()
    {
        // �ʱ�ȭ �۾�
        for (int i = 0; i < Enum.GetValues(typeof(CostumeType)).Length; i++)
        {
            // enumŸ���� ��ȸ�Ͽ� �� Ÿ�Ժ��� �ڽ�Ƭ ����
            var type = (CostumeType)Enum.ToObject(typeof(CostumeType), i);
            SwitchCostume(type);
        }
    }

    public void SwitchCostume(CostumeType type)
    {
        // �ڽ�Ƭ ����
        switch (type)
        {
            case CostumeType.Head:
                UnDressCostume(CostumeType.Head);
                DressCostume(CostumeType.Head);
                break;
            case CostumeType.Face:
                UnDressCostume(CostumeType.Face);
                DressCostume(CostumeType.Face);
                break;
            case CostumeType.Upper:
                UnDressCostume(CostumeType.Upper);
                DressCostume(CostumeType.Upper);
                break;
            case CostumeType.Lower:
                UnDressCostume(CostumeType.Lower);
                DressCostume(CostumeType.Lower);
                break;
            case CostumeType.Foot:
                UnDressCostume(CostumeType.Foot);
                DressCostume(CostumeType.Foot);
                break;
        }
    }

    private void DressCostume(CostumeType type)
    {
        var instance = DataManager.Instance;

        // �ڽ�Ƭ ����
        switch (type)
        {
            // ~Tf�� �ڽĿ�����Ʈ ������ ������ ������ ���� ���� ���� (�ε��� ���� ����)
            case CostumeType.Head:
                if (headTf.childCount > instance.GetCostumeData(CostumeType.Head))
                {
                    currentHead = headTf.GetChild(instance.GetCostumeData(CostumeType.Head)).gameObject;
                    currentHead.SetActive(true);
                }
                break;
            case CostumeType.Face:
                if (faceTf.childCount > instance.GetCostumeData(CostumeType.Face))
                {
                    currentFace = faceTf.GetChild(instance.GetCostumeData(CostumeType.Face)).gameObject;
                    currentFace.SetActive(true);
                }
                break;
            case CostumeType.Upper:
                if (upperTf.childCount > instance.GetCostumeData(CostumeType.Upper))
                {
                    currentUpper = upperTf.GetChild(instance.GetCostumeData(CostumeType.Upper)).gameObject;
                    currentUpper.SetActive(true);
                }
                break;
            case CostumeType.Lower:
                if (lowerTf.childCount > instance.GetCostumeData(CostumeType.Lower))
                {
                    currentLower = lowerTf.GetChild(instance.GetCostumeData(CostumeType.Lower)).gameObject;
                    currentLower.SetActive(true);
                }
                break;
            case CostumeType.Foot:
                if (footTf.childCount > instance.GetCostumeData(CostumeType.Foot))
                {
                    currentFoot = footTf.GetChild(instance.GetCostumeData(CostumeType.Foot)).gameObject;
                    currentFoot.SetActive(true);
                }
                break;
        }
    }

    private void UnDressCostume(CostumeType type)
    {
        // �ڽ�Ƭ ����
        switch (type)
        {
            case CostumeType.Head:
                if (currentHead != null)
                {
                    currentHead.SetActive(false);
                }
                break;
            case CostumeType.Face:
                if (currentFace != null)
                {
                    currentFace.SetActive(false);
                }
                break;
            case CostumeType.Upper:
                if (currentUpper != null)
                {
                    currentUpper.SetActive(false);
                }
                break;
            case CostumeType.Lower:
                if (currentLower != null)
                {
                    currentLower.SetActive(false);
                }
                break;
            case CostumeType.Foot:
                if (currentFoot != null)
                {
                    currentFoot.SetActive(false);
                }
                break;
        }
    }
}
