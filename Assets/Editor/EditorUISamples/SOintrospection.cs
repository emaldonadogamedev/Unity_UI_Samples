using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

using EditorUISamples.Components;
using EditorUISamples.DataTypes;

namespace EditorUISamples
{
    class SOintrospection : EditorWindow
    {
        [MenuItem(menuItemRoot + "Pick Scriptable Object Data")]
        static void ShowWindow()
        {
            var window = GetWindow<SOintrospection>();
        }

        protected const string menuItemRoot = "My UI Samples/";

        protected ScrollView scrollView;

        private void OnEnable()
        {
            var root = this.rootVisualElement;

            var objectField = new ObjectField("Picked Scriptable Object: ");
            objectField.objectType = typeof(CustomSO);
            objectField.RegisterValueChangedCallback(OnNewValueSelected);

            root.Add(objectField);

            scrollView = new ScrollView();

            root.Add(scrollView);
        }

        private void OnNewValueSelected(ChangeEvent<Object> evt)
        {
            var newValue = (CustomSO)evt.newValue;

            scrollView.Clear();

            scrollView.Add(new SerializedObjectConatiner(new SerializedObject(newValue)));
        }
    }
}
