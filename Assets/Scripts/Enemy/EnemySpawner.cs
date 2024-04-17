using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Enemy
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject _enemyPrefab;

        [SerializeField] 
        private float _enemyEnterval = 3f;

        private void Start()
        {
            StartCoroutine(spawnEnemy(_enemyEnterval, _enemyPrefab));
        }

        private IEnumerator spawnEnemy(float interval, GameObject enemy)
        {
            yield return new WaitForSeconds(interval);
            GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-15f, 10f),
                Random.Range(16f, -12f), 0), Quaternion.identity);
            StartCoroutine(spawnEnemy(interval, enemy));
        }
    }
}
