using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Windows.Forms;

public class Argement_Checker : MonoBehaviour
{


    //          IN order to fix system windows form compability change .net api compability level to .Net 4x    //in player settings



    // Start is called before the first frame update
    void Start()
    {
        Argument_PAsser();
        Argument_Finder();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Argument_PAsser()                   //Func to Enter Argument in Program using system.command arg
    {
        string args = "zxzxz";
        args = string.Join("\n", System.Environment.GetCommandLineArgs());
        var target = gameObject.GetComponent<Text>();
        target.text = args;
    }




    public void Argument_Finder()                    // Program to Find Desigre Argument in Provided Arguments
    {


        string[] args = System.Environment.GetCommandLineArgs();

       int compare_tag=0;                   //default 0 not found , 1 == found

        for (int i = 0; i < args.Length; i++)
        {
            if (string.Compare(args[i], "pass") == 0)
            {
                var target = gameObject.GetComponent<Text>();
                target.text = "obj Found";
                Debug.Log("Object Found");
                compare_tag = 1;

                //MessageBox.Show("argument passed");
            }
            else
            {
                var target = gameObject.GetComponent<Text>();
                target.text = "obj ! Found";
                Debug.Log("Object Not Found");
                //MessageBox.Show("Lauch from Launcher");
                //break;
            }

        }
        if (compare_tag==1)
        {
            MessageBox.Show("Argument passed");
        }
        else 
            if (compare_tag==0)
        {
            MessageBox.Show("Launch From Launcher");
        }
    }

        
}
