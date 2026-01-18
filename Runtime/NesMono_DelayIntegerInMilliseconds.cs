using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace Eloi.NesUtility
{

    public class NesMono_DelayIntegerInMilliseconds : MonoBehaviour
    {

        public UnityEvent<int> m_onActionIntegerRequested;
        public int m_timeInMilliseconds;
        public List<WhenToExecuteIntAction> m_waitingToBeExecuted = new List<WhenToExecuteIntAction>();


        public void Update()
        {
            m_timeInMilliseconds = (int)(Time.time * 1000f);

            for (int i = m_waitingToBeExecuted.Count - 1; i >= 0; i--)
            {

                if (m_waitingToBeExecuted[i].m_whenToExecuteInMilliseconds < m_timeInMilliseconds)
                {

                    int toExecute = m_waitingToBeExecuted[i].m_actionToExecute;
                    m_waitingToBeExecuted.RemoveAt(i);
                    m_onActionIntegerRequested.Invoke(toExecute);


                }
            }


        }
        public void AddActionToDelayAsIntegerInSeconds(int actionInInteger, float secondsDelay)
        {
            AddActionToDelayAsIntegerInMilliseconds(actionInInteger, (int)(secondsDelay * 1000f));
        }

        public void AddActionToDelayAsIntegerInMilliseconds(int actionInInteger, int millisecondsDelay)
        {

            m_waitingToBeExecuted.Add(new WhenToExecuteIntAction(actionInInteger, m_timeInMilliseconds + millisecondsDelay));
        }

        [System.Serializable]
        public class WhenToExecuteIntAction
        {

            public int m_whenToExecuteInMilliseconds;
            public int m_actionToExecute;

            public WhenToExecuteIntAction(int actionInInteger, int millisecondsDelay)
            {
                this.m_actionToExecute = actionInInteger;
                this.m_whenToExecuteInMilliseconds = millisecondsDelay;
            }
        }
    }


}