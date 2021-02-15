using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class StaticSound : MonoBehaviour
    {
        [SerializeField]
        private AudioClip source;

        public void Play()
        {
            AudioSource.PlayClipAtPoint(source, transform.position);
        }
    }
}