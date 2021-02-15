using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class RandomBody : MonoBehaviour
    {
        [SerializeField]
        private Body body;
        [SerializeField]
        private List<Sprite> bodies;

        public void Awake()
        {
            var index = RandIndex();
            var _body = bodies[index];
            body.body_sprite = _body;
        }
        private int RandIndex() 
        {
            return UnityEngine.Random.Range(0, bodies.Count);
        }
    }
}
