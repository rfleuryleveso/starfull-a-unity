using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class VesselController : MonoBehaviour
{
    VesselControls actions;
    private Vector2 vesselMovement = new Vector2(0, 0);
    private float vesselUpDownMovement = 0.0f;

    [SerializeField] private GameObject vessel;

    // From https://stackoverflow.com/a/69631752/15886503
    private Quaternion targetGlobalRotation;
    private Quaternion targetLocalRotation = Quaternion.identity;

    private Rigidbody vesselRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        actions = new VesselControls();
        actions.VesselActions.MovementVector.performed += KeyboardActionStarted;
        actions.VesselActions.MovementVector.canceled += KeyboardActionEnded;

        actions.VesselActions.MovementUpDownVector.performed += KeyboardUpDownPerformed;
        actions.VesselActions.MovementUpDownVector.canceled += KeyboardUpDownEnded;

        actions.VesselActions.MouseXY.performed += MouseActionPerformed;
        actions.Enable();

        this.vesselRigidBody = this.vessel.GetComponent<Rigidbody>();

        targetGlobalRotation = transform.rotation;
    }

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
        actions.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        this.vesselRigidBody.AddRelativeForce(new Vector3(this.vesselMovement.x, 0, this.vesselMovement.y) * 10f);
        this.vesselRigidBody.AddRelativeForce(new Vector3(0, this.vesselUpDownMovement, 0) * 5f);
    }

    void MouseActionPerformed(InputAction.CallbackContext context)
    {
        Vector2 mouseInput = context.ReadValue<Vector2>();
        vesselRigidBody.rotation *= Quaternion.Euler(mouseInput.y, mouseInput.x, 0.0f);
    }


    void KeyboardActionStarted(InputAction.CallbackContext context)
    {
        vesselMovement = context.ReadValue<Vector2>();
    }

    void KeyboardActionEnded(InputAction.CallbackContext context)
    {
        vesselMovement = context.ReadValue<Vector2>();
    }

    void KeyboardUpDownPerformed(InputAction.CallbackContext context)
    {
        vesselUpDownMovement = context.ReadValue<float>();
    }

    void KeyboardUpDownEnded(InputAction.CallbackContext context)
    {
        vesselUpDownMovement = context.ReadValue<float>();
    }
}