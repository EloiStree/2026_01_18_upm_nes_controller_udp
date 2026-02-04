using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
namespace Eloi.NesUtility
{
    public class NesMono_OnUpDownToUnityEvent : MonoBehaviour,
    IPointerDownHandler,
    IPointerUpHandler
    {
        public bool m_currentValue;
        public UnityEvent<bool> m_onUpDownChanged;
        public UnityEvent m_onDown;
        public UnityEvent m_onUp;


        //#region Swap Menu
        //[ContextMenu("Swap Unity Down <-> Up")]
        //public void SwapDownUp()
        //{
        //    var downListeners = Capture(m_onDown);
        //    var upListeners = Capture(m_onUp);

        //    Clear(m_onDown);
        //    Clear(m_onUp);

        //    Restore(m_onDown, upListeners);
        //    Restore(m_onUp, downListeners);

        //    EditorUtility.SetDirty(this);
        //}

        //private List<(UnityEngine.Object target, string method)> Capture(UnityEvent evt)
        //{
        //    var list = new List<(UnityEngine.Object, string)>();

        //    int count = evt.GetPersistentEventCount();
        //    for (int i = 0; i < count; i++)
        //    {
        //        list.Add((
        //            evt.GetPersistentTarget(i),
        //            evt.GetPersistentMethodName(i)
        //        ));
        //    }

        //    return list;
        //}

        //private void Clear(UnityEvent evt)
        //{
        //    while (evt.GetPersistentEventCount() > 0)
        //        UnityEventTools.RemovePersistentListener(evt, 0);
        //}

        //private void Restore(UnityEvent evt, List<(UnityEngine.Object target, string method)> list)
        //{
        //    foreach (var (target, method) in list)
        //    {
        //        var action = Delegate.CreateDelegate(
        //            typeof(UnityAction),
        //            target,
        //            method
        //        ) as UnityAction;

        //        UnityEventTools.AddPersistentListener(evt, action);
        //    }
        //}
        //#endregion

        public void OnPointerDown(PointerEventData eventData)
        {
            m_currentValue = true;
            m_onUpDownChanged?.Invoke(m_currentValue);
            m_onDown?.Invoke();
        }
        public void OnPointerUp(PointerEventData eventData)
        {
            m_currentValue = false;
            m_onUpDownChanged?.Invoke(m_currentValue);
            m_onUp?.Invoke();
        }
    }
}