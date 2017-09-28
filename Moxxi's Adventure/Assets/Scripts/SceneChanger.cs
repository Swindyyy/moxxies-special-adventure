using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

    public string direction;

    void Start()
    {
        
    }
		
	public void Change()
    {
        StartCoroutine(ChangeScene());
    }

   void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player") {
            StartCoroutine(ChangeScene());
        }
    }

    IEnumerator ChangeScene()
    {
        float fadeTime = GameObject.Find("_Manager").GetComponent<Fade>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(direction);
    }
}
