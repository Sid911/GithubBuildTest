using UnityEditor;
using UnityEngine;

public class Build: MonoBehaviour
{
      static void Start()
    {
        Debug.Log("### BUILDING ###");
        var report = BuildPipeline.BuildPlayer(
            new[] { "Assets/Scenes/SampleScene.unity" },
            "./builds/win64/SampleScene.exe",
            target: BuildTarget.StandaloneWindows64,
            options: BuildOptions.None);

        Debug.Log("###   DONE   ###");

        Debug.Log(report);
    }
}