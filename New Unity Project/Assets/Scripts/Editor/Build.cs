using UnityEditor;
using UnityEngine;

public class Build: MonoBehaviour
{
      static void Start()
    {
        Debug.Log("### BUILDING ###");
        var report = BuildPipeline.BuildPlayer(
            new[] { "Assets/Scenes/Test.unity" },
            "Build/Win/Test.exe",
            target: BuildTarget.StandaloneWindows64,
            options: BuildOptions.None);

        Debug.Log("###   DONE   ###");

        Debug.Log(report);
    }
}