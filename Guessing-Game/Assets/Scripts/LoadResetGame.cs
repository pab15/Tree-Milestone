using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadResetGame : MonoBehaviour
{
    public void ClickedResetGame()
    {
        LoadGameManager.parent = null;
        LoadGameManager.current = LoadGameManager.gameTree.root;
        LoadGameManager.questionTextBox.SetActive(true);
        LoadGameManager.noButton.SetActive(true);
        LoadGameManager.yesButton.SetActive(true);
        LoadGameManager.resetButton.SetActive(false);
        LoadGameManager.startOverButton.SetActive(false);
        LoadGameManager.promptTextBox.SetActive(false);
        LoadGameManager.prevMoveLeft = false;
        LoadGameManager.prevMoveRight = false;
        LoadGameManager.questionText.text = "Think of a person...\n" + LoadGameManager.current.content;
    }
}
