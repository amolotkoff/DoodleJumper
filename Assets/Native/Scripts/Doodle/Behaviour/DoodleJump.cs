using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class DoodleJump : MonoBehaviour
    {
        [SerializeField]
        private float height;

        private Rigidbody2D rb2D;

        public float Height { get => height; set => height = value; }

        public void Awake()
        {
            rb2D = GetComponent<Rigidbody2D>();
            rb2D.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        public void Boost(float height) 
        {
            var force = new Vector2(0, height);
            rb2D.velocity = force;
        }
        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent<DoodlePlatform>(out var platform)) 
            {
                var force = new Vector2(0, height);
                rb2D.velocity = force;
            }
        }
    }
}
