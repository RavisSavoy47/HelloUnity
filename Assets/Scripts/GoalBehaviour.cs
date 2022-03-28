using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehaviour : MonoBehaviour
{
    public Material FailureNaterial;

    [SerializeField]
    private float _health = 10;

    private int _enemyCount = 0;

    public int EnemyCount
    {
        get { return _enemyCount; }
        set { _enemyCount = value; }
    }

    private void Update()
    {
        if (_enemyCount >= _health)
        {
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            if (renderer)
            {
                renderer.material = FailureNaterial;
            }
        }
    }
}