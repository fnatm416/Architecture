using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public WeaponType weaponType;

    public float maxHealth;
    public float currentHealth;

    public float maxStemina;
    public float currentStemina;

    public void Init(PlayerData data)
    {
        // �ʱ�ȭ �۾�
        weaponType = data.weapon.type;

        currentHealth = maxHealth;
        currentStemina = maxStemina;
    }
}
