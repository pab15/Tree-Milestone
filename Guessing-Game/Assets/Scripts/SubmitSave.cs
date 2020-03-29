using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SubmitSave : MonoBehaviour
{
    public string saveName;
    public GameObject inputField;
    public void ClickedSubmitSave()
    {
        saveName = inputField.GetComponent<Text>().text;
        CreateGameManager.gameTree.WritePreOrderTraversal(saveName);
        CreateGameManager.saveName.SetActive(false);
        CreateGameManager.submitSave.SetActive(false);
        foreach (GameObject go in CreateGameManager.allActiveGameObjects)
        {
            go.SetActive(true);
        }
        CreateGameManager.allActiveGameObjects.Clear();
    }
}
