using UnityEngine;
using UnityEngine.Events;
namespace Eloi.NesUtility
{

    public class NesMono_AutoJoinOnUpDownInteger : MonoBehaviour
    {
        public UnityEvent<int> m_onIntegerRequested;
        public GameObject[] m_parentsToOverwatch;

        public void OnEnable()
        {
            foreach (var parent in m_parentsToOverwatch)
            {
                NesMono_OnUpDownToInteger[] upDownToIntegerComponents =
                    parent.GetComponentsInChildren<NesMono_OnUpDownToInteger>();
                foreach (var component in upDownToIntegerComponents)
                {
                    component.AddIntegerRequestListen(PushIntegerRequest);
                }

                NesMono_InputButtonToInteger [] inputButtons =
                  parent.GetComponentsInChildren<NesMono_InputButtonToInteger>();
                foreach (var component in inputButtons)
                {
                    component.AddListenerToIntegerRequest(PushIntegerRequest);
                }
            }
        }
        public void OnDisable()
        {

            foreach (var parent in m_parentsToOverwatch)
            {
                NesMono_OnUpDownToInteger[] upDownToIntegerComponents =
                    parent.GetComponentsInChildren<NesMono_OnUpDownToInteger>();
                foreach (var component in upDownToIntegerComponents)
                {
                    component.RemoveIntegerRequestListen(PushIntegerRequest);
                }
                NesMono_InputButtonToInteger[] inputButtons =
                  parent.GetComponentsInChildren<NesMono_InputButtonToInteger>();
                foreach (var component in inputButtons)
                {
                    component.RemoveListenerToIntegerRequest(PushIntegerRequest);
                }
            }
        }
        public void PushIntegerRequest(int value)
        {
            m_onIntegerRequested?.Invoke(value);
        }

    }
}