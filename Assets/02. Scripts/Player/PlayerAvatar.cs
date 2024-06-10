using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerAvatar : MonoBehaviour
{
    // 스킨 목록
    public SkinnedMeshRenderer head;
    public SkinnedMeshRenderer upper;
    public SkinnedMeshRenderer lower;
    public SkinnedMeshRenderer foot;

    public void SetCostume(CostumeData data)
    {
        // 코스튬 변경
        switch (data.type)
        {
            case CostumeType.Head:
                head.sharedMesh = data.mesh.sharedMesh;
                head.material = data.mesh.material;
                break;
            case CostumeType.Upper:
                upper.sharedMesh = data.mesh.sharedMesh;
                upper.material = data.mesh.material;
                break;
            case CostumeType.Lower:
                lower.sharedMesh = data.mesh.sharedMesh;
                lower.material = data.mesh.material;
                break;
            case CostumeType.Foot:
                foot.sharedMesh = data.mesh.sharedMesh;
                foot.material = data.mesh.material;
                break;
        }
    }
}
