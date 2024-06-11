using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyManager : MonoBehaviour
{
    // 커스터마이징 테스트 변수
    public TMP_Text headText;
    public TMP_Text faceText;
    public TMP_Text upperText;
    public TMP_Text lowerText;
    public TMP_Text footText;
    //

    public void InGame()
    {
        SceneManager.LoadScene("InGame");
    }

    // 커스터마이징 테스트 함수
    public void ChangeHead(int point)
    {
        DataManager.Instance.playerData.costumeDatas[CostumeType.Head] += point;
        int value = DataManager.Instance.playerData.costumeDatas[CostumeType.Head];
        int length = DataManager.Instance.playerAvatar.headTf.childCount;

        if (value > length -1)
        {
            value = 0;
        }
        else if (value < 0)
        {
            value = length - 1;
        }

        DataManager.Instance.playerData.costumeDatas[CostumeType.Head] = value;
        headText.text = value.ToString();
        DataManager.Instance.playerAvatar.SwitchCostume(CostumeType.Head);
    }

    public void ChangeFace(int point)
    {
        DataManager.Instance.playerData.costumeDatas[CostumeType.Face] += point;
        int value = DataManager.Instance.playerData.costumeDatas[CostumeType.Face];
        int length = DataManager.Instance.playerAvatar.faceTf.childCount;

        if (value > length -1)
        {
            value = 0;
        }
        else if (value < 0)
        {
            value = length - 1;
        }

        DataManager.Instance.playerData.costumeDatas[CostumeType.Face] = value;
        faceText.text = value.ToString();
        DataManager.Instance.playerAvatar.SwitchCostume(CostumeType.Face);
    }

    public void ChangeUpper(int point)
    {
        DataManager.Instance.playerData.costumeDatas[CostumeType.Upper] += point;
        int value = DataManager.Instance.playerData.costumeDatas[CostumeType.Upper];
        int length = DataManager.Instance.playerAvatar.upperTf.childCount;

        if (value > length -1)
        {
            value = 0;
        }
        else if (value < 0)
        {
            value = length - 1;
        }

        DataManager.Instance.playerData.costumeDatas[CostumeType.Upper] = value;
        upperText.text = value.ToString();
        DataManager.Instance.playerAvatar.SwitchCostume(CostumeType.Upper);
    }

    public void ChangeLower(int point)
    {
        DataManager.Instance.playerData.costumeDatas[CostumeType.Lower] += point;
        int value = DataManager.Instance.playerData.costumeDatas[CostumeType.Lower];
        int length = DataManager.Instance.playerAvatar.lowerTf.childCount;

        if (value > length -1)
        {
            value = 0;
        }
        else if (value < 0)
        {
            value = length - 1;
        }

        DataManager.Instance.playerData.costumeDatas[CostumeType.Lower] = value;
        lowerText.text = value.ToString();
        DataManager.Instance.playerAvatar.SwitchCostume(CostumeType.Lower);
    }

    public void ChangeFoot(int point)
    {
        DataManager.Instance.playerData.costumeDatas[CostumeType.Foot] += point;
        int value = DataManager.Instance.playerData.costumeDatas[CostumeType.Foot];
        int length = DataManager.Instance.playerAvatar.footTf.childCount;

        if (value > length -1)
        {
            value = 0;
        }
        else if (value < 0)
        {
            value = length - 1;
        }

        DataManager.Instance.playerData.costumeDatas[CostumeType.Foot] = value;
        footText.text = value.ToString();
        DataManager.Instance.playerAvatar.SwitchCostume(CostumeType.Foot);
    }
    //
}
