using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHand : MonoBehaviour
{
    // Start is called before the first frame update
    public InputActionProperty pinchAnim;
    public Animator handAnim;
    float triggerValue,gripValue;
    public InputActionProperty gripAnim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        triggerValue=pinchAnim.action.ReadValue<float>();
        
        handAnim.SetFloat("Trigger", triggerValue);
        gripValue = gripAnim.action.ReadValue<float>();
        handAnim.SetFloat("Grip", gripValue);
    }
}
