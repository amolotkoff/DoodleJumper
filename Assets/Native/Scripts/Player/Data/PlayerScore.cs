using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    [CreateAssetMenu(menuName = "Game/Player/Score")]
    public class PlayerScore : ScriptableObject
    {
        public int score;
    }
}