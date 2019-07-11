using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class UIHealthBehaviour : MonoBehaviour
{

    public Text TextComponent;
    [SerializeField]
    private Lodis.IntVariable intVariableRef;
    [SerializeField]
    private List<GameObject> containerChildren;
    public GameObject container;
    public GameObject ImagePrefab;

    void Start()
    {
        CreateSegments();
        if (TextComponent == null)
            TextComponent = GetComponent<Text>();
    }

    [ContextMenu("Create Segments")]
    public void CreateSegments()
    {
        if (containerChildren.Count > 0)
            UnCreateSegments();

        TextComponent.text = intVariableRef.name;
        for (int i = 0; i < intVariableRef.Val; i++)
        {
            var prefab = Instantiate(ImagePrefab, container.transform);
            containerChildren.Add(prefab);
        }
    }
    [ContextMenu("UnCreate Segments")]
    public void UnCreateSegments()
    {
        TextComponent.text = "no name";
        for (int i = 0; i < containerChildren.Count; i++)
        {
            DestroyImmediate(containerChildren[i]);
        }
        containerChildren = new List<GameObject>();
    }

    public void OnHealthChanged(Object obj)
    {
        var sender = obj as Lodis.IntVariable;
        if (sender == null)
            return;
        if (sender != intVariableRef)
            return;
        this.CreateSegments();
    }

}
