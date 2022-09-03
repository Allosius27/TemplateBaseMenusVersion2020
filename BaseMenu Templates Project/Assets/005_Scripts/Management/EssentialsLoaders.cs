using AllosiusDev.Audio;
using Core;
using Core.Session;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EssentialsLoaders : MonoBehaviour
{
    [SerializeField] private AudioController audioController;
    [SerializeField] private SessionController sessionController;
    [SerializeField] private LangueManager langueManager;
    [SerializeField] private SceneLoader sceneLoader;
    [SerializeField] private UICanvasManager uiCanvasManager;

    [SerializeField] private BaseGameController gameController;

    private void Awake()
    {
        if (AudioController.Instance == null)
        {
            Instantiate(audioController);
        }

        if(SessionController.Instance == null)
        {
            Instantiate(sessionController);
        }

        if (LangueManager.Instance == null)
        {
            Instantiate(langueManager);
        }

        if(SceneLoader.Instance == null)
        {
            Instantiate(sceneLoader);
        }

        if(UICanvasManager.Instance == null)
        {
            Instantiate(uiCanvasManager);
        }

        BaseGameController baseGameController = FindObjectOfType<BaseGameController>();
        if (baseGameController == null)
        {
            Instantiate(gameController);
        }
    }
}
