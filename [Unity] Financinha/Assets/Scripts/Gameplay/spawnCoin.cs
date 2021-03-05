using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCoin : MonoBehaviour
{
    public float currentTimer;
    public float timeToback;
    public GameObject coin;
    public float ypositive;
    public float ynegative;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer -= Time.deltaTime;

        if (currentTimer < 0)
        {
            currentTimer = timeToback;
            Instantiate(coin,
                        new Vector2(transform.position.x,
                                    transform.position.y + Random.Range(ynegative, ypositive)),
                        Quaternion.identity);
        }
    }
}
