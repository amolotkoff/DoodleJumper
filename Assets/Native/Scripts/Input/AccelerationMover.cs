using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class AccelerationMover : MonoBehaviour
    {
        [SerializeField]
        private AccelerationListener listener;

        [SerializeField]
        private float smooth;

        private Rigidbody2D rb2D;

        public void Awake()
        {
            rb2D = GetComponent<Rigidbody2D>();
        }
        public void OnEnable()
        {
            listener.AddListener(Move);
        }
        public void OnDisable()
        {
            listener.RemoveListener(Move);
        }
        private void Move(float acceleration)
        {
            var acc = acceleration * smooth;
            var velocity = new Vector2(acc, rb2D.velocity.y);
            rb2D.velocity = velocity;
        }
    }
}