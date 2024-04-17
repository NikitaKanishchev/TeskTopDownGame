using TMPro;
using UnityEngine;

namespace LogicUI
{
    public class Results : MonoBehaviour
    {
        [SerializeField] private EnemyCount count;
        [SerializeField] private TMP_Text text;

        private void Start()
        {
            text.SetText($"Счёт: {count.GlobalGameScore}");
        }
    }
}
