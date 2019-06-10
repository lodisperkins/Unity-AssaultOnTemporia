using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEditor;
using System.IO;
namespace CustomEditors
{
    public class GitWindow : EditorWindow
    { 
        [MenuItem("Git/Open CommandLine")]
        public static void Init()
        {
            Process.Start("cmd.exe");
        } 
    }
}