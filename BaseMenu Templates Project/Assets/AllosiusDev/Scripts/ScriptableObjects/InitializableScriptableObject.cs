using UnityEngine;

namespace AllosiusDev {
    public abstract class InitializableScriptableObject : ScriptableObject, IInitializable {
        public abstract void Initialize();
    }
}
