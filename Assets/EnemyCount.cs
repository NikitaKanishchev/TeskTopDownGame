using TMPro;
using UnityEngine;

public class EnemyCount : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private TMP_Text _scoreCount;

    public int GlobalGameScore => _score;

    private void Start() => 
        _scoreCount.text = "Счёт: 0";

    public void Kill()
    {
        _score++;
        _scoreCount.text = "Счёт" + _score;
    }
}
