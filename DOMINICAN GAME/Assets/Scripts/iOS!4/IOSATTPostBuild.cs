#if UNITY_EDITOR && UNITY_IOS
using System.IO;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;
public class BuildPostProcessInfo
{
    [PostProcessBuild]
    public static void OnPostBuildProcessInfo(BuildTarget target, string path)
    {
        if(target == BuildTarget.iOS)
        {
            var infoPlistPath = path + "/Info.plist";
            PlistDocument document = new PlistDocument();
            document.ReadFromString(File.ReadAllText(infoPlistPath));
            var elementRoot = document.root;
            elementRoot.SetString("NSUserTrackingUsageDescription", "This identifier will be used to deliver personalized ads to you.");
            File.WriteAllText(infoPlistPath, document.WriteToString());
        }
    }
}

#endif