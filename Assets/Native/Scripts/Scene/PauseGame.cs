using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class PauseGame : MonoBehaviour
    {
        private bool isPaused = false;

        public void PauseOrUnpause()
        {
            if (isPaused)
                Time.timeScale = 1f;
            else
                Time.timeScale = 0f;

            isPaused = !isPaused;
        }
    }
}