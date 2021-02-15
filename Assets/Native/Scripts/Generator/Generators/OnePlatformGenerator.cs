using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Rand = UnityEngine.Random;

namespace Game
{
    [CreateAssetMenu(menuName = "Game/Generator/OnePlatformGenerator")]
    public class OnePlatformGenerator : PlatformGenerator
    {
        [SerializeField]
        private DoodlePlatform platform;

        public override float Generate(float fromHeight, float toHeight, float fromWidth, float toWidth, float maxHeight)
        {
            float height = fromHeight;
            for (;height < toHeight; height += Rand.Range(Rand.Range(platform.Height, maxHeight),                                                                      maxHeight))
            {
                var newPlatform = Instantiate(platform);
                var width = UnityEngine.Random.Range(fromWidth, toWidth);

                newPlatform.transform.position = new Vector3(width,
                                                             height,
                                                             0);            
            }

            return height;
        }
    }
}