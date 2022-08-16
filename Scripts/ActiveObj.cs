using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObj : MonoBehaviour
{
    public GameObject hideobj;
    private bool ison = true;
    public GameObject onmenu;


    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void ClickButt(){
        ison = !ison;
        hideobj.SetActive(ison);
        onmenu.SetActive(!ison);
    }
}
