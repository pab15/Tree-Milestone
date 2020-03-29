using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    public void ClickedResetGame()
    {
        CreateGameManager.parent = null;
        CreateGameManager.current = CreateGameManager.gameTree.root;
        CreateGameManager.questionTextBox.SetActive(true);
        CreateGameManager.noButton.SetActive(true);
        CreateGameManager.yesButton.SetActive(true);
        CreateGameManager.resetButton.SetActive(false);
        CreateGameManager.startOverButton.SetActive(false);
        CreateGameManager.promptTextBox.SetActive(false);
        CreateGameManager.prevMoveLeft = false;
        CreateGameManager.prevMoveRight = false;
        CreateGameManager.questionText.text = "Think of a person...\n" + CreateGameManager.current.content;
    }
}
