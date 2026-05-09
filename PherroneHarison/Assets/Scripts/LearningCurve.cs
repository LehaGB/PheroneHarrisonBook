using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 30;
    public int addedAge = 1;

    
    void Start()
    {
        ComputeAdge();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /// <summary>
    /// Сложение двух переменых.
    /// </summary>
    public void ComputeAdge()
    {
        Debug.Log(currentAge + addedAge);
    }
}
