using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 0.5f;
    private Player _target;

    private void Update() => Move();

    public void SetTarget(Player target) => _target = target;

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
        transform.LookAt(_target.transform);
    }
}