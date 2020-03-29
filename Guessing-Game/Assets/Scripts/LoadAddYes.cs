using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAddYes : MonoBehaviour
{
    public void ClickedYes()
    {
        if (LoadGameManager.started == true)
        {
            LoadGameManager.addYesButton.SetActive(false);
            LoadGameManager.addNoButton.SetActive(false);
            LoadGameManager.resetButton.SetActive(true);
            LoadGameManager.startOverButton.SetActive(true);
            LoadGameManager.parent.yesNode = new PeopleNode(LoadGameManager.newPerson);
            LoadGameManager.parent.noNode = LoadGameManager.current;
            LoadGameManager.current = LoadGameManager.parent;
            LoadGameManager.started = false;
        }
        else
        {
            LoadGameManager.addYesButton.SetActive(false);
            LoadGameManager.addNoButton.SetActive(false);
            LoadGameManager.resetButton.SetActive(true);
            LoadGameManager.startOverButton.SetActive(true);
            if (LoadGameManager.prevMoveRight == true)
            {
                LoadGameManager.parent.noNode = LoadGameManager.savedNode;
                LoadGameManager.parent.noNode.yesNode = new PeopleNode(LoadGameManager.newPerson);
                LoadGameManager.parent.noNode.noNode = LoadGameManager.current;
            }
            else if (LoadGameManager.prevMoveLeft == true)
            {
                LoadGameManager.parent.yesNode = LoadGameManager.savedNode;
                LoadGameManager.parent.yesNode.yesNode = new PeopleNode(LoadGameManager.newPerson);
                LoadGameManager.parent.yesNode.noNode = LoadGameManager.current;
            }
        }
    }
}
