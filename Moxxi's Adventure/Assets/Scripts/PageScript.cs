using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;

public class PageScript : MonoBehaviour {

    string pageName;
    int pageNum;

    // Use this for initialization
    void Start()
    {
        pageName = transform.name;
        pageName = Regex.Match(pageName, @"\d+").Value;
        pageNum = Int32.Parse(pageName);
        if(GameControl.control.GetPageFound(pageNum) ==  true)
        {
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            GameControl.control.SetPageFound(pageNum);
            Destroy(this.gameObject);
        }
    }
}
