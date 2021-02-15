using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class RandImageColor : MonoBehaviour
    {
        [SerializeField]
        private SpriteRenderer spriteRenderer;

        public void Start()
        {
            spriteRenderer.color = RandColor();
        }
        private Color RandColor() 
        {
            var colors = new Color[] { Color.green, 
                                       Color.red, 
                                       Color.blue,
                                       Color.black,
                                       Color.grey,
                                       Color.cyan,
                                       Color.yellow };

            var randIndex = UnityEngine.Random.Range(0, colors.Length);

            return colors[randIndex];
        }
    }
}