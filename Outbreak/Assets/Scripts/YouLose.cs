
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
///T�m� koodi suoritetaan kun kaikki kolikot on ker�tty.
/// </summary>
public class LoseGame : MonoBehaviour
{

    //Voittopaneli
    public GameObject GameEndScreen;
    //Pause
    public static bool gameIsPaused;

    // Update is called once per frame
    void Update()
    {
        //ESCill� p��see p��valikkoon
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        //ENTERill� ladataan peli alkamaan uudestaan
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //Peli k�ynnistyy
            Time.timeScale = 1.0f;
            gameIsPaused = false;
            //Aloitetaan uusi peli
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 


        //N�ytet��n h�vi� paneeli
        GameEndScreen.SetActive(true);

        //Pys�ytet��n peli
        gameIsPaused = !gameIsPaused;
        PauseGame();

    }

    /// <summary>
    /// T�m� metodi pys�ytt�� pelin ja k�ynnist�� pelin tarvittaessa.
    /// </summary>
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
