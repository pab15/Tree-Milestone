using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoButtonClick : MonoBehaviour
{
    public void MoveRight()
    {
        if (CreateGameManager.current.isLeafNode == true)
        {
            CreateGameManager.nameField.SetActive(true);
            CreateGameManager.submitName.SetActive(true);
            CreateGameManager.promptTextBox.SetActive(true);
            CreateGameManager.yesButton.SetActive(false);
            CreateGameManager.noButton.SetActive(false);
            CreateGameManager.promptText.text = "What person were you thinking of?";
            CreateGameManager.questionTextBox.SetActive(false);
        }
        else
        {
            CreateGameManager.parent = CreateGameManager.current;
            CreateGameManager.current = CreateGameManager.current.MoveRight();
            CreateGameManager.questionText.text = CreateGameManager.current.AskQuestion();
            CreateGameManager.prevMoveRight = true;
            CreateGameManager.prevMoveLeft = false;
        }
    }
}
