using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Events;
using UnityEngine;

namespace Game
{
    public class Coin : MonoBehaviour
    {
        [SerializeField]
        private PlayerScore score;

        [SerializeField]
        private UnityEvent onCollectEvent;

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.TryGetComponent<Doodler>(out var doodler)) 
            {
                score.score++;
                onCollectEvent.Invoke();
                Destroy(gameObject);
            }
        }
    }
}