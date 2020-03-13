using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        /*PeopleNode head = new PeopleNode("Did Your President Serve Two Or More Years?");
        head.yesNode = new PeopleNode("Barack Obama");
        head.noNode = new PeopleNode("Did Your President Serve Less Than One Year In Office");
        head.noNode.yesNode = new PeopleNode("Did Your President Die In Office?");
        head.noNode.noNode = new PeopleNode("Richard Nixon");
        head.noNode.yesNode.yesNode = new PeopleNode("John F. Kennedy");
        head.noNode.yesNode.noNode = new PeopleNode("Donald Trump");
        GameTree presidentTree = new GameTree(head);
        presidentTree.WritePreOrderTraversal("test");*/
        GameTree gameTree = Loader.LoadTreeFile("test");
    }
}
