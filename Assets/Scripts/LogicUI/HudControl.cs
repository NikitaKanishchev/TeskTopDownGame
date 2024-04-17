using UnityEngine;

namespace LogicUI
{
    public class HudControl : MonoBehaviour
    {
        [SerializeField] private GameObject _joystickType;
        [SerializeField] private GameObject _buttonType;
    
        private void Start()
        {
            int inputIndex = PlayerPrefs.GetInt("InputType");
            if(inputIndex == 0 )
                _joystickType.SetActive(true);
            else
            {
                _buttonType.SetActive(true);
            }
        }
    }
}
