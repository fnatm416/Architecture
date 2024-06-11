using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerAvatar : MonoBehaviour
{
    // 스킨 목록
    public Transform headTf;
    public Transform faceTf;
    public Transform upperTf;
    public Transform lowerTf;
    public Transform footTf;

    private GameObject currentHead;
    private GameObject currentFace;
    private GameObject currentUpper;
    private GameObject currentLower;
    private GameObject currentFoot;

    public void SwitchCostume(CostumeData data)
    {
        // 코스튬 변경
        switch (data.type)
        {
            case CostumeType.Head:
                currentHead.SetActive(false);
                currentHead = headTf.GetChild(data.index).gameObject;
                currentHead.SetActive(true);
                break;
            case CostumeType.Face:
                currentFace.SetActive(false);
                currentFace = faceTf.GetChild(data.index).gameObject;
                currentFace.SetActive(true);
                break;
            case CostumeType.Upper:
                currentUpper.SetActive(false);
                currentUpper = upperTf.GetChild(data.index).gameObject;
                currentUpper.SetActive(true);
                break;
            case CostumeType.Lower:
                currentLower.SetActive(false);
                currentLower = lowerTf.GetChild(data.index).gameObject;
                currentLower.SetActive(true);
                break;
            case CostumeType.Foot:
                currentFoot.SetActive(false);
                currentFoot = footTf.GetChild(data.index).gameObject;
                currentFoot.SetActive(true);
                break;
        }
    }
}
