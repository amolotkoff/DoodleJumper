using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using TMPro;

namespace Game
{
    public class ScoreView : MonoBehaviour 
    {
        [SerializeField]
        private PlayerScore score;
        [SerializeField]
        private TextMeshProUGUI text;

        public void FixedUpdate()
        {
            text.text = score.score.ToString();
        }
    }
}