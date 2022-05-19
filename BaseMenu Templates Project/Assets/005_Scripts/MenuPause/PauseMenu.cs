using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Button[] MenuButtons => menuButtons;

    public static bool gameIsPaused = false;
    public static bool canPause = true;

    public SettingsMenu settingsMenu;
    public GameObject pauseMenuUI;

    [SerializeField] private Button[] menuButtons;

    [SerializeField] private SceneData mainMenuSceneData;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == (int)(object)Scenes.MainMenu || SceneManager.GetActiveScene().buildIndex == (int)(object)Scenes.BootScene)
        {
            canPause = false;
        }
        else
        {
            canPause = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Escape"))
        {
            MenuPause();
        }
    }

    public void MenuPause()
    {
        if (canPause)
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
        UICanvasManager.Instance.EventSystem.SetSelectedGameObject(menuButtons[0].gameObject);
        // Arrêter le temps
        Time.timeScale = 0;
        // Changer le statut du jeu (l'état : pause ou jeu actif)
        gameIsPaused = true;

    }

    public void Resume()
    {
        Time.timeScale = 1;

        gameIsPaused = false;

        settingsMenu.ExitSettings();
        pauseMenuUI.SetActive(false);
    }

    public void LoadSettings()
    {
        Debug.Log("Loading Settings menu");
        settingsMenu.LaunchSettings();
        //settingsMenu.SetActive(true);
    }

    public void LoadMainMenu()
    {
        canPause = false;
        Resume();
        AllosiusDev.AudioManager.StopAllMusics();
        SceneLoader.Instance.ActiveLoadingScreen(mainMenuSceneData, 1.0f);
    }
}
