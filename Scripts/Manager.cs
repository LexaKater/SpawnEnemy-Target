using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Manager : MonoBehaviour
{
    [SerializeField] List<EnemySpawner> _spawners = new List<EnemySpawner>();

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
            if (_spawners.Count > 0)
            {
                indexSpawner = UserUtils.GetRandomNumber(minIndex, _spawners.Count);
                _spawners[indexSpawner].CreateEnemy();
            }
            else
            {
                _isCoroutineWork = false;
            }

            yield return wait;
        }
    }
}

