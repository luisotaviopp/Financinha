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

    public int formation;
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
            formation = 1;
            //Renova o contador
            cooldownTimer = 20;
            currentTimer = cooldownTimer;

            //Instancia o novo obstáculo
            if(formation == 1)
            {
               
                Instantiate(obstacles[Random.Range(0, obstacles.Length)],
                            new Vector3(transform.position.x, 
                                       Random.Range(this.transform.position.y + spawnPosNegative, 
                                                    this.transform.position.y + spawnPosPositive)
                                                    ),   
                                                Quaternion.identity);
                Instantiate(obstacles[Random.Range(0, obstacles.Length)],
                            new Vector3(transform.position.x+18,
                                       Random.Range(this.transform.position.y + spawnPosNegative,
                                                    this.transform.position.y + spawnPosPositive)
                                                    ),
                                                Quaternion.identity);
                Instantiate(obstacles[Random.Range(0, obstacles.Length)],
                            new Vector3(transform.position.x +18+9,
                                       Random.Range(this.transform.position.y + spawnPosNegative,
                                                    this.transform.position.y + spawnPosPositive)
                                                    ),
                                                Quaternion.identity);
                Instantiate(obstacles[Random.Range(0, obstacles.Length)],
            new Vector3(transform.position.x + 18 + 9 + 18,
                       Random.Range(this.transform.position.y + spawnPosNegative,
                                    this.transform.position.y + spawnPosPositive)
                                    ),
                                Quaternion.identity);
                Instantiate(obstacles[Random.Range(0, obstacles.Length)],
                            new Vector3(transform.position.x + 18 + 9 + 18 + 9,
                                       Random.Range(this.transform.position.y + spawnPosNegative,
                                                    this.transform.position.y + spawnPosPositive)
                                                    ),
                                                Quaternion.identity);
                Instantiate(obstacles[Random.Range(0, obstacles.Length)],
                            new Vector3(transform.position.x + 18 + 9 + 18 + 9 + 9,
                                       Random.Range(this.transform.position.y + spawnPosNegative,
                                                    this.transform.position.y + spawnPosPositive)
                                                    ),
                                                Quaternion.identity);
            }
            if (formation == 2)
            {

                
            }
            if (formation == 3)
            {

               
            }
        }
    }
}
