using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartOver : MonoBehaviour
{
    public void ClickedStartOver()
    {
        SceneManager.LoadScene("CreateGame", LoadSceneMode.Single);
    }
}
