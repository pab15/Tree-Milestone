﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoadGame : MonoBehaviour
{
    public void OnClickLoadGame()
    {
        SceneManager.LoadScene("LoadGame", LoadSceneMode.Single);
    }
}
