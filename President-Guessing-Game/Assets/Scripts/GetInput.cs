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
        if (CreateGameManager.isRoot == true)
        {
            CreateGameManager.current = new PeopleNode(questionAnswer);
            CreateGameManager.isRoot = false;
            CreateGameManager.questionBox.SetActive(false);
            CreateGameManager.questionButton.SetActive(false);
            CreateGameManager.questionTextBox.SetActive(true);
            CreateGameManager.questionText.text = CreateGameManager.current.content;
            CreateGameManager.yesButton.SetActive(true);
            CreateGameManager.noButton.SetActive(true);
            CreateGameManager.parent = CreateGameManager.current;
        }
        else
        {
            if (CreateGameManager.movedLeft == true)
            {
                CreateGameManager.current.yesNode = new PeopleNode(questionAnswer);
                CreateGameManager.questionBox.SetActive(false);
                CreateGameManager.questionButton.SetActive(false);
                CreateGameManager.questionTextBox.SetActive(true);
                CreateGameManager.questionText.text = CreateGameManager.parent.content;
                CreateGameManager.yesButton.SetActive(true);
                CreateGameManager.noButton.SetActive(true);
                CreateGameManager.current = CreateGameManager.parent;
                CreateGameManager.movedLeft = false;
            }
            else if (CreateGameManager.movedRight == true)
            {
                CreateGameManager.current.noNode = new PeopleNode(questionAnswer);
                CreateGameManager.questionBox.SetActive(false);
                CreateGameManager.questionButton.SetActive(false);
                CreateGameManager.questionTextBox.SetActive(true);
                CreateGameManager.questionText.text = CreateGameManager.parent.content;
                CreateGameManager.yesButton.SetActive(true);
                CreateGameManager.noButton.SetActive(true);
                CreateGameManager.current = CreateGameManager.parent;
                CreateGameManager.movedRight = false;
            }
        }
    }
}
