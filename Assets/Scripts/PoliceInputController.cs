using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PoliceInputController : MonoBehaviour
    // this script allows the animation to happen by communicating with the Police Department script
{
    public InputActionReference RobberySpottedVRController;
    public PoliceDepartment PoliceDepartment;

    private void OnEnable()
    {
        RobberySpottedVRController.action.performed += Action_performed;

    }

    private void Action_performed(InputAction.CallbackContext obj)
    {
        Debug.Log("The Police have been called");
        PoliceDepartment.RecieveTip();
    }

    private void OnDisable()
    {
        RobberySpottedVRController.action.performed -= Action_performed;
    }
}
