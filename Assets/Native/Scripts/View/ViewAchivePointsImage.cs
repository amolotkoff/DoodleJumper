using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class ViewAchivePointsImage : MonoBehaviour
    {
        [SerializeField]
        private Image activeSprite;
        [SerializeField]
        private Image inactiveSprite;
        [SerializeField]
        private PlayerScore currentScore;
        [SerializeField]
        private PlayerScore maxScore;

        public void Start()
        {
            activeSprite.enabled = false;
            inactiveSprite.enabled = true;
        }
        public void FixedUpdate()
        {
            if (currentScore.score > maxScore.score) 
            {
                activeSprite.enabled = true;
                inactiveSprite.enabled = false;
                enabled = false;
            }
        }
    }
}