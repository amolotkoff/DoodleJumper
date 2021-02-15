using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public abstract class PlatformGenerator : ScriptableObject
    {
        //return last platform-y
        public abstract float Generate(float fromHeight, float toHeight, float fromWidth, float toWidth, float maxHeight);
    }
}