using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class LoadScene : MonoBehaviour
    {
        [SerializeField]
        private SceneLoader loader;

        public void Load()
        {
            loader.Load(gameObject);
        }
    }
}