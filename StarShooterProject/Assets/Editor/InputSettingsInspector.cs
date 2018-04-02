using StarShooter.Input;
using UnityEditor;

[CustomEditor(typeof(InputSettings))]
public class InputSettingsInspector : Editor {

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EditorUtility.SetDirty(target);
    }
}
