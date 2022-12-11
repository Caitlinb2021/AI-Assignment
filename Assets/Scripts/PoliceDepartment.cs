using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PoliceDepartment : MonoBehaviour
    // This is a script to enable crowd behaviour by sending a tip to the police deptartment when a robbery is spotted in the park. 
{
    public delegate void RobberyAnnouncementHandler();
    public static event RobberyAnnouncementHandler onRobberySpottedAtPark; 
     
   
    public bool triggerOnEnable;

    private void OnEnable()
    {
        if (triggerOnEnable)                                               // when button is pressed on controller this will trigger an event 
            RecieveTip(); 
    }

    public void RecieveTip()
    {
        onRobberySpottedAtPark.Invoke();                                 // once confirmed button has been pressed this will start crowd behaviour 
    }
}
