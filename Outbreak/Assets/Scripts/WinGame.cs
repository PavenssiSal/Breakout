using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    LevelCreator levelCreator;
    //Voittopaneli
    public GameObject GameWinScreen;
    //Pause
    public static bool gameIsPaused;

    private void Start()
    {
        levelCreator = FindObjectOfType<LevelCreator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (levelCreator.totalBlockAmount == 0)
        {
            //N‰ytet‰‰n h‰viˆ paneeli
            GameWinScreen.SetActive(true);

            //Pys‰ytet‰‰n peli
            gameIsPaused = !gameIsPaused;
            PauseGame();
            //ESCill‰ p‰‰see p‰‰valikkoon
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
            //ENTERill‰ ladataan peli alkamaan uudestaan
            if (Input.GetKeyDown(KeyCode.Return))
            {
                //Peli k‰ynnistyy
                Time.timeScale = 1.0f;
                gameIsPaused = false;
                //Aloitetaan uusi peli
                Application.LoadLevel(Application.loadedLevel);
            }
        }

        
        
        void PauseGame()
        {
            if (gameIsPaused)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }

}

