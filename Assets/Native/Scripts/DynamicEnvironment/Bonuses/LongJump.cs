using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class LongJump : MonoBehaviour
    {
        [SerializeField]
        private float Height;

        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent<DoodleJump>(out var jumper)) 
            {
                jumper.Boost(Height);
                Destroy(gameObject);
            }
        }
    }
}
