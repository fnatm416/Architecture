using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    #region Singleton
    private static DataManager instance;
    public static DataManager Instance
    {
        get
        {
            if (instance == null)
            {
                var obj = FindObjectOfType<DataManager>();

                if (obj != null)
                {
                    instance = obj;
                }
                else
                {
                    var newObj = new GameObject();
                    newObj.AddComponent<DataManager>();

                    instance = newObj.GetComponent<DataManager>();
                }
            }

            return instance;
        }
    }
    #endregion

    public List<CostumeData> costumes;
    public PlayerData data;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
