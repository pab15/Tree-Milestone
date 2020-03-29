using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSubmitSave : MonoBehaviour
{
    public string saveName;
    public GameObject inputField;
    public void ClickedSubmitSave()
    {
        saveName = inputField.GetComponent<Text>().text;
        LoadGameManager.gameTree.WritePreOrderTraversal(saveName);
        LoadGameManager.saveName.SetActive(false);
        LoadGameManager.submitSave.SetActive(false);
        foreach (GameObject go in LoadGameManager.allActiveGameObjects)
        {
            go.SetActive(true);
        }
        LoadGameManager.allActiveGameObjects.Clear();
    }
}
