using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddYes : MonoBehaviour
{
    public void ClickedYes()
    {
        if (CreateGameManager.started == true)
        {
            CreateGameManager.addYesButton.SetActive(false);
            CreateGameManager.addNoButton.SetActive(false);
            CreateGameManager.resetButton.SetActive(true);
            CreateGameManager.startOverButton.SetActive(true);
            CreateGameManager.parent.yesNode = new PeopleNode(CreateGameManager.newPerson);
            CreateGameManager.parent.noNode = CreateGameManager.current;
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
                CreateGameManager.parent.noNode.yesNode = new PeopleNode(CreateGameManager.newPerson);
                CreateGameManager.parent.noNode.noNode = CreateGameManager.current;
                CreateGameManager.prevMoveRight = false;
            }
            else if (CreateGameManager.prevMoveLeft == true)
            {
                CreateGameManager.parent.yesNode = CreateGameManager.savedNode;
                CreateGameManager.parent.yesNode.yesNode = new PeopleNode(CreateGameManager.newPerson);
                CreateGameManager.parent.yesNode.noNode = CreateGameManager.current;
                CreateGameManager.prevMoveLeft = false;
            }
        }
    }
}
