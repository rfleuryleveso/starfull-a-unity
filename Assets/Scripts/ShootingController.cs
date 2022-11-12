using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ShootingController : MonoBehaviour
{
    VesselControls actions;
    private CanonBehaviour[] _canonBehaviours;
    [SerializeField] private float fireRate = 0.5f;
    private float nextFire = 0.0f;
    private bool isShooting = false;


    // Start is called before the first frame update
    void Start()
    {
        actions = new VesselControls();
        actions.VesselActions.Fire.performed += MouseFirePerformed;
        actions.VesselActions.Fire.canceled += MouseFirePerformed;
        actions.Enable();

        this._canonBehaviours = GetComponentsInChildren<CanonBehaviour>();
        Debug.Log($"Found {this._canonBehaviours.Length} CanonBehaviours in children");
    }

    void OnDisable()
    {
        actions.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (isShooting && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            foreach (var canonBehaviour in this._canonBehaviours)
            {
                // Make each canon behaviour instantiate the correct projectile type
                canonBehaviour.Shoot();
            }
        }
    }

    void MouseFirePerformed(InputAction.CallbackContext context)
    {
        this.isShooting = context.ReadValueAsButton();
    }
}