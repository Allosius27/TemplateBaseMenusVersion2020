//
// Updated by Allosius(Yanis Q.) on 30/06/2022.
//

using AllosiusDev.Audio;
using UnityEngine;

namespace AllosiusDev
{
    public partial class Extensions
    {

        public static AudioSource SetSoundToSource(this AudioSource source, AudioData sound)
        {
            source.clip = sound.Clip;
            source.pitch = sound.Pitch;
            source.loop = sound.Loop;
            source.priority = sound.Priority;

            if (sound.SpacialBlend != 0)
            {
                source.volume = sound.Volume3d;
            }
            else
            {
                source.volume = sound.Volume2d;
            }

            source.spatialBlend = sound.SpacialBlend;
            source.maxDistance = sound.MaxDistance;

            return source;
        }


    }
}