using System;
using UnityEditor;
using UnityEngine;

namespace EditorUISamples
{
    class SOSingleton : ScriptableSingleton<SOSingleton>
    {
        public string fileName = "";

        public string[] stringArray;

        [NonSerialized]
        public string fileNameProtected = "9880";

        public UnityEngine.Object someObject;

        [SerializeField]
        protected int intData = 90;
    }
}
