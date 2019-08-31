using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Platformer.UI
{
    public class VictoryUIController : MonoBehaviour
    {
        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
