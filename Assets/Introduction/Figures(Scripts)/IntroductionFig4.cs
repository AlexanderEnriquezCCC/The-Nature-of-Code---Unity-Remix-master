using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionFig4 : MonoBehaviour
{
    //Helped by Charlie from IAM Lab and some cool guy name Jarell from one of my coding classes
    GameObject sphere;
    // Start is called before the first frame update
    //Interpreted I4 as there is a spread of a colors as esscentially a "splash"
    //Interpreted I5 as the obj has a origin position and can take steps of |0|thru|10| and origin changes every time to step with the changed val. (ex. org @ 0,0 can step to (-10to10,-10to10), new org is at 5,6, can step to (-5to15,-4to16)
    void Start()
    {
        
    }
    /*
    //FOR I4
    //Update is called once per frame
    void Update()
    {
        //To create a Gaussian distribution in Unity we can actually use Random.Range() on two separate Random.Ranges
        float num = Random.Range(Random.Range(-10, 10), Random.Range(-10, 10));
        float sd = 1;
        float mean = 4;

        float x = sd * (num + mean);

        float y = Random.Range(0, 5);
        float z = sd * (num + mean);

        //This creates a sphere GameObject
        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphereChangeColor();

        Destroy(sphere.GetComponent<SphereCollider>());

        //This sets our ink "sphere game objects" at the position of the Walker GameObject (walkerGO) at the current frame
        //to draw the path
        sphere.transform.position = new Vector3(x, y, 0);
    }

    void sphereChangeColor()
    {
        int redRandNum = Random.Range(0, 256);
        int greenRandNum = Random.Range(0, 256);
        int blueRandNum = Random.Range(0, 256);
        Color randColor = new Color(redRandNum, greenRandNum, blueRandNum, 0);

        sphere.GetComponent<MeshRenderer>().material.color = randColor;
    }
    */

    // Update is called once per frame
    void Update()
    {
        //To create a Gaussian distribution in Unity we can actually use Random.Range() on two separate Random.Ranges
        //need to get it to walk on the Z and X
        float num = Random.Range(Random.Range(-10, 10), Random.Range(-10, 10));
        float sd = 1;
        float mean = 4;

        float x = sd * (num + mean);

        //float y = Random.Range(0, 5);
        float z = Random.Range(-10, 10);
        mean = z;

        //This creates a sphere GameObject
        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        Destroy(sphere.GetComponent<SphereCollider>());

        //This sets our ink "sphere game objects" at the position of the Walker GameObject (walkerGO) at the current frame
        //to draw the path
        sphere.transform.position = new Vector3(x, 0F, z);
    }
}
 