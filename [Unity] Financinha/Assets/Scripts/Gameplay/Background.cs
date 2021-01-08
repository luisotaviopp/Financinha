using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Renderer bgMaterial;
    public float parallaxSpeed;

    private void FixedUpdate()
    {
        if (parallaxSpeed < 1.1)
        {
            parallaxSpeed += Time.deltaTime / 110;
        }

        bgMaterial.material.mainTextureOffset += new Vector2(0, parallaxSpeed * Time.deltaTime);
    }
}