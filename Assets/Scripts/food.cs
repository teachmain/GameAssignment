using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class food : MonoBehaviour
{
    public float point = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider OterOBJ){
        if(OterOBJ.gameObject.name == "PlayBody"){
           OterOBJ.gameObject.GetComponent<GetPoint>().AddPoint(point);
            Destroy(this.gameObject);
        }
        
    }
}
