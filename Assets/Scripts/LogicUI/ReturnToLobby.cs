using UnityEngine;
using UnityEngine.SceneManagement;

namespace LogicUI
{
    public class ReturnToLobby : MonoBehaviour
    {
        public void ReturnLobby()
        {
            SceneManager.LoadSceneAsync("Scenes/Lobby");
        }
    }
}
