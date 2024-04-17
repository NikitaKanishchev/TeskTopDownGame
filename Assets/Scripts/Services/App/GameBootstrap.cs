using Services.Input;
using UnityEngine;

namespace Services.App
{
    public class GameBootstrap : MonoBehaviour
    {
        public IInputService InputService { get; private set; }

        private void Awake()
        {
            RegisterInput();
            DontDestroyOnLoad(this);
        }

        private void RegisterInput()
        {
            InputService = Application.isEditor
                ? (IInputService) new StandaloneInputService()
                : new MobileInputService();
        }
    }
}