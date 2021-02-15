using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class LoadSceneWhenDoodlerDie : MonoBehaviour
    {
        [SerializeField]
        private SceneLoader loader;
        [SerializeField]
        private DoodlerDeathListener deathListener;

        public void OnEnable()
        {
            deathListener.AddEvent(Load);
        }
        public void OnDisable()
        {
            deathListener.RemoveEvent(Load);
        }
        private void Load(Doodler doodler)
        {
            loader.Load(doodler.gameObject);
        }
    }
}