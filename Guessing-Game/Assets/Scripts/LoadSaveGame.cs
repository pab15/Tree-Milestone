using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSaveGame : MonoBehaviour
{
    public void ClickedSaveGame()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

        foreach (GameObject go in allObjects)
        {
            if (go.activeInHierarchy)
            {
                if (go.name != "EventSystem" && go.name != "Canvas"
                        && go.name != "LoadGameManager" && go.name != "Main Camera")
                {
                    LoadGameManager.allActiveGameObjects.Add(go);
                }
            }
        }

        foreach (GameObject go in LoadGameManager.allActiveGameObjects)
        {
            go.SetActive(false);
        }

        LoadGameManager.saveName.SetActive(true);
        LoadGameManager.submitSave.SetActive(true);
    }
}
