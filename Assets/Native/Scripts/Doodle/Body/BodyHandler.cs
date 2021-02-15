using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class BodyHandler : MonoBehaviour
    {
        [SerializeField]
        private Body body;

        private SpriteRenderer spriteRenderer;

        public void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
        public void Start()
        {
            var bodySprite = body.body_sprite;
            spriteRenderer.sprite = bodySprite;
        }
    }
}