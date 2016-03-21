﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class FadeoutToScene : MonoBehaviour {

    public string sceneName;
    RawImage black;
    bool fade = false;
    
    void Start ()
    {
        black = GameObject.FindObjectOfType<RawImage>();
    }

    void FixedUpdate()
    {
        if (fade)
        {
            if (black.color.a < 1)
            {
                black.color = new Color(0f, 0f, 0f, black.color.a + 0.05f);
                return;
            }
            SceneManager.LoadScene(sceneName);
        }

    }

    void OnTriggerEnter(Collider col)
    {
        black.enabled = true;
        black.color = new Color(0f, 0f, 0f, 0.005f);
        fade = true;
    }
}
