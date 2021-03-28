using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _launchForce = 10f;
    [SerializeField] private Rigidbody _rigidbody = null;
    public void Launch()
    {
        _rigidbody.AddRelativeForce(Vector3.forward * _launchForce, ForceMode.Impulse);
        Destroy(gameObject, 5);
    }
}
