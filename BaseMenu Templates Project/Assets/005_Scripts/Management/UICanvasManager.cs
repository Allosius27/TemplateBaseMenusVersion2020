using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UICanvasManager : AllosiusDev.Singleton<UICanvasManager>
{
    #region Fields

    private GameObject eventSystemCurrentObjectSelected;

    #endregion

    #region Properties

    public EventSystem EventSystem => eventSystem;

    public SettingsMenu SettingsMenu => settingsMenu;

    public PauseMenu PauseMenu => pauseMenu;

    #endregion

    #region UnityInspector

    [SerializeField] private EventSystem eventSystem;

    [SerializeField] private SettingsMenu settingsMenu;

    [SerializeField] private PauseMenu pauseMenu;

    #endregion

    #region Behaviour

    private void Update()
    {
        if (eventSystem.currentSelectedGameObject != null)
        {
            eventSystemCurrentObjectSelected = eventSystem.currentSelectedGameObject;
        }

        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            if (eventSystemCurrentObjectSelected != null && eventSystem.currentSelectedGameObject == null)
            {
                eventSystem.SetSelectedGameObject(eventSystemCurrentObjectSelected);
            }
        }
    }

    #endregion
}
