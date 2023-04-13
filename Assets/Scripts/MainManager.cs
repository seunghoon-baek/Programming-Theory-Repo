using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI currentPointText;
    [SerializeField] TextMeshProUGUI currentPlayerNameText;
    [SerializeField] TextMeshProUGUI bestPointText;
    [SerializeField] TextMeshProUGUI bestPlayerNameText;

    [SerializeField] Button resumeButton;
    [SerializeField] Button backToMenuButton;

    public string currentPlayerName;
    public int currentPoint;
    public string bestPlayerName;
    public int bestPoint; 
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void ManageScoreText()
    {

    }

    void PauseGame()
    {
        
    }
}
