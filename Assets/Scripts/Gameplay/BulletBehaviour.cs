using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    private string _ownerTag;
    [SerializeField]
    private float _damage;

    public string Owner
    {
        get { return _ownerTag; }
        set { _ownerTag = value; }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Owner))
            return;

        HealthBehaviour otherHealth = other.GetComponent<HealthBehaviour>();

        if (!otherHealth)
            return;

        otherHealth.TakeDamge(_damage);
    }
}
