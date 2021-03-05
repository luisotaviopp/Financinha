using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvniBehavior : MonoBehaviour
{
    public float speed;
    public Transform a;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.RotateAround(a.position, 10 * Time.deltaTime);
    }
}
