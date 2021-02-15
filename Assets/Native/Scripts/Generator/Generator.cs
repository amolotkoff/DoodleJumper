using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class Generator : MonoBehaviour
    {
        [SerializeField]
        private GeneratorData generatorData;
        [SerializeField]
        private Transform UpPoint;

        public float Generate(DoodleJump jumper)
        {
            var generator = generatorData.generator;
                
            var camera = Camera.main;

            var cameraWorldToView = camera.WorldToViewportPoint(new Vector3(1, 1, 0));

            var maxHeightJump = jumper.Height * .3f;

            var fromHeight = transform.position.y;
            var toHeight = UpPoint.position.y;

            var cameraWidth = 1 / (cameraWorldToView.x - .5f);
            var cameraHalfWidth = cameraWidth / 2f;
            var cameraWidthCenter = camera.transform.position.x;
            var dCameraWidth = cameraHalfWidth * .9f;
            var fromWidth = cameraWidthCenter - dCameraWidth;
            var toWidth = cameraWidthCenter + dCameraWidth;

            var lastY = generator.Generate(fromHeight, toHeight, fromWidth, toWidth, maxHeightJump);

            var dHeight = toHeight - fromHeight;

            transform.position = new Vector3(transform.position.x,
                                             toHeight,
                                             transform.position.z);

            UpPoint.transform.position += new Vector3(0, dHeight, 0);

            return lastY;
        }
    }
}