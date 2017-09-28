using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;
using System;
using UnityEngine.UI;

public class scrollImageChanger : MonoBehaviour {

    string imgName;
    int pageNum;
    public Sprite page;

	// Use this for initialization
	void Start () {
        imgName = transform.name;
        imgName = Regex.Match(imgName, @"\d+").Value;
        pageNum = Int32.Parse(imgName);
    }
	
	// Update is called once per frame
	void Update () {
        Image img = GetComponent<Image>();
	    if(GameControl.control.GetPageFound(pageNum) == true)
        {
            img.sprite = page;
        }
	}
}
