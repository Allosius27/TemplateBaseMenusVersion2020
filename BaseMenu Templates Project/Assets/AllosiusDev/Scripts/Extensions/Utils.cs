#if UNITY_EDITOR
using System.Reflection;

namespace AllosiusDev {
    public static class Utils {
        public static void ClearLog() //you can copy/paste this code to the bottom of your script
    {
            Assembly assembly = Assembly.GetAssembly(typeof(UnityEditor.Editor));
            System.Type type = assembly.GetType("UnityEditor.LogEntries");
            MethodInfo method = type.GetMethod("Clear");
            method.Invoke(new object(), null);
        }
    }
}
#endif