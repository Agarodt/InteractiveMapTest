using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlbumScript : MonoBehaviour
{
    public static AlbumScript instance;
    [SerializeField]
    int locType;
    public int index; 
    Image AlbumImage;
    [SerializeField]
    Sprite[] EcoMarketImgs;
    [SerializeField]
    Sprite[] CinemaImgs;

    void Awake()
    {
        instance = this;
    }
    
    void Start()
    {   
        Close();
        AlbumImage = transform.GetChild(0).GetComponent<Image>();
        ShowImage();
    }

    public void NextImage()
    {
        if (index < 2)
        {
        index += 1;
        }
        else
        {
        index = 0;
        }
        ShowImage();
        
        
        
    }
    public void PreviousImage()
    {
        if (index > 0)
        {
        index -= 1;
        }
        else
        {
        index = 2;
        }
        ShowImage();
        
    }

    public void ShowImage()
    {
      if (locType == 0)
      {
      AlbumImage.sprite = EcoMarketImgs[index];
      }
      if (locType == 1)
      {
      AlbumImage.sprite = CinemaImgs[index];
      }

    }

    public void Open()
    {
        locType = InfoScript.instance.locType;
        transform.localScale = Vector3.one;
    }

    public void Close()
    {
        transform.localScale = Vector3.zero;
    }
}
