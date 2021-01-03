using System;
using UnityEditor;
using UnityEngine;

namespace EditorUISamples.DataTypes
{
    [CreateAssetMenu(fileName ="Create SingletonSO Instance", menuName ="")]
    class SOSingleton : ScriptableSingleton<SOSingleton>
    {
        public string stringVariable = "";

        public string[] stringArray;

        [NonSerialized]
        public string fileNameProtected = "9880";

        public UnityEngine.Object someObject;

        [SerializeField]
        protected int intVariable = 90;

        [SerializeField]
        protected SerializableClass dataClassInstance;

        [SerializeField]
        protected SerializableClass[] dataClassArray;
    }
}
