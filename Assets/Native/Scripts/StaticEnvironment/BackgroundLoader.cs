using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class BackgroundLoader : MonoBehaviour
    {
        [SerializeField]
        private BackgroundData backgroundData;

        public void Start()
        {
            var back = Instantiate(backgroundData.background);
            back.transform.parent = transform;
            var position = Camera.main.transform.position;
            position.z = 1;
            back.transform.position = position;
        }
    }
}
