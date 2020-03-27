using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesButtonClick : MonoBehaviour
{
    public void MoveLeft()
    {
        if (CreateGameManager.current.noLeftNode == true)
        {
            CreateGameManager.questionBox.SetActive(true);
            CreateGameManager.questionButton.SetActive(true);
            CreateGameManager.questionTextBox.SetActive(false);
            CreateGameManager.yesButton.SetActive(false);
            CreateGameManager.noButton.SetActive(false);
            CreateGameManager.movedLeft = true;
        }
        else
        {
            CreateGameManager.current = CreateGameManager.current.MoveLeft();
            CreateGameManager.questionText.text = CreateGameManager.current.content;
        }
    }
}
