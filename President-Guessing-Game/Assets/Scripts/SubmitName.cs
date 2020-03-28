using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitName : MonoBehaviour
{
    public string questionAnswer;
    public GameObject inputField;
    public void ClickedSubmitName()
    {
        questionAnswer = inputField.GetComponent<Text>().text;
        CreateGameManager.nameField.SetActive(false);
        CreateGameManager.submitName.SetActive(false);
        CreateGameManager.questionBox.SetActive(true);
        CreateGameManager.questionButton.SetActive(true);
        CreateGameManager.promptText.text = ("What is a yes or no question I can use to tell  " 
                                                + CreateGameManager.current.content + " from " 
                                                + questionAnswer + "?");
        CreateGameManager.newPerson = questionAnswer;
    }
}
