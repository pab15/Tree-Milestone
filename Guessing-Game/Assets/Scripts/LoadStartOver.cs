using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadStartOver : MonoBehaviour
{
    public void ClickedStartOver()
    {
        SceneManager.LoadScene("LoadGame", LoadSceneMode.Single);
    }
}
