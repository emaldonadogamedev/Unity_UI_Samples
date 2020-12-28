using UnityEditor;
using UnityEngine;
using UnityTemplateProjects;

using EditorUISamples.Components;
using UnityEngine.UIElements;

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

        [HideInInspector]
        protected SerializedObject m_windowData;

        private void OnEnable()
        {
            m_windowData = new SerializedObject(SOSingleton.instance);

            var sv = new ScrollView(ScrollViewMode.VerticalAndHorizontal);

            sv.Add(new SerializedObjectConatiner(m_windowData));

            this.rootVisualElement.Add(sv);
        }
    }
}
