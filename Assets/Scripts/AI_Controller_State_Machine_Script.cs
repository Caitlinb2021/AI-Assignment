using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class AI_Controller_State_Machine_Script : MonoBehaviour
    // this script controls the NPCs and the animations they carry out, it also allows the navmesh to find locations to send the NPCs to
{
    public LocomotionAnimation locomotionAnimation;
    public Animator StateMachineAnimator;
    public Transform robberyLocation;
    public Transform homeLocation;
    public Transform moveTarget;

    private void OnEnable()
    {
        PoliceDepartment.onRobberySpottedAtPark += PoliceDepartment_onRobberySpottedAtPark; 
    }

    private void PoliceDepartment_onRobberySpottedAtPark()
    {
        moveTarget = robberyLocation;                                              // when the robbery is spotted then the crow will all move to the robbery location 
        StateMachineAnimator.SetBool("isChasing", true);
    }

    private void OnDisable()
    {
        PoliceDepartment.onRobberySpottedAtPark -= PoliceDepartment_onRobberySpottedAtPark;                   // if no tip is sent to the police department then the crowd will not locate to the robbery location 
    }
}
