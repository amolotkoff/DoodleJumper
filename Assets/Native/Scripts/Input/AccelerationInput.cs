using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class AccelerationInput : MonoBehaviour
    {
        [SerializeField]
        private AccelerationListener listeners;
        [SerializeField]
        private float accelerationForce = 10.0f;
        [SerializeField]
        private float MaxAcceleration;
        [SerializeField]
        private Vector2 accelerationActiveZone;

        private float currentAcceleration = 0;
        public void FixedUpdate()
        {
            var acceleration = Input.acceleration.x;
            acceleration = accelerationSpecify(acceleration) * accelerationForce;
             
            if (acceleration != 0f)
            {
                listeners.Notify(acceleration);
            }
        }
        private float accelerationSpecify(float dAcceleration) 
        {
            var absdAcceleration = Mathf.Abs(dAcceleration);

            if ((absdAcceleration > accelerationActiveZone.x) && (absdAcceleration < accelerationActiveZone.y)) 
            {
                var newAcceleration = currentAcceleration + dAcceleration;
                if (Mathf.Abs(newAcceleration) < MaxAcceleration) 
                    currentAcceleration = newAcceleration;
            }

            return currentAcceleration;
        }
    }
}