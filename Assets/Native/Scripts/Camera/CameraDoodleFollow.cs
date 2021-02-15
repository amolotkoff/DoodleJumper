using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class CameraDoodleFollow : MonoBehaviour
    {
        [SerializeField]
        private Transform doodler;

        public void LateUpdate()
        {
            if (doodler != null)
                if (transform.position.y < doodler.position.y) 
                {
                    transform.position = new Vector3(transform.position.x,
                                                     doodler.position.y,
                                                     transform.position.z);
                }
        }
    }
}