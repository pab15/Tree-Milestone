using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNo : MonoBehaviour
{
    public void ClickedAddNo()
    {
        if (CreateGameManager.started == true)
        {
            CreateGameManager.addYesButton.SetActive(false);
            CreateGameManager.addNoButton.SetActive(false);
            CreateGameManager.resetButton.SetActive(true);
            CreateGameManager.startOverButton.SetActive(true);
            CreateGameManager.parent.noNode = new PeopleNode(CreateGameManager.newPerson);
            CreateGameManager.parent.yesNode = CreateGameManager.current;
            CreateGameManager.current = CreateGameManager.parent;
            CreateGameManager.started = false;
        }
        else
        {
            CreateGameManager.addYesButton.SetActive(false);
            CreateGameManager.addNoButton.SetActive(false);
            CreateGameManager.resetButton.SetActive(true);
            CreateGameManager.startOverButton.SetActive(true);
            if (CreateGameManager.prevMoveRight == true)
            {
                CreateGameManager.parent.noNode = CreateGameManager.savedNode;
                CreateGameManager.parent.noNode.noNode = new PeopleNode(CreateGameManager.newPerson);
                CreateGameManager.parent.noNode.yesNode = CreateGameManager.current;
            }
            else if (CreateGameManager.prevMoveLeft == true)
            {
                CreateGameManager.parent.yesNode = CreateGameManager.savedNode;
                CreateGameManager.parent.yesNode.noNode = new PeopleNode(CreateGameManager.newPerson);
                CreateGameManager.parent.yesNode.yesNode = CreateGameManager.current;
            }
        }
    }
}
