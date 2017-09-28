using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public static UIController UIControl;

    PageChanger pc;

    [SerializeField]
    Image image;
    [SerializeField]
    Button next;
    [SerializeField]
    Button back;
    
	// Use this for initialization
	void Start () {
        pc = image.GetComponent<PageChanger>();
	}
	
    public void DisableBackButton()
    {
        back.interactable = false;
    }

    public void EnableBackButton()
    {
        back.interactable = true;
    }

    public void DisableNextButton()
    {
        next.interactable = false;
    }
    
    public void EnableNextButton()
    {
        next.interactable = true;
    }

    public void NextPage()
    {
        pc.SetPage(1);
        if(back.interactable == false)
        {
            EnableBackButton();
        }
    }

    public void PreviousPage()
    {
        pc.SetPage(-1);
        if(next.interactable == false)
        {
            next.interactable = true;
        }
    }

}
