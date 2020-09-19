using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPelletBlink : MonoBehaviour
{
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(powerPelletFlash());
    }

    IEnumerator powerPelletFlash()
    {
        if (rend.enabled == true)
            rend.enabled = false;
        else
            rend.enabled = true;
        yield return new WaitForSeconds(2.0f);
    }
}
