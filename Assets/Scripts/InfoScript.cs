using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoScript : MonoBehaviour
{
    public static InfoScript instance;
    public int locType; 
    Image InfoImage;
    [SerializeField]
    Sprite[] InfoImages;
    public bool infoClosed;

    void Awake()
    {
        instance = this;
    }
    
    void Start()
    {
        Close();
        InfoImage = transform.GetChild(0).GetComponent<Image>();
    }

    public void Open()
    {
        transform.localScale = Vector3.one;
        infoClosed = false;
        StartCoroutine(IsInteractive());
        
    }

    public void Close()
    {
        transform.localScale = Vector3.zero;
        infoClosed = true;
        transform.GetChild(0).gameObject.SetActive(false);
    }

    IEnumerator IsInteractive()
    {
        yield return new WaitForSeconds(0.1f);
        transform.GetChild(0).gameObject.SetActive(true);
        InfoImage.sprite = InfoImages[locType];
    }
}
