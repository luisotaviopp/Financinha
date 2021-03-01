using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Gameplay
{
    public class PlataformBehavior : ObstacleBehaviour
    {
        public GameObject plataforma;
        public Transform posicao;
        public bool spawnCan;
        void Update()
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= -19.85f)
            {
                transform.position = new Vector2(20, transform.position.y);
            }
           
        }
    }
}