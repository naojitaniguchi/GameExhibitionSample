using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitByTimer : MonoBehaviour
{
    public float waitTime = 10.0f ;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ExitApp");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
    UnityEngine.Application.Quit();
#endif

        }
    }

    // コルーチン  
    private IEnumerator ExitApp()
    {
        // コルーチンの処理  
        yield return new WaitForSeconds(waitTime);

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
    UnityEngine.Application.Quit();
#endif

    }

}
