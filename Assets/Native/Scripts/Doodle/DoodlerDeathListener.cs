using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Events;
using UnityEngine;

namespace Game
{
    [CreateAssetMenu (menuName = "Game/Doodler/DeathListener")]
    public class DoodlerDeathListener : ScriptableObject
    {
        [SerializeField]
        private UnityDoodlerEvent onDeathEvent;

        public void AddEvent(UnityAction<Doodler> _event) 
        {
            onDeathEvent.AddListener(_event);
        }
        public void RemoveEvent(UnityAction<Doodler> _event) 
        {
            onDeathEvent.RemoveListener(_event);
        }
        public void NotifyDeath(Doodler doodler) 
        {
            onDeathEvent.Invoke(doodler);
        }
    }
}