using UnityEngine;
using UnityEngine.Events;

public class NesMono_OnUpDownTick : MonoBehaviour
{
    public UnityEvent m_onDown;
    public UnityEvent m_onUp;
    public void OnDown()
    {
        Debug.Log("Pressed");
        m_onDown.Invoke();
    }

    public void OnUp()
    {
        Debug.Log("Released");
        m_onUp.Invoke();
    }

}
