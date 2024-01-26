using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Text;

public class scriptObjectGenerator : EditorWindow
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [MenuItem("Window/ScriptObject Generator")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(scriptObjectGenerator)); //显示该窗口
    }

    string schemeClassName;
    private void Generate()
    {
        string classPath = "Assets/scriptObjectBuilder.csTemplate";
        string content = File.ReadAllText(classPath);
        content = content.Replace("%CLASSNAME%", schemeClassName);

        string saveDirectory = "Assets/scriptObject/";
        Directory.CreateDirectory(saveDirectory);
        string builderName = saveDirectory + "scriptObject_" + schemeClassName + "_builder.cs";
        File.Create(builderName).Dispose();
        File.WriteAllText(builderName, content);
    }

    private void OnGUI()
    {
        GUILayout.Label("Scheme Class Name", EditorStyles.boldLabel);
        schemeClassName = GUILayout.TextField(schemeClassName);
        if (GUILayout.Button("生成"))
        {
            Generate();
        }
    }
}
