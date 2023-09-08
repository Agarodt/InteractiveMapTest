using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Camera main;
    [SerializeField]
    float ClampBias = 2;
  
    void Start()
    {
        main = GetComponent<Camera>();
    }
    public void moveUp()
    {
        if(transform.position.y < ClampBias)
        {
        transform.Translate(0,0.2f,0);
        }
        
    }

    public void moveDown()
    {
        if(transform.position.y > -ClampBias)
        {
        transform.Translate(0,-0.2f,0);
        }
        
    }

    public void moveLeft()
    {
        if(transform.position.x > -ClampBias)
        {
        transform.Translate(-0.2f,0,0);
        }
        
    }

     public void moveRight()
    {
        if(transform.position.x < ClampBias)
        {
        transform.Translate(0.2f,0,0);
        }
        
    }

    public void ZoomIn()
    {
       if (main.orthographicSize > 2)
       {
       main.orthographicSize -= 1;
       ClampBias += 1;
       }
       
        
    }

    public void ZoomOut()
    {
       if (main.orthographicSize < 5)
       {
       main.orthographicSize += 1;
       ClampBias -= 1;
       }
    }

   
}
