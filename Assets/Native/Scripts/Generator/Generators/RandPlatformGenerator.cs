using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Rand = UnityEngine.Random;

namespace Game
{
    [CreateAssetMenu(menuName = "Game/Generator/RandPlatformGenerator")]
    public class RandPlatformGenerator : PlatformGenerator
    {
        [SerializeField]
        private List<DoodlePlatform> platforms;

        public override float Generate(float fromHeight, float toHeight, float fromWidth, float toWidth, float maxHeight)
        {
            float height = fromHeight;
            float platformHeight = platforms[0].Height;
            for (; height < toHeight; height += Rand.Range(Rand.Range(platformHeight, maxHeight), maxHeight))
            {
                var platform = RandPlatform();
                var newPlatform = Instantiate(platform);
                var width = UnityEngine.Random.Range(fromWidth, toWidth);

                newPlatform.transform.position = new Vector3(width,
                                                             height,
                                                             0);
            }

            return height;
        }

        private DoodlePlatform RandPlatform()
        {
            var randIndex = UnityEngine.Random.Range(0, platforms.Count);
            return platforms[randIndex];
        }
    }
}