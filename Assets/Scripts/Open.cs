using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Open : MonoBehaviour
{
    bool IsPlayer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && IsPlayer){
            GetComponent<Animator>().SetBool("Op",true);
            print("yes");
        }
    }
    private void OnTriggerEnter(Collider Other){
        print("EEEEE");
        if(Other.gameObject.name=="PlayBody"){
            IsPlayer = true;
        }
    }
    private void OnTriggerExit(Collider Other){
        if(Other.gameObject.name=="PlayBody"){
            IsPlayer = false;
        }
    }
}
