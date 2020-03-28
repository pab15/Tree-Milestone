using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesButtonClick : MonoBehaviour
{
    public void MoveLeft()
    {
        if (CreateGameManager.current.isLeafNode == true)
        {
            CreateGameManager.questionText.text = "I win!";
            CreateGameManager.resetButton.SetActive(true);
            CreateGameManager.startOverButton.SetActive(true);
        }
        else
        {
            CreateGameManager.parent = CreateGameManager.current;
            CreateGameManager.current = CreateGameManager.current.MoveLeft();
            CreateGameManager.questionText.text = CreateGameManager.current.AskQuestion();
            CreateGameManager.prevMoveLeft = true;
        }
    }
}
