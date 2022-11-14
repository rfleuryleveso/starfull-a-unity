using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;



public class ShootingController : MonoBehaviour
{
    VesselControls actions;
    [SerializeField] private Image crosshairImage;
    private CanonBehaviour[] _canonBehaviours;
    [SerializeField] private float fireRate = 0.5f;
    private float nextFire = 0.0f;
    private bool isShooting = false;
    [SerializeField] private Camera camera; // Main camera, to project raycast layers
    [SerializeField] private LayerMask ignoredRaycastLayers; // The layers that will be ignored by the crosshair raycast
    [SerializeField] private AudioSource shotAudio;
    private GameObject hitObject;
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
                canonBehaviour.Shoot(this.hitObject);
                this.shotAudio.Play();
            }
        }

        // Raycast from the crosshair to check for a target
        // If a target is seen, change the color to red, and set the hitObject
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, ~this.ignoredRaycastLayers)) {
            this.crosshairImage.color = Color.red;
            // hit.collider.gameObject
            this.hitObject = hit.collider.gameObject;
        }
        else
        {
            this.crosshairImage.color = Color.blue;
            this.hitObject = null;
        }
    }

    void MouseFirePerformed(InputAction.CallbackContext context)
    {
        this.isShooting = context.ReadValueAsButton();
    }
}