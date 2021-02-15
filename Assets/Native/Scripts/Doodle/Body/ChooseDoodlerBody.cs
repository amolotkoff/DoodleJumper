using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Events;
using UnityEngine;

namespace Game
{
    public class ChooseDoodlerBody : MonoBehaviour
    {
        [SerializeField]
        private Body bodyData;

        [SerializeField]
        private SpriteRenderer sprite;

        [SerializeField]
        private UnityEvent onChooseEvent;

        public void Choose()
        {
            bodyData.body_sprite = sprite.sprite;
            onChooseEvent.Invoke();
        }
    }
}