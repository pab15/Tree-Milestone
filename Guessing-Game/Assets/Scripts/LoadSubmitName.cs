using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSubmitName : MonoBehaviour
{
    public string questionAnswer;
    public GameObject inputField;
    public void ClickedSubmitName()
    {
        questionAnswer = inputField.GetComponent<Text>().text;
        LoadGameManager.nameField.SetActive(false);
        LoadGameManager.submitName.SetActive(false);
        LoadGameManager.questionBox.SetActive(true);
        LoadGameManager.questionButton.SetActive(true);
        LoadGameManager.promptText.text = ("What is a yes or no question I can use to tell  "
                                                + LoadGameManager.current.content + " from "
                                                + questionAnswer + "?");
        LoadGameManager.newPerson = questionAnswer;
    }
}
