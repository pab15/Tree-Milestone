using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadGetInput : MonoBehaviour
{
    public string questionAnswer;
    public GameObject inputField;

    public void CreateNode()
    {
        questionAnswer = inputField.GetComponent<Text>().text;
        if (LoadGameManager.started == true)
        {
            LoadGameManager.gameTree.root = new PeopleNode(questionAnswer);
            LoadGameManager.parent = LoadGameManager.gameTree.root;
            LoadGameManager.promptText.text = "Is the answer for " + LoadGameManager.newPerson + " yes or no?";
            LoadGameManager.questionBox.SetActive(false);
            LoadGameManager.questionButton.SetActive(false);
            LoadGameManager.addYesButton.SetActive(true);
            LoadGameManager.addNoButton.SetActive(true);
        }
        else
        {
            LoadGameManager.savedNode = new PeopleNode(questionAnswer);
            LoadGameManager.promptText.text = "Is the answer for " + LoadGameManager.newPerson + " yes or no?";
            LoadGameManager.questionBox.SetActive(false);
            LoadGameManager.questionButton.SetActive(false);
            LoadGameManager.addYesButton.SetActive(true);
            LoadGameManager.addNoButton.SetActive(true);
        }
    }
}
