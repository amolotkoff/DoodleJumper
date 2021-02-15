using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class RandVelocity : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D rb2D;
        [SerializeField]
        private Vector2 randVelocity;

        public void Start()
        {
            var xvelocity = UnityEngine.Random.Range(randVelocity.x, randVelocity.y);
            var force = new Vector2(xvelocity, 0);
            rb2D.velocity = force;
        }
    }
}