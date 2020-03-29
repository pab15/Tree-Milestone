using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadGameName : MonoBehaviour
{
    public string loadGameName;
    public GameObject inputField;
    public void ClickedLoadGameName()
    {
        loadGameName = inputField.GetComponent<Text>().text;
        LoadGameManager.gameTree = new GameTree(loadGameName);
        LoadGameManager.current = LoadGameManager.gameTree.root;
        LoadGameManager.loadGameName.SetActive(false);
        LoadGameManager.loadGameButton.SetActive(false);
        LoadGameManager.questionTextBox.SetActive(true);
        LoadGameManager.noButton.SetActive(true);
        LoadGameManager.yesButton.SetActive(true);
        LoadGameManager.questionText.text = "Think of a person...\n" + LoadGameManager.current.AskQuestion();
    }
}
