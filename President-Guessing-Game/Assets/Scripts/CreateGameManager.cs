using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateGameManager : MonoBehaviour
{
    public static GameTree gameTree;
    public static PeopleNode parent;
    public static PeopleNode current;
    public static bool isRoot;
    public static bool movedLeft;
    public static bool movedRight;
    public static GameObject questionBox;
    public static GameObject questionButton;
    public static GameObject questionTextBox;
    public static GameObject yesButton;
    public static GameObject noButton;
    public static Text questionText;
    
    
    void Start()
    {
        gameTree = new GameTree();
        isRoot = true;
        movedLeft = false;
        movedRight = true;
        parent = null;
        current = gameTree.root;
        questionBox = GameObject.Find("QuestionField");
        questionButton = GameObject.Find("SubmitQuestion");
        yesButton = GameObject.Find("YesButton");
        noButton = GameObject.Find("NoButton");
        questionTextBox = GameObject.Find("QuestionText");
        questionText = questionTextBox.GetComponent<Text>();
        questionTextBox.SetActive(false);
        noButton.SetActive(false);
        yesButton.SetActive(false);
    }
}
