using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

namespace Game 
{
    [CreateAssetMenu(menuName = "Game/Input/Acceleration/Listener")]
    public class AccelerationListener : ScriptableObject
    {
        [SerializeField]
        private UnityFloatEvent listeners;

        public void AddListener(UnityAction<float> listener) 
        {
            listeners.AddListener(listener);
        }
        public void RemoveListener(UnityAction<float> listener) 
        {
            listeners.RemoveListener(listener);
        }
        public void Notify(float acceleration) 
        {
            listeners.Invoke(acceleration);
        }
    }
}