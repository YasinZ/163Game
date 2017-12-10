using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenNext : MonoBehaviour {
    
    public GameObject [] next;
    public GameManager gm;
    private bool created = false;

	// Use this for initialization
	void Start () {
        gm = Object.FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball") && !created)
        {
            //Debug.Log("Before incremented: " + gm.numGenerated + " created: " + created + " object name: " + this.name);
            int randIndex = Random.Range(0, next.Length);
            GameObject nextRamp = Instantiate(next[randIndex]);
            nextRamp.transform.localPosition = new Vector3(0, -1.172f * gm.numGenerated, 2.759f * gm.numGenerated);
            gm.Increase();
            created = true;
            Destroy(this.transform.parent.gameObject, 15);
            //Debug.Log(gm.numGenerated);

        }
    }
}
