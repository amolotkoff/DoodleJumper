using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class UpdateMaxPlayerScore : MonoBehaviour 
    {
        [SerializeField]
        private PlayerScore currentScore;
        [SerializeField]
        private PlayerScore maxScore;

        public void Start()
        {
            if (currentScore.score > maxScore.score)
                maxScore.score = currentScore.score;
        }
    }
}