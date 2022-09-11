//
// Updated by Allosius(Yanis Q.) on 11/9/2022.
//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace AllosiusDevUtilities.Core
{
    public class GameStateManager : Singleton<GameStateManager>
    {
        #region Properties

        public static bool gameIsPaused = false;

        #endregion

        #region Behaviour

        [Button(ButtonSizes.Medium)]
        public void SetGameIsPaused()
        {
            Debug.Log("Game Is Paused : " + gameIsPaused);
        }

        #endregion
    }
}
