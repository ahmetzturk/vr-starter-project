using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Gun : MonoBehaviour
{
    private float recoil = 1;
    [SerializeField] private XRGrabInteractable _XRGrabInteractable;
    [SerializeField] private Transform barrel = null;
    [SerializeField] private GameObject projectile = null;
    [SerializeField] private Rigidbody rigidbody = null;

    private void OnEnable()
    {
        _XRGrabInteractable.onActivate.AddListener(Fire);
    }
    private void OnDisable()
    {
        _XRGrabInteractable.onActivate.RemoveListener(Fire);
    }

    private void Fire(XRBaseInteractor interactor)
    {
        CreateProjectile();
        ApplyRecoil();       
    }

    private void CreateProjectile()
    {
        GameObject projectileObject = Instantiate(projectile, barrel.position, barrel.rotation);
        projectileObject.GetComponent<Projectile>().Launch();
    }
    private void ApplyRecoil()
    {
        rigidbody.AddRelativeForce(Vector3.right * recoil, ForceMode.Impulse);
    }

}
