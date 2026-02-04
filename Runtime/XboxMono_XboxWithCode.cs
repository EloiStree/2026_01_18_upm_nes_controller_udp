using System;
using UnityEngine;
using UnityEngine.Events;

public class XboxMono_XboxWithCode : MonoBehaviour
{
    public UnityEvent<int> m_onIntegerAction;
    public UnityEvent<int, int> m_onIntegerActionWithDelayInMilliseconds;


    #region GENERIC METHODS

    public void PushIntegerAction(int integer)
    {
        m_onIntegerAction?.Invoke(integer);
    }
    public void PushIntegerActionWithMillisecondsDelay(int integer, int milliseconds)
    {
        m_onIntegerActionWithDelayInMilliseconds?.Invoke(integer, milliseconds);
    }
    public void PushIntegerActionWithSecondsDelay(int integer, float seconds)
    {
        int milliseconds = Mathf.RoundToInt(seconds * 1000f);
        m_onIntegerActionWithDelayInMilliseconds?.Invoke(integer, milliseconds);
    }
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


    public void SeveralClick(int key, int numberOfClick, int delayBetweenClicksMilliseconds, int pressDurationMilliseconds)
    {
        int timeRelative = 0;

        for (int i = 0; i < numberOfClick; i++)
        {
            PressKeyInMilliseconds(key, timeRelative);
            timeRelative += pressDurationMilliseconds;
            ReleaseKeyInMilliseconds(key, timeRelative);
            timeRelative += delayBetweenClicksMilliseconds;
        }
    }
    public void DoubleClick(int key, int delayBetweenClicksMilliseconds, int pressDurationMilliseconds)
      => SeveralClick(key, 2, delayBetweenClicksMilliseconds, pressDurationMilliseconds);

    public void TripleClick(int key, int delayBetweenClicksMilliseconds, int pressDurationMilliseconds)
      => SeveralClick(key, 3, delayBetweenClicksMilliseconds, pressDurationMilliseconds);

    #endregion

    #region BUTTONS AND AXES VALUES
    [SerializeField] private int m_buttonADown = 1300;
    [SerializeField] private int m_buttonXLeft = 1301;
    [SerializeField] private int m_buttonBRight = 1302;
    [SerializeField] private int m_buttonYUp = 1303;
    [SerializeField] private int m_buttonLeftSide = 1304;
    [SerializeField] private int m_buttonRightSide = 1305;
    [SerializeField] private int m_buttonLeftStick = 1306;
    [SerializeField] private int m_buttonRightStick = 1307;
    [SerializeField] private int m_buttonMenuRight = 1308;
    [SerializeField] private int m_buttonMenuLeft = 1309;
    [SerializeField] private int m_arrowRelease = 1310;
    [SerializeField] private int m_arrowUp = 1311;
    [SerializeField] private int m_arrowUpRight = 1312;
    [SerializeField] private int m_arrowRight = 1313;
    [SerializeField] private int m_arrowDownRight = 1314;
    [SerializeField] private int m_arrowDown = 1315;
    [SerializeField] private int m_arrowDownLeft = 1316;
    [SerializeField] private int m_arrowLeft = 1317;
    [SerializeField] private int m_arrowUpLeft = 1318;
    [SerializeField] private int m_xboxHomeButton = 1319;
    [SerializeField] private int m_randomAxis = 1320;
    [SerializeField] private int m_startRecording = 1321;
    [SerializeField] private int m_leftStickNeutral = 1330;
    [SerializeField] private int m_leftStickUp = 1331;
    [SerializeField] private int m_leftStickUpRight = 1332;
    [SerializeField] private int m_leftStickRight = 1333;
    [SerializeField] private int m_leftStickDownRight = 1334;
    [SerializeField] private int m_leftStickDown = 1335;
    [SerializeField] private int m_leftStickDownLeft = 1336;
    [SerializeField] private int m_leftStickLeft = 1337;
    [SerializeField] private int m_leftStickUpLeft = 1338;
    [SerializeField] private int m_rightStickNeutral = 1340;
    [SerializeField] private int m_rightStickUp = 1341;
    [SerializeField] private int m_rightStickUpRight = 1342;
    [SerializeField] private int m_rightStickRight = 1343;
    [SerializeField] private int m_rightStickDownRight = 1344;
    [SerializeField] private int m_rightStickDown = 1345;
    [SerializeField] private int m_rightStickDownLeft = 1346;
    [SerializeField] private int m_rightStickLeft = 1347;
    [SerializeField] private int m_rightStickUpLeft = 1348;
    [SerializeField] private int m_leftTrigger100Percent = 1358;
    [SerializeField] private int m_rightTrigger100Percent = 1359;
    [SerializeField] private int m_leftTrigger75Percent = 1368;
    [SerializeField] private int m_rightTrigger75Percent = 1369;
    [SerializeField] private int m_leftTrigger50Percent = 1378;
    [SerializeField] private int m_rightTrigger50Percent = 1379;
    [SerializeField] private int m_leftTrigger25Percent = 1388;
    [SerializeField] private int m_rightTrigger25Percent = 1389;
    [SerializeField] private int m_leftStickHorizontalP100Percent = 1350;
    [SerializeField] private int m_leftStickHorizontalN100Percent = 1351;
    [SerializeField] private int m_leftStickVerticalP100Percent = 1352;
    [SerializeField] private int m_leftStickVerticalN100Percent = 1353;
    [SerializeField] private int m_rightStickHorizontalP100Percent = 1354;
    [SerializeField] private int m_rightStickHorizontalN100Percent = 1355;
    [SerializeField] private int m_rightStickVerticalP100Percent = 1356;
    [SerializeField] private int m_rightStickVerticalN100Percent = 1357;
    [SerializeField] private int m_leftStickHorizontalP75Percent = 1360;
    [SerializeField] private int m_leftStickHorizontalN75Percent = 1361;
    [SerializeField] private int m_leftStickVerticalP75Percent = 1362;
    [SerializeField] private int m_leftStickVerticalN75Percent = 1363;
    [SerializeField] private int m_rightStickHorizontalP75Percent = 1364;
    [SerializeField] private int m_rightStickHorizontalN75Percent = 1365;
    [SerializeField] private int m_rightStickVerticalP75Percent = 1366;
    [SerializeField] private int m_rightStickVerticalN75Percent = 1367;
    [SerializeField] private int m_leftStickHorizontalP50Percent = 1370;
    [SerializeField] private int m_leftStickHorizontalN50Percent = 1371;
    [SerializeField] private int m_leftStickVerticalP50Percent = 1372;
    [SerializeField] private int m_leftStickVerticalN50Percent = 1373;
    [SerializeField] private int m_rightStickHorizontalP50Percent = 1374;
    [SerializeField] private int m_rightStickHorizontalN50Percent = 1375;
    [SerializeField] private int m_rightStickVerticalP50Percent = 1376;
    [SerializeField] private int m_rightStickVerticalN50Percent = 1377;
    [SerializeField] private int m_leftStickHorizontalP25Percent = 1380;
    [SerializeField] private int m_leftStickHorizontalN25Percent = 1381;
    [SerializeField] private int m_leftStickVerticalP25Percent = 1382;
    [SerializeField] private int m_leftStickVerticalN25Percent = 1383;
    [SerializeField] private int m_rightStickHorizontalP25Percent = 1384;
    [SerializeField] private int m_rightStickHorizontalN25Percent = 1385;
    [SerializeField] private int m_rightStickVerticalP25Percent = 1386;
    [SerializeField] private int m_rightStickVerticalN25Percent = 1387;
    
    [SerializeField] private int m_releaseAllTouch = 1390;
    [SerializeField] private int m_releaseAllTouchButMenu = 1391;
    [SerializeField] private int m_clearTimedCommand = 1398;
    #endregion

    #region Button A Methods
    public void PressKeyA() => PressKey(m_buttonADown);
    public void ReleaseKeyA() => ReleaseKey(m_buttonADown);
    public void StrokeKeyA_NoDelay() => StrokeKeyNoDelay(m_buttonADown);
    public void StrokeKeyA_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_buttonADown, milliseconds);
    public void StrokeKeyA_ForSeconds(float seconds) => StrokeKeyForSeconds(m_buttonADown, seconds);
    public void PressKeyA_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_buttonADown, milliseconds);
    public void PressKeyA_InSeconds(float seconds) => PressKeyInSeconds(m_buttonADown, seconds);
    public void ReleaseKeyA_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_buttonADown, milliseconds);
    public void ReleaseKeyA_InSeconds(float seconds) => ReleaseKeyInSeconds(m_buttonADown, seconds);
    #endregion

    #region Button B Methods
    public void PressKeyB() => PressKey(m_buttonBRight);
    public void ReleaseKeyB() => ReleaseKey(m_buttonBRight);
    public void StrokeKeyB_NoDelay() => StrokeKeyNoDelay(m_buttonBRight);
    public void StrokeKeyB_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_buttonBRight, milliseconds);
    public void StrokeKeyB_ForSeconds(float seconds) => StrokeKeyForSeconds(m_buttonBRight, seconds);
    public void PressKeyB_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_buttonBRight, milliseconds);
    public void PressKeyB_InSeconds(float seconds) => PressKeyInSeconds(m_buttonBRight, seconds);
    public void ReleaseKeyB_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_buttonBRight, milliseconds);
    public void ReleaseKeyB_InSeconds(float seconds) => ReleaseKeyInSeconds(m_buttonBRight, seconds);
    #endregion

    #region Button X Methods
    public void PressKeyX() => PressKey(m_buttonXLeft);
    public void ReleaseKeyX() => ReleaseKey(m_buttonXLeft);
    public void StrokeKeyX_NoDelay() => StrokeKeyNoDelay(m_buttonXLeft);
    public void StrokeKeyX_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_buttonXLeft, milliseconds);
    public void StrokeKeyX_ForSeconds(float seconds) => StrokeKeyForSeconds(m_buttonXLeft, seconds);
    public void PressKeyX_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_buttonXLeft, milliseconds);
    public void PressKeyX_InSeconds(float seconds) => PressKeyInSeconds(m_buttonXLeft, seconds);
    public void ReleaseKeyX_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_buttonXLeft, milliseconds);
    public void ReleaseKeyX_InSeconds(float seconds) => ReleaseKeyInSeconds(m_buttonXLeft, seconds);
    #endregion

    #region Button Y Methods
    public void PressKeyY() => PressKey(m_buttonYUp);
    public void ReleaseKeyY() => ReleaseKey(m_buttonYUp);
    public void StrokeKeyY_NoDelay() => StrokeKeyNoDelay(m_buttonYUp);
    public void StrokeKeyY_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_buttonYUp, milliseconds);
    public void StrokeKeyY_ForSeconds(float seconds) => StrokeKeyForSeconds(m_buttonYUp, seconds);
    public void PressKeyY_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_buttonYUp, milliseconds);
    public void PressKeyY_InSeconds(float seconds) => PressKeyInSeconds(m_buttonYUp, seconds);
    public void ReleaseKeyY_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_buttonYUp, milliseconds);
    public void ReleaseKeyY_InSeconds(float seconds) => ReleaseKeyInSeconds(m_buttonYUp, seconds);
    #endregion
    #region Button Menu Left Methods
    public void PressKeyMenuLeft() => PressKey(m_buttonMenuLeft);
    public void ReleaseKeyMenuLeft() => ReleaseKey(m_buttonMenuLeft);
    public void StrokeKeyMenuLeft_NoDelay() => StrokeKeyNoDelay(m_buttonMenuLeft);
    public void StrokeKeyMenuLeft_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_buttonMenuLeft, milliseconds);
    public void StrokeKeyMenuLeft_ForSeconds(float seconds) => StrokeKeyForSeconds(m_buttonMenuLeft, seconds);
    public void PressKeyMenuLeft_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_buttonMenuLeft, milliseconds);
    public void PressKeyMenuLeft_InSeconds(float seconds) => PressKeyInSeconds(m_buttonMenuLeft, seconds);
    public void ReleaseKeyMenuLeft_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_buttonMenuLeft, milliseconds);
    public void ReleaseKeyMenuLeft_InSeconds(float seconds) => ReleaseKeyInSeconds(m_buttonMenuLeft, seconds);
    #endregion

    #region Button Menu Right Methods
    public void PressKeyMenuRight() => PressKey(m_buttonMenuRight);
    public void ReleaseKeyMenuRight() => ReleaseKey(m_buttonMenuRight);
    public void StrokeKeyMenuRight_NoDelay() => StrokeKeyNoDelay(m_buttonMenuRight);
    public void StrokeKeyMenuRight_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_buttonMenuRight, milliseconds);
    public void StrokeKeyMenuRight_ForSeconds(float seconds) => StrokeKeyForSeconds(m_buttonMenuRight, seconds);
    public void PressKeyMenuRight_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_buttonMenuRight, milliseconds);
    public void PressKeyMenuRight_InSeconds(float seconds) => PressKeyInSeconds(m_buttonMenuRight, seconds);
    public void ReleaseKeyMenuRight_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_buttonMenuRight, milliseconds);
    public void ReleaseKeyMenuRight_InSeconds(float seconds) => ReleaseKeyInSeconds(m_buttonMenuRight, seconds);
    #endregion

    #region Button Left Side Methods
    public void PressKeyLeftSide() => PressKey(m_buttonLeftSide);
    public void ReleaseKeyLeftSide() => ReleaseKey(m_buttonLeftSide);
    public void StrokeKeyLeftSide_NoDelay() => StrokeKeyNoDelay(m_buttonLeftSide);
    public void StrokeKeyLeftSide_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_buttonLeftSide, milliseconds);
    public void StrokeKeyLeftSide_ForSeconds(float seconds) => StrokeKeyForSeconds(m_buttonLeftSide, seconds);
    public void PressKeyLeftSide_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_buttonLeftSide, milliseconds);
    public void PressKeyLeftSide_InSeconds(float seconds) => PressKeyInSeconds(m_buttonLeftSide, seconds);
    public void ReleaseKeyLeftSide_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_buttonLeftSide, milliseconds);
    public void ReleaseKeyLeftSide_InSeconds(float seconds) => ReleaseKeyInSeconds(m_buttonLeftSide, seconds);
    #endregion

    #region Button Right Side Methods
    public void PressKeyRightSide() => PressKey(m_buttonRightSide);
    public void ReleaseKeyRightSide() => ReleaseKey(m_buttonRightSide);
    public void StrokeKeyRightSide_NoDelay() => StrokeKeyNoDelay(m_buttonRightSide);
    public void StrokeKeyRightSide_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_buttonRightSide, milliseconds);
    public void StrokeKeyRightSide_ForSeconds(float seconds) => StrokeKeyForSeconds(m_buttonRightSide, seconds);
    public void PressKeyRightSide_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_buttonRightSide, milliseconds);
    public void PressKeyRightSide_InSeconds(float seconds) => PressKeyInSeconds(m_buttonRightSide, seconds);
    public void ReleaseKeyRightSide_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_buttonRightSide, milliseconds);
    public void ReleaseKeyRightSide_InSeconds(float seconds) => ReleaseKeyInSeconds(m_buttonRightSide, seconds);
    #endregion

    
    #region Button Left Stick Methods
    public void PressKeyLeftStick() => PressKey(m_buttonLeftStick);
    public void ReleaseKeyLeftStick() => ReleaseKey(m_buttonLeftStick);
    public void StrokeKeyLeftStick_NoDelay() => StrokeKeyNoDelay(m_buttonLeftStick);
    public void StrokeKeyLeftStick_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_buttonLeftStick, milliseconds);
    public void StrokeKeyLeftStick_ForSeconds(float seconds) => StrokeKeyForSeconds(m_buttonLeftStick, seconds);
    public void PressKeyLeftStick_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_buttonLeftStick, milliseconds);
    public void PressKeyLeftStick_InSeconds(float seconds) => PressKeyInSeconds(m_buttonLeftStick, seconds);
    public void ReleaseKeyLeftStick_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_buttonLeftStick, milliseconds);
    public void ReleaseKeyLeftStick_InSeconds(float seconds) => ReleaseKeyInSeconds(m_buttonLeftStick, seconds);
    #endregion

    #region Button Right Stick Methods
    public void PressKeyRightStick() => PressKey(m_buttonRightStick);
    public void ReleaseKeyRightStick() => ReleaseKey(m_buttonRightStick);
    public void StrokeKeyRightStick_NoDelay() => StrokeKeyNoDelay(m_buttonRightStick);
    public void StrokeKeyRightStick_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_buttonRightStick, milliseconds);
    public void StrokeKeyRightStick_ForSeconds(float seconds) => StrokeKeyForSeconds(m_buttonRightStick, seconds);
    public void PressKeyRightStick_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_buttonRightStick, milliseconds);
    public void PressKeyRightStick_InSeconds(float seconds) => PressKeyInSeconds(m_buttonRightStick, seconds);
    public void ReleaseKeyRightStick_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_buttonRightStick, milliseconds);
    public void ReleaseKeyRightStick_InSeconds(float seconds) => ReleaseKeyInSeconds(m_buttonRightStick, seconds);
    #endregion

    #region Arrow Release Methods
    public void PressKeyArrowRelease() => PressKey(m_arrowRelease);
    public void ReleaseKeyArrowRelease() => ReleaseKey(m_arrowRelease);
    public void StrokeKeyArrowRelease_NoDelay() => StrokeKeyNoDelay(m_arrowRelease);
    public void StrokeKeyArrowRelease_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_arrowRelease, milliseconds);
    public void StrokeKeyArrowRelease_ForSeconds(float seconds) => StrokeKeyForSeconds(m_arrowRelease, seconds);
    public void PressKeyArrowRelease_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_arrowRelease, milliseconds);
    public void PressKeyArrowRelease_InSeconds(float seconds) => PressKeyInSeconds(m_arrowRelease, seconds);
    public void ReleaseKeyArrowRelease_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_arrowRelease, milliseconds);
    public void ReleaseKeyArrowRelease_InSeconds(float seconds) => ReleaseKeyInSeconds(m_arrowRelease, seconds);
    #endregion

    #region Arrow Up Methods
    public void PressKeyArrowUp() => PressKey(m_arrowUp);
    public void ReleaseKeyArrowUp() => ReleaseKey(m_arrowUp);
    public void StrokeKeyArrowUp_NoDelay() => StrokeKeyNoDelay(m_arrowUp);
    public void StrokeKeyArrowUp_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_arrowUp, milliseconds);
    public void StrokeKeyArrowUp_ForSeconds(float seconds) => StrokeKeyForSeconds(m_arrowUp, seconds);
    public void PressKeyArrowUp_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_arrowUp, milliseconds);
    public void PressKeyArrowUp_InSeconds(float seconds) => PressKeyInSeconds(m_arrowUp, seconds);
    public void ReleaseKeyArrowUp_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_arrowUp, milliseconds);
    public void ReleaseKeyArrowUp_InSeconds(float seconds) => ReleaseKeyInSeconds(m_arrowUp, seconds);
    #endregion

    #region Arrow Up Right Methods
    public void PressKeyArrowUpRight() => PressKey(m_arrowUpRight);
    public void ReleaseKeyArrowUpRight() => ReleaseKey(m_arrowUpRight);
    public void StrokeKeyArrowUpRight_NoDelay() => StrokeKeyNoDelay(m_arrowUpRight);
    public void StrokeKeyArrowUpRight_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_arrowUpRight, milliseconds);
    public void StrokeKeyArrowUpRight_ForSeconds(float seconds) => StrokeKeyForSeconds(m_arrowUpRight, seconds);
    public void PressKeyArrowUpRight_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_arrowUpRight, milliseconds);
    public void PressKeyArrowUpRight_InSeconds(float seconds) => PressKeyInSeconds(m_arrowUpRight, seconds);
    public void ReleaseKeyArrowUpRight_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_arrowUpRight, milliseconds);
    public void ReleaseKeyArrowUpRight_InSeconds(float seconds) => ReleaseKeyInSeconds(m_arrowUpRight, seconds);
    #endregion

    #region Arrow Right Methods
    public void PressKeyArrowRight() => PressKey(m_arrowRight);
    public void ReleaseKeyArrowRight() => ReleaseKey(m_arrowRight);
    public void StrokeKeyArrowRight_NoDelay() => StrokeKeyNoDelay(m_arrowRight);
    public void StrokeKeyArrowRight_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_arrowRight, milliseconds);
    public void StrokeKeyArrowRight_ForSeconds(float seconds) => StrokeKeyForSeconds(m_arrowRight, seconds);
    public void PressKeyArrowRight_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_arrowRight, milliseconds);
    public void PressKeyArrowRight_InSeconds(float seconds) => PressKeyInSeconds(m_arrowRight, seconds);
    public void ReleaseKeyArrowRight_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_arrowRight, milliseconds);
    public void ReleaseKeyArrowRight_InSeconds(float seconds) => ReleaseKeyInSeconds(m_arrowRight, seconds);
    #endregion

    #region Arrow Down Right Methods
    public void PressKeyArrowDownRight() => PressKey(m_arrowDownRight);
    public void ReleaseKeyArrowDownRight() => ReleaseKey(m_arrowDownRight);
    public void StrokeKeyArrowDownRight_NoDelay() => StrokeKeyNoDelay(m_arrowDownRight);
    public void StrokeKeyArrowDownRight_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_arrowDownRight, milliseconds);
    public void StrokeKeyArrowDownRight_ForSeconds(float seconds) => StrokeKeyForSeconds(m_arrowDownRight, seconds);
    public void PressKeyArrowDownRight_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_arrowDownRight, milliseconds);
    public void PressKeyArrowDownRight_InSeconds(float seconds) => PressKeyInSeconds(m_arrowDownRight, seconds);
    public void ReleaseKeyArrowDownRight_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_arrowDownRight, milliseconds);
    public void ReleaseKeyArrowDownRight_InSeconds(float seconds) => ReleaseKeyInSeconds(m_arrowDownRight, seconds);
    #endregion

    #region Arrow Down Methods
    public void PressKeyArrowDown() => PressKey(m_arrowDown);
    public void ReleaseKeyArrowDown() => ReleaseKey(m_arrowDown);
    public void StrokeKeyArrowDown_NoDelay() => StrokeKeyNoDelay(m_arrowDown);
    public void StrokeKeyArrowDown_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_arrowDown, milliseconds);
    public void StrokeKeyArrowDown_ForSeconds(float seconds) => StrokeKeyForSeconds(m_arrowDown, seconds);
    public void PressKeyArrowDown_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_arrowDown, milliseconds);
    public void PressKeyArrowDown_InSeconds(float seconds) => PressKeyInSeconds(m_arrowDown, seconds);
    public void ReleaseKeyArrowDown_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_arrowDown, milliseconds);
    public void ReleaseKeyArrowDown_InSeconds(float seconds) => ReleaseKeyInSeconds(m_arrowDown, seconds);
    #endregion

    #region Arrow Down Left Methods
    public void PressKeyArrowDownLeft() => PressKey(m_arrowDownLeft);
    public void ReleaseKeyArrowDownLeft() => ReleaseKey(m_arrowDownLeft);
    public void StrokeKeyArrowDownLeft_NoDelay() => StrokeKeyNoDelay(m_arrowDownLeft);
    public void StrokeKeyArrowDownLeft_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_arrowDownLeft, milliseconds);
    public void StrokeKeyArrowDownLeft_ForSeconds(float seconds) => StrokeKeyForSeconds(m_arrowDownLeft, seconds);
    public void PressKeyArrowDownLeft_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_arrowDownLeft, milliseconds);
    public void PressKeyArrowDownLeft_InSeconds(float seconds) => PressKeyInSeconds(m_arrowDownLeft, seconds);
    public void ReleaseKeyArrowDownLeft_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_arrowDownLeft, milliseconds);
    public void ReleaseKeyArrowDownLeft_InSeconds(float seconds) => ReleaseKeyInSeconds(m_arrowDownLeft, seconds);
    #endregion

    #region Arrow Left Methods
    public void PressKeyArrowLeft() => PressKey(m_arrowLeft);
    public void ReleaseKeyArrowLeft() => ReleaseKey(m_arrowLeft);
    public void StrokeKeyArrowLeft_NoDelay() => StrokeKeyNoDelay(m_arrowLeft);
    public void StrokeKeyArrowLeft_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_arrowLeft, milliseconds);
    public void StrokeKeyArrowLeft_ForSeconds(float seconds) => StrokeKeyForSeconds(m_arrowLeft, seconds);
    public void PressKeyArrowLeft_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_arrowLeft, milliseconds);
    public void PressKeyArrowLeft_InSeconds(float seconds) => PressKeyInSeconds(m_arrowLeft, seconds);
    public void ReleaseKeyArrowLeft_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_arrowLeft, milliseconds);
    public void ReleaseKeyArrowLeft_InSeconds(float seconds) => ReleaseKeyInSeconds(m_arrowLeft, seconds);
    #endregion

    #region Arrow Up Left Methods
    public void PressKeyArrowUpLeft() => PressKey(m_arrowUpLeft);
    public void ReleaseKeyArrowUpLeft() => ReleaseKey(m_arrowUpLeft);
    public void StrokeKeyArrowUpLeft_NoDelay() => StrokeKeyNoDelay(m_arrowUpLeft);
    public void StrokeKeyArrowUpLeft_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_arrowUpLeft, milliseconds);
    public void StrokeKeyArrowUpLeft_ForSeconds(float seconds) => StrokeKeyForSeconds(m_arrowUpLeft, seconds);
    public void PressKeyArrowUpLeft_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_arrowUpLeft, milliseconds);
    public void PressKeyArrowUpLeft_InSeconds(float seconds) => PressKeyInSeconds(m_arrowUpLeft, seconds);
    public void ReleaseKeyArrowUpLeft_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_arrowUpLeft, milliseconds);
    public void ReleaseKeyArrowUpLeft_InSeconds(float seconds) => ReleaseKeyInSeconds(m_arrowUpLeft, seconds);
    #endregion




    #region Xbox Home Button Methods
    public void PressKeyXboxHome() => PressKey(m_xboxHomeButton);
    public void ReleaseKeyXboxHome() => ReleaseKey(m_xboxHomeButton);
    public void StrokeKeyXboxHome_NoDelay() => StrokeKeyNoDelay(m_xboxHomeButton);
    public void StrokeKeyXboxHome_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_xboxHomeButton, milliseconds);
    public void StrokeKeyXboxHome_ForSeconds(float seconds) => StrokeKeyForSeconds(m_xboxHomeButton, seconds);
    public void PressKeyXboxHome_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_xboxHomeButton, milliseconds);
    public void PressKeyXboxHome_InSeconds(float seconds) => PressKeyInSeconds(m_xboxHomeButton, seconds);
    public void ReleaseKeyXboxHome_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_xboxHomeButton, milliseconds);
    public void ReleaseKeyXboxHome_InSeconds(float seconds) => ReleaseKeyInSeconds(m_xboxHomeButton, seconds);
    #endregion

    

    public void SetTriggerLeftValuePercent01(float percentValue)
    {
        if (percentValue <= 0f)
            PushIntegerAction(m_leftTrigger25Percent + 1000);
        else if (percentValue < 0.25f)
            PushIntegerAction(m_leftTrigger25Percent);
        else if (percentValue < 0.5f)
            PushIntegerAction(m_leftTrigger50Percent);
        else if (percentValue < 0.75f)
            PushIntegerAction(m_leftTrigger75Percent);
        else
            PushIntegerAction(m_leftTrigger100Percent);
    }

    public void SetTriggerRightValuePercent01(float percentValue)
    {
        if (percentValue <= 0f)
            PushIntegerAction(m_rightTrigger25Percent + 1000);
        else if (percentValue < 0.25f)
            PushIntegerAction(m_rightTrigger25Percent);
        else if (percentValue < 0.5f)
            PushIntegerAction(m_rightTrigger50Percent);
        else if (percentValue < 0.75f)
            PushIntegerAction(m_rightTrigger75Percent);
        else
            PushIntegerAction(m_rightTrigger100Percent);
    }

    public void SetLeftStickHorizontalValuePercent11(float percentValue)
    {
        if (percentValue == 0f)
            PushIntegerAction(m_leftStickNeutral);
        else if (percentValue <= -1f)
            PushIntegerAction(m_leftStickHorizontalN100Percent);
        else if (percentValue < -0.75f)
            PushIntegerAction(m_leftStickHorizontalN75Percent);
        else if (percentValue < -0.5f)
            PushIntegerAction(m_leftStickHorizontalN50Percent);
        else if (percentValue < -0.25f)
            PushIntegerAction(m_leftStickHorizontalN25Percent);
        else if (percentValue < 0.25f)
            PushIntegerAction(m_leftStickNeutral);
        else if (percentValue < 0.5f)
            PushIntegerAction(m_leftStickHorizontalP25Percent);
        else if (percentValue < 0.75f)
            PushIntegerAction(m_leftStickHorizontalP50Percent);
        else if (percentValue < 1f)
            PushIntegerAction(m_leftStickHorizontalP75Percent);
    }

    public void SetLeftStickVerticalValuePercent11(float percentValue)
    {
        if (percentValue == 0f)
            PushIntegerAction(m_leftStickNeutral);
        else if (percentValue <= -1f)
            PushIntegerAction(m_leftStickVerticalN100Percent);
        else if (percentValue < -0.75f)
            PushIntegerAction(m_leftStickVerticalN75Percent);
        else if (percentValue < -0.5f)
            PushIntegerAction(m_leftStickVerticalN50Percent);
        else if (percentValue < -0.25f)
            PushIntegerAction(m_leftStickVerticalN25Percent);
        else if (percentValue < 0.25f)
            PushIntegerAction(m_leftStickNeutral);
        else if (percentValue < 0.5f)
            PushIntegerAction(m_leftStickVerticalP25Percent);
        else if (percentValue < 0.75f)
            PushIntegerAction(m_leftStickVerticalP50Percent);
        else if (percentValue < 1f)
            PushIntegerAction(m_leftStickVerticalP75Percent);
    }

    public void SetRightStickHorizontalValuePercent11(float percentValue)
    {
        if (percentValue == 0f)
            PushIntegerAction(m_rightStickNeutral);
        else if (percentValue <= -1f)
            PushIntegerAction(m_rightStickHorizontalN100Percent);
        else if (percentValue < -0.75f)
            PushIntegerAction(m_rightStickHorizontalN75Percent);
        else if (percentValue < -0.5f)
            PushIntegerAction(m_rightStickHorizontalN50Percent);
        else if (percentValue < -0.25f)
            PushIntegerAction(m_rightStickHorizontalN25Percent);
        else if (percentValue < 0.25f)
            PushIntegerAction(m_rightStickNeutral);
        else if (percentValue < 0.5f)
            PushIntegerAction(m_rightStickHorizontalP25Percent);
        else if (percentValue < 0.75f)
            PushIntegerAction(m_rightStickHorizontalP50Percent);
        else if (percentValue < 1f)
            PushIntegerAction(m_rightStickHorizontalP75Percent);
    }

    public void SetRightStickVerticalValuePercent11(float percentValue)
    {
        if (percentValue == 0f)
            PushIntegerAction(m_rightStickNeutral);
        else if (percentValue <= -1f)
            PushIntegerAction(m_rightStickVerticalN100Percent);
        else if (percentValue < -0.75f)
            PushIntegerAction(m_rightStickVerticalN75Percent);
        else if (percentValue < -0.5f)
            PushIntegerAction(m_rightStickVerticalN50Percent);
        else if (percentValue < -0.25f)
            PushIntegerAction(m_rightStickVerticalN25Percent);
        else if (percentValue < 0.25f)
            PushIntegerAction(m_rightStickNeutral);
        else if (percentValue < 0.5f)
            PushIntegerAction(m_rightStickVerticalP25Percent);
        else if (percentValue < 0.75f)
            PushIntegerAction(m_rightStickVerticalP50Percent);
        else if (percentValue < 1f)
            PushIntegerAction(m_rightStickVerticalP75Percent);
    }


    public void SetJoystickLeftWithPercent11(float xPercent, float yPercent)
    {
        SetLeftStickHorizontalValuePercent11(xPercent);
        SetLeftStickVerticalValuePercent11(yPercent);
    }

    public void SetJoystickRightWithPercent11(float xPercent, float yPercent)
    {
        SetRightStickHorizontalValuePercent11(xPercent);
        SetRightStickVerticalValuePercent11(yPercent);
    }
    
    #region Start Recording Button Methods
    public void PressKeyStartRecording() => PressKey(m_startRecording);
    public void ReleaseKeyStartRecording() => ReleaseKey(m_startRecording);
    public void StrokeKeyStartRecording_NoDelay() => StrokeKeyNoDelay(m_startRecording);
    public void StrokeKeyStartRecording_ForMilliseconds(int milliseconds) => StrokeKeyForMilliseconds(m_startRecording, milliseconds);
    public void StrokeKeyStartRecording_ForSeconds(float seconds) => StrokeKeyForSeconds(m_startRecording, seconds);
    public void PressKeyStartRecording_InMilliseconds(int milliseconds) => PressKeyInMilliseconds(m_startRecording, milliseconds);
    public void PressKeyStartRecording_InSeconds(float seconds) => PressKeyInSeconds(m_startRecording, seconds);
    public void ReleaseKeyStartRecording_InMilliseconds(int milliseconds) => ReleaseKeyInMilliseconds(m_startRecording, milliseconds);
    public void ReleaseKeyStartRecording_InSeconds(float seconds) => ReleaseKeyInSeconds(m_startRecording, seconds);
#endregion
   

    public void PressLeftTrigger()=> PressKey(m_leftTrigger100Percent);
    public void ReleaseLeftTrigger() => ReleaseKey(m_leftTrigger100Percent);

    public void PressRightTrigger() => PressKey(m_rightTrigger100Percent);
    public void ReleaseRightTrigger() => ReleaseKey(m_rightTrigger100Percent);

    


}
