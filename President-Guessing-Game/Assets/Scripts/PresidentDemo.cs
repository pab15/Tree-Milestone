using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PresidentDemo : MonoBehaviour
{
    public void OnClickDemoGame()
    {
        SceneManager.LoadScene("PresidentDemo", LoadSceneMode.Single);
    }
}
