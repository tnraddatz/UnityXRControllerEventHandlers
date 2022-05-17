using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BastionVr;
public class CubeMovement : MonoBehaviour
{
    //InputManager inputManager = new InputManager();
    // Start is called before the first frame update
    void Start()
    {
        InputManager.OnGripLeftHandPressed.AddListener(BoxGripPressed);
        InputManager.OnGripRightHandPressed.AddListener(BoxGripPressed);
        InputManager.OnTriggerRightHandPressed.AddListener(BoxGripPressed);
        InputManager.OnTriggerLeftHandPressed.AddListener(BoxGripPressed);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void BoxGripPressed()
    {
        transform.Translate(0f, 0.05f, 0f);
    }
}
