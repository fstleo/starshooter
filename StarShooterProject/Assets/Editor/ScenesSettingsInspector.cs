using StarShooter.GameManagement.SceneManagement;
using UnityEditor;

[CustomEditor(typeof(ScenesSettings))]
public class ScenesSettingsInspector : Editor {

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EditorUtility.SetDirty(target);
    }
}
