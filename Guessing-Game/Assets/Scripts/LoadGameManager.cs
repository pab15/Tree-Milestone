using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadGameManager : MonoBehaviour
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
    public static GameObject loadGameName;
    public static GameObject loadGameButton;
    public static List<GameObject> allActiveGameObjects;
    public static Text promptText;
    public static Text questionText;
    public static bool started;
    public static bool prevMoveLeft;
    public static bool prevMoveRight;

    void Start()
    {
        allActiveGameObjects = new List<GameObject>();
        parent = null;
        prevMoveLeft = false;
        prevMoveRight = false;
        current = null;
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
        loadGameName = GameObject.Find("LoadGameName");
        loadGameButton = GameObject.Find("LoadGameButton");
        loadGameName.SetActive(true);
        loadGameButton.SetActive(true);
        questionTextBox.SetActive(false);
        noButton.SetActive(false);
        yesButton.SetActive(false);
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
