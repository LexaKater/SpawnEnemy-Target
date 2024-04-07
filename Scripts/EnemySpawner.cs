using System;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeReference] private Player _target;

    private Vector3 _position;
    private Quaternion _rotation;

    public void CreateEnemy()
    {
        _enemy.transform.position = _position;
        _enemy.transform.rotation = _rotation;

        Enemy enemy = Instantiate(_enemy);
        enemy.TakeTarget(GetTarget());
    }

    private void Awake()
    {
        _position = transform.position;
        _rotation = transform.rotation;
    }

    private Player GetTarget() => _target;
}