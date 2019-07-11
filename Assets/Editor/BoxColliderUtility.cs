using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;

public class BoxColliderUtility : UnityEditor.EditorWindow
{

    [SerializeField]
    List<GameObject> sceneObjects;

    Vector2 scroll1;
    [MenuItem("Tools/GetAllGameObjects")]
    public static void GetAllColliders()
    {
        var window = GetWindow<BoxColliderUtility>();
        window.Init();
        window.Show();

    }
    private void Init()
    {
        Refresh();
    }

    private void Refresh()
    {
        var objs = FindObjectsOfType(typeof(GameObject)) as GameObject[];
        sceneObjects = new List<GameObject>();
        foreach (var go in objs)
        {
            if (go.GetComponent<Collider>())
            {
                sceneObjects.Add(go);
            }
        }
    }
    private void OnGUI()
    {
        
        if(GUILayout.Button("Refresh"))
        {
            Refresh();
        }
        if (GUILayout.Button("Strip"))
        {
            foreach (var go in sceneObjects)
            {
                var components = go.GetComponents<Component>().ToList();
                var toremove = new List<Component>();

                foreach (var c in components)
                {                    
                    if (
                        c.GetType() == typeof(BoxCollider) ||
                        c.GetType() == typeof(Transform) ||
                        c.GetType() == typeof(SphereCollider)||
                        c.GetType() == typeof(MeshCollider)
                        )
                        continue;
                    
                    toremove.Add(c);
                }

                toremove.ForEach(tr => DestroyImmediate(tr));
            }
        }
        var gs = new GUIStyle
        {
            fontSize = 18,
            fontStyle = FontStyle.BoldAndItalic,
            normal = new GUIStyleState { textColor = Color.cyan }

        };

        EditorGUILayout.BeginHorizontal();
        //======================================//
        EditorGUILayout.BeginVertical();
        EditorGUILayout.LabelField("sceneObjects", gs);
        EditorGUILayout.Space();
        scroll1 = DisplayArray(sceneObjects, scroll1);
        EditorGUILayout.EndVertical();

        //=======================================//

        EditorGUILayout.EndHorizontal();
    }

    private Vector2 DisplayArray(List<GameObject> objects, Vector2 scrollv)
    {
        if (objects == null || objects.Count <= 0)
        {
            EditorGUILayout.LabelField("no list to display");
        }

        else
        {
            scrollv = EditorGUILayout.BeginScrollView(scrollv);
            objects.ForEach(obj => EditorGUILayout.ObjectField(obj, typeof(GameObject), true));
            EditorGUILayout.Space();
            EditorGUILayout.EndScrollView();
        }

        return scrollv;
    }
}
