<<<<<<< HEAD
﻿// Cristian Pop - https://boxophobic.com/

using UnityEngine;
using UnityEditor;
using Boxophobic.StyledGUI;
using Boxophobic.Utils;

public class SkyboxExtendedHub : EditorWindow
{
    string assetFolder = "Assets/BOXOPHOBIC/Atmospheric Height Fog";

    int assetVersion;
    string bannerVersion;

    Color bannerColor;
    string bannerText;
    string helpURL;
    static SkyboxExtendedHub window;

    [MenuItem("Window/BOXOPHOBIC/Skybox Cubemap Extended/Hub", false, 1000)]
    public static void ShowWindow()
    {
        window = GetWindow<SkyboxExtendedHub>(false, "Skybox Cubemap Extended", true);
        window.minSize = new Vector2(300, 200);
    }

    void OnEnable()
    {
        bannerColor = new Color(0.55f, 0.7f, 1f);
        bannerText = "Skybox Cubemap Extended";
        helpURL = "https://docs.google.com/document/d/1ughK58Aveoet6hpdfYxY5rzkOcIkjEoR0VdN2AhngSc/edit#heading=h.gqix7il7wlwd";

        //Safer search, there might be many user folders
        string[] searchFolders;

        searchFolders = AssetDatabase.FindAssets("Skybox Cubemap Extended");

        for (int i = 0; i < searchFolders.Length; i++)
        {
            if (AssetDatabase.GUIDToAssetPath(searchFolders[i]).EndsWith("Skybox Cubemap Extended.pdf"))
            {
                assetFolder = AssetDatabase.GUIDToAssetPath(searchFolders[i]);
                assetFolder = assetFolder.Replace("/Skybox Cubemap Extended.pdf", "");
            }
        }

        assetVersion = SettingsUtils.LoadSettingsData(assetFolder + "/Core/Editor/Version.asset", -99);
        bannerVersion = assetVersion.ToString();
        bannerVersion = bannerVersion.Insert(1, ".");
        bannerVersion = bannerVersion.Insert(3, ".");

        bannerColor = new Color(0.7f, 0.7f, 0.7f);
        bannerText = "Skybox Cubemap Extended " + bannerVersion;
    }

    void OnGUI()
    {
        StyledGUI.DrawWindowBanner(bannerColor, bannerText, helpURL);

        GUILayout.BeginHorizontal();
        GUILayout.Space(20);

        EditorGUILayout.HelpBox("The included shader is compatible by default with Standard and Universal Render Pipelines!", MessageType.Info, true);

        GUILayout.Space(13);
        GUILayout.EndHorizontal();
    }
}


=======
﻿// Cristian Pop - https://boxophobic.com/

using UnityEngine;
using UnityEditor;
using Boxophobic.StyledGUI;
using Boxophobic.Utils;

public class SkyboxExtendedHub : EditorWindow
{
    string assetFolder = "Assets/BOXOPHOBIC/Atmospheric Height Fog";

    int assetVersion;
    string bannerVersion;

    Color bannerColor;
    string bannerText;
    string helpURL;
    static SkyboxExtendedHub window;

    [MenuItem("Window/BOXOPHOBIC/Skybox Cubemap Extended/Hub", false, 1000)]
    public static void ShowWindow()
    {
        window = GetWindow<SkyboxExtendedHub>(false, "Skybox Cubemap Extended", true);
        window.minSize = new Vector2(300, 200);
    }

    void OnEnable()
    {
        bannerColor = new Color(0.55f, 0.7f, 1f);
        bannerText = "Skybox Cubemap Extended";
        helpURL = "https://docs.google.com/document/d/1ughK58Aveoet6hpdfYxY5rzkOcIkjEoR0VdN2AhngSc/edit#heading=h.gqix7il7wlwd";

        //Safer search, there might be many user folders
        string[] searchFolders;

        searchFolders = AssetDatabase.FindAssets("Skybox Cubemap Extended");

        for (int i = 0; i < searchFolders.Length; i++)
        {
            if (AssetDatabase.GUIDToAssetPath(searchFolders[i]).EndsWith("Skybox Cubemap Extended.pdf"))
            {
                assetFolder = AssetDatabase.GUIDToAssetPath(searchFolders[i]);
                assetFolder = assetFolder.Replace("/Skybox Cubemap Extended.pdf", "");
            }
        }

        assetVersion = SettingsUtils.LoadSettingsData(assetFolder + "/Core/Editor/Version.asset", -99);
        bannerVersion = assetVersion.ToString();
        bannerVersion = bannerVersion.Insert(1, ".");
        bannerVersion = bannerVersion.Insert(3, ".");

        bannerColor = new Color(0.7f, 0.7f, 0.7f);
        bannerText = "Skybox Cubemap Extended " + bannerVersion;
    }

    void OnGUI()
    {
        StyledGUI.DrawWindowBanner(bannerColor, bannerText, helpURL);

        GUILayout.BeginHorizontal();
        GUILayout.Space(20);

        EditorGUILayout.HelpBox("The included shader is compatible by default with Standard and Universal Render Pipelines!", MessageType.Info, true);

        GUILayout.Space(13);
        GUILayout.EndHorizontal();
    }
}


>>>>>>> main
