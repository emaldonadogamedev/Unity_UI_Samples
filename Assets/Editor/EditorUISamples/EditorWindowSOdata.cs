using UnityEditor;
using UnityEngine;
using UnityTemplateProjects;

namespace EditorUISamples
{
    public class EditorWindowSOdata : EditorWindow
    {
        [MenuItem(menuItemRoot + "Scriptable Object Data")]
        static void ShowWindow()
        {
            var window = GetWindow<EditorWindowSOdata>();
        }

        protected const string menuItemRoot = "My UI Samples/";

        private void OnEnable()
        {
            
        }
    }
}
