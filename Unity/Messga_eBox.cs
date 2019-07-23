using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messga_eBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string args = "zxzxz";
        args = string.Join("\n", System.Environment.GetCommandLineArgs());
        var target = gameObject.GetComponent<Text>();
        target.text = args;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
