using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Dead : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider otherOBJ){
        print("Work!");
        if(otherOBJ.gameObject.name=="PlayBody"){
            print("dead!");
            dead();
        }
    }
    void dead(){
        SceneManager.LoadScene(2);
    }
}
