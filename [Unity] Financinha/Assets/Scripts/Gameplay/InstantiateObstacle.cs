using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObstacle : MonoBehaviour
{
    public float currentTimer;
    public float cooldownTimer;
    public GameObject[] obstacles;
    public int selectedObstacleIndex;
    public float spawnPosNegative;
    public float spawnPosPositive;
    private void Start()
    {
        cooldownTimer = Random.Range(1f, 6f);
        currentTimer = cooldownTimer;

        Debug.Log(obstacles.Length + " obstáculos cadastrados");
    }

    private void Update()
    {
        currentTimer -= Time.deltaTime;

        if (currentTimer < 0)
        {
            // Seleciona um dos obstáculos
            selectedObstacleIndex = Random.Range(0, obstacles.Length);

            //Renova o contador
            cooldownTimer = Random.Range(3f, 8f);
            currentTimer = cooldownTimer;

            //Instancia o novo obstáculo
            Instantiate(obstacles[selectedObstacleIndex],
                        new Vector3(transform.position.x, 
                                   Random.Range(this.transform.position.y + spawnPosNegative, 
                                                this.transform.position.y + spawnPosPositive)
                                                ),   
                                            Quaternion.identity);
        }
    }
}
