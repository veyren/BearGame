using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager sm_EventManager;

    public static GameManager Instance
    {
        get
        {
            if(!sm_EventManager)
            {
                FindObjectOfType<GameManager>();

                sm_EventManager = FindObjectOfType(typeof(GameManager)) as GameManager;

                if(!sm_EventManager)
                    Debug.LogError("There needs to be one active GameManager script on a GameObject in your scene.");
                else
                    sm_EventManager.Init();
            }

            return sm_EventManager;
        }
    }

    void Init()
    {
        // The function which is called once the beginning
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Debug.Log("The game has started");
    }

    public void EndGame()
    {
        Debug.Log("The game has ended");
    }
}
