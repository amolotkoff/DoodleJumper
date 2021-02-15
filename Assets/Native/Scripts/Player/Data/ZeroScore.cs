using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class ZeroScore : MonoBehaviour
    {
        [SerializeField]
        private PlayerScore score;

        public void Awake()
        {
            score.score = 0;
        }
    }
}