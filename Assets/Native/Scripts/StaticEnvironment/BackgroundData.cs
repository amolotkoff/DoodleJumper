using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    [CreateAssetMenu (menuName = "Game/Background/Data")]
    public class BackgroundData : ScriptableObject
    {
        public GameObject background;
    }
}