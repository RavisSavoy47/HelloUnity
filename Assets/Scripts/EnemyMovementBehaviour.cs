using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBehaviour : MovementBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _speed;

    public Transform Target
    {
        get { return _target; }
        set { _target = value; }
    }

    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    // Update is called once per frame
    public override void Update()
    {
        Vector3 direction = _target.position - transform.position;
        Velocity = direction.normalized * Speed;

        base.Update();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _target)
        {
            //Increment the enemycount 
            GoalBehaviour goal = other.GetComponent<GoalBehaviour>();
            if (goal)
                goal.EnemyCount++;
            //destorys this enemy
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
