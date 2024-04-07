using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 0.5f;
    private Player _target;

    public void TakeTarget(Player target) => _target = target;

    private void Update() => Move();

    private void Move()
    {    
        transform.position = Vector3.Lerp(transform.position, _target.transform.position, _speed * Time.deltaTime);
        transform.LookAt(_target.transform);
    }
}
