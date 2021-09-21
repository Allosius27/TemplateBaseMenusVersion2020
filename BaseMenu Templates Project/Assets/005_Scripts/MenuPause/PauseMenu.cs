using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public static bool canPause;
    public GameObject settingsMenu;
    public GameObject pauseMenuUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Escape") && canPause)
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    public void Paused()
    {
        //Afficher le menu pause
        pauseMenuUI.SetActive(true);
        // Arrêter le temps
        Time.timeScale = 0;
        // Changer le statut du jeu (l'état : pause ou jeu actif)
        gameIsPaused = true;

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        settingsMenu.SetActive(false);

        Time.timeScale = 1;

        gameIsPaused = false;

    }

    public void LoadSettings()
    {
        Debug.Log("Loading Settings menu");
        settingsMenu.SetActive(true);
    }

    public void LoadMainMenu()
    {
        canPause = false;
        Resume();
        SceneLoader.Instance.ChangeScene(Scenes.MainMenu);
    }
}
