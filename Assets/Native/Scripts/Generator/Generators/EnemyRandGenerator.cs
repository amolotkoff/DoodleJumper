using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

using Rand = UnityEngine.Random;

namespace Game
{
    [CreateAssetMenu(menuName = "Game/Generator/EnemyPlatformSpawner")]
    public class EnemyRandGenerator : RandPlatformGenerator
    {
        [SerializeField]
        private List<GameObject> enemies;
        [SerializeField]
        private int difficulty;

        public override float Generate(float fromHeight, float toHeight, float fromWidth, float toWidth, float maxHeight)
        {
            var enemiesCount = EnemiesCount(toHeight);
            for (int i = 0; i < enemiesCount; i++) 
            {
                var enemy = RandEnemy();
                enemy.transform.position = RandPosition(fromWidth,toWidth,fromHeight,toHeight);
            }

            return base.Generate(fromHeight, toHeight, fromWidth, toWidth, maxHeight);
        }
        private Vector3 RandPosition(float fromWidth, float toWidth, float fromHeight, float toHeight) 
        {
            return new Vector3(Rand.Range(fromWidth, toWidth), Rand.Range(fromHeight, toHeight), 0);
        }
        private int EnemiesCount(float toHeight) 
        {
            return Rand.Range(0, difficulty);
        }
        private GameObject RandEnemy() 
        {
            var randIndex = Rand.Range(0, enemies.Count);

            return Instantiate(enemies[randIndex]);
        }
    }
}