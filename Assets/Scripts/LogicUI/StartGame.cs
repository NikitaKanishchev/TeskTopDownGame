using UnityEngine;
using UnityEngine.SceneManagement;

namespace LogicUI
{
    public class StartGame : MonoBehaviour
    {
        public void OpenGame()
        {
            SceneManager.LoadSceneAsync("Scenes/Main");
        }
    }
}
