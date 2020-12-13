using UnityEditor;
using UnityEngine;
using UnityTemplateProjects;

namespace EditorUISamples
{
    public class EditorWindowSceneView : EditorWindow
    {
        [MenuItem(menuItemRoot + "Scene View - kinda")]
        static void ShowWindow()
        {
            var window = GetWindow<EditorWindowSceneView>();
        }

        protected const string menuItemRoot = "My UI Samples/";

        protected Camera camera;
        protected GameObject camGameObject;
        protected SimpleCameraController simpleCameraController;
        protected Rect camRect = new Rect(0, 0, 1000, 1000);

        private void OnEnable()
        {
            camRect = new Rect(0f, 0f, this.position.width, this.position.height);
            SceneView.duringSceneGui += SceneGUI;
        }

        void SceneGUI(SceneView sceneView)
        {
            // This will have scene events including mouse down on scenes objects
            Event cur = Event.current;
        }

        private void OnFocus()
        {
            var components = new System.Type[] { typeof(Camera), typeof(SimpleCameraController) };
            camGameObject = EditorUtility.CreateGameObjectWithHideFlags(
                "camGameObject", 
                HideFlags.HideInHierarchy,
                components
            );

            camera = camGameObject.GetComponent<Camera>();

            camera.transform.position = new Vector3(2.32f, 1.2f, 3.71f);
            camera.transform.rotation = Quaternion.Euler(20.14f, 195.09f, 0.001f);
            simpleCameraController = camGameObject.GetComponent<SimpleCameraController>();
            if (simpleCameraController == null)
            {
                throw new System.ArgumentNullException("SimpleCameraController");
            }
        }

        private void OnLostFocus()
        {
            if (this.camera != null)
            {
                Object.DestroyImmediate(this.camera.gameObject);
                this.camera = null;
            }
        }

        private void OnGUI()
        {
            if (camera == null)
                return;

            if (camRect.width != position.width || camRect.height != position.height)
            {
                camRect.width = position.width;
                camRect.height = position.height;
            }

            Handles.BeginGUI();
            Handles.SetCamera(camRect, camera);
            Handles.DrawCamera(camRect, camera, DrawCameraMode.Normal, true);
            Handles.EndGUI();
        }

        private void Update()
        {
        }

        private void OnDestroy()
        {
            this.OnLostFocus();
        }

        protected ScriptableObject currentDataUsed;
    }
}
