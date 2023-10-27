using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Point : MonoBehaviour
{    TextMeshProUGUI texts;
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        texts = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        texts.text = string.Format("{0:D4}",points);
    }
}
