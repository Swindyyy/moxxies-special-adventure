using UnityEngine;
using System.Collections;

public class Pointtomove : MonoBehaviour {

    public float speed = 1.5f;
    private float idle;
    private Vector3 target;
    Animator anim;

	// Use this for initialization
	void Start () {
        target = transform.position;
        anim = GetComponent<Animator>();
        idle = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            float rotation = transform.localScale.x;
            Debug.Log("Rotation: " + rotation);
            if(target.x > transform.position.x)
            {
                    transform.localRotation = Quaternion.Euler(0, 0, 0);
                    Debug.Log("Rotation after flip: " + transform.localRotation);
            }
            if (target.x < transform.position.x)
            {
                    transform.localRotation = Quaternion.Euler(0, 180, 0);
                    Debug.Log("Rotation after flip: " + transform.localRotation);
            }
            anim.SetBool("Moving", true);
            idle = 0;
        }
       

        if (transform.position != target)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
        else
        {
            idle += Time.deltaTime;
            anim.SetBool("Moving", false);
        }
        anim.SetFloat("IdleTime", idle);
    }
}
