using Core.Session;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class BaseGameController : MonoBehaviour
    {
        #region Properties

        public SceneData MenuScene => menuScene;

        public SceneData StartLevelScene => startLevelScene;

        #endregion

        #region UnityInspector

        [SerializeField] private SceneData menuScene;

        [SerializeField] private SceneData startLevelScene;

        #endregion

        #region Unity Functions

        private void Awake()
        {
            SessionController.Instance.InitializeGame(this);
        }

        #endregion

        #region Public Functions

        public void OnInit()
        {

        }

        public void OnUpdate()
        {

        }

        #endregion
    }
}

