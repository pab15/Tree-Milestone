using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadYesButtonClicked : MonoBehaviour
{
    public void MoveLeft()
    {
        if (LoadGameManager.current.isLeafNode == true)
        {
            LoadGameManager.questionText.text = "I win!";
            LoadGameManager.resetButton.SetActive(true);
            LoadGameManager.startOverButton.SetActive(true);
        }
        else
        {
            LoadGameManager.parent = LoadGameManager.current;
            LoadGameManager.current = LoadGameManager.current.MoveLeft();
            LoadGameManager.questionText.text = LoadGameManager.current.AskQuestion();
            LoadGameManager.prevMoveLeft = true;
            LoadGameManager.prevMoveRight = false;
        }
    }
}
