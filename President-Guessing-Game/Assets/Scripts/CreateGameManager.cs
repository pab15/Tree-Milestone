using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateGameManager : MonoBehaviour
{
    public static GameTree gameTree;
    public static PeopleNode parent;
    public static PeopleNode current;
    public static PeopleNode savedNode;
    public static string newPerson;
    public static GameObject questionBox;
    public static GameObject questionButton;
    public static GameObject questionTextBox;
    public static GameObject yesButton;
    public static GameObject noButton;
    public static GameObject resetButton;
    public static GameObject startOverButton;
    public static GameObject nameField;
    public static GameObject submitName;
    public static GameObject promptTextBox;
    public static GameObject addYesButton;
    public static GameObject addNoButton;
    public static GameObject saveButton;
    public static GameObject mainButton;
    public static GameObject saveName;
    public static GameObject submitSave;
    public static List<GameObject> allActiveGameObjects;
    public static Text promptText;
    public static Text questionText;
    public static bool started;
    public static bool prevMoveLeft;
    public static bool prevMoveRight;
    
    void Start()
    {
        allActiveGameObjects = new List<GameObject>();
        gameTree = new GameTree();
        parent = null;
        started = true;
        prevMoveLeft = false;
        prevMoveRight = false;
        current = new PeopleNode("Elvis Presley");
        questionBox = GameObject.Find("QuestionField");
        questionButton = GameObject.Find("SubmitQuestion");
        yesButton = GameObject.Find("YesButton");
        noButton = GameObject.Find("NoButton");
        questionTextBox = GameObject.Find("QuestionText");
        questionText = questionTextBox.GetComponent<Text>();
        resetButton = GameObject.Find("Reset");
        startOverButton = GameObject.Find("StartOver");
        nameField = GameObject.Find("NameField");
        submitName = GameObject.Find("SubmitName");
        promptTextBox = GameObject.Find("PromptText");
        promptText = promptTextBox.GetComponent<Text>();
        addYesButton = GameObject.Find("AddYesButton");
        addNoButton = GameObject.Find("AddNoButton");
        saveButton = GameObject.Find("SaveGame");
        mainButton = GameObject.Find("MainMenu");
        saveName = GameObject.Find("SaveName");
        submitSave = GameObject.Find("SubmitSave");
        questionText.text = "Think of a person...\n" + current.AskQuestion();
        questionTextBox.SetActive(true);
        noButton.SetActive(true);
        yesButton.SetActive(true);
        questionButton.SetActive(false);
        questionBox.SetActive(false);
        resetButton.SetActive(false);
        startOverButton.SetActive(false);
        nameField.SetActive(false);
        submitName.SetActive(false);
        promptTextBox.SetActive(false);
        addYesButton.SetActive(false);
        addNoButton.SetActive(false);
        submitSave.SetActive(false);
        saveName.SetActive(false);
    }
}
