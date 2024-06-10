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
        // 초기화 작업
        currentHealth = maxHealth;
        currentStemina = maxStemina;
    }
}
