using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoButtonClick : MonoBehaviour
{
    public void MoveRight()
    {
        if (CreateGameManager.current.noRightNode == true)
        {
            CreateGameManager.questionBox.SetActive(true);
            CreateGameManager.questionButton.SetActive(true);
            CreateGameManager.questionTextBox.SetActive(false);
            CreateGameManager.yesButton.SetActive(false);
            CreateGameManager.noButton.SetActive(false);
            CreateGameManager.movedRight = true;
        }
        else
        {
            CreateGameManager.current = CreateGameManager.current.MoveRight();
            CreateGameManager.questionText.text = CreateGameManager.current.content;
        }
    }
}
