using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PingPongMoveEffect : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D rb2D;

        public void OnBecameInvisible()
        {
            var camera = Camera.main;
            if (camera != null)
            {
                var oppositeVelocity = rb2D.velocity;
                oppositeVelocity.x = -oppositeVelocity.x;
                rb2D.velocity = oppositeVelocity;
            }
        }
    }
}
