using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetInput : MonoBehaviour
{
    public string questionAnswer;
    public GameObject inputField;
    
    public void CreateNode()
    {
        questionAnswer = inputField.GetComponent<Text>().text;
        if (CreateGameManager.started == true)
        {
            CreateGameManager.gameTree.root = new PeopleNode(questionAnswer);
            CreateGameManager.parent = CreateGameManager.gameTree.root;
            CreateGameManager.promptText.text = "Is the answer for " + CreateGameManager.newPerson + " yes or no?";
            CreateGameManager.questionBox.SetActive(false);
            CreateGameManager.questionButton.SetActive(false);
            CreateGameManager.addYesButton.SetActive(true);
            CreateGameManager.addNoButton.SetActive(true);
        }
        else
        {
            CreateGameManager.savedNode = new PeopleNode(questionAnswer);
            CreateGameManager.promptText.text = "Is the answer for " + CreateGameManager.newPerson + " yes or no?";
            CreateGameManager.questionBox.SetActive(false);
            CreateGameManager.questionButton.SetActive(false);
            CreateGameManager.addYesButton.SetActive(true);
            CreateGameManager.addNoButton.SetActive(true);
        }
    }
}
