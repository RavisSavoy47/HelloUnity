using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehaviour : HealthBehaviour
{
    public Material FailureNaterial;

    public override void OnDeath()
    {
        base.OnDeath();

        MeshRenderer renderer = GetComponent<MeshRenderer>();
        if (renderer)
        {
            renderer.material = FailureNaterial;
        }
    }
}
