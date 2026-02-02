using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct IntCommandRelativeStep
{
    public int m_relativeDelayInMilliseconds;
    public int m_integerAction;
}

[System.Serializable]
public class IntCommandRelativeStepSequence
{
    public List<IntCommandRelativeStep> m_steps = new List<IntCommandRelativeStep>();

    public void ClearSteps()
    {
        m_steps.Clear();
    }
    public void DeleteStepAtIndex(int index)
    {
        if (index >= 0 && index < m_steps.Count)
            m_steps.RemoveAt(index);
    }
    
    public void AppendStepAtStart(IntCommandRelativeStep step)
    {
        m_steps.Insert(0, step);

    }
    public void AppendStepAtEnd(IntCommandRelativeStep step)
    {
        m_steps.Add(step);
    }
    public void OrderStepsByTime()
    {
        m_steps.Sort((a, b) => a.m_relativeDelayInMilliseconds.CompareTo(b.m_relativeDelayInMilliseconds));
    }
}

public class NesMono_IntCommandBuilder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
