using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{
    CanvasGroup CanGroup;
    [SerializeField]
    bool isClicked;
  
    void Start()
    {
        CanGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isClicked)
        {
            CanGroup.alpha -= Time.deltaTime;
        }
    }

    public void NextScene()
    {
        StartCoroutine (LoadMap());
        isClicked = true;
        
    }

    IEnumerator LoadMap()
    {
        yield return new WaitForSeconds(1f);
        
          SceneManager.LoadScene(1);
        
    }
}
