using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
namespace Eloi.NesUtility
{
    public class NesMono_InputButtonToInteger : MonoBehaviour
    {
        public InputActionReference m_inputAction;
        public UnityEvent<int> m_onIntegerRequested;
        public int m_onDownInteger =1000;
        public int m_onUpInteger=2000;
        public bool m_isPressed;

        public void AddListenerToIntegerRequest(Action<int> integerListener) {

            m_onIntegerRequested.AddListener(integerListener.Invoke);
        }
        public void RemoveListenerToIntegerRequest(Action<int> integerListener)
        {

            m_onIntegerRequested.RemoveListener(integerListener.Invoke);
        }

        void OnEnable()

        {
            m_inputAction.action.Enable();
            m_inputAction.action.performed += ctx => Context(ctx);
            m_inputAction.action.started += ctx => Context(ctx);
            m_inputAction.action.canceled += ctx => Context(ctx);
        }
        private void OnDisable()
        {
            m_inputAction.action.Disable();
            m_inputAction.action.performed -= ctx => Context(ctx);
            m_inputAction.action.started -= ctx => Context(ctx);
            m_inputAction.action.canceled -= ctx => Context(ctx);

        }


        void Context(InputAction.CallbackContext ctx)
        {
            bool isPressed = ctx.ReadValue<float>() > 0.5f;
            if (isPressed != m_isPressed)
            {
                m_isPressed = isPressed;
                if (m_isPressed)
                {
                    m_onIntegerRequested.Invoke(m_onDownInteger);
                }
                else
                {
                    m_onIntegerRequested.Invoke(m_onUpInteger);
                }
            }
        }
    }


}