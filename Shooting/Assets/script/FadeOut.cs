﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour {
    Image[] images;
    // Use this for initialization
    void Start () {
        images = GetComponentsInChildren<Image>();
    }

    // Update is called once per frame
    void Update () {
        foreach (Image img in images)
        {
            Color color = img.color;
            color.a -= 0.05f;
            if (color.a <= 0.0f)
            {
                color.a = 0.0f;
                Destroy(this);
            }
            img.color = color;
        }
    }
}
