using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{

    public static GameControl control;
    public bool[] pages;
    public int numPages;
    public GameObject pagesCanvas;
    private int pagesFound;

    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(this);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {
        numPages = 5;
        pagesFound = 0;
        pages = new bool[numPages];
        for (int i = 0; i < numPages; i++)
        {
            pages[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if((pagesCanvas.activeSelf == false) &&  (currentScene.name != "Menu"))
        {
            pagesCanvas.SetActive(true);
        }
    }

    public bool GetPageFound(int num)
    {
        return pages[num-1];
    }

    public void SetPageFound(int num)
    {
        pages[num-1] = true;
        pagesFound += 1;
        if(pagesFound == 5)
        {
            StartCoroutine(EndScene());
        }
    }

    IEnumerator EndScene()
    {
        float fadeTime = GameObject.Find("_Manager").GetComponent<Fade>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene("End scene");
    }
}
