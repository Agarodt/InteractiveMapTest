using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TimerScript : MonoBehaviour
{
    [SerializeField]
    float inactiveTime;

    void Update()
    {
        inactiveTime += Time.deltaTime;

        if (Input.anyKey)
        {
            inactiveTime = 0;
        }

        if (inactiveTime > 30f)
        {
            SceneManager.LoadScene(0);
        }
    }
}
