using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private List<Transform> _waypoints = new List<Transform>();

    private float _speed = 2f;
    private int _currentWaypoint = 0;

    private void Update() => Move();

    private void Move()
    {
            if (transform.position == _waypoints[_currentWaypoint].position)
                _currentWaypoint = ++_currentWaypoint % _waypoints.Count;

            transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoint].position, _speed * Time.deltaTime);
    }
}