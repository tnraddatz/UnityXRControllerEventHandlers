using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

namespace BastionVr
{
    public class InputManager : MonoBehaviour
    {
        /*
            Singleton
        */
        private static InputManager _instance;
        public static InputManager Instance { get { return _instance; } }


        GenericXRController inputActions;
        [SerializeField] Vector2 pressedAndReleasedThreshold = new Vector2(0.1f, 0.9f);

        /*
            Grip Left Hand Events
        */
        public static UnityEvent OnGripLeftHandPressed = new UnityEvent();
        public static UnityEvent<float> OnGripLeftHandUpdated = new UnityEvent<float>();
        public static UnityEvent OnGripLeftHandReleased = new UnityEvent();

        /*
            Grip Right Hand Events
        */
        public static UnityEvent OnGripRightHandPressed = new UnityEvent();
        public static UnityEvent<float> OnGripRightHandUpdated = new UnityEvent<float>();
        public static UnityEvent OnGripRightHandReleased = new UnityEvent();

        /*
            Trigger Left Hand Events
        */
        public static UnityEvent OnTriggerLeftHandPressed = new UnityEvent();
        public static UnityEvent<float> OnTriggerLeftHandUpdated = new UnityEvent<float>();
        public static UnityEvent OnTriggerLeftHandReleased = new UnityEvent();


        /*
            Trigger Right Hand Events
        */
        public static UnityEvent OnTriggerRightHandPressed = new UnityEvent();
        public static UnityEvent<float> OnTriggerRightHandUpdated = new UnityEvent<float>();
        public static UnityEvent OnTriggerRightHandReleased = new UnityEvent();


        /*
            Trigger Values
        */
        float leftHandTriggerValue;
        float rightHandTriggerValue;
        bool rightTriggerPressed;
        bool leftTriggerPressed;

        /*
            Grip Values
        */
        float leftHandGripValue;
        float rightHandGripValue;
        bool rightGripPressed;
        bool leftGripPressed;

        /*
            Init
        */
        void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(this.gameObject);
            }
            else
            {
                _instance = this;
            }
            inputActions = new GenericXRController();
            inputActions.RightController.Grip.performed += PressGripRight;
            inputActions.RightController.Trigger.performed += PressTriggerRight;
            inputActions.LeftController.Grip.performed += PressGripLeft;
            inputActions.LeftController.Trigger.performed += PressTriggerLeft;
            inputActions.Enable();
        }
        private void OnEnable()
        {
            inputActions.Enable();
        }

        private void OnDisable()
        {
            inputActions.Disable();
        }

        private void OnDestroy()
        {
            inputActions.Dispose();
        }

        /*
            Input Handler Delegates
        */

        private void PressGripRight(InputAction.CallbackContext obj)
        {
            rightHandGripValue = obj.ReadValue<float>();
            if (rightHandGripValue > pressedAndReleasedThreshold.x && rightHandGripValue < pressedAndReleasedThreshold.y)
            {
                OnGripRightHandUpdated.Invoke(rightHandGripValue);
                rightGripPressed = false;
            }

            if (!rightGripPressed && rightHandGripValue > pressedAndReleasedThreshold.y)
            {
                OnGripRightHandPressed.Invoke();
                rightGripPressed = true;
            }
            if (rightGripPressed && rightHandGripValue < pressedAndReleasedThreshold.x)
            {
                rightGripPressed = false;
                OnGripRightHandReleased.Invoke();
            }
        }

        private void PressTriggerRight(InputAction.CallbackContext obj)
        {
            rightHandTriggerValue = obj.ReadValue<float>();
            if (rightHandTriggerValue > pressedAndReleasedThreshold.x && rightHandTriggerValue < pressedAndReleasedThreshold.y)
            {
                OnTriggerRightHandUpdated.Invoke(rightHandTriggerValue);
                leftTriggerPressed = false;
            }

            if (!leftTriggerPressed && rightHandTriggerValue > pressedAndReleasedThreshold.y)
            {
                OnTriggerRightHandPressed.Invoke();
                leftTriggerPressed = true;
            }
            if (leftTriggerPressed && rightHandTriggerValue < pressedAndReleasedThreshold.x)
            {
                leftTriggerPressed = false;
                OnTriggerRightHandReleased.Invoke();
            }
        }

        private void PressGripLeft(InputAction.CallbackContext obj)
        {
            leftHandGripValue = obj.ReadValue<float>();
            if (leftHandGripValue > pressedAndReleasedThreshold.x && leftHandGripValue < pressedAndReleasedThreshold.y)
            {
                OnGripLeftHandUpdated.Invoke(leftHandGripValue);
                leftGripPressed = false;
            }

            if (!leftGripPressed && leftHandGripValue > pressedAndReleasedThreshold.y)
            {
                OnGripLeftHandPressed.Invoke();
                leftGripPressed = true;
            }
            if (leftGripPressed && leftHandGripValue < pressedAndReleasedThreshold.x)
            {
                leftGripPressed = false;
                OnGripLeftHandReleased.Invoke();
            }
        }

        private void PressTriggerLeft(InputAction.CallbackContext obj)
        {
            leftHandTriggerValue = obj.ReadValue<float>();
            if (leftHandTriggerValue > pressedAndReleasedThreshold.x && leftHandTriggerValue < pressedAndReleasedThreshold.y)
            {
                OnTriggerLeftHandUpdated.Invoke(leftHandTriggerValue);
                leftTriggerPressed = false;
            }

            if (!leftTriggerPressed && leftHandTriggerValue > pressedAndReleasedThreshold.y)
            {
                OnTriggerLeftHandPressed.Invoke();
                leftTriggerPressed = true;
            }
            if (leftTriggerPressed && leftHandTriggerValue < pressedAndReleasedThreshold.x)
            {
                leftTriggerPressed = false;
                OnTriggerLeftHandReleased.Invoke();
            }
        }

    }

}