using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class BackgroundSetter : MonoBehaviour
    {
        [SerializeField]
        private BackgroundData backgroundData;
        [SerializeField]
        private GameObject background;

        public void Set()
        {
            backgroundData.background = background;
        }
    }
}