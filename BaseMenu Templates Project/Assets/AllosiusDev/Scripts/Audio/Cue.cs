using UnityEngine;

namespace AllosiusDev {
    [System.Serializable]
    public struct Cue {
        public Sound Sound => new Sound(clips[Random.Range(0, clips.Length)], parameters);
        public AudioClip[] Clips => clips;
        public SoundParameters Parameters => parameters;

        [SerializeField] private AudioClip[] clips;
        [SerializeField] private SoundParameters parameters;

        public Cue(AudioClip[] clips = null, float volume = 1, float volume3d = 1, float pitch = 1, bool loop = false) {
            this.clips = clips;
            parameters = new SoundParameters(volume, volume3d, pitch, loop);
        }

        public Cue(AudioClip[] clips, SoundParameters parameters) {
            this.clips = clips;
            this.parameters = parameters;
        }


        public static implicit operator Sound(Cue cue) {
            return cue.Sound;
        }
    }
}