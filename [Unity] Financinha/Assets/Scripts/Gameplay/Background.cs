﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Renderer bgMaterial;
    public float parallaxSpeed;
    public float dividos = 1;

    private void FixedUpdate()
    {
        if (parallaxSpeed < 1.1)
        {
            parallaxSpeed += Time.deltaTime / 110;
        }

        bgMaterial.material.mainTextureOffset += new Vector2(parallaxSpeed * Time.deltaTime/dividos, 0);
    }
}