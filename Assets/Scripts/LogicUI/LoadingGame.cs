using UnityEngine;
using UnityEngine.SceneManagement;

namespace LogicUI
{
    public class LoadingGame : MonoBehaviour
    {
        private void Start()
        {
            SceneManager.LoadSceneAsync("Scenes/Lobby");
        }
    }
}
