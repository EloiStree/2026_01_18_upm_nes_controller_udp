using UnityEngine;

public class NesMono_ExampleClickAllButtons : MonoBehaviour
{
    public NesMono_NesWithCode m_nes;


    [ContextMenu("Click On All Buttons")]
    public void ClickOnAllButtons()
    {
        m_nes.StrokeFastArrowLeft(100);
        m_nes.StrokeFastArrowRight(100);
        m_nes.StrokeFastArrowUp(100);
        m_nes.StrokeFastArrowDown(100);
        m_nes.StrokeFastButtonA(100);
        m_nes.StrokeFastButtonB(100);
        m_nes.StrokeFastMenuLeft(100);
        m_nes.StrokeFastMenuLeft(100);
    }
    [ContextMenu("Click On All Buttons With Delayer")]
    public void ClickOnAllButtonsWithDelayer()
    {
        int millisecondsCounter=0;
        int timeBetweenStrokes = 800;
        m_nes.PressKeyInMilliseconds(m_nes.m_intKeyArrowLeft, millisecondsCounter);
        millisecondsCounter += timeBetweenStrokes;
        m_nes.ReleaseKeyInMilliseconds(m_nes.m_intKeyArrowLeft, millisecondsCounter);
        millisecondsCounter += timeBetweenStrokes;
        m_nes.PressKeyInMilliseconds(m_nes.m_intKeyArrowRight, millisecondsCounter);
        millisecondsCounter += timeBetweenStrokes;
        m_nes.ReleaseKeyInMilliseconds(m_nes.m_intKeyArrowRight, millisecondsCounter);
        millisecondsCounter += timeBetweenStrokes;
        m_nes.PressKeyInMilliseconds(m_nes.m_intKeyArrowUp, millisecondsCounter);
        millisecondsCounter += timeBetweenStrokes;
        m_nes.ReleaseKeyInMilliseconds(m_nes.m_intKeyArrowUp, millisecondsCounter);
        millisecondsCounter += timeBetweenStrokes;
        m_nes.PressKeyInMilliseconds(m_nes.m_intKeyArrowDown, millisecondsCounter);
        millisecondsCounter += timeBetweenStrokes;
        m_nes.ReleaseKeyInMilliseconds(m_nes.m_intKeyArrowDown, millisecondsCounter);
        millisecondsCounter += timeBetweenStrokes;
        m_nes.PressKeyInMilliseconds(m_nes.m_intKeyButtonA, millisecondsCounter);
        millisecondsCounter += timeBetweenStrokes;
        m_nes.ReleaseKeyInMilliseconds(m_nes.m_intKeyButtonA, millisecondsCounter);
        millisecondsCounter += timeBetweenStrokes;
        m_nes.PressKeyInMilliseconds(m_nes.m_intKeyButtonB, millisecondsCounter);
        millisecondsCounter += timeBetweenStrokes;
        m_nes.ReleaseKeyInMilliseconds(m_nes.m_intKeyButtonB, millisecondsCounter);
        millisecondsCounter += timeBetweenStrokes;
        m_nes.PressKeyInMilliseconds(m_nes.m_intKeyMenuLeft, millisecondsCounter);
        millisecondsCounter += timeBetweenStrokes;
        m_nes.ReleaseKeyInMilliseconds(m_nes.m_intKeyMenuLeft, millisecondsCounter);
        millisecondsCounter += timeBetweenStrokes;
        m_nes.PressKeyInMilliseconds(m_nes.m_intKeyMenuRight, millisecondsCounter);
        millisecondsCounter += timeBetweenStrokes;
        m_nes.ReleaseKeyInMilliseconds(m_nes.m_intKeyMenuRight, millisecondsCounter);
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
