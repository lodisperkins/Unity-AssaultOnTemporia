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
            TextComponent = GetComponentInChildren<Text>();
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
            Destroy(containerChildren[i]);
        }
        containerChildren = new List<GameObject>();
    }

    public void OnHealthChanged()
    {
        this.CreateSegments();
    }

}
