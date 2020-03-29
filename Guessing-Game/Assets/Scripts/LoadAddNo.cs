using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAddNo : MonoBehaviour
{
    public void ClickedAddNo()
    {
        if (LoadGameManager.started == true)
        {
            LoadGameManager.addYesButton.SetActive(false);
            LoadGameManager.addNoButton.SetActive(false);
            LoadGameManager.resetButton.SetActive(true);
            LoadGameManager.startOverButton.SetActive(true);
            LoadGameManager.parent.noNode = new PeopleNode(LoadGameManager.newPerson);
            LoadGameManager.parent.yesNode = LoadGameManager.current;
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
                LoadGameManager.parent.noNode.noNode = new PeopleNode(LoadGameManager.newPerson);
                LoadGameManager.parent.noNode.yesNode = LoadGameManager.current;
            }
            else if (LoadGameManager.prevMoveLeft == true)
            {
                LoadGameManager.parent.yesNode = LoadGameManager.savedNode;
                LoadGameManager.parent.yesNode.noNode = new PeopleNode(LoadGameManager.newPerson);
                LoadGameManager.parent.yesNode.yesNode = LoadGameManager.current;
            }
        }
    }
}
