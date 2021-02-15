using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Events;
using UnityEngine;

namespace Game
{
    public class ChoosePlatformGenerator : MonoBehaviour
    {
        [SerializeField]
        private UnityEvent onChooseEvent;
        [SerializeField]
        private GeneratorData generatorData;
        [SerializeField]
        private PlatformGenerator generator;

        public void Choose()
        {
            generatorData.generator = generator;
            onChooseEvent.Invoke();
        }
    }
}