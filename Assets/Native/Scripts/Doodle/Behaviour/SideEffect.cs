using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class SideEffect : MonoBehaviour
    {
        [SerializeField]
        private Transform onTransform;

        public void OnBecameInvisible()
        {
            if (onTransform != null) 
            {
                var camera = Camera.main;
                if (camera != null) 
                {
                    var viewportPosition = camera.WorldToViewportPoint(onTransform.position);
                    var newPosition = onTransform.position;

                    if (viewportPosition.x > 1 || viewportPosition.x < 0)
                        newPosition.x = -newPosition.x;

                    onTransform.position = newPosition;
                }
            }
        }
    }
}