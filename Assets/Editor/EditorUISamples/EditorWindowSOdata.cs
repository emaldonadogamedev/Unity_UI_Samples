using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

using EditorUISamples.DataTypes;
using EditorUISamples.Components;

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

            rootVisualElement.Add(sv);
        }
    }
}
