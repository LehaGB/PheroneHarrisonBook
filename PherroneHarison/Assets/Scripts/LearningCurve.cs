using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    
    private int currentAge = 30;

    [Header("Varieble")]
    public int addedAge = 1;
    public float pi = 3.14f;
    public string firstName = "Harisson";
    public double money = 12.5d;
    public bool isAuthor = true;

    
    void Start()
    {
        ComputeAdge();
        Debug.LogFormat($"Varieble {addedAge} {pi} {firstName} {money}");
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
