using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateDescription : MonoBehaviour
{
    public static InstantiateDescription instance;
    public Text text;
    public TextAsset ta;
    [SerializeField]
    public int currentNode = 0;
    Node[] nd;
    Description description;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        text = transform.GetChild(2).GetComponent<Text>();
    }

    public void ChangeText()
    {
        description = Description.Load(ta);
        nd = description.nodes;
        text.text = nd[currentNode].Infotext;
    }
}
