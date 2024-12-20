using UnityEngine;
using System.Collections;
using UnityEditor;

//Place this script on Assets/Editor 

[CustomEditor(typeof(PlayOnEditor))]
public class ObjectBuilderEditor : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        
        PlayOnEditor myScript = (PlayOnEditor)target;
        if(GUILayout.Button("Play"))
        {
            myScript.PlayVideo();
        }
        if(GUILayout.Button("Pause"))
        {
            myScript.PauseVideo();
        }
        if(GUILayout.Button("Restart"))
        {
            myScript.RestartVideo();
        }

        if (myScript.CurrSeek != myScript.LastSeek)
        {
            myScript.SeekVideo(myScript.CurrSeek);
            myScript.LastSeek = myScript.CurrSeek;
        }
        
    }
    
    
}
