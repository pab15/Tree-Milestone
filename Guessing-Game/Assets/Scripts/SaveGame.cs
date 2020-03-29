using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    public void ClickedSaveGame()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

        foreach (GameObject go in allObjects)
        {
            if (go.activeInHierarchy)
            {
                if (go.name != "EventSystem" && go.name != "Canvas"
                        && go.name != "CreateGameManager" && go.name != "Main Camera")
                {
                    CreateGameManager.allActiveGameObjects.Add(go);
                }
            }
        }

        foreach (GameObject go in CreateGameManager.allActiveGameObjects)
        {
            go.SetActive(false);
        }

        CreateGameManager.saveName.SetActive(true);
        CreateGameManager.submitSave.SetActive(true);
    } 
}
