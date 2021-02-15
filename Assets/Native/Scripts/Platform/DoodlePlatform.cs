using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class DoodlePlatform : MonoBehaviour
    {
        [SerializeField]
        private BoxCollider2D _collider;

        public float Height { get => _collider.size.y; }
        public float Width { get => _collider.size.x; }
    }
}