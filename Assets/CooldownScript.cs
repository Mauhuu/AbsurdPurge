using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownScript : MonoBehaviour
{

    public GameObject img, shieldUse, shieldUnable;
    public float cooldownTime = 2;
    public float nextFireTime = 0;
    

    void Start()
    {
        shieldUnable.SetActive(false);
        shieldUse.SetActive(true);
        img.SetActive(false);
    }

    private void Update()
    {
        if (Time.time > nextFireTime)
        {
            if (Input.GetKeyDown(KeyCode.Space) && nextFireTime == 0)
            {
                img.SetActive(true);
                shieldUnable.SetActive(true);
                shieldUse.SetActive(false);
                nextFireTime = Time.deltaTime + cooldownTime;
                StartCoroutine(shieldDuration());
            }
            
        }

        if (nextFireTime > 0)
        {
            nextFireTime -= Time.deltaTime;

        }

        if (nextFireTime < 0)
        {

            nextFireTime = 0;
        }
        

    }

    IEnumerator shieldDuration()
    {
        yield return new WaitForSeconds(2);
        img.SetActive(false);
        yield return new WaitForSeconds(3);
        shieldUse.SetActive(true);
        shieldUnable.SetActive(false);
    }

}

    
