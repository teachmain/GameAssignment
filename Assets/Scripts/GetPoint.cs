using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class GetPoint : MonoBehaviour
{
    public float points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(points >= 20){
            SceneManager.LoadScene(3);
        }
    }
    public void AddPoint(float p){
        points += p;
        GameObject.Find("Pointer").GetComponent<Point>().points = (int)(points);
    }
}
