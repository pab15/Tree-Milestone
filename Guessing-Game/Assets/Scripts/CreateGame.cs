using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreateGame : MonoBehaviour
{
    public void OnClickCreateGame()
    {
        SceneManager.LoadScene("CreateGame", LoadSceneMode.Single);
    }
}
