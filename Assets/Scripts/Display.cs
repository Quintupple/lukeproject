using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Display : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    string valueDisplay;

    // Update is called once per frame
    void Update()
    {
        textMesh.text = valueDisplay;
        valueDisplay = "Value: " + PlayerPrefs.GetInt("Explicit").ToString();
    }
}
