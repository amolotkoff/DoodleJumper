using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class DoodleTurnSide : MonoBehaviour
    {
        [SerializeField]
        private AccelerationListener accelerationListener;

        public void OnEnable()
        {
            accelerationListener.AddListener(TurnOnAcceleration);
        }
        public void OnDisable()
        {
            accelerationListener.RemoveListener(TurnOnAcceleration);
        }
        private void TurnOnAcceleration(float acceleration) 
        {
            var localScaleX = RoundAcceleration(acceleration);

            transform.localScale = new Vector3(localScaleX,
                                               transform.localScale.y,
                                               transform.localScale.z);
        }
        private float RoundAcceleration(float acceleration) 
        {
            if (acceleration > 0)
                return 1f;

            return -1f;
        }
    }
}