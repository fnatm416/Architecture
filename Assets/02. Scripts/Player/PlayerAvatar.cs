using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatar : MonoBehaviour
{
    private PlayerStats stats;

    public GameObject weapon;
    public SkinnedMeshRenderer head;
    public SkinnedMeshRenderer upper;
    public SkinnedMeshRenderer lower;
    public SkinnedMeshRenderer foot;

    public void ChangeWeapon(WeaponData data)
    {
        // ���� ����
        stats.weaponType = data.type;
    }

    public void ChangeCostume(CostumeData data)
    {
        // �ڽ�Ƭ ����
        switch (data.type)
        {
            case CostumeType.Head:
                head.sharedMesh = data.mesh.sharedMesh;
                head.material = data.material;
                break;
            case CostumeType.Upper:
                upper.sharedMesh = data.mesh.sharedMesh;
                upper.material = data.material;
                break;
            case CostumeType.Lower:
                lower.sharedMesh = data.mesh.sharedMesh;
                lower.material = data.material;
                break;
            case CostumeType.Foot:
                foot.sharedMesh = data.mesh.sharedMesh;
                foot.material = data.material;
                break;
        }
    }
}
