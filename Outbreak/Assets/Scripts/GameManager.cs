using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //Make game end screen an object so it can be made visible later
    [SerializeField]
    public GameObject GameEndScreen;
    public GameObject GameWinScreen;
    public TMP_Text scoreText;

    public int score = 0;

    private void Update()
    {
        scoreText.text = score.ToString($"Score: {score}");
    }
    
}
