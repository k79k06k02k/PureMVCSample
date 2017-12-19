using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour 
{
    private void Start () 
    {
        new ApplicationFacade(gameObject);  
	}
}
