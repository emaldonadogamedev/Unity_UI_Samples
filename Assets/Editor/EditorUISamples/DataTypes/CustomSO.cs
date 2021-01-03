using System;
using UnityEngine;

namespace EditorUISamples.DataTypes
{
    [CreateAssetMenu(fileName = "CustomSO_Instance", menuName = "CustomSO/Create Instance", order = 1)]
    class CustomSO : ScriptableObject
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
    }
}
