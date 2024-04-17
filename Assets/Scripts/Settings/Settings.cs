using TMPro;
using UnityEngine;

namespace Settings
{
    public class Settings : MonoBehaviour
    {
        public TMP_Dropdown controlDropdown;
        public TMP_Dropdown qualityDropdown;
        
        private Resolution[] _resolutions;

        private void Start()
        {
            _resolutions = Screen.resolutions;
            int currentResolutionIndex = 0;
            
            
            LoadSetting(currentResolutionIndex);
        }

        public void DropDownSelected(TMP_Dropdown dropdown)
        {
            int index = dropdown.value;
            PlayerPrefs.SetInt("InputType", index);
        }
        
        public void SetQuality(int qualityIndex)
        {
            QualitySettings.SetQualityLevel(qualityIndex);
        }

        public void SaveSetting()
        {
            PlayerPrefs.SetInt("QualitySettingPreference", qualityDropdown.value);
            PlayerPrefs.SetInt("InputType", controlDropdown.value);
        }
        
        public void LoadSetting(int currentResolutionIndex)
        {
            if (PlayerPrefs.HasKey("QualitySettingPreference"))
                qualityDropdown.value = PlayerPrefs.GetInt("QualitySettingPreference");
            else
            {
                qualityDropdown.value = 3;
            }

            if (PlayerPrefs.HasKey("InputType"))
                controlDropdown.value = PlayerPrefs.GetInt("InputType");
            else
            {
                controlDropdown.value = currentResolutionIndex;
            }
        }
    }
}