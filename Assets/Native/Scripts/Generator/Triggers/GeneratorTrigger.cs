using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class GeneratorTrigger : MonoBehaviour
    {
        [SerializeField]
        private DoodleJump jumper;

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<Generator>(out var trigger)) 
            {
                trigger.Generate(jumper);
            }
        }
    }
}
