using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviorBallon : MonoBehaviour
{
    public float speed;
    public float speedx;
    public float rang1;
    public float rang2;
    public bool up;
    // Start is called before the first frame update
    void Start()
    {
       speedx = Random.Range(rang1,rang2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speedx * Time.deltaTime);
        if (!up)
        {

        transform.Translate(Vector2.up * speed * Time.deltaTime ); 
        }
    }
}
