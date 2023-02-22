using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    private Button button;
    private void Start()
    {
        button= GetComponent<Button>();
        button.onClick.AddListener(SayMyName);
    }

    private void SayMyName()
    {
        Debug.Log("Bear");
        Debug.Log("Tomato Bear");

    }
}
