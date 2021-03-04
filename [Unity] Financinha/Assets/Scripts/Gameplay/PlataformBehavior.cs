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
            speed += Time.deltaTime / 110;
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= -19.85f)
            {
                transform.position = new Vector2(21.65f, transform.position.y);
            }
           
        }
    }
}