using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Player _target;

    private Vector3 _position;
    private Quaternion _rotation;
     
    private void Awake()
    {
        _position = transform.position;
        _rotation = transform.rotation;
    }

    public void CreateEnemy()
    {
        Enemy enemy = Instantiate(_enemy, _position, _rotation);
        enemy.SetTarget(_target);
    }
}