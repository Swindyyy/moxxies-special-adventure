using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PageChanger : MonoBehaviour {

    int currentPageNum;
    
    GameObject currentObj;

    [SerializeField]
    Sprite page1;
    [SerializeField]
    Sprite page2;
    [SerializeField]
    Sprite page3;
    [SerializeField]
    Sprite page4;
    [SerializeField]
    Sprite page5;
    [SerializeField]
    Image currentPage;
    [SerializeField]
    UIController uiC;


    // Use this for initialization
    void Start () {
        currentPageNum = 1;
	}
	
	public void SetPage(int mod)
    {
        currentPageNum += mod;
        if (currentPageNum == 1)
        {
            currentPage.sprite = page1;
            uiC.DisableBackButton();
        } else if (currentPageNum == 2)
        {
            currentPage.sprite = page2;
        } else if (currentPageNum == 3)
        {
            currentPage.sprite = page3;
        } else if (currentPageNum == 4)
        {
            currentPage.sprite = page4;
        } else if (currentPageNum == 5)
        {
            currentPage.sprite = page5;
            uiC.DisableNextButton();
        }
    }
}
