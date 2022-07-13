using AllosiusDev.Core.Session;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AllosiusDev.Core
{
    public class BaseGameController : MonoBehaviour
    {
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

