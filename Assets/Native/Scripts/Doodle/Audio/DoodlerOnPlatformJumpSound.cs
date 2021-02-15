using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class DoodlerOnPlatformJumpSound : MonoBehaviour
    {
        [SerializeField]
        private AudioSource source;

        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent<DoodlePlatform>(out var platform)) 
            {
                source.Play();
            }
        }
    }
}