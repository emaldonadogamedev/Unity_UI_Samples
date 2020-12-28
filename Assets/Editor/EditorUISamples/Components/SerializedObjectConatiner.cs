using System;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace EditorUISamples.Components
{
    class SerializedObjectConatiner : BindableElement, IDisposable
    {
        public SerializedObject serializedObject { get; protected set; }

        public SerializedObjectConatiner(SerializedObject serializedObject)
        {
            name = "Serialized Object: " + serializedObject.targetObject.name;
            this.serializedObject = serializedObject;

            var rootProperty = serializedObject.GetIterator();

            if (rootProperty.NextVisible(true))
            {
                // skip the property that has the actual serialized object tied to it
                rootProperty.NextVisible(true);

                do
                {
                    var newPropField = new PropertyField(rootProperty);
                    Add(newPropField);
                }
                while (rootProperty.NextVisible(false));

                this.Bind(serializedObject);
            }
        }

        public void Dispose()
        {
            serializedObject?.Dispose();
        }
    }
}
