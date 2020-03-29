using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNoButtonClicked : MonoBehaviour
{
    public void MoveRight()
    {
        if (LoadGameManager.current.isLeafNode == true)
        {
            LoadGameManager.nameField.SetActive(true);
            LoadGameManager.submitName.SetActive(true);
            LoadGameManager.promptTextBox.SetActive(true);
            LoadGameManager.yesButton.SetActive(false);
            LoadGameManager.noButton.SetActive(false);
            LoadGameManager.promptText.text = "What person were you thinking of?";
            LoadGameManager.questionTextBox.SetActive(false);
        }
        else
        {
            LoadGameManager.parent = LoadGameManager.current;
            LoadGameManager.current = LoadGameManager.current.MoveRight();
            LoadGameManager.questionText.text = LoadGameManager.current.AskQuestion();
            LoadGameManager.prevMoveRight = true;
            LoadGameManager.prevMoveLeft = false;
        }
    }
}
