using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AllosiusDev
{
    [CreateAssetMenu(fileName = "New AudioData", menuName = "AllosiusDev/AudioData")]
    public class AudioData : ScriptableObject
    {
        #region UnityInspector

        public Sound sound;

        #endregion
    }
}
