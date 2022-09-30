//
// Updated by Allosius(Yanis Q.) on 7/9/2022.
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace AllosiusDevUtilities
{
    [Serializable]
    public class FeedbackChangeColorSprite : BaseFeedback
    {
        public Color newSpriteColor;

        public override IEnumerator Execute(GameObject _owner)
        {
            if (IsActive)
            {
                if(spriteRenderer != null)
                {
                    Debug.Log("ChangeColor");
                    spriteRenderer.color = newSpriteColor;
                }
                else
                {
                    Debug.LogWarning("SpriteRenderer is null");
                }
            }
            return base.Execute(_owner);
        }
    }
}