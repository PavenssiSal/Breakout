using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    LevelCreator levelCreator;
    //Make game end screen an object so it can be made visible later
    [SerializeField]
    public GameObject GameEndScreen;
    public GameObject GameWinScreen;

    public int points = 0;

    private void Update()
    {
        
    }
}
