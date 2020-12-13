using UnityEditor;
using UnityEngine;
using UnityTemplateProjects;

namespace EditorUISamples
{
    public class EditorWindowSObackend : EditorWindow
    {
        [MenuItem(menuItemRoot + "Scriptable Object Data")]
        static void ShowWindow()
        {
            var window = GetWindow<EditorWindowSObackend>();
        }

        protected const string menuItemRoot = "My UI Samples/";

        private void OnEnable()
        {
        }

        protected ScriptableObject currentDataUsed;
    }
}
