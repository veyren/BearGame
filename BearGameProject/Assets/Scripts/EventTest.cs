using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class EventTest : MonoBehaviour
{
    private UnityAction m_SomeListener;

    void Awake()
    {
        m_SomeListener = new UnityAction(SomeFunction);
    }

    void OnEnable()
    {
        EventManager.StartListening("test", m_SomeListener);
        EventManager.StartListening("Spawn", MyEventCallback);
        EventManager.StartListening("Destroy", SomeThirdFunction);
    }

    void OnDisable()
    {
        EventManager.StopListening("test", m_SomeListener);
        EventManager.StopListening("Spawn", MyEventCallback);
        EventManager.StopListening("Destroy", SomeThirdFunction);
    }

    void SomeFunction()
    {
        Debug.Log("Some Function was called!");
    }

    void MyEventCallback()
    {
        Debug.Log("Some Other Function was called!");
    }

    void SomeThirdFunction()
    {
        Debug.Log("Some Third Function was called!");
    }
}
