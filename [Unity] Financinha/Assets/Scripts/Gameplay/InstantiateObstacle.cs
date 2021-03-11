using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObstacle : MonoBehaviour
{
    public float currentTimer;
    public float cooldownTimer;
    [Header("obstaculos")]
    public GameObject[] obstacles;
    [Header("posição dos obstaculos")]
    public Transform[] position;
    [Header("selecionando obstaculo")]
    public int[] selectedObstacleIndex;
    [Header("Quantidade de objeto")]
    public int amount;
    public int amountRandommin;
    public int amountRandomMax;
    [Header("POSICAO DO OBJETO")]
    public int[] selectedObstacleTransformIndex;

    [Header("NOMEAR")]
    public float spawnPosNegative;
    public float spawnPosPositive;




    public int formation;
    private void Start()
    {
        //cooldownTimer = Random.Range(1f, 6f);
        currentTimer = cooldownTimer;


    }

    private void Update()
    {
        currentTimer -= Time.deltaTime;

        if (currentTimer < 0)
        {
            // Seleciona um dos obstáculos
            //selectedObstacleIndex = Random.Range(0, obstacles.Length);
            formation = 1;
            //Renova o contador
            
            currentTimer = cooldownTimer;

            //Instancia o novo obstáculo
            if(formation == 1)
            {
                Spawn();
            }
            if (formation == 2)
            {

                
            }
            if (formation == 3)
            {

               
            }
        }
    }
    public void Spawn()
    {
        amount = Random.Range(amountRandommin, amountRandomMax);
        for (int i = 0; i < amount; i++)
        {
            Instantiate(obstacles[Random.Range(0, obstacles.Length)],
                        position[selectedObstacleTransformIndex[i]].position,
                        Quaternion.identity);
        }
    }
  
}
