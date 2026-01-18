using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class NesMono_OnUpDownToInteger : MonoBehaviour,
    IPointerDownHandler,
    IPointerUpHandler
{
    [SerializeField] private UnityEvent<int> m_onIntegerRequested;
    public int m_onValueDown = 1032;
    public int m_onValueUp = 2032;


    public void AddIntegerRequestListen(UnityAction<int> call)
    {
        m_onIntegerRequested.AddListener(call);
    }
    public void RemoveIntegerRequestListen(UnityAction<int> call)
    {
        m_onIntegerRequested.RemoveListener(call);
    }

    [Header("Debug")]
    public int m_lastPushed;
    public void OnPointerDown(PointerEventData eventData)
    {
        m_lastPushed = m_onValueDown;
        m_onIntegerRequested?.Invoke(m_onValueDown);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        m_lastPushed = m_onValueUp;
        m_onIntegerRequested?.Invoke(m_onValueUp);
    }
}