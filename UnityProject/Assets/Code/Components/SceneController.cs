using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject;


public class SceneController : MonoBehaviour
{
    private Microwave wave;
    // Start is called before the first frame update
    void Start()
    {
        this.wave = new Microwave();
        
        Debug.Log(this.wave);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
