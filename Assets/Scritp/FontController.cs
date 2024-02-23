using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FontController : MonoBehaviour
{
    public Font newFont;

    void Start()
    {
        Text textComponent = GetComponent<Text>();
        if (textComponent != null)
        {
            textComponent.font = newFont;
        }
    }
}

