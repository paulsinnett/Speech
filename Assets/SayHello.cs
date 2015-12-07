using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class SayHello : MonoBehaviour
{
    public Text text;

    void OnMouseDown()
    {
        text.text = "Hello";
    }
}
