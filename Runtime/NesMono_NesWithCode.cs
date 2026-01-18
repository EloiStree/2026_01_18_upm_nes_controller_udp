using UnityEngine;
using UnityEngine.Events;
namespace Eloi.NesUtility
{

    //Menu Left 1309 2309
    //Menu Right 1308 2308
    //Up Arrow 1331 2331
    //Down Arrow 1335 2335
    //Left Arrow 1337 2337
    //Right Arrow 1333 2333
    //A button 1300 2300
    //B button 1301 2301

    public class NesMono_NesWithCode : MonoBehaviour
    {
        public UnityEvent<int> m_onIntegerAction;
        public UnityEvent<int, int> m_onIntegerActionWithDelayInMilliseconds;
        public int m_intKeyArrowUp = 1331;
        public int m_intKeyArrowRight = 1333;
        public int m_intKeyArrowLeft = 1337;
        public int m_intKeyArrowDown = 1335;
        public int m_intKeyMenuLeft = 1309;
        public int m_intKeyMenuRight = 1308;
        public int m_intKeyButtonA = 1300;
        public int m_intKeyButtonB = 1301;



        #region GENERIC METHODS
        public void PressKey(int value)
        {
            m_onIntegerAction?.Invoke(value);
        }
        public void ReleaseKey(int value)
        {
            m_onIntegerAction?.Invoke(value + 1000);
        }
        public void StrokeKeyNoDelay(int key)
        {
            PressKey(key);
            ReleaseKey(key);
        }


        public void PressKeyInMilliseconds(int value, int milliseconds)
        {
            m_onIntegerActionWithDelayInMilliseconds?.Invoke(value, milliseconds);
        }
        public void PressKeyInSeconds(int value, float seconds)
        {
            int milliseconds = Mathf.RoundToInt(seconds * 1000f);
            m_onIntegerActionWithDelayInMilliseconds?.Invoke(value, milliseconds);
        }
        public void ReleaseKeyInMilliseconds(int value, int milliseconds)
        {
            m_onIntegerActionWithDelayInMilliseconds?.Invoke(value + 1000, milliseconds);
        }
        public void ReleaseKeyInSeconds(int value, float seconds)
        {
            int milliseconds = Mathf.RoundToInt(seconds * 1000f);
            m_onIntegerActionWithDelayInMilliseconds?.Invoke(value + 1000, milliseconds);
        }
        public void StrokeKeyInMilliseconds(int key, int delayMilliseconds, int pressDurationMilliseconds)
        {
            PressKeyInMilliseconds(key, pressDurationMilliseconds);
            ReleaseKeyInMilliseconds(key, delayMilliseconds + pressDurationMilliseconds);
        }
        public void StrokeKeyInSeconds(int key, float delaySeconds, float pressDurationSeconds)
        {
            int delayMilliseconds = Mathf.RoundToInt(delaySeconds * 1000f);
            int pressDurationMilliseconds = Mathf.RoundToInt(pressDurationSeconds * 1000f);
            PressKeyInMilliseconds(key, pressDurationMilliseconds);
            ReleaseKeyInMilliseconds(key, delayMilliseconds + pressDurationMilliseconds);
        }
        public void StrokeKeyForMilliseconds(int key, int pressDurationMilliseconds)
        {
            PressKey(key);
            ReleaseKeyInMilliseconds(key, pressDurationMilliseconds);
        }
        public void StrokeKeyForSeconds(int key, float pressDurationSeconds)
        {
            int pressDurationMilliseconds = Mathf.RoundToInt(pressDurationSeconds * 1000f);
            PressKey(key);
            ReleaseKeyInMilliseconds(key, pressDurationMilliseconds);
        }
        #endregion

        #region FAST STROKE ON MENU AND BUTTON
        public void StrokeLeftMenuFor100ms()
        {
            StrokeKeyForMilliseconds(m_intKeyMenuLeft, 100);
        }
        public void StrokeRightMenuFor100ms()
        {
            StrokeKeyForMilliseconds(m_intKeyMenuRight, 100);
        }
        public void StrokeButtonAFor100ms()
        {
            StrokeKeyForMilliseconds(m_intKeyButtonA, 100);
        }
        public void StrokeButtonBFor100ms()
        {
            StrokeKeyForMilliseconds(m_intKeyButtonB, 100);
        }
        #endregion

        #region PRESS AND RELEASE FOR ALL
        public void PressButtonA() => PressKey(m_intKeyButtonA);
        public void ReleaseButtonA() => ReleaseKey(m_intKeyButtonA);
        public void StrokeFastButtonA(int milliseconds) => StrokeKeyForMilliseconds(m_intKeyButtonA, milliseconds);

        public void PressButtonB() => PressKey(m_intKeyButtonB);
        public void ReleaseButtonB() => ReleaseKey(m_intKeyButtonB);
        public void StrokeFastButtonB(int milliseconds) => StrokeKeyForMilliseconds(m_intKeyButtonB, milliseconds);

        public void PressArrowUp() => PressKey(m_intKeyArrowUp);
        public void ReleaseArrowUp() => ReleaseKey(m_intKeyArrowUp);
        public void StrokeFastArrowUp(int milliseconds) => StrokeKeyForMilliseconds(m_intKeyArrowUp, milliseconds);

        public void PressArrowDown() => PressKey(m_intKeyArrowDown);
        public void ReleaseArrowDown() => ReleaseKey(m_intKeyArrowDown);
        public void StrokeFastArrowDown(int milliseconds) => StrokeKeyForMilliseconds(m_intKeyArrowDown, milliseconds);

        public void PressArrowLeft() => PressKey(m_intKeyArrowLeft);
        public void ReleaseArrowLeft() => ReleaseKey(m_intKeyArrowLeft);
        public void StrokeFastArrowLeft(int milliseconds) => StrokeKeyForMilliseconds(m_intKeyArrowLeft, milliseconds);

        public void PressArrowRight() => PressKey(m_intKeyArrowRight);
        public void ReleaseArrowRight() => ReleaseKey(m_intKeyArrowRight);
        public void StrokeFastArrowRight(int milliseconds) => StrokeKeyForMilliseconds(m_intKeyArrowRight, milliseconds);

        public void PressMenuLeft() => PressKey(m_intKeyMenuLeft);
        public void ReleaseMenuLeft() => ReleaseKey(m_intKeyMenuLeft);
        public void StrokeFastMenuLeft(int milliseconds) => StrokeKeyForMilliseconds(m_intKeyMenuLeft, milliseconds);

        public void PressMenuRight() => PressKey(m_intKeyMenuRight);
        public void ReleaseMenuRight() => ReleaseKey(m_intKeyMenuRight);
        public void StrokeFastMenuRight(int milliseconds) => StrokeKeyForMilliseconds(m_intKeyMenuRight, milliseconds);
        #endregion

        #region PRESS RELEASE BOOL

        public void PressOrReleaseButtonA(bool press)
        {
            if (press)
                PressKey(m_intKeyButtonA);
            else
                ReleaseKey(m_intKeyButtonA);
        }
        public void PressOrReleaseButtonB(bool press)
        {
            if (press)
                PressKey(m_intKeyButtonB);
            else
                ReleaseKey(m_intKeyButtonB);
        }
        public void PressOrReleaseArrowUp(bool press)
        {
            if (press)
                PressKey(m_intKeyArrowUp);
            else
                ReleaseKey(m_intKeyArrowUp);
        }
        public void PressOrReleaseArrowDown(bool press)
        {
            if (press)
                PressKey(m_intKeyArrowDown);
            else
                ReleaseKey(m_intKeyArrowDown);
        }
        public void PressOrReleaseArrowLeft(bool press)
        {
            if (press)
                PressKey(m_intKeyArrowLeft);
            else
                ReleaseKey(m_intKeyArrowLeft);
        }
        public void PressOrReleaseArrowRight(bool press)
        {
            if (press)
                PressKey(m_intKeyArrowRight);
            else
                ReleaseKey(m_intKeyArrowRight);
        }
        public void PressOrReleaseMenuLeft(bool press)
        {
            if (press)
                PressKey(m_intKeyMenuLeft);
            else
                ReleaseKey(m_intKeyMenuLeft);
        }
        public void PressOrReleaseMenuRight(bool press)
        {
            if (press)
                PressKey(m_intKeyMenuRight);
            else
                ReleaseKey(m_intKeyMenuRight);
        }

        #endregion
    }


}