using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyManager : MonoBehaviour
{
    public void InGame()
    {
        SceneManager.LoadScene("InGame");
    }
}
