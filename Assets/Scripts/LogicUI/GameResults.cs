using Hero;
using UnityEngine;

namespace LogicUI
{
    public class GameResults : MonoBehaviour
    {
        private HeroDeath _death;
        [SerializeField] private GameObject resultsPanel;

        private void Start()
        {
            _death = FindObjectOfType<HeroDeath>();
            _death.PlayerDeath += PlayerDeath;
        }

        private void PlayerDeath() => 
            resultsPanel.SetActive(true);
    }
}
