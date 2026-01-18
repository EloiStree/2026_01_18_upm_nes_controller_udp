using UnityEngine;
namespace Eloi.NesUtility
{

    public class NesMono_CallDebugLog : MonoBehaviour
    {

        public void CallDebugLog(string message)
        {
            Debug.Log(message);
        }
        public void CallDebugLogWarning(string message)
        {
            Debug.LogWarning(message);
        }
        public void CallDebugLogError(string message)
        {
            Debug.LogError(message);
        }
    }
}