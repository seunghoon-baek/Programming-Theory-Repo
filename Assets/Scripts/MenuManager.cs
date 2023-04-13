using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public string playerName;
    [SerializeField] Button startButton;
    [SerializeField] Button exitButton;
    [SerializeField] TMP_InputField nameField;

    // Start is called before the first frame update
    void Awake()
    {
        playerName = nameField.text;
        startButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    void ExitGame()
    {
#if UNITY_STANDALONE
        Application.Quit();
#endif
#if UNITY_STANDALONE
        EditorApplication.ExitPlaymode();
#endif
    }
    
}
