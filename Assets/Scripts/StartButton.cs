using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click(){
       SceneManager.LoadScene(1);
    }

}
