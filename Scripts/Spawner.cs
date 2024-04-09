using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] SpawnPoint[] _spawnPoints;

    private bool _isCoroutineWork = true;
    private float _delayBetweenSpawn = 2f;

    private void Start() => StartCoroutine(LaunchSpawner());

    private IEnumerator LaunchSpawner()
    {
        var wait = new WaitForSeconds(_delayBetweenSpawn);

        int minIndex = 0;
        int indexSpawner;

        while (_isCoroutineWork)
        {
            if (_spawnPoints.Length > 0)
            {
                indexSpawner = Random.Range(minIndex, _spawnPoints.Length);
                _spawnPoints[indexSpawner].CreateEnemy();
            }
            else
            {
                _isCoroutineWork = false;
            }

            yield return wait;
        }
    }
}