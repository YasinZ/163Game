using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenNext : MonoBehaviour {
    public GameObject next;
    public GameManager gm;
    private bool created = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball") && !created)
        {
            Instantiate(next);
            //next.transform.rotation = transform.rotation;
            next.transform.localPosition = new Vector3(0, -1.172f * gm.numGenerated, 2.759f * gm.numGenerated);
            gm.numGenerated++;
            created = true;
            Debug.Log(2.759f * gm.numGenerated);

        }
    }
}
