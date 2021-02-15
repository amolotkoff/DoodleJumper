using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class DeadZone : MonoBehaviour
    {
        [SerializeField]
        private UnityGameObjectEvent onEvent;

        public void OnCollisionEnter2D(Collision2D collision)
        {
            var go = collision.gameObject;
            onEvent.Invoke(go);
            Destroy(go);
        }
        public void OnTriggerEnter2D(Collider2D collision)
        {
            var go = collision.gameObject;
            onEvent.Invoke(go);
            Destroy(go);
        }
    }
}