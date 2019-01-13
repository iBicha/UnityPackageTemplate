using UnityEditor;

namespace Company.Product.Editor
{
    [CustomEditor(typeof(ExampleScript))]
    public class ExampleScriptEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox("This is a custom inspector.", MessageType.Info);
            base.OnInspectorGUI();
        }
    }
}