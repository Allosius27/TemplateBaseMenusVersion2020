//
// Updated by Allosius(Yanis Q.) on 7/9/2022.
//

using Sirenix.OdinInspector;
using AllosiusDevUtilities.Audio;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AllosiusDevUtilities
{
    [Serializable]
    public class FeedbackPlaySound : BaseFeedback
    {
        [InfoBox("Play a clip audio")]
        public AudioData audioData;

        public override IEnumerator Execute(GameObject _owner)
        {
            if(IsActive)
                AudioController.Instance.PlayAudio(audioData);
            return base.Execute(_owner);
        }
    }
}
