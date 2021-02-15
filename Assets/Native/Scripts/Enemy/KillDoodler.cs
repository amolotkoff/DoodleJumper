using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class KillDoodler : MonoBehaviour
    {
        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<Doodler>(out var doodler)) 
            {
                Destroy(doodler.gameObject);
            }
        }
    }
}