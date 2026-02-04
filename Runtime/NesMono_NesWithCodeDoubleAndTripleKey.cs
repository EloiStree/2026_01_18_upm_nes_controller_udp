using UnityEngine;
namespace Eloi.NesUtility
{
    public class NesMono_NesWithCodeDoubleAndTripleKey:MonoBehaviour
    {

        void Reset() {

            m_toAffect = GetComponent<NesMono_NesWithCode>();
        }

        public NesMono_NesWithCode m_toAffect;

        // We lets here the designer choose what it means in timing to double or tiple click.
        public int m_millisecondsBetweenClicks = 50;
        public int m_millisecondsForPressDuration = 50;


        [ContextMenu("Double Click A")]
        public void DoubleClickButtonA()
        {
            m_toAffect.DoubleClick(m_toAffect.m_intKeyButtonA, m_millisecondsBetweenClicks,
                m_millisecondsForPressDuration);
        }
        [ContextMenu("Triple Click A")]
        public void TripleClickButtonA()
        {
            m_toAffect.TripleClick(m_toAffect.m_intKeyButtonA, m_millisecondsBetweenClicks, m_millisecondsForPressDuration);

        }


        [ContextMenu("Double Click B")]
        public void DoubleClickButtonB()
        {
            m_toAffect.DoubleClick(m_toAffect.m_intKeyButtonB, m_millisecondsBetweenClicks, m_millisecondsForPressDuration);
        }
        [ContextMenu("Triple Click B")]
        public void TripleClickButtonB()
        {
            m_toAffect.TripleClick(m_toAffect.m_intKeyButtonB, m_millisecondsBetweenClicks, m_millisecondsForPressDuration);
        }
        public void DoubleClickArrowUp()
        {
            m_toAffect.DoubleClick(m_toAffect.m_intKeyArrowUp, m_millisecondsBetweenClicks, m_millisecondsForPressDuration);
        }
        public void TripleClickArrowUp()
        {
            m_toAffect.TripleClick(m_toAffect.m_intKeyArrowUp, m_millisecondsBetweenClicks, m_millisecondsForPressDuration);
        }
        public void DoubleClickArrowDown()
        {
            m_toAffect.DoubleClick(m_toAffect.m_intKeyArrowDown, m_millisecondsBetweenClicks, m_millisecondsForPressDuration);
        }
        public void TripleClickArrowDown()
        {
            m_toAffect.TripleClick(m_toAffect.m_intKeyArrowDown, m_millisecondsBetweenClicks, m_millisecondsForPressDuration);
        }
        public void DoubleClickArrowLeft()
        {
            m_toAffect.DoubleClick(m_toAffect.m_intKeyArrowLeft, m_millisecondsBetweenClicks, m_millisecondsForPressDuration);
        }
        public void TripleClickArrowLeft()
        {
            m_toAffect.TripleClick(m_toAffect.m_intKeyArrowLeft, m_millisecondsBetweenClicks, m_millisecondsForPressDuration);
        }
        public void DoubleClickArrowRight()
        {
            m_toAffect.DoubleClick(m_toAffect.m_intKeyArrowRight, m_millisecondsBetweenClicks, m_millisecondsForPressDuration);
        }
        public void TripleClickArrowRight()
        {
            m_toAffect.TripleClick(m_toAffect.m_intKeyArrowRight, m_millisecondsBetweenClicks, m_millisecondsForPressDuration);
        }
        public void DoubleClickMenuLeft()
        {
            m_toAffect.DoubleClick(m_toAffect.m_intKeyMenuLeft, m_millisecondsBetweenClicks, m_millisecondsForPressDuration);
        }
        public void TripleClickMenuLeft()
        {
            m_toAffect.TripleClick(m_toAffect.m_intKeyMenuLeft, m_millisecondsBetweenClicks, m_millisecondsForPressDuration);
        }
        public void DoubleClickMenuRight()
        {
            m_toAffect.DoubleClick(m_toAffect.m_intKeyMenuRight, m_millisecondsBetweenClicks, m_millisecondsForPressDuration);
        }
        public void TripleClickMenuRight()
        {
            m_toAffect.TripleClick(m_toAffect.m_intKeyMenuRight, m_millisecondsBetweenClicks, m_millisecondsForPressDuration);
        }



    }


}