using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine;

namespace Game
{
    [CreateAssetMenu(menuName = "Game/Scene/Loader")]
    public class SceneLoader : ScriptableObject
    {
        [SerializeField]
        private string sceneName;

        public void Load(GameObject sender)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}